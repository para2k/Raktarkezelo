namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    partial class VideokartyaForm
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
            this.memoriameretNUD = new System.Windows.Forms.NumericUpDown();
            this.magorajelNUD = new System.Windows.Forms.NumericUpDown();
            this.ramTipusCB = new System.Windows.Forms.ComboBox();
            this.raytCheckBox = new System.Windows.Forms.CheckBox();
            this.fogyasztasNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoriameretNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magorajelNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogyasztasNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // gyartoCB
            // 
            this.gyartoCB.Size = new System.Drawing.Size(164, 24);
            // 
            // memoriameretNUD
            // 
            this.memoriameretNUD.BackColor = System.Drawing.Color.Firebrick;
            this.memoriameretNUD.ForeColor = System.Drawing.Color.White;
            this.memoriameretNUD.Location = new System.Drawing.Point(351, 87);
            this.memoriameretNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.memoriameretNUD.Name = "memoriameretNUD";
            this.memoriameretNUD.Size = new System.Drawing.Size(174, 22);
            this.memoriameretNUD.TabIndex = 12;
            this.memoriameretNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.memoriameretNUD.ValueChanged += new System.EventHandler(this.memoriameretNUD_ValueChanged);
            // 
            // magorajelNUD
            // 
            this.magorajelNUD.BackColor = System.Drawing.Color.Firebrick;
            this.magorajelNUD.ForeColor = System.Drawing.Color.White;
            this.magorajelNUD.Location = new System.Drawing.Point(351, 140);
            this.magorajelNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.magorajelNUD.Name = "magorajelNUD";
            this.magorajelNUD.Size = new System.Drawing.Size(174, 22);
            this.magorajelNUD.TabIndex = 13;
            this.magorajelNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.magorajelNUD.ValueChanged += new System.EventHandler(this.magorajelNUD_ValueChanged);
            // 
            // ramTipusCB
            // 
            this.ramTipusCB.BackColor = System.Drawing.Color.MidnightBlue;
            this.ramTipusCB.ForeColor = System.Drawing.Color.White;
            this.ramTipusCB.FormattingEnabled = true;
            this.ramTipusCB.Location = new System.Drawing.Point(351, 196);
            this.ramTipusCB.Name = "ramTipusCB";
            this.ramTipusCB.Size = new System.Drawing.Size(174, 24);
            this.ramTipusCB.TabIndex = 14;
            this.ramTipusCB.TextChanged += new System.EventHandler(this.ramTipusCB_TextChanged);
            // 
            // raytCheckBox
            // 
            this.raytCheckBox.AutoSize = true;
            this.raytCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raytCheckBox.Location = new System.Drawing.Point(351, 294);
            this.raytCheckBox.Name = "raytCheckBox";
            this.raytCheckBox.Size = new System.Drawing.Size(202, 20);
            this.raytCheckBox.TabIndex = 15;
            this.raytCheckBox.Text = "Raytracing támogatás van-e?";
            this.raytCheckBox.UseVisualStyleBackColor = true;
            // 
            // fogyasztasNUD
            // 
            this.fogyasztasNUD.BackColor = System.Drawing.Color.Firebrick;
            this.fogyasztasNUD.ForeColor = System.Drawing.Color.White;
            this.fogyasztasNUD.Location = new System.Drawing.Point(351, 250);
            this.fogyasztasNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.fogyasztasNUD.Name = "fogyasztasNUD";
            this.fogyasztasNUD.Size = new System.Drawing.Size(174, 22);
            this.fogyasztasNUD.TabIndex = 16;
            this.fogyasztasNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fogyasztasNUD.ValueChanged += new System.EventHandler(this.fogyasztasNUD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Memóriamérete:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Magórajele:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "RAM típusa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fogyasztása:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(531, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Watt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(531, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "GB";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(531, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Mhz";
            // 
            // VideokartyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fogyasztasNUD);
            this.Controls.Add(this.raytCheckBox);
            this.Controls.Add(this.ramTipusCB);
            this.Controls.Add(this.magorajelNUD);
            this.Controls.Add(this.memoriameretNUD);
            this.Name = "VideokartyaForm";
            this.Text = "VideokartyaForm";
            this.Controls.SetChildIndex(this.gyartoCB, 0);
            this.Controls.SetChildIndex(this.tipusTB, 0);
            this.Controls.SetChildIndex(this.arNUD, 0);
            this.Controls.SetChildIndex(this.garanciaNUD, 0);
            this.Controls.SetChildIndex(this.cimLabel, 0);
            this.Controls.SetChildIndex(this.memoriameretNUD, 0);
            this.Controls.SetChildIndex(this.magorajelNUD, 0);
            this.Controls.SetChildIndex(this.ramTipusCB, 0);
            this.Controls.SetChildIndex(this.raytCheckBox, 0);
            this.Controls.SetChildIndex(this.fogyasztasNUD, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoriameretNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magorajelNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogyasztasNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown memoriameretNUD;
        private System.Windows.Forms.NumericUpDown magorajelNUD;
        private System.Windows.Forms.ComboBox ramTipusCB;
        private System.Windows.Forms.CheckBox raytCheckBox;
        private System.Windows.Forms.NumericUpDown fogyasztasNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}