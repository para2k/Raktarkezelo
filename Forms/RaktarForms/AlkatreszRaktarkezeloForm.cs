using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat.Forms
{
    public partial class AlkatreszRaktarkezeloForm : Form
    {
        List<Alkatresz> osszesAlkatresz;
        public int AktualisRaktarSzama { get; private set; }
        public Alkatresz KivalasztottAlkatresz { get; private set; }

        bool torlese;
        public AlkatreszRaktarkezeloForm(int raktarSzama, bool torlese = false)
        {
            InitializeComponent();
            AktualisRaktarSzama = raktarSzama;
            this.torlese = torlese;
            Design_Allitas(torlese);
            Alkatreszek_Betoltese(raktarSzama);
        }

        //HA HOZZÁADÁS BETÖLTJÜK AZ ÖSSZES ALKATRÉSZT, HA TÖRLÉS AKKOR CSAK A RAKTÁR ALKATRÉSZEIT
        void Alkatreszek_Betoltese(int raktarSzam)
        {
            if (torlese)
            {
                osszesAlkatresz = MySQLKezelo.Alkatreszek_Beolvasasa_Raktarbol(raktarSzam); 
            }
            else
            {
                osszesAlkatresz = MySQLKezelo.Alkatreszek_Beolvasasa();
            }

            osszesAlkatreszCB.DataSource = osszesAlkatresz;
        }

        //VÁLASZTÁS ALAPJÁN MÓDOSÍTJUK AZ ALKATRÉSZ MENNYISÉGÉT
        private void dinamikusGomb_Click(object sender, EventArgs e)
        {
            if (KivalasztottAlkatresz != null)
            {
                if (!torlese)
                {
                    MySQLKezelo.Alkatresz_Raktarkezeles(KivalasztottAlkatresz.Id, AktualisRaktarSzama, (int)numericUpDown1.Value, DateTime.Now);
                }
                else
                {
                    MySQLKezelo.Alkatresz_Raktarkezeles(KivalasztottAlkatresz.Id, AktualisRaktarSzama, (int)numericUpDown1.Value, DateTime.Now, true);
                }

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Kérem válasszon ki egy alkatrészt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //HA VÁLTOZIK A KIVÁLASZTOTT ALKATRÉSZ A FELTÖLTÖTT COMBOBOX-BAN, AKKOR FRISSÍTJÜK AZ AKTUÁLIS ALKATRÉSZ DARABSZÁMÁT
        //HA TÖRLÉS, AKKOR BEÁLLÍTJUK A NUMERICUPDOWN MAXIMUM ÉRTÉKÉT AZ AKTUÁLIS ALKATRÉSZ MENNYISÉGÉRE
        private void osszesAlkatreszCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            KivalasztottAlkatresz = osszesAlkatreszCB.SelectedItem as Alkatresz;
            int aktualisMennyiseg = MySQLKezelo.Alkatresz_Mennyiseg_Lekerese_Raktarbol(KivalasztottAlkatresz.Id, AktualisRaktarSzama);
            darabszamRaktarbanLabel.Text = $"{aktualisMennyiseg} db";
            darabszamRaktarbanLabel.Location = new Point(this.Width /2 - darabszamRaktarbanLabel.Width / 2, darabszamRaktarbanLabel.Location.Y);
            if (torlese)
            {
                numericUpDown1.Maximum = aktualisMennyiseg;
            }
            else
            {
                numericUpDown1.Maximum = 20000;
            }
        }

        void Design_Allitas(bool torlese)
        {
            if (torlese)
            {
                this.Text = "Alkatrész törlése raktárból";
                cimLabel.Text = this.Text;
                kerdesLabel.Text = "Hány darabot szeretne törölni a raktárból?";
                dinamikusGomb.Text = "Törlés";
            }
            else
            {
                this.Text = "Alkatrész hozzáadása raktárhoz";
                cimLabel.Text = this.Text;
                kerdesLabel.Text = "Hány darabot szeretne hozzáadni a raktárhoz?";
                dinamikusGomb.Text = "Hozzáadás";
            }

            kerdesLabel.Location = new Point(this.Width / 2 - kerdesLabel.Width / 2, kerdesLabel.Location.Y);
            numericUpDown1.Location = new Point(this.Width /2 - numericUpDown1.Width / 2, numericUpDown1.Location.Y);
            cimLabel.Location = new Point(this.Width / 2 - cimLabel.Width / 2, cimLabel.Location.Y);
            dinamikusGomb.Location = new Point(this.Width / 2 - dinamikusGomb.Width / 2, dinamikusGomb.Location.Y);
        }
    }
}
