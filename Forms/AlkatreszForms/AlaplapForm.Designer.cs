namespace ProOktatasVizsgaFeladat.AlkatreszFormok
{
    partial class AlaplapForm
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
            this.foglalatCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chipsetCB = new System.Windows.Forms.ComboBox();
            this.rgbCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // garanciaNUD
            // 
            this.garanciaNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // gyartoCB
            // 
            this.gyartoCB.Size = new System.Drawing.Size(164, 24);
            // 
            // foglalatCB
            // 
            this.foglalatCB.BackColor = System.Drawing.Color.MidnightBlue;
            this.foglalatCB.ForeColor = System.Drawing.Color.White;
            this.foglalatCB.FormattingEnabled = true;
            this.foglalatCB.Location = new System.Drawing.Point(401, 86);
            this.foglalatCB.Name = "foglalatCB";
            this.foglalatCB.Size = new System.Drawing.Size(180, 24);
            this.foglalatCB.TabIndex = 12;
            this.foglalatCB.SelectedIndexChanged += new System.EventHandler(this.foglalatCB_SelectedIndexChanged);
            this.foglalatCB.TextChanged += new System.EventHandler(this.foglalatCB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Foglalat típusa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Chipset:";
            // 
            // chipsetCB
            // 
            this.chipsetCB.BackColor = System.Drawing.Color.MidnightBlue;
            this.chipsetCB.ForeColor = System.Drawing.Color.White;
            this.chipsetCB.FormattingEnabled = true;
            this.chipsetCB.Location = new System.Drawing.Point(401, 139);
            this.chipsetCB.Name = "chipsetCB";
            this.chipsetCB.Size = new System.Drawing.Size(180, 24);
            this.chipsetCB.TabIndex = 14;
            this.chipsetCB.SelectedIndexChanged += new System.EventHandler(this.chipsetCB_SelectedIndexChanged);
            this.chipsetCB.TextChanged += new System.EventHandler(this.chipsetCB_TextChanged);
            // 
            // rgbCheckBox
            // 
            this.rgbCheckBox.AutoSize = true;
            this.rgbCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rgbCheckBox.Location = new System.Drawing.Point(401, 191);
            this.rgbCheckBox.Name = "rgbCheckBox";
            this.rgbCheckBox.Size = new System.Drawing.Size(152, 20);
            this.rgbCheckBox.TabIndex = 16;
            this.rgbCheckBox.Text = "RGB világítás van-e?";
            this.rgbCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlaplapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.rgbCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chipsetCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.foglalatCB);
            this.Name = "AlaplapForm";
            this.Text = "AlaplapForm";
            this.Controls.SetChildIndex(this.gyartoCB, 0);
            this.Controls.SetChildIndex(this.tipusTB, 0);
            this.Controls.SetChildIndex(this.arNUD, 0);
            this.Controls.SetChildIndex(this.garanciaNUD, 0);
            this.Controls.SetChildIndex(this.cimLabel, 0);
            this.Controls.SetChildIndex(this.foglalatCB, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.chipsetCB, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.rgbCheckBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox foglalatCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox chipsetCB;
        private System.Windows.Forms.CheckBox rgbCheckBox;
    }
}