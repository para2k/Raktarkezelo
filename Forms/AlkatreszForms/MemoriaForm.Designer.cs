namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    partial class MemoriaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idozitesNUD = new System.Windows.Forms.NumericUpDown();
            this.generacioCB = new System.Windows.Forms.ComboBox();
            this.orajelNUD = new System.Windows.Forms.NumericUpDown();
            this.meretNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idozitesNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orajelNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // gyartoCB
            // 
            this.gyartoCB.Size = new System.Drawing.Size(164, 24);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Időzítés:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Generáció:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Órajele:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Mérete:";
            // 
            // idozitesNUD
            // 
            this.idozitesNUD.BackColor = System.Drawing.Color.Firebrick;
            this.idozitesNUD.ForeColor = System.Drawing.Color.White;
            this.idozitesNUD.Location = new System.Drawing.Point(335, 250);
            this.idozitesNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.idozitesNUD.Name = "idozitesNUD";
            this.idozitesNUD.Size = new System.Drawing.Size(174, 22);
            this.idozitesNUD.TabIndex = 33;
            this.idozitesNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idozitesNUD.ValueChanged += new System.EventHandler(this.idozitesNUD_ValueChanged);
            // 
            // generacioCB
            // 
            this.generacioCB.BackColor = System.Drawing.Color.MidnightBlue;
            this.generacioCB.ForeColor = System.Drawing.Color.White;
            this.generacioCB.FormattingEnabled = true;
            this.generacioCB.Location = new System.Drawing.Point(335, 86);
            this.generacioCB.Name = "generacioCB";
            this.generacioCB.Size = new System.Drawing.Size(174, 24);
            this.generacioCB.TabIndex = 32;
            this.generacioCB.TextChanged += new System.EventHandler(this.generacioCB_TextChanged);
            // 
            // orajelNUD
            // 
            this.orajelNUD.BackColor = System.Drawing.Color.Firebrick;
            this.orajelNUD.ForeColor = System.Drawing.Color.White;
            this.orajelNUD.Location = new System.Drawing.Point(335, 195);
            this.orajelNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.orajelNUD.Name = "orajelNUD";
            this.orajelNUD.Size = new System.Drawing.Size(174, 22);
            this.orajelNUD.TabIndex = 31;
            this.orajelNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orajelNUD.ValueChanged += new System.EventHandler(this.orajelNUD_ValueChanged);
            // 
            // meretNUD
            // 
            this.meretNUD.BackColor = System.Drawing.Color.Firebrick;
            this.meretNUD.ForeColor = System.Drawing.Color.White;
            this.meretNUD.Location = new System.Drawing.Point(335, 139);
            this.meretNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.meretNUD.Name = "meretNUD";
            this.meretNUD.Size = new System.Drawing.Size(174, 22);
            this.meretNUD.TabIndex = 30;
            this.meretNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.meretNUD.ValueChanged += new System.EventHandler(this.meretNUD_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(515, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "GB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(515, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Mhz";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "* Az ár a komponensek alapján lesz kiszámolva !";
            // 
            // MemoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idozitesNUD);
            this.Controls.Add(this.generacioCB);
            this.Controls.Add(this.orajelNUD);
            this.Controls.Add(this.meretNUD);
            this.Name = "MemoriaForm";
            this.Text = "MemoriaForm";
            this.Controls.SetChildIndex(this.tipusTB, 0);
            this.Controls.SetChildIndex(this.arNUD, 0);
            this.Controls.SetChildIndex(this.garanciaNUD, 0);
            this.Controls.SetChildIndex(this.cimLabel, 0);
            this.Controls.SetChildIndex(this.gyartoCB, 0);
            this.Controls.SetChildIndex(this.meretNUD, 0);
            this.Controls.SetChildIndex(this.orajelNUD, 0);
            this.Controls.SetChildIndex(this.generacioCB, 0);
            this.Controls.SetChildIndex(this.idozitesNUD, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idozitesNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orajelNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meretNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown idozitesNUD;
        private System.Windows.Forms.ComboBox generacioCB;
        private System.Windows.Forms.NumericUpDown orajelNUD;
        private System.Windows.Forms.NumericUpDown meretNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}