using System;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    public partial class ProcesszorForm : BaseAlkatreszForm
    {
        public ProcesszorForm()
        {
            InitializeComponent();
            ArNUD_Allitas();
            ComboBoxok_Feltoltese();
            CimLabelAllitas("Processzor");
        }

        public ProcesszorForm(Processzor modositando)
        {
            InitializeComponent();
            ArNUD_Allitas();
            ComboBoxok_Feltoltese();
            AktualisAlkatresz = modositando;
            AlapBeallitasModositoKonstruktorhoz(modositando);
            tokozasCB.SelectedIndex = (int)modositando.Tokozas;
            orajelNUD.Value = modositando.Orajele;
            l3cacheNUD.Value = modositando.L3CacheMerete;
            magszamNUD.Value = modositando.Magszam;
        }

        void ComboBoxok_Feltoltese()
        {
            gyartoCB.DataSource = Ertekek.processzorEngedelyezettGyartok;
            tokozasCB.DataSource = Enum.GetValues(typeof(Tokozas));
        }

        //ÚJ PROCESSZOR VAGY MÓDOSÍTÁSA
        protected override void dinamikusGomb_Click(object sender, EventArgs e)
        {
            if (AktualisAlkatresz == null)
            {
                try
                {
                    AktualisAlkatresz = new Processzor((Tokozas)tokozasCB.SelectedIndex, (uint)orajelNUD.Value, (uint)l3cacheNUD.Value, (byte)magszamNUD.Value,
                        0, gyartoCB.Text, tipusTB.Text, 0, (int)garanciaNUD.Value);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A processzor létrehozása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    AlapBeallitasokAlkatreszModositashoz();
                    Processzor processzor = (Processzor)AktualisAlkatresz;
                    processzor.Tokozas = (Tokozas)tokozasCB.SelectedIndex;
                    processzor.Orajele = (uint)orajelNUD.Value;
                    processzor.L3CacheMerete = (uint)l3cacheNUD.Value;
                    processzor.Magszam = (byte)magszamNUD.Value;
                    AktualisAlkatresz = processzor;

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A processzor módosítása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void gyartoCB_TextChanged(object sender, EventArgs e)
        {
            Combobox_Gyarto_Allitas(Ertekek.processzorEngedelyezettGyartok);
        }

        #region DESIGN

        void Gyarto_Helyes_Tokozas_Allitas()
        {
            Tokozas valasztott = (Tokozas)tokozasCB.SelectedIndex;
            if (gyartoCB.SelectedIndex == 0)
            {
                if (valasztott == Tokozas.AM4 || valasztott == Tokozas.AM5)
                {
                    tokozasCB.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    tokozasCB.BackColor = Ertekek.helytelenSzin;
                }
            }
            else if (gyartoCB.SelectedIndex == 1)
            {
                if (valasztott == Tokozas.LGA1200 || valasztott == Tokozas.LGA1700)
                {
                    tokozasCB.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    tokozasCB.BackColor = Ertekek.helytelenSzin;
                }
            }
        }

        protected override void gyartoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gyarto_Helyes_Tokozas_Allitas();
        }
        private void tokozasCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gyarto_Helyes_Tokozas_Allitas();
        }

        protected override void arNUD_ValueChanged(object sender, EventArgs e)
        {
            //árszámítás a konstruktoron keresztül
        }
        private void orajelNUD_ValueChanged(object sender, EventArgs e)
        {
            if (orajelNUD.Value >= 1000 && orajelNUD.Value <= 6000)
            {
                orajelNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                orajelNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void l3cacheNUD_ValueChanged(object sender, EventArgs e)
        {
            if (l3cacheNUD.Value >= 2 && l3cacheNUD.Value <= 256)
            {
                l3cacheNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                l3cacheNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void magszamNUD_ValueChanged(object sender, EventArgs e)
        {
            if (magszamNUD.Value >= 1 && magszamNUD.Value <= 32)
            {
                magszamNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                magszamNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        #endregion
    }
}
