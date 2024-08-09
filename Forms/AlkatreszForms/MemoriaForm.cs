using System;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    public partial class MemoriaForm : BaseAlkatreszForm
    {
        public MemoriaForm()
        {
            InitializeComponent();
            ArNUD_Allitas();
            ComboBoxok_Feltoltese();
            CimLabelAllitas("Memória");
        }

        public MemoriaForm(Memoria modositando)
        {
            InitializeComponent();
            ArNUD_Allitas();
            ComboBoxok_Feltoltese();
            AktualisAlkatresz = modositando;
            AlapBeallitasModositoKonstruktorhoz(modositando);
            meretNUD.Value = modositando.Merete;
            generacioCB.SelectedIndex = (int)modositando.Generacio;
            orajelNUD.Value = modositando.Orajele;
            idozitesNUD.Value = modositando.Idozites;
        }

        void ComboBoxok_Feltoltese()
        {
            gyartoCB.DataSource = Ertekek.memoriaEngedelyezettGyartok;
            generacioCB.DataSource = Enum.GetValues(typeof(Generacio));
        }

        //ÚJ MEMÓRIA, VAGY MÓDOSÍTÁSA
        protected override void dinamikusGomb_Click(object sender, EventArgs e)
        {
            if (AktualisAlkatresz == null)
            {
                try
                {
                    AktualisAlkatresz = new Memoria((byte)meretNUD.Value, (uint)orajelNUD.Value, (Generacio)generacioCB.SelectedIndex, (byte)idozitesNUD.Value,
                        0, gyartoCB.Text, tipusTB.Text, (int)garanciaNUD.Value, 0);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A memória létrehozása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    AlapBeallitasokAlkatreszModositashoz();
                    Memoria memoria = AktualisAlkatresz as Memoria;
                    memoria.Merete = (byte)meretNUD.Value;
                    memoria.Orajele = (uint)orajelNUD.Value;
                    memoria.Generacio = (Generacio)generacioCB.SelectedIndex;
                    memoria.Idozites = (byte)idozitesNUD.Value;
                    AktualisAlkatresz = memoria;

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A memória módosítása sikertelen! " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region DESIGN

        protected override void arNUD_ValueChanged(object sender, EventArgs e)
        {
            //árszámítás a konstruktoron keresztül
        }
        protected override void gyartoCB_TextChanged(object sender, EventArgs e)
        {
            Combobox_Gyarto_Allitas(Ertekek.memoriaEngedelyezettGyartok);
        }

        private void meretNUD_ValueChanged(object sender, EventArgs e)
        {
            if(meretNUD.Value >= 8 && meretNUD.Value <= 128)
            {
                meretNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                meretNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void orajelNUD_ValueChanged(object sender, EventArgs e)
        {
            Generacio gen = (Generacio)generacioCB.SelectedIndex;

            if(orajelNUD.Value >= 3000 && orajelNUD.Value <= 8000)
            {
                if(gen == Generacio.DDR4 && orajelNUD.Value <= 4400 || gen == Generacio.DDR5 && orajelNUD.Value >= 5200)
                {
                    orajelNUD.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    orajelNUD.BackColor = Ertekek.helytelenSzin;
                }
            }
            else
            {
                orajelNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void idozitesNUD_ValueChanged(object sender, EventArgs e)
        {
            if(idozitesNUD.Value >= 8 && idozitesNUD.Value <= 60)
            {
                idozitesNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                idozitesNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        private void generacioCB_TextChanged(object sender, EventArgs e)
        {
            Generacio gen = (Generacio)generacioCB.SelectedIndex;
            if (Enum.IsDefined(typeof(Generacio), generacioCB.Text))
            {
                generacioCB.BackColor = Ertekek.helyesSzin;

                if(gen == Generacio.DDR4 && orajelNUD.Value >=3000 && orajelNUD.Value <= 4400)
                {
                    orajelNUD.BackColor = Ertekek.helyesSzin;
                }
                else if(gen == Generacio.DDR5 && orajelNUD.Value >= 5200 && orajelNUD.Value <= 8000)
                {
                    orajelNUD.BackColor = Ertekek.helyesSzin;
                }
                else
                {
                    orajelNUD.BackColor = Ertekek.helytelenSzin;
                }
                    
            }
            else
            {
                generacioCB.BackColor = Ertekek.helytelenSzin;
            }
        }

        #endregion
    }
}
