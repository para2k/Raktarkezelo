using ProOktatasVizsgaFeladat.AlkatreszFormok;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat
{
    public partial class Form1 : Form
    {
        List<Alkatresz> alkatreszekLista;
        public enum AlkatreszTipus { Alaplap, Memoria, Processzor, Videokartya, Tapegyseg }

        List<int> raktarokSzama;
        public Form1()
        {
            raktarokSzama = new List<int> { 1, 2, 3, 4 };
            InitializeComponent();
            raktarSzamaCB.DataSource = raktarokSzama;
            alkatreszCB.DataSource = Enum.GetValues(typeof(AlkatreszTipus));
        }

        void LB_Frissites()
        {
            alkatreszekLista = MySQLKezelo.Alkatreszek_Beolvasasa();
            alkatreszekLB.DataSource = null;
            alkatreszekLB.DataSource = alkatreszekLista;
        }

        //A COMBOBOX-BAN KIVÁLASZTOTT RAKTÁRT ÁTADJUK A RAKTÁR KEZELŐ FORMUNKNAK ÉS MEG IS NYITJUK
        private void raktarMegnyitasGomb_Click(object sender, EventArgs e)
        {
            if (raktarSzamaCB.SelectedIndex != -1)
            {
                alkatreszekLista = MySQLKezelo.Alkatreszek_Beolvasasa();

                RaktarForm raktarForm = new RaktarForm(raktarokSzama[raktarSzamaCB.SelectedIndex]);
                if (raktarForm.ShowDialog() == DialogResult.OK)
                {
                    //csak fogjuk az ablakot
                }
            }
        }

        //HA VAN KIVÁLASZTOTT ALKATRÉSZ TÍPUS, MEGNYITJUK A HOZZÁ TARTOZÓ FORMOT ÚJ HOZZÁADÁSHOZ
        private void alkatreszHozzaadasGomb_Click(object sender, EventArgs e)
        {
            if (alkatreszCB.SelectedIndex != -1)
            {
                switch ((AlkatreszTipus)alkatreszCB.SelectedIndex)
                {
                    case AlkatreszTipus.Alaplap:
                        AlaplapForm alaplapForm = new AlaplapForm();
                        if (alaplapForm.ShowDialog() == DialogResult.OK)
                        {
                            MySQLKezelo.Alkatresz_Letrehozas(alaplapForm.AktualisAlkatresz);
                        }
                        break;
                    case AlkatreszTipus.Memoria:
                        MemoriaForm memoriaForm = new MemoriaForm();
                        if (memoriaForm.ShowDialog() == DialogResult.OK)
                        {
                            MySQLKezelo.Alkatresz_Letrehozas(memoriaForm.AktualisAlkatresz);
                        }
                        break;
                    case AlkatreszTipus.Processzor:
                        ProcesszorForm processzorForm = new ProcesszorForm();
                        if (processzorForm.ShowDialog() == DialogResult.OK)
                        {
                            MySQLKezelo.Alkatresz_Letrehozas(processzorForm.AktualisAlkatresz);
                        }
                        break;
                    case AlkatreszTipus.Videokartya:
                        VideokartyaForm videokartyaForm = new VideokartyaForm();
                        if (videokartyaForm.ShowDialog() == DialogResult.OK)
                        {
                            MySQLKezelo.Alkatresz_Letrehozas(videokartyaForm.AktualisAlkatresz);
                        }
                        break;
                    case AlkatreszTipus.Tapegyseg:
                        TapegysegForm tapegysegForm = new TapegysegForm();
                        if (tapegysegForm.ShowDialog() == DialogResult.OK)
                        {
                            MySQLKezelo.Alkatresz_Letrehozas(tapegysegForm.AktualisAlkatresz);
                        }
                        break;
                }
            }
            LB_Frissites();
        }

        //HA VAN KIVÁLASZTOTT ALKATRÉSZ, AKKOR MEGHÍVJUK AZ ALKATRÉSZ KEZELÉSÉT VÉGZŐ FORMUNKAT MÓDOSÍTÁSHOZ
        private void alkatreszModositasGomb_Click(object sender, EventArgs e)
        {
            if (alkatreszekLB.SelectedIndex != -1)
            {
                Alkatresz kivalasztott = alkatreszekLB.SelectedItem as Alkatresz;

                if (kivalasztott is Alaplap)
                {
                    AlaplapForm alaplapForm = new AlaplapForm(kivalasztott as Alaplap);
                    if (alaplapForm.ShowDialog() == DialogResult.OK)
                    {
                        MySQLKezelo.Alkatresz_Modositas(alaplapForm.AktualisAlkatresz);
                    }
                }
                else if (kivalasztott is Memoria memoria)
                {
                    MemoriaForm memoriaForm = new MemoriaForm(memoria);
                    if (memoriaForm.ShowDialog() == DialogResult.OK)
                    {
                        MySQLKezelo.Alkatresz_Modositas(memoriaForm.AktualisAlkatresz);
                    }
                }
                else if (kivalasztott is Processzor processzor)
                {
                    ProcesszorForm processzorForm = new ProcesszorForm(processzor);
                    if (processzorForm.ShowDialog() == DialogResult.OK)
                    {
                        MySQLKezelo.Alkatresz_Modositas(processzorForm.AktualisAlkatresz);
                    }
                }
                else if (kivalasztott is Tapegyseg tapegyseg)
                {
                    TapegysegForm tapegysegForm = new TapegysegForm(tapegyseg);
                    if (tapegysegForm.ShowDialog() == DialogResult.OK)
                    {
                        MySQLKezelo.Alkatresz_Modositas(tapegysegForm.AktualisAlkatresz);
                    }
                }
                else if (kivalasztott is Videokartya videokartya)
                {
                    VideokartyaForm videokartyaForm = new VideokartyaForm(videokartya);
                    if (videokartyaForm.ShowDialog() == DialogResult.OK)
                    {
                        MySQLKezelo.Alkatresz_Modositas(videokartyaForm.AktualisAlkatresz);
                    }
                }
                LB_Frissites();
            }
        }

        //HA MÉG NEM LÉTEZIK AZ ADATBÁZIS, AKKOR MEGHÍVJUK AZ ADATBÁZIST ELKÉSZÍTÓ METÓDUST
        private void sqlCsatlakozasLabel_DoubleClick(object sender, EventArgs e)
        {
            if (!MySQLKezelo.Letezike_Az_Adatbazis())
            {
                MySQLKezelo.Adatbazis_Es_Tablak_Letrehozasa();
            }
            else
            {
                MessageBox.Show("Az adatbázis már létezik és be is van töltve!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        //TÖRÖLJÜK A KIVÁLASZTOTT ALKATRÉSZT AZ ADATBÁZISBÓL
        private void alkatreszTorlesGomb_Click(object sender, EventArgs e)
        {
            if (alkatreszekLB.SelectedIndex != -1)
            {
                Alkatresz kivalasztott = alkatreszekLB.SelectedItem as Alkatresz;
                if (MessageBox.Show($"Biztosan törlöd a {kivalasztott} alkatrészt?", "Megerősítés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MySQLKezelo.Alkatresz_Torles_Folistabol(kivalasztott);
                    LB_Frissites();
                }
            }
        }

        //FÁJL KIVÁLASZTÁSA UTÁN CSV-BŐL MEGPRÓBÁLJUK BEOLVASNI AZ ALKATRÉSZT
        private void csvBeolvasasPB_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog betoltesHelye = new OpenFileDialog();
            betoltesHelye.Filter = "CSV Files|*.csv";
            betoltesHelye.Title = "Alkatrész betöltése CSV-ből";

            if (betoltesHelye.ShowDialog() == DialogResult.OK)
            {
                string fajlHelye = betoltesHelye.FileName;
                {
                    Alkatresz betoltendoAlkatresz = MySQLKezelo.Alkatresz_Beolvasasa_CSVbol(fajlHelye);

                    if (!MySQLKezelo.Letezik_Az_Alkatresz(betoltendoAlkatresz))
                    {
                        MySQLKezelo.Alkatresz_Letrehozas(betoltendoAlkatresz);
                        MessageBox.Show("Sikeres betöltés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LB_Frissites();
                    }
                    else
                    {
                        MessageBox.Show("Ez az alkatrész már az adatbázisban van! ", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }  
        }

        //BETÖLTÉSNÉL MEGVIZSGÁLJUK, HOGY LÉTEZIK-E AZ ADATBÁZIS, HA IGEN, AKKOR SZINKRONIZÁLUNK
        private void Form1_Load(object sender, EventArgs e)
        {
            if (MySQLKezelo.Letezike_Az_Adatbazis())
            {
                LB_Frissites();
            }
        }

        #region DESIGN

        private void sqlPB_MouseLeave(object sender, EventArgs e)
        {
            sqlPB.Width = sqlPB.Width - 8;
            sqlPB.Height = sqlPB.Height - 8;
            sqlPB.Location = new Point(sqlPB.Location.X + 4, sqlPB.Location.Y + 4);
            sqlCsatlakozasLabel.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        }

        private void sqlPB_MouseEnter(object sender, EventArgs e)
        {
            sqlPB.Width = sqlPB.Width + 8;
            sqlPB.Height = sqlPB.Height + 8;
            sqlPB.Location = new Point(sqlPB.Location.X - 4, sqlPB.Location.Y - 4);
            sqlCsatlakozasLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        }

        private void csvBeolvasasPB_MouseEnter(object sender, EventArgs e)
        {
            csvBeolvasasPB.Width = csvBeolvasasPB.Width + 8;
            csvBeolvasasPB.Height = csvBeolvasasPB.Height + 8;
            csvBeolvasasPB.Location = new Point(csvBeolvasasPB.Location.X - 4, csvBeolvasasPB.Location.Y - 4);
            csvBetoltesLabel.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        }

        private void csvBeolvasasPB_MouseLeave(object sender, EventArgs e)
        {
            csvBeolvasasPB.Width = csvBeolvasasPB.Width - 8;
            csvBeolvasasPB.Height = csvBeolvasasPB.Height - 8;
            csvBeolvasasPB.Location = new Point(csvBeolvasasPB.Location.X + 4, csvBeolvasasPB.Location.Y + 4);
            csvBetoltesLabel.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        }

        #endregion
    }
}
