using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    public partial class TapegysegForm : BaseAlkatreszForm
    {
        public TapegysegForm()
        {
            InitializeComponent();
            ComboBoxok_Feltoltese();
            CimLabelAllitas("Tápegység");
        }

        public TapegysegForm(Tapegyseg modositando)
        {
            InitializeComponent();
            ComboBoxok_Feltoltese();
            AktualisAlkatresz = modositando;
            AlapBeallitasModositoKonstruktorhoz(modositando);
            teljesitmenyNUD.Value = modositando.Teljesitmeny;
            minosegCB.SelectedIndex = (int)modositando.Minoseg;
        }

        void ComboBoxok_Feltoltese()
        {
            gyartoCB.DataSource = Ertekek.tapegysegEngedelyezettGyartok;
            minosegCB.DataSource = Enum.GetValues(typeof(Minoseg));
        }

        //ÚJ TÁPEGYSÉG VAGY MÓDOSÍTÁSA
        protected override void dinamikusGomb_Click(object sender, EventArgs e)
        {
            if (AktualisAlkatresz == null)
            {
                try
                {
                    AktualisAlkatresz = new Tapegyseg((uint)teljesitmenyNUD.Value, (Minoseg)minosegCB.SelectedIndex, 0, gyartoCB.Text, tipusTB.Text,
                        (int)arNUD.Value, (int)garanciaNUD.Value);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A tápegység létrehozása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    AlapBeallitasokAlkatreszModositashoz();
                    Tapegyseg tapegyseg = AktualisAlkatresz as Tapegyseg;
                    tapegyseg.Ar = (int)arNUD.Value;
                    tapegyseg.Teljesitmeny = (uint)teljesitmenyNUD.Value;
                    tapegyseg.Minoseg = (Minoseg)minosegCB.SelectedIndex;
                    AktualisAlkatresz = tapegyseg;

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A tápegység módosítása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region DESIGN

        protected override void gyartoCB_TextChanged(object sender, EventArgs e)
        {
            Combobox_Gyarto_Allitas(Ertekek.tapegysegEngedelyezettGyartok); 
        }
        private void teljesitmenyNUD_ValueChanged(object sender, EventArgs e)
        {
            if(teljesitmenyNUD.Value >= 350 && teljesitmenyNUD.Value <= 1200)
            {
                teljesitmenyNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                teljesitmenyNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void minosegCB_TextChanged(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(Minoseg), minosegCB.Text))
            {
                minosegCB.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                minosegCB.BackColor = Ertekek.helytelenSzin;
            }
        }

        #endregion
    }
}
