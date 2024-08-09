using System;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    public partial class VideokartyaForm : BaseAlkatreszForm
    {
        public VideokartyaForm()
        {
            InitializeComponent();
            ComboBoxok_Feltoltese();
            CimLabelAllitas("Videokártya");
        }

        public VideokartyaForm(Videokartya modositando)
        {
            InitializeComponent();
            ComboBoxok_Feltoltese();
            AktualisAlkatresz = modositando;
            AlapBeallitasModositoKonstruktorhoz(modositando);
            ramTipusCB.SelectedIndex = (int)modositando.RamTipus;
            memoriameretNUD.Value = modositando.MemoriaMerete;
            magorajelNUD.Value = modositando.MagOrajel;
            fogyasztasNUD.Value = modositando.Fogyasztas;
            raytCheckBox.Checked = modositando.RaytracingTamogatasVane;
        }

        void ComboBoxok_Feltoltese()
        {
            gyartoCB.DataSource = Ertekek.videokartyaEngedelyezettGyartok;
            ramTipusCB.DataSource = Enum.GetValues(typeof(RamTipus));
        }

        //ÚJ VIDEÓKÁRTYA VAGY MÓDOSÍTÁSA
        protected override void dinamikusGomb_Click(object sender, EventArgs e)
        {
            if (AktualisAlkatresz == null)
            {
                try
                {
                    AktualisAlkatresz = new Videokartya((byte)memoriameretNUD.Value, (uint)magorajelNUD.Value, (RamTipus)ramTipusCB.SelectedIndex,
                        (uint)fogyasztasNUD.Value, raytCheckBox.Checked, 0, gyartoCB.Text, tipusTB.Text, (int)arNUD.Value, (int)garanciaNUD.Value);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A videokártya létrehozása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    AlapBeallitasokAlkatreszModositashoz();
                    Videokartya vk = AktualisAlkatresz as Videokartya;
                    vk.Ar = (int)arNUD.Value;
                    vk.MemoriaMerete = (byte)memoriameretNUD.Value;
                    vk.MagOrajel = (uint)magorajelNUD.Value;
                    vk.RamTipus = (RamTipus)ramTipusCB.SelectedIndex;
                    vk.Fogyasztas = (uint)fogyasztasNUD.Value;
                    vk.RaytracingTamogatasVane = raytCheckBox.Checked;
                    AktualisAlkatresz = vk;

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A videokártya módosítása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region DESIGN

        protected override void gyartoCB_TextChanged(object sender, EventArgs e)
        {
            Combobox_Gyarto_Allitas(Ertekek.videokartyaEngedelyezettGyartok);
        }

        private void memoriameretNUD_ValueChanged(object sender, EventArgs e)
        {
            if(memoriameretNUD.Value >= 8 && memoriameretNUD.Value <= 32)
            {
                memoriameretNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                memoriameretNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void magorajelNUD_ValueChanged(object sender, EventArgs e)
        {
            if(magorajelNUD.Value >= 1800 && magorajelNUD.Value <= 3200)
            {
                magorajelNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                magorajelNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void fogyasztasNUD_ValueChanged(object sender, EventArgs e)
        {
            if(fogyasztasNUD.Value >= 120 && fogyasztasNUD.Value <= 650)
            {
                fogyasztasNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                fogyasztasNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void ramTipusCB_TextChanged(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(RamTipus), ramTipusCB.Text))
            {
                ramTipusCB.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                ramTipusCB.BackColor = Ertekek.helytelenSzin;
            }
        }

        #endregion
    }
}
