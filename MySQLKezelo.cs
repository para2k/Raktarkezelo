using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static ProOktatasVizsgaFeladat.Form1;

namespace ProOktatasVizsgaFeladat
{
    public static class MySQLKezelo
    {
        static string kapcsolatiString = "server=localhost;uid=root;pwd=;";
        static MySqlConnection kapcsolat = new MySqlConnection(kapcsolatiString);


        /// <summary>
        /// Program indításakor megvizsgáljuk, hogy létezik-e már a megadott adatbázis, ha igen, feltöltjük
        /// a fő formunk csoportosító elemét a fő táblánk elemeivel. 
        /// </summary>
        /// <returns> Ha már létezik, akkor igazzal tér vissza, ellenkező esetben hamis. </returns>
        public static bool Letezike_Az_Adatbazis()
        {
            bool letezik = false;

            try
            {
                kapcsolat.Open();

                string query = $"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'raktardb'";
                using (MySqlCommand cmd = new MySqlCommand(query, kapcsolat))
                {
                    object eredmeny = cmd.ExecuteScalar();
                    letezik = (eredmeny != null && eredmeny.ToString().Equals("raktardb", StringComparison.OrdinalIgnoreCase));
                }

                if (letezik)
                {
                    kapcsolat.ChangeDatabase("raktardb");

                    List<string> tablak = new List<string> { "alkatreszek", "raktar1", "raktar2", "raktar3", "raktar4" };
                    foreach (string tabla in tablak)
                    {
                        string tablaQuery = $"SHOW TABLES LIKE '{tabla}'";
                        using (MySqlCommand tablaCmd = new MySqlCommand(tablaQuery, kapcsolat))
                        {
                            object eredmeny = tablaCmd.ExecuteScalar();
                            letezik &= (eredmeny != null && eredmeny.ToString().Equals(tabla, StringComparison.OrdinalIgnoreCase));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba az adatbázis előzetes vizsgálata közben! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }

            return letezik;
        }


        /// <summary>
        /// Létrehozza az adatbázist és a táblákat hozzá, ez a programunk alapja.
        /// </summary>
        public static void Adatbazis_Es_Tablak_Letrehozasa()
        {
            try
            {
                kapcsolat.Open();

                string ujDatabaseQuery = "CREATE DATABASE IF NOT EXISTS `raktardb`";

                MySqlCommand cmd = new MySqlCommand(ujDatabaseQuery, kapcsolat);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Adatbázis sikeresen létrehozva! Váltás az aktuális adatbázisra.", "Sikeres", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kapcsolat.ChangeDatabase("raktardb");

                string[] ujTablakQueryk = TablaQuerykBeolvasasa();

                foreach (string query in ujTablakQueryk)
                {
                    MySqlCommand tablakLetrehozasa = new MySqlCommand(query, kapcsolat);
                    tablakLetrehozasa.ExecuteNonQuery();
                }

                MessageBox.Show("Táblák sikeresen létrehozva!", "Sikeres", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Adatbázis létrehozása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }
        }

        #region ALKATRÉSZ QUERYK

        /// <summary>
        /// Beolvassa az összes alkatrészt a főtáblánkból.
        /// </summary>
        /// <returns>A komplett alkatrész listával tér vissza.</returns>
        public static List<Alkatresz> Alkatreszek_Beolvasasa()
        {
            List<Alkatresz> alkatreszek = new List<Alkatresz>();

            try
            {
                kapcsolat.Open();
                string query = $"SELECT * FROM `alkatreszek`";
                MySqlCommand cmd = new MySqlCommand(query, kapcsolat);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    Alkatreszek_Beolvasasa_Listaba(dr, alkatreszek);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alkatrészek beolvasása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }

            return alkatreszek;
        }


        /// <summary>
        /// Segítő funkció az összes alkatrész beolvasásához.
        /// </summary>
        /// <param name="dr"> A társított MySqlDataReader az adatbázisból beolvasáshoz. </param>
        /// <param name="alkatreszLista"> A fő funkció üres listája, amit feltöltünk alkatrészekkel. </param>
        /// <returns> Egy komplett, alkatrész specifikus, szétválogatott listával tér vissza.</returns>
        static List<Alkatresz> Alkatreszek_Beolvasasa_Listaba(MySqlDataReader dr, List<Alkatresz> alkatreszLista)
        {
            List<Alkatresz> alkatreszek = alkatreszLista;

            try
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    AlkatreszTipus alkatreszTipus = (AlkatreszTipus)Enum.Parse(typeof(AlkatreszTipus), dr.GetString(1));
                    string gyarto = dr.GetString(2);
                    string tipus = dr.GetString(3);
                    int ar = dr.GetInt32(4);
                    int garancia = dr.GetInt32(5);

                    switch (alkatreszTipus)
                    {
                        case AlkatreszTipus.Alaplap:
                            Alkatresz alk = new Alaplap((ProcesszorFoglalat)Enum.Parse(typeof(ProcesszorFoglalat), dr.GetString(6)),
                            (Chipset)Enum.Parse(typeof(Chipset), dr.GetString(7)), Int_To_Bool(dr.GetInt32(8)), id, gyarto, tipus, ar, garancia);
                            alkatreszek.Add(alk);
                            break;
                        case AlkatreszTipus.Memoria:
                            Memoria mem = new Memoria(dr.GetByte(9), dr.GetUInt32(10), (Generacio)Enum.Parse(typeof(Generacio), dr.GetString(11)),
                                dr.GetByte(12), id, gyarto, tipus, ar, garancia);
                            alkatreszek.Add(mem);
                            break;
                        case AlkatreszTipus.Tapegyseg:
                            Tapegyseg tap = new Tapegyseg(dr.GetUInt32(22), (Minoseg)Enum.Parse(typeof(Minoseg), dr.GetString(23)), id, gyarto, tipus, ar, garancia);
                            alkatreszek.Add(tap);
                            break;
                        case AlkatreszTipus.Videokartya:
                            Videokartya vid = new Videokartya(dr.GetByte(13), dr.GetUInt32(14), (RamTipus)Enum.Parse(typeof(RamTipus), dr.GetString(15)),
                            dr.GetUInt32(16), Int_To_Bool(dr.GetInt32(17)), id, gyarto, tipus, ar, garancia);
                            alkatreszek.Add(vid);
                            break;
                        case AlkatreszTipus.Processzor:
                            Processzor proc = new Processzor((Tokozas)Enum.Parse(typeof(Tokozas), dr.GetString(18)), dr.GetUInt32(19), dr.GetUInt32(20),
                            dr.GetByte(21), id, gyarto, tipus, ar, garancia);
                            alkatreszek.Add(proc);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Az alkatrészek listába olvasása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return alkatreszek;
        }


        /// <summary>
        /// Létrehozunk egy alkatrészt az adatbázisban.
        /// </summary>
        /// <param name="ujalkatresz"> A már helyileg elkészült alkatrész. </param>
        public static void Alkatresz_Letrehozas(Alkatresz ujalkatresz)
        {
            string oszlopok = "(ID, AlkatreszTipus, Gyarto, Tipus, Ar, Garancia, ";
            string values = "VALUES (@id, @AlkatreszTipus, @Gyarto, @Tipus, @Ar, @Garancia, ";
            try
            {
                kapcsolat.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = kapcsolat;
                    cmd.Parameters.AddWithValue("@id", ujalkatresz.Id);
                    cmd.Parameters.AddWithValue("@Gyarto", ujalkatresz.Gyarto);
                    cmd.Parameters.AddWithValue("@Tipus", ujalkatresz.Tipus);
                    cmd.Parameters.AddWithValue("@Ar", ujalkatresz.Ar);
                    cmd.Parameters.AddWithValue("@Garancia", ujalkatresz.Garancia);

                    if (ujalkatresz is Alaplap alaplap)
                    {
                        oszlopok += "Foglalat, Chipset, RgbVilagitasVane) ";
                        values += "@Foglalat, @Chipset, @RgbVilagitasVane)";
                        cmd.Parameters.AddWithValue("@AlkatreszTipus", AlkatreszTipus.Alaplap.ToString());
                        cmd.Parameters.AddWithValue("@Foglalat", alaplap.Foglalat.ToString());
                        cmd.Parameters.AddWithValue("@Chipset", alaplap.Chipset.ToString());
                        cmd.Parameters.AddWithValue("@RgbVilagitasVane", alaplap.RgbVilagitasVane);
                    }
                    else if (ujalkatresz is Memoria memoria)
                    {
                        oszlopok += "Merete, Orajele, Generacio, Idozites) ";
                        values += "@Merete, @Orajele, @Generacio, @Idozites)";
                        cmd.Parameters.AddWithValue("@AlkatreszTipus", AlkatreszTipus.Memoria.ToString());
                        cmd.Parameters.AddWithValue("@Merete", memoria.Merete);
                        cmd.Parameters.AddWithValue("@Orajele", memoria.Orajele);
                        cmd.Parameters.AddWithValue("@Generacio", memoria.Generacio.ToString());
                        cmd.Parameters.AddWithValue("@Idozites", memoria.Idozites);
                    }
                    else if (ujalkatresz is Videokartya videokartya)
                    {
                        oszlopok += "MemoriaMerete, MagOrajele, RamTipus, Fogyasztas, RaytracingTamogatasVane) ";
                        values += "@MemoriaMerete, @MagOrajele, @RamTipus, @Fogyasztas, @RaytracingTamogatasVane)";
                        cmd.Parameters.AddWithValue("@AlkatreszTipus", AlkatreszTipus.Videokartya.ToString());
                        cmd.Parameters.AddWithValue("@MemoriaMerete", videokartya.MemoriaMerete);
                        cmd.Parameters.AddWithValue("@MagOrajele", videokartya.MagOrajel);
                        cmd.Parameters.AddWithValue("@RamTipus", videokartya.RamTipus.ToString());
                        cmd.Parameters.AddWithValue("@Fogyasztas", videokartya.Fogyasztas);
                        cmd.Parameters.AddWithValue("@RaytracingTamogatasVane", videokartya.RaytracingTamogatasVane);
                    }
                    else if (ujalkatresz is Processzor processzor)
                    {
                        oszlopok += "Tokozas, ProcesszorOrajele, L3CacheMerete, Magszam) ";
                        values += "@Tokozas, @Orajele, @L3CacheMerete, @Magszam)";
                        cmd.Parameters.AddWithValue("@AlkatreszTipus", AlkatreszTipus.Processzor.ToString());
                        cmd.Parameters.AddWithValue("@Tokozas", processzor.Tokozas.ToString());
                        cmd.Parameters.AddWithValue("@Orajele", processzor.Orajele);
                        cmd.Parameters.AddWithValue("@L3CacheMerete", processzor.L3CacheMerete);
                        cmd.Parameters.AddWithValue("@Magszam", processzor.Magszam);
                    }
                    else if (ujalkatresz is Tapegyseg tapegyseg)
                    {
                        oszlopok += "Teljesitmeny, Minoseg) ";
                        values += "@Teljesitmeny, @Minoseg)";
                        cmd.Parameters.AddWithValue("@AlkatreszTipus", AlkatreszTipus.Tapegyseg.ToString());
                        cmd.Parameters.AddWithValue("@Teljesitmeny", tapegyseg.Teljesitmeny);
                        cmd.Parameters.AddWithValue("@Minoseg", tapegyseg.Minoseg.ToString());
                    }
                    cmd.CommandText = "INSERT INTO `alkatreszek` " + oszlopok + values;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az alkatrész létrehozása során!" + ex.Message, "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }
        }


        /// <summary>
        /// Vizsgálati funkció a CSV fájl betöltéséhez, gátolja az alkatrész duplikáció létrehozását.
        /// </summary>
        /// <param name="alkatresz"> A helyileg létrehozott alkatrész, amit vizsgálnunk kell. </param>
        /// <returns></returns>
        public static bool Letezik_Az_Alkatresz(Alkatresz alkatresz)
        {
            int vane = 0;
            try
            {
                kapcsolat.Open();

                string query = "SELECT COUNT(*) FROM `alkatreszek` WHERE `Gyarto` = @gyarto AND `Tipus` = @tipus AND " +
                    "`Ar` = @ar AND `Garancia` = @garancia AND `AlkatreszTipus` = @alkatreszTipus;";

                using (MySqlCommand cmd = new MySqlCommand(query, kapcsolat))
                {
                    cmd.Parameters.AddWithValue("@gyarto", alkatresz.Gyarto);
                    cmd.Parameters.AddWithValue("@tipus", alkatresz.Tipus);
                    cmd.Parameters.AddWithValue("@ar", alkatresz.Ar);
                    cmd.Parameters.AddWithValue("@garancia", alkatresz.Garancia);

                    AlkatreszTipus tipus = (AlkatreszTipus)Enum.Parse(typeof(AlkatreszTipus), alkatresz.GetType().Name);

                    cmd.Parameters.AddWithValue("@alkatreszTipus", tipus.ToString());

                    vane = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen alkatrész duplikáció vizsgálat! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }

            return vane > 0;
        }


        /// <summary>
        /// A kiválasztott CSV fájlból beolvassuk az alkatrészt.
        /// </summary>
        /// <param name="fajlHelye"> A CSV kiválasztott helye, ahonnan be szeretnénk olvasni a fájlt. </param>
        /// <returns> A kész alkatrésszel tér vissza, ha nem üres a CSV. </returns>
        /// <exception cref="InvalidOperationException"> Ha nem ismeri fel az alkatrész típusát. </exception>
        public static Alkatresz Alkatresz_Beolvasasa_CSVbol(string fajlHelye)
        {
            Alkatresz aktualisAlkatresz = null;

            try
            {
                using (StreamReader sr = new StreamReader(fajlHelye))
                {
                    string sor = sr.ReadLine();

                    if (sor != null)
                    {
                        string[] adatok = sor.Split(',');
                        string gyarto = adatok[0];
                        string tipus = adatok[1];
                        int ar = Convert.ToInt32(adatok[2]);
                        int garancia = Convert.ToInt32(adatok[3]);
                        string alkatreszTipus = adatok[4];

                        AlkatreszTipus milyenAlkatresz = (AlkatreszTipus)Enum.Parse(typeof(AlkatreszTipus), alkatreszTipus);

                        switch (milyenAlkatresz)
                        {
                            case AlkatreszTipus.Alaplap:
                                aktualisAlkatresz = new Alaplap(
                                    (ProcesszorFoglalat)Enum.Parse(typeof(ProcesszorFoglalat), adatok[5]),
                                    (Chipset)Enum.Parse(typeof(Chipset), adatok[6]),
                                    Convert.ToBoolean(adatok[7]), 0, gyarto, tipus, ar, garancia);
                                break;

                            case AlkatreszTipus.Memoria:
                                aktualisAlkatresz = new Memoria(
                                    Convert.ToByte(adatok[5]),
                                    Convert.ToUInt32(adatok[6]),
                                    (Generacio)Enum.Parse(typeof(Generacio), adatok[7]),
                                    Convert.ToByte(adatok[8]), 0, gyarto, tipus, ar, garancia);
                                break;

                            case AlkatreszTipus.Processzor:
                                aktualisAlkatresz = new Processzor(
                                    (Tokozas)Enum.Parse(typeof(Tokozas), adatok[5]),
                                    Convert.ToUInt32(adatok[6]),
                                    Convert.ToUInt32(adatok[7]),
                                    Convert.ToByte(adatok[8]), 0, gyarto, tipus, ar, garancia);
                                break;

                            case AlkatreszTipus.Videokartya:
                                aktualisAlkatresz = new Videokartya(
                                    Convert.ToByte(adatok[5]),
                                    Convert.ToUInt32(adatok[6]),
                                    (RamTipus)Enum.Parse(typeof(RamTipus), adatok[7]),
                                    Convert.ToUInt32(adatok[8]),
                                    Convert.ToBoolean(adatok[9]),
                                    0, gyarto, tipus, ar, garancia);
                                break;

                            case AlkatreszTipus.Tapegyseg:
                                aktualisAlkatresz = new Tapegyseg(
                                    Convert.ToUInt32(adatok[5]),
                                    (Minoseg)Enum.Parse(typeof(Minoseg), adatok[6]),
                                    0, gyarto, tipus, ar, garancia);
                                break;

                            default:
                                throw new InvalidOperationException("Ismeretlen alkatrész típus!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A fájl nem tartalmaz adatokat!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az alkatrész beolvasása során!" + ex.Message, "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aktualisAlkatresz;
        }


        /// <summary>
        /// Módosítjuk az alkatrészt az adatbázisban.
        /// </summary>
        /// <param name="modositando"> A módosítani kívánt alkatrész. </param>
        public static void Alkatresz_Modositas(Alkatresz modositando)
        {
            string kiegeszites = string.Empty;
            try
            {
                kapcsolat.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = kapcsolat;
                    cmd.Parameters.AddWithValue("@id", modositando.Id);
                    cmd.Parameters.AddWithValue("@Gyarto", modositando.Gyarto);
                    cmd.Parameters.AddWithValue("@Tipus", modositando.Tipus);
                    cmd.Parameters.AddWithValue("@Ar", modositando.Ar);
                    cmd.Parameters.AddWithValue("@Garancia", modositando.Garancia);

                    if (modositando is Alaplap alaplap)
                    {
                        kiegeszites += "Foglalat=@Foglalat, Chipset=@Chipset, RgbVilagitasVane=@RgbVilagitasVane";
                        cmd.Parameters.AddWithValue("@Foglalat", alaplap.Foglalat.ToString());
                        cmd.Parameters.AddWithValue("@Chipset", alaplap.Chipset.ToString());
                        cmd.Parameters.AddWithValue("@RgbVilagitasVane", alaplap.RgbVilagitasVane);
                    }
                    else if (modositando is Memoria memoria)
                    {
                        kiegeszites += "Merete=@Merete, Orajele=@Orajele, Generacio=@Generacio, Idozites=@Idozites";
                        cmd.Parameters.AddWithValue("@Merete", memoria.Merete);
                        cmd.Parameters.AddWithValue("@Orajele", memoria.Orajele);
                        cmd.Parameters.AddWithValue("@Generacio", memoria.Generacio.ToString());
                        cmd.Parameters.AddWithValue("@Idozites", memoria.Idozites);
                    }
                    else if (modositando is Videokartya videokartya)
                    {
                        kiegeszites += "MemoriaMerete=@MemoriaMerete, MagOrajele=@MagOrajele, RamTipus=@RamTipus, Fogyasztas=@Fogyasztas, RaytracingTamogatasVane=@rtvane";
                        cmd.Parameters.AddWithValue("@MemoriaMerete", videokartya.MemoriaMerete);
                        cmd.Parameters.AddWithValue("@MagOrajele", videokartya.MagOrajel);
                        cmd.Parameters.AddWithValue("@RamTipus", videokartya.RamTipus.ToString());
                        cmd.Parameters.AddWithValue("@Fogyasztas", videokartya.Fogyasztas);
                        cmd.Parameters.AddWithValue("@rtvane", videokartya.RaytracingTamogatasVane);
                    }
                    else if (modositando is Processzor processzor)
                    {
                        kiegeszites += "Tokozas=@Tokozas, ProcesszorOrajele=@Orajele, L3CacheMerete=@L3CacheMerete, Magszam=@Magszam";
                        cmd.Parameters.AddWithValue("@Tokozas", processzor.Tokozas.ToString());
                        cmd.Parameters.AddWithValue("@Orajele", processzor.Orajele);
                        cmd.Parameters.AddWithValue("@L3CacheMerete", processzor.L3CacheMerete);
                        cmd.Parameters.AddWithValue("@Magszam", processzor.Magszam);
                    }
                    else if (modositando is Tapegyseg tapegyseg)
                    {
                        kiegeszites += "Teljesitmeny=@Teljesitmeny, Minoseg=@Minoseg";
                        cmd.Parameters.AddWithValue("@Teljesitmeny", tapegyseg.Teljesitmeny);
                        cmd.Parameters.AddWithValue("@Minoseg", tapegyseg.Minoseg.ToString());
                    }
                    cmd.CommandText = "UPDATE `alkatreszek` SET Gyarto=@Gyarto, Tipus=@Tipus, Ar=@Ar, Garancia=@Garancia, " + kiegeszites + " WHERE ID=@id";
                    cmd.ExecuteNonQuery();
                }
                kapcsolat.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az alkatrész módosítása során!" + ex.Message, "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }
        }

        /// <summary>
        /// Töröljük a kiválasztott alkatrészt az adatbázisból.
        /// </summary>
        /// <param name="torlendo"> A törölni kívánt alkatrész. </param>
        public static void Alkatresz_Torles_Folistabol(Alkatresz torlendo)
        {
            try
            {
                kapcsolat.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = kapcsolat;
                    cmd.CommandText = "DELETE FROM `alkatreszek` WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", torlendo.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az alkatrész törlése során!" + ex.Message, "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }
        }

        #endregion

        #region RAKTÁR QUERYK

        /// <summary>
        /// A kiválasztott raktár elemeit olvassuk ki.
        /// </summary>
        /// <param name="raktarSzam"> Az aktuális raktár, amiből ki szeretnénk olvasni az alkatrészeket. </param>
        /// <returns> A paraméterként megadott raktár listájával tér vissza. </returns>
        public static List<Alkatresz> Alkatreszek_Beolvasasa_Raktarbol(int raktarSzam)
        {
            List<Alkatresz> lista = new List<Alkatresz>();
            try
            {
                kapcsolat.Open();

                string query = $"SELECT a. * FROM `raktar{raktarSzam}` r JOIN `alkatreszek` a ON r.ID = a.ID";
                MySqlCommand cmd = new MySqlCommand(query, kapcsolat);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    Alkatreszek_Beolvasasa_Listaba(dr, lista);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alkatrészek beolvasása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }

            return lista;
        }


        /// <summary>
        /// A kivákasztott raktár alkatrészeit kezeli.
        /// </summary>
        /// <param name="alkatreszID"> A módosítani, vagy törölni kívánt alkatrész azonosítója. </param>
        /// <param name="raktarSzama"> A kiválasztott raktár száma. </param>
        /// <param name="mennyiseg"> A módosítási mennyiség, amennyivel növelni, vagy csökkenteni szeretnénk a darabszámot. </param>
        /// <param name="modositasDatuma"> A módosítás aktuális dátuma. </param>
        /// <param name="torlese"> Törlés vizsgáló, ha igaz, a mennyiség módosító negatív értékű lesz. </param>
        public static void Alkatresz_Raktarkezeles(int alkatreszID, int raktarSzama, int mennyiseg, DateTime modositasDatuma, bool torlese = false)
        {
            try
            {
                kapcsolat.Open();

                string melyikRaktar = $"`raktar{raktarSzama}`";
                string query = $"SELECT Mennyiseg FROM {melyikRaktar} WHERE ID=@id";
                MySqlCommand cmd = new MySqlCommand(query, kapcsolat);
                cmd.Parameters.AddWithValue("@id", alkatreszID);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (!torlese)
                {
                    if (count > 0)
                    {
                        string updateQuery = $"UPDATE {melyikRaktar} SET Mennyiseg=Mennyiseg+@mennyiseg, Modositva=@modositva WHERE ID=@id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, kapcsolat);
                        updateCmd.Parameters.AddWithValue("@id", alkatreszID);
                        updateCmd.Parameters.AddWithValue("@mennyiseg", mennyiseg);
                        updateCmd.Parameters.AddWithValue("@modositva", modositasDatuma);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string beillesztQuery = $"INSERT INTO {melyikRaktar} (ID, Mennyiseg, Modositva) VALUES (@id, @mennyiseg, @modositva)";
                        MySqlCommand beillesztCmd = new MySqlCommand(beillesztQuery, kapcsolat);
                        beillesztCmd.Parameters.AddWithValue("@id", alkatreszID);
                        beillesztCmd.Parameters.AddWithValue("@mennyiseg", mennyiseg);
                        beillesztCmd.Parameters.AddWithValue("@modositva", modositasDatuma);
                        beillesztCmd.ExecuteNonQuery();
                    }

                    //LOG
                    LogRaktarMozgas(alkatreszID, raktarSzama, mennyiseg, false, modositasDatuma);
                }
                else
                {
                    if (count > 0)
                    {
                        if (mennyiseg < count)
                        {
                            string updateQuery = $"UPDATE {melyikRaktar} SET Mennyiseg=Mennyiseg-@mennyiseg, Modositva=@modositva WHERE ID=@id";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, kapcsolat);
                            updateCmd.Parameters.AddWithValue("@id", alkatreszID);
                            updateCmd.Parameters.AddWithValue("@mennyiseg", mennyiseg);
                            updateCmd.Parameters.AddWithValue("@modositva", modositasDatuma);
                            updateCmd.ExecuteNonQuery();
                        }
                        else if (mennyiseg == count)
                        {
                            string torlesQuery = $"DELETE FROM {melyikRaktar} WHERE ID=@id";
                            MySqlCommand torlesCmd = new MySqlCommand(torlesQuery, kapcsolat);
                            torlesCmd.Parameters.AddWithValue("@id", alkatreszID);
                            torlesCmd.ExecuteNonQuery();
                        }

                        //LOG
                        LogRaktarMozgas(alkatreszID, raktarSzama, mennyiseg, true, modositasDatuma);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az alkatrész raktárba rakása során!" + ex.Message, "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }
        }


        /// <summary>
        /// A kiválasztott raktárból beolvassuk a keresett alkatrész mennyiségét.
        /// </summary>
        /// <param name="alkatreszID"> A keresett alkatrész azonosítója. </param>
        /// <param name="raktarSzama"> Az aktuális raktár száma. </param>
        /// <returns></returns>
        public static int Alkatresz_Mennyiseg_Lekerese_Raktarbol(int alkatreszID, int raktarSzama)
        {
            int mennyiseg = 0;

            try
            {
                kapcsolat.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT Mennyiseg FROM `raktar{raktarSzama}` WHERE ID= {alkatreszID}", kapcsolat);
                object eredmeny = cmd.ExecuteScalar();
                if (eredmeny != null)
                {
                    mennyiseg = Convert.ToInt32(eredmeny);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a mennyiség lekérése során!" + ex.Message, "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }

            return mennyiseg;
        }


        /// <summary>
        /// A kiválasztott raktár összes alkatrész mennyiségét beolvassuk egy szótárba.
        /// </summary>
        /// <param name="alkatreszID"> A keresett alkatrészek ID kollekciója. </param>
        /// <param name="raktarSzama"> A raktár, amelyikben keressük a mennyiségeket. </param>
        /// <returns> Az alkatrész ID-k lesznek a kulcsok, az érték pedig maga a mennyiség. </returns>
        public static Dictionary<int, int> Osszes_Alkatresz_Mennyisege_Raktarbol(IEnumerable<int> alkatreszID, int raktarSzama)
        {
            Dictionary<int, int> alkatreszidEsMennyiseg = new Dictionary<int, int>();

            string query = $"SELECT ID, Mennyiseg FROM `raktar{raktarSzama}` WHERE ID IN ({string.Join(",", alkatreszID)})";

            try
            {
                kapcsolat.Open();

                MySqlCommand cmd = new MySqlCommand(query, kapcsolat);
                using(MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = dr.GetInt32(0);
                        int mennyiseg = dr.GetInt32(1);
                        alkatreszidEsMennyiseg.Add(id, mennyiseg);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiba történt a raktár mennyiségek lekérése során!" + ex.Message, "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                kapcsolat.Close();
            }

            return alkatreszidEsMennyiseg;
        }


        static void LogRaktarMozgas(int alkatreszID, int raktarSzama, int mennyiseg, bool torles, DateTime modositasDatuma)
        {
            string logUzenet = $"{modositasDatuma} - Alkatrész ID: {alkatreszID} Raktár száma: {raktarSzama} ";
            logUzenet += torles ? $"Törölve: {mennyiseg} db " : $"Hozzáadva: {mennyiseg} db";

            string fajlHelye = Path.Combine(Environment.CurrentDirectory, "Logolás\\log.txt");
            if (!Directory.Exists(Path.GetDirectoryName(fajlHelye)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fajlHelye));
            }

            using (StreamWriter sw = new StreamWriter(fajlHelye, true, Encoding.UTF8))
            {
                sw.WriteLine(logUzenet);
            }
        }
        #endregion

        /// <summary>
        /// Segítő funkció a táblák létrehozásához.
        /// </summary>
        /// <returns> Az összes elkészíteni kívánt tábla query-jével tér vissza. </returns>
        static string[] TablaQuerykBeolvasasa()
        {
            return new string[]
            {
                //ALKATRÉSZEK FŐTÁBLA
                @"CREATE TABLE IF NOT EXISTS `alkatreszek`
                (ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
                AlkatreszTipus ENUM('Alaplap', 'Memoria', 'Videokartya', 'Processzor', 'Tapegyseg') NOT NULL,
                Gyarto VARCHAR(100) NOT NULL,
                Tipus VARCHAR(100) NOT NULL,
                Ar INT NOT NULL,
                Garancia INT NOT NULL,
                Foglalat ENUM('LGA1200', 'LGA1700', 'AM4', 'AM5'),
                Chipset ENUM ('H510', 'H610', 'B660', 'Z690', 'B760', 'Z790', 'B450', 'X470', 'B550', 'X570', 'B650', 'X670'),
                RgbVilagitasVane TINYINT(1),
                Merete TINYINT,
                Orajele INT,
                Generacio ENUM('DDR4', 'DDR5'),
                Idozites TINYINT,
                MemoriaMerete TINYINT,
                MagOrajele INT,
                RamTipus ENUM('GDDR6', 'GDDR6X'),
                Fogyasztas INT,
                RaytracingTamogatasVane TINYINT(1),
                Tokozas ENUM('LGA1200', 'LGA1700', 'AM4', 'AM5'),
                ProcesszorOrajele INT,
                L3CacheMerete INT,
                Magszam TINYINT,
                Teljesitmeny INT,
                Minoseg ENUM('Bronze', 'Silver', 'Gold'))",
                //RAKTÁR 1
                @"CREATE TABLE IF NOT EXISTS `raktar1` 
                (ID INT NOT NULL PRIMARY KEY,
                Mennyiseg INT NOT NULL,
                Modositva DATETIME NOT NULL)",
                //RAKTÁR 2
                @"CREATE TABLE IF NOT EXISTS `raktar2`
                (ID INT NOT NULL PRIMARY KEY,
                Mennyiseg INT NOT NULL,
                Modositva DATETIME NOT NULL)",
                //RAKTÁR 3
                @"CREATE TABLE IF NOT EXISTS `raktar3`
                (ID INT NOT NULL PRIMARY KEY,
                Mennyiseg INT NOT NULL,
                Modositva DATETIME NOT NULL)",
                //RAKTÁR 4
                @"CREATE TABLE IF NOT EXISTS `raktar4`
                (ID INT NOT NULL PRIMARY KEY,
                Mennyiseg INT NOT NULL,
                Modositva DATETIME NOT NULL)"
            };
        }

        #region Segítő funkciók
        static int Bool_To_Int(bool x)
        {
            if (x) return 1;
            else { return 0; }
        }

        static bool Int_To_Bool(int x)
        {
            if (x == 1) return true;
            else return false;
        }
        #endregion
    }
}
