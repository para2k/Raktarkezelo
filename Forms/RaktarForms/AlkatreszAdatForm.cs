using System;
using System.IO;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat.Forms.RaktarForms
{
    public partial class AlkatreszAdatForm : Form
    {
        Alkatresz MenteshezAktualisAlkatresz { get; set; }
        public AlkatreszAdatForm(Alkatresz valasztottAlkatresz)
        {
            InitializeComponent();
            Adatok_Beallitasa(valasztottAlkatresz);
            MenteshezAktualisAlkatresz = valasztottAlkatresz;
        }

        //AZ AKTUÁLIS ALKATRÉSZ ADATAIT A LABELEKHEZ RENDELJÜK
        void Adatok_Beallitasa(Alkatresz alk)
        {
            label1.Text = "ID: " + alk.Id;
            label3.Text = "Gyártó: " + alk.Gyarto;
            label5.Text = "Tipus: " + alk.Tipus;
            label7.Text = $"Ár: {alk.Ar} ft";
            label9.Text = $"Garancia: {alk.Garancia} hónap";
            label2.Text = alk.GetType().ToString().Replace("ProOktatasVizsgaFeladat.", "");

            if (alk is Alaplap alaplap)
            {
                label4.Text = "Processzorfoglalat: " + alaplap.Foglalat;
                label6.Text = "Chipset: " + alaplap.Chipset;
                bool test = alaplap.RgbVilagitasVane;
                label8.Text = "RGB világítás: " + (test ? "Van" : "Nincs");
                label10.Visible = false;
                label10.Enabled = false;
                label12.Visible = false;
                label12.Enabled = false;
            }
            else if (alk is Memoria mem)
            {
                label4.Text = $"Memória mérete: {mem.Merete} GB";
                label6.Text = $"Órajele: {mem.Orajele} Mhz";
                label8.Text = "Generáció: " + mem.Generacio;
                label10.Text = $"Időzítés (CL): {mem.Idozites}";
                label12.Visible = false;
                label12.Enabled = false;
            }
            else if (alk is Processzor proc)
            {
                label4.Text = "Tokozása: " + proc.Tokozas;
                label6.Text = $"Órajele: {proc.Orajele} Mhz";
                label8.Text = $"L3Cache mérete: {proc.L3CacheMerete} MB";
                label10.Text = $"Magszám: {proc.Magszam} db";
                label12.Visible = false;
                label12.Enabled = false;
            }
            else if (alk is Videokartya vid)
            {
                label4.Text = $"Memóriamérete: {vid.MemoriaMerete} GB";
                label6.Text = $"Magórajel: {vid.MagOrajel} Mhz";
                label8.Text = "RAM típusa: " + vid.RamTipus;
                label10.Text = $"Fogyasztás: {vid.Fogyasztas} Watt";
                bool test = vid.RaytracingTamogatasVane;
                label12.Text = "Raytracing támogatás: " + (test ? "Van" : "Nincs");
            }
            else if (alk is Tapegyseg tap)
            {
                label4.Text = "Minősége :" + tap.Minoseg;
                label6.Text = $"Teljesítménye: {tap.Teljesitmeny} Watt";
                label8.Enabled = false;
                label8.Visible = false;
                label10.Visible = false;
                label10.Enabled = false;
                label12.Visible = false;
                label12.Enabled = false;
            }
        }

        //MENTÉS CSV-BE
        private void csvPB_Click(object sender, EventArgs e)
        {
            SaveFileDialog mentoAblak = new SaveFileDialog();
            mentoAblak.Filter = "CSV Files|*.csv";
            mentoAblak.Title = "Alkatrész exportálása CSV-be";
            mentoAblak.FileName = "Alkatreszek.csv";

            if (mentoAblak.ShowDialog() == DialogResult.OK)
            {
                string fajlHelye = mentoAblak.FileName;

                try
                {
                    using (StreamWriter sw = new StreamWriter(fajlHelye))
                    {
                        string sor = CSV_Fajl_Szerkezet_Felepitese(MenteshezAktualisAlkatresz);

                        sw.WriteLine(sor);
                    }

                    MessageBox.Show("Alkatrész sikeresen mentve!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba az alkatrész csv-be mentése során! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //SEGÍTŐ FUNKCIÓ A MENTÉSHEZ
        string CSV_Fajl_Szerkezet_Felepitese(Alkatresz alk)
        {
            string csvString = "";
            csvString += $"{alk.Gyarto},{alk.Tipus},{alk.Ar},{alk.Garancia},{alk.GetType().Name}";
            if (alk is Alaplap alaplap)
            {
                csvString += $",{alaplap.Foglalat},{alaplap.Chipset},{alaplap.RgbVilagitasVane}";
            }
            else if (alk is Memoria mem)
            {
                csvString += $",{mem.Merete},{mem.Orajele},{mem.Generacio},{mem.Idozites}";
            }
            else if (alk is Processzor proc)
            {
                csvString += $",{proc.Tokozas},{proc.Orajele},{proc.L3CacheMerete},{proc.Magszam}";
            }
            else if (alk is Videokartya vid)
            {
                csvString += $",{vid.MemoriaMerete},{vid.MagOrajel},{vid.RamTipus},{vid.Fogyasztas},{vid.RaytracingTamogatasVane}";
            }
            else if (alk is Tapegyseg tap)
            {
                csvString += $",{tap.Minoseg},{tap.Teljesitmeny}";
            }

            return csvString;
        }

        //BEZÁRÁS GOMB
        private void bezarasGomb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
