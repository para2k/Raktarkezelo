namespace ProOktatasVizsgaFeladat.Forms
{
    partial class AlkatreszRaktarkezeloForm
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
            this.osszesAlkatreszCB = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.kerdesLabel = new System.Windows.Forms.Label();
            this.dinamikusGomb = new System.Windows.Forms.Button();
            this.cimLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.darabszamRaktarbanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // osszesAlkatreszCB
            // 
            this.osszesAlkatreszCB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.osszesAlkatreszCB.ForeColor = System.Drawing.Color.White;
            this.osszesAlkatreszCB.FormattingEnabled = true;
            this.osszesAlkatreszCB.Location = new System.Drawing.Point(17, 85);
            this.osszesAlkatreszCB.Margin = new System.Windows.Forms.Padding(4);
            this.osszesAlkatreszCB.Name = "osszesAlkatreszCB";
            this.osszesAlkatreszCB.Size = new System.Drawing.Size(284, 24);
            this.osszesAlkatreszCB.TabIndex = 0;
            this.osszesAlkatreszCB.SelectedIndexChanged += new System.EventHandler(this.osszesAlkatreszCB_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(103, 170);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Összes alkatrész:";
            // 
            // kerdesLabel
            // 
            this.kerdesLabel.AutoSize = true;
            this.kerdesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kerdesLabel.Location = new System.Drawing.Point(14, 137);
            this.kerdesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kerdesLabel.Name = "kerdesLabel";
            this.kerdesLabel.Size = new System.Drawing.Size(287, 16);
            this.kerdesLabel.TabIndex = 3;
            this.kerdesLabel.Text = "Hány darabot szeretne a raktárhoz adni?";
            // 
            // dinamikusGomb
            // 
            this.dinamikusGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinamikusGomb.Location = new System.Drawing.Point(59, 288);
            this.dinamikusGomb.Name = "dinamikusGomb";
            this.dinamikusGomb.Size = new System.Drawing.Size(187, 46);
            this.dinamikusGomb.TabIndex = 4;
            this.dinamikusGomb.Text = "[dinamikus]";
            this.dinamikusGomb.UseVisualStyleBackColor = true;
            this.dinamikusGomb.Click += new System.EventHandler(this.dinamikusGomb_Click);
            // 
            // cimLabel
            // 
            this.cimLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cimLabel.AutoSize = true;
            this.cimLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cimLabel.Location = new System.Drawing.Point(114, 9);
            this.cimLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cimLabel.Name = "cimLabel";
            this.cimLabel.Size = new System.Drawing.Size(89, 18);
            this.cimLabel.TabIndex = 5;
            this.cimLabel.Text = "[dinamikus]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aktuális darabszáma a raktárban:";
            // 
            // darabszamRaktarbanLabel
            // 
            this.darabszamRaktarbanLabel.AutoSize = true;
            this.darabszamRaktarbanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darabszamRaktarbanLabel.ForeColor = System.Drawing.Color.White;
            this.darabszamRaktarbanLabel.Location = new System.Drawing.Point(114, 240);
            this.darabszamRaktarbanLabel.Name = "darabszamRaktarbanLabel";
            this.darabszamRaktarbanLabel.Size = new System.Drawing.Size(79, 18);
            this.darabszamRaktarbanLabel.TabIndex = 8;
            this.darabszamRaktarbanLabel.Text = "[mennyidb]";
            // 
            // AlkatreszRaktarkezeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(318, 365);
            this.Controls.Add(this.darabszamRaktarbanLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cimLabel);
            this.Controls.Add(this.dinamikusGomb);
            this.Controls.Add(this.kerdesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.osszesAlkatreszCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlkatreszRaktarkezeloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktárhoz hozzáadás";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox osszesAlkatreszCB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kerdesLabel;
        private System.Windows.Forms.Button dinamikusGomb;
        private System.Windows.Forms.Label cimLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label darabszamRaktarbanLabel;
    }
}