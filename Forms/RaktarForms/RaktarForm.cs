using ProOktatasVizsgaFeladat.Forms;
using ProOktatasVizsgaFeladat.Forms.RaktarForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat
{
    public partial class RaktarForm : Form
    {
        List<Alkatresz> aktualisRaktarLista;
        public int RaktarSzama { get; private set; }
        public RaktarForm(int raktarSzama)
        {
            InitializeComponent();
            RaktarSzama = raktarSzama;
            raktarNeveLabel.Text = $"Raktár {raktarSzama}";
            this.Text = raktarNeveLabel.Text + " kezelése";

            Raktar_Es_ListBox_Frissites();
        }
        void Raktar_Es_ListBox_Frissites()
        {
            aktualisRaktarLista = MySQLKezelo.Alkatreszek_Beolvasasa_Raktarbol(RaktarSzama);
            raktarLB.DataSource = null;
            raktarLB.DataSource = aktualisRaktarLista;
        }

        //ALKATRÉSZ HOZZÁADÁSA A RAKTÁRHOZ
        private void alkatreszHozzaadasGomb_Click(object sender, EventArgs e)
        {
            AlkatreszRaktarkezeloForm ablak = new AlkatreszRaktarkezeloForm(RaktarSzama);
            if (ablak.ShowDialog() == DialogResult.OK)
            {
                Raktar_Es_ListBox_Frissites();
            }
        }

        //ALKATRÉSZ TÖRLÉSE A RAKTÁRBÓL
        private void alkatreszTorlesGomb_Click(object sender, EventArgs e)
        {
            AlkatreszRaktarkezeloForm ablak = new AlkatreszRaktarkezeloForm(RaktarSzama, true);
            {
                if (ablak.ShowDialog() == DialogResult.OK)
                {
                    Raktar_Es_ListBox_Frissites();
                }
            }
        }

        //DUPLA KLIKKRE FELHOZZUK AZ ALKATRÉSZ ADAT FORMOT
        private void raktarLB_DoubleClick(object sender, EventArgs e)
        {
            if (raktarLB.SelectedIndex != -1)
            {
                Alkatresz alkatresz = (Alkatresz)raktarLB.SelectedItem;
                AlkatreszAdatForm ablak = new AlkatreszAdatForm(alkatresz);
                ablak.Show();
            }
        }

        #region SZŰRÉSEK

        //A RAKTÁR ALKATRÉSZEINEK AZ ÖSSZÉRTÉKE
        //SZŰRÉSNÉL AZ AKTUÁLIS SZŰRÉS ALKATRÉSZEINEK AZ ÖSSZÉRTÉKE
        private void raktarOsszertekGomb_Click(object sender, EventArgs e)
        {
            int teljesErtek = 0;
            int teljesBruttoErtek = 0;
            string osszesites = "";
            List<Alkatresz> szurtAlkatreszek = new List<Alkatresz>();

            foreach(var item in raktarLB.Items)
            {
                if (item is Alkatresz alkatresz)
                {
                    szurtAlkatreszek.Add(alkatresz);
                }
            }

            if (szurtAlkatreszek.Count == 0)
            {
                MessageBox.Show("Nincs elem a raktárban!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IEnumerable<int> alkatreszIDk = szurtAlkatreszek.Select(alkatresz => alkatresz.Id).ToList();
            Dictionary<int, int> darabSzamok = MySQLKezelo.Osszes_Alkatresz_Mennyisege_Raktarbol(alkatreszIDk, RaktarSzama);
            foreach (Alkatresz alkatresz in szurtAlkatreszek)
            {
                osszesites += $"{alkatresz} - {darabSzamok[alkatresz.Id]} db" + Environment.NewLine;
            }
            teljesErtek = szurtAlkatreszek.Sum(alkatresz => alkatresz.Ar * darabSzamok[alkatresz.Id]);
            teljesBruttoErtek = (int)szurtAlkatreszek.Sum(alkatresz => alkatresz.BruttoArSzamitas() * darabSzamok[alkatresz.Id]);

            MessageBox.Show($"Az összes alkatrész nettó értéke a jelenlegi raktárban: {teljesErtek} ft" + Environment.NewLine
                + $"Bruttó értéke: {teljesBruttoErtek} ft" + Environment.NewLine + osszesites);
        }

        private void szuresTB_TextChanged(object sender, EventArgs e)
        {
            if (aktualisRaktarLista.Count == 0) return;

            SzuresSzovegAlapjan(aktualisRaktarLista, szuresTB.Text.ToLower());
        }

        List<Alkatresz> SzuresSzovegAlapjan(List<Alkatresz> teljesLista, string szoveg)
        {
            List<Alkatresz> szurtAlkatreszek = teljesLista.Where(alkatresz => alkatresz.ToString().ToLower().Contains(szoveg)).ToList();
            raktarLB.DataSource = null;
            raktarLB.DataSource = szurtAlkatreszek;

            return szurtAlkatreszek;
        }

        private void szuresArAlapjanGomb_Click(object sender, EventArgs e)
        {
            if (minArNUD.Value > maxArNUD.Value)
            {
                MessageBox.Show("A minimum ár szűrője nem lehet kisebb a maximumnál!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            List<Alkatresz> szurtAlkatreszek = SzuresArAlapjan(aktualisRaktarLista, (int)minArNUD.Value, (int)maxArNUD.Value);
            raktarLB.DataSource = null;
            raktarLB.DataSource = szurtAlkatreszek;
        }

        List<Alkatresz> SzuresArAlapjan(List<Alkatresz> teljesLista, int minAr, int maxAr)
        {
            List<Alkatresz> szurtAlkatreszek = teljesLista.Where(alkatresz => alkatresz.Ar >= minAr && alkatresz.Ar <= maxAr).ToList();
            raktarLB.DataSource = null;
            raktarLB.DataSource = szurtAlkatreszek;
            return szurtAlkatreszek;
        }

        //EREDETI RAKTÁR VISSZAÁLLÍTÁSA SZŰRÉSRŐL
        private void visszaallitasGomb_Click(object sender, EventArgs e)
        {
            szuresTB.Text = string.Empty;
            minArNUD.Value = 0;
            maxArNUD.Value = 0;
            raktarLB.DataSource = null;
            raktarLB.DataSource = aktualisRaktarLista;
        }

        #endregion
    }
}
