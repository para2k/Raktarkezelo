namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    partial class ProcesszorForm
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
            this.magszamNUD = new System.Windows.Forms.NumericUpDown();
            this.tokozasCB = new System.Windows.Forms.ComboBox();
            this.l3cacheNUD = new System.Windows.Forms.NumericUpDown();
            this.orajelNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magszamNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3cacheNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orajelNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // gyartoCB
            // 
            this.gyartoCB.Size = new System.Drawing.Size(164, 24);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Magszám:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tokozása:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "L3Cache Mérete:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Órajele:";
            // 
            // magszamNUD
            // 
            this.magszamNUD.BackColor = System.Drawing.Color.Firebrick;
            this.magszamNUD.ForeColor = System.Drawing.Color.White;
            this.magszamNUD.Location = new System.Drawing.Point(316, 250);
            this.magszamNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.magszamNUD.Name = "magszamNUD";
            this.magszamNUD.Size = new System.Drawing.Size(174, 22);
            this.magszamNUD.TabIndex = 25;
            this.magszamNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.magszamNUD.ValueChanged += new System.EventHandler(this.magszamNUD_ValueChanged);
            // 
            // tokozasCB
            // 
            this.tokozasCB.BackColor = System.Drawing.Color.MidnightBlue;
            this.tokozasCB.ForeColor = System.Drawing.Color.White;
            this.tokozasCB.FormattingEnabled = true;
            this.tokozasCB.Location = new System.Drawing.Point(316, 86);
            this.tokozasCB.Name = "tokozasCB";
            this.tokozasCB.Size = new System.Drawing.Size(174, 24);
            this.tokozasCB.TabIndex = 24;
            this.tokozasCB.SelectedIndexChanged += new System.EventHandler(this.tokozasCB_SelectedIndexChanged);
            // 
            // l3cacheNUD
            // 
            this.l3cacheNUD.BackColor = System.Drawing.Color.Firebrick;
            this.l3cacheNUD.ForeColor = System.Drawing.Color.White;
            this.l3cacheNUD.Location = new System.Drawing.Point(316, 195);
            this.l3cacheNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.l3cacheNUD.Name = "l3cacheNUD";
            this.l3cacheNUD.Size = new System.Drawing.Size(174, 22);
            this.l3cacheNUD.TabIndex = 23;
            this.l3cacheNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3cacheNUD.ValueChanged += new System.EventHandler(this.l3cacheNUD_ValueChanged);
            // 
            // orajelNUD
            // 
            this.orajelNUD.BackColor = System.Drawing.Color.Firebrick;
            this.orajelNUD.ForeColor = System.Drawing.Color.White;
            this.orajelNUD.Location = new System.Drawing.Point(316, 139);
            this.orajelNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.orajelNUD.Name = "orajelNUD";
            this.orajelNUD.Size = new System.Drawing.Size(174, 22);
            this.orajelNUD.TabIndex = 22;
            this.orajelNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orajelNUD.ValueChanged += new System.EventHandler(this.orajelNUD_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Mhz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "MB";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(496, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "db";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(297, 16);
            this.label14.TabIndex = 33;
            this.label14.Text = "* Az ár a komponensek alapján lesz kiszámolva !";
            // 
            // ProcesszorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.magszamNUD);
            this.Controls.Add(this.tokozasCB);
            this.Controls.Add(this.l3cacheNUD);
            this.Controls.Add(this.orajelNUD);
            this.Name = "ProcesszorForm";
            this.Text = "ProcesszorForm";
            this.Controls.SetChildIndex(this.gyartoCB, 0);
            this.Controls.SetChildIndex(this.tipusTB, 0);
            this.Controls.SetChildIndex(this.arNUD, 0);
            this.Controls.SetChildIndex(this.garanciaNUD, 0);
            this.Controls.SetChildIndex(this.cimLabel, 0);
            this.Controls.SetChildIndex(this.orajelNUD, 0);
            this.Controls.SetChildIndex(this.l3cacheNUD, 0);
            this.Controls.SetChildIndex(this.tokozasCB, 0);
            this.Controls.SetChildIndex(this.magszamNUD, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magszamNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3cacheNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orajelNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown magszamNUD;
        private System.Windows.Forms.ComboBox tokozasCB;
        private System.Windows.Forms.NumericUpDown l3cacheNUD;
        private System.Windows.Forms.NumericUpDown orajelNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}