using System;
using System.Linq;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    public partial class AlaplapForm : BaseAlkatreszForm
    {
        public AlaplapForm()
        {
            InitializeComponent();
            CimLabelAllitas("Alaplap");
            ComboBoxok_Feltoltese();
        }

        public AlaplapForm(Alaplap modositando)
        {
            InitializeComponent();
            ComboBoxok_Feltoltese();
            AktualisAlkatresz = modositando;
            AlapBeallitasModositoKonstruktorhoz(modositando);
            foglalatCB.SelectedIndex = (int)modositando.Foglalat;
            chipsetCB.SelectedIndex = (int)modositando.Chipset;
            rgbCheckBox.Checked = modositando.RgbVilagitasVane;
        }

        void ComboBoxok_Feltoltese()
        {
            gyartoCB.DataSource = Ertekek.alaplapEngedelyezettGyartok;
            foglalatCB.DataSource = Enum.GetValues(typeof(ProcesszorFoglalat));
            chipsetCB.DataSource = Enum.GetValues(typeof(Chipset));
        }

        //ÚJ ALAPLAP VAGY MÓDOSÍTÁSA
        protected override void dinamikusGomb_Click(object sender, EventArgs e)
        {
            if (AktualisAlkatresz == null)
            {
                try
                {
                    AktualisAlkatresz = new Alaplap((ProcesszorFoglalat)foglalatCB.SelectedIndex, (Chipset)chipsetCB.SelectedIndex, rgbCheckBox.Checked, 0,
                    gyartoCB.Text, tipusTB.Text, (int)arNUD.Value, (int)garanciaNUD.Value);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az alaplap létrehozása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    AlapBeallitasokAlkatreszModositashoz();
                    Alaplap alaplap = AktualisAlkatresz as Alaplap;
                    alaplap.Ar = (int)arNUD.Value;
                    alaplap.Foglalat = (ProcesszorFoglalat)foglalatCB.SelectedIndex;
                    alaplap.Chipset = (Chipset)chipsetCB.SelectedIndex;
                    alaplap.RgbVilagitasVane = rgbCheckBox.Checked;
                    AktualisAlkatresz = alaplap;

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Az alaplap módosítása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region DESIGN

        protected override void gyartoCB_TextChanged(object sender, EventArgs e)
        {
            Combobox_Gyarto_Allitas(Ertekek.alaplapEngedelyezettGyartok);
        }

        void Combobox_Hatter_Allitas()
        {
            ProcesszorFoglalat foglalat = (ProcesszorFoglalat)foglalatCB.SelectedIndex;
            Chipset chipset = (Chipset)chipsetCB.SelectedIndex;

            if (foglalat == ProcesszorFoglalat.LGA1200)
            {
                if (chipset == Chipset.H510 || chipset == Chipset.H610)
                {
                    chipsetCB.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    chipsetCB.BackColor = Ertekek.helytelenSzin;
                }
            }
            else if (foglalat == ProcesszorFoglalat.LGA1700)
            {
                if (chipset == Chipset.B660 || chipset == Chipset.Z690 || chipset == Chipset.B760 || chipset == Chipset.Z790)
                {
                    chipsetCB.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    chipsetCB.BackColor = Ertekek.helytelenSzin;
                }
            }
            else if (foglalat == ProcesszorFoglalat.AM4)
            {
                if (chipset == Chipset.B450 || chipset == Chipset.X470 || chipset == Chipset.B550 || chipset == Chipset.X570)
                {
                    chipsetCB.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    chipsetCB.BackColor = Ertekek.helytelenSzin;
                }
            }
            else if (foglalat == ProcesszorFoglalat.AM5)
            {
                if (chipset == Chipset.B650 || chipset == Chipset.X670)
                {
                    chipsetCB.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    chipsetCB.BackColor = Ertekek.helytelenSzin;
                }
            }
        }

        private void chipsetCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_Hatter_Allitas();
        }

        private void foglalatCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_Hatter_Allitas();
        }
        private void foglalatCB_TextChanged(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(ProcesszorFoglalat), foglalatCB.Text))
            {
                foglalatCB.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                foglalatCB.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void chipsetCB_TextChanged(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(Chipset), chipsetCB.Text))
            {
                chipsetCB.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                chipsetCB.BackColor = Ertekek.helytelenSzin;
            }
        }
        #endregion
    }
}
