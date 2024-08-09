using System;
using System.Linq;
using System.Windows.Forms;

namespace ProOktatasVizsgaFeladat
{
    public partial class BaseAlkatreszForm : Form
    {
        public Alkatresz AktualisAlkatresz { get; protected set; }
        public BaseAlkatreszForm()
        {
            InitializeComponent();
        }

        protected virtual void dinamikusGomb_Click(object sender, EventArgs e)
        {
            // a subformok felül fogják írni a gomb működését
        }

        //KÖZÖS TEXT ÉS LABEL ÁLLÍTÁS
        protected void CimLabelAllitas(string milyenAlkatresz)
        {
            if (AktualisAlkatresz != null)
            {
                cimLabel.Text = $"{milyenAlkatresz}";
                dinamikusGomb.Text = cimLabel.Text + " módosítása";
                this.Text = "Módosítás";
            }
            else
            {
                cimLabel.Text = $"{milyenAlkatresz}";
                dinamikusGomb.Text = cimLabel.Text + " létrehozása";
                this.Text = "Létrehozás";
            }
        }

        //KÖZÖS ÁR ÁLLÍTÁS
        protected void ArNUD_Allitas()
        {
            arNUD.Enabled = false;
            arNUD.BackColor = Ertekek.helyesSzin;
        }

        //KÖZÖS ALKATRÉSZ INFO ÁLLÍTÁS
        protected void AlapBeallitasokAlkatreszModositashoz()
        {
            AktualisAlkatresz.Gyarto = gyartoCB.Text;
            AktualisAlkatresz.Tipus = tipusTB.Text;
            AktualisAlkatresz.Garancia = (int)garanciaNUD.Value;
        }

        //KÖZÖS ALKATRÉSZ INFO ÁLLÍTÁS MÓDOSÍTÁSNÁL
        protected void AlapBeallitasModositoKonstruktorhoz(Alkatresz alkatresz)
        {
            gyartoCB.Text = alkatresz.Gyarto;
            tipusTB.Text = alkatresz.Tipus;
            garanciaNUD.Value = alkatresz.Garancia;
            arNUD.Value = alkatresz.Ar;

            CimLabelAllitas(alkatresz.GetType().Name);
        }

        #region Design
        protected virtual void gyartoCB_TextChanged(object sender, EventArgs e)
        {
            //subclass override
        }

        protected virtual void gyartoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //subclass override
        }

        protected void Combobox_Gyarto_Allitas(string[] melyikAlkatreszGyartoListaja)
        {
            if (gyartoCB.Text.Length >= 3 && melyikAlkatreszGyartoListaja.Contains(gyartoCB.Text))
            {
                gyartoCB.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                gyartoCB.BackColor = Ertekek.helytelenSzin;
            }
        }

        protected void tipusTB_TextChanged(object sender, EventArgs e)
        {
            if (tipusTB.Text.Length >= 3)
            {
                tipusTB.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                tipusTB.BackColor = Ertekek.helytelenSzin;
            }
        }

        protected virtual void arNUD_ValueChanged(object sender, EventArgs e)
        {
            if (arNUD.Value >= 500 && arNUD.Value <= 20000000)
            {
                arNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                arNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        protected void garanciaNUD_ValueChanged(object sender, EventArgs e)
        {
            if (garanciaNUD.Value >= 0 && garanciaNUD.Value <= 120)
            {
                garanciaNUD.BackColor = Ertekek.helyesSzin;
            }
            else
            {
                garanciaNUD.BackColor = Ertekek.helytelenSzin;
            }
        }

        #endregion
    }
}
