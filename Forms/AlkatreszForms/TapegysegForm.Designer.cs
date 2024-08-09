namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    partial class TapegysegForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minosegCB = new System.Windows.Forms.ComboBox();
            this.teljesitmenyNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teljesitmenyNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // gyartoCB
            // 
            this.gyartoCB.Size = new System.Drawing.Size(164, 24);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Minősége:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Teljesítménye:";
            // 
            // minosegCB
            // 
            this.minosegCB.BackColor = System.Drawing.Color.MidnightBlue;
            this.minosegCB.ForeColor = System.Drawing.Color.White;
            this.minosegCB.FormattingEnabled = true;
            this.minosegCB.Location = new System.Drawing.Point(347, 139);
            this.minosegCB.Name = "minosegCB";
            this.minosegCB.Size = new System.Drawing.Size(174, 24);
            this.minosegCB.TabIndex = 30;
            this.minosegCB.TextChanged += new System.EventHandler(this.minosegCB_TextChanged);
            // 
            // teljesitmenyNUD
            // 
            this.teljesitmenyNUD.BackColor = System.Drawing.Color.Firebrick;
            this.teljesitmenyNUD.ForeColor = System.Drawing.Color.White;
            this.teljesitmenyNUD.Location = new System.Drawing.Point(347, 86);
            this.teljesitmenyNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.teljesitmenyNUD.Name = "teljesitmenyNUD";
            this.teljesitmenyNUD.Size = new System.Drawing.Size(174, 22);
            this.teljesitmenyNUD.TabIndex = 29;
            this.teljesitmenyNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.teljesitmenyNUD.ValueChanged += new System.EventHandler(this.teljesitmenyNUD_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Watt";
            // 
            // TapegysegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minosegCB);
            this.Controls.Add(this.teljesitmenyNUD);
            this.Name = "TapegysegForm";
            this.Text = "TapegysegForm";
            this.Controls.SetChildIndex(this.tipusTB, 0);
            this.Controls.SetChildIndex(this.arNUD, 0);
            this.Controls.SetChildIndex(this.garanciaNUD, 0);
            this.Controls.SetChildIndex(this.cimLabel, 0);
            this.Controls.SetChildIndex(this.gyartoCB, 0);
            this.Controls.SetChildIndex(this.teljesitmenyNUD, 0);
            this.Controls.SetChildIndex(this.minosegCB, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teljesitmenyNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox minosegCB;
        private System.Windows.Forms.NumericUpDown teljesitmenyNUD;
        private System.Windows.Forms.Label label8;
    }
}