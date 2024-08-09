namespace ProOktatasVizsgaFeladat
{
    partial class BaseAlkatreszForm
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
            this.tipusTB = new System.Windows.Forms.TextBox();
            this.arNUD = new System.Windows.Forms.NumericUpDown();
            this.garanciaNUD = new System.Windows.Forms.NumericUpDown();
            this.cimLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dinamikusGomb = new System.Windows.Forms.Button();
            this.gyartoCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tipusTB
            // 
            this.tipusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tipusTB.BackColor = System.Drawing.Color.Firebrick;
            this.tipusTB.ForeColor = System.Drawing.Color.White;
            this.tipusTB.Location = new System.Drawing.Point(40, 139);
            this.tipusTB.Name = "tipusTB";
            this.tipusTB.Size = new System.Drawing.Size(164, 22);
            this.tipusTB.TabIndex = 1;
            this.tipusTB.TextChanged += new System.EventHandler(this.tipusTB_TextChanged);
            // 
            // arNUD
            // 
            this.arNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.arNUD.BackColor = System.Drawing.Color.Firebrick;
            this.arNUD.ForeColor = System.Drawing.Color.White;
            this.arNUD.Location = new System.Drawing.Point(40, 193);
            this.arNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.arNUD.Name = "arNUD";
            this.arNUD.Size = new System.Drawing.Size(164, 22);
            this.arNUD.TabIndex = 2;
            this.arNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arNUD.ValueChanged += new System.EventHandler(this.arNUD_ValueChanged);
            // 
            // garanciaNUD
            // 
            this.garanciaNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.garanciaNUD.BackColor = System.Drawing.Color.Firebrick;
            this.garanciaNUD.ForeColor = System.Drawing.Color.White;
            this.garanciaNUD.Location = new System.Drawing.Point(40, 249);
            this.garanciaNUD.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.garanciaNUD.Name = "garanciaNUD";
            this.garanciaNUD.Size = new System.Drawing.Size(164, 22);
            this.garanciaNUD.TabIndex = 3;
            this.garanciaNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.garanciaNUD.ValueChanged += new System.EventHandler(this.garanciaNUD_ValueChanged);
            // 
            // cimLabel
            // 
            this.cimLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cimLabel.AutoSize = true;
            this.cimLabel.Location = new System.Drawing.Point(247, 19);
            this.cimLabel.Name = "cimLabel";
            this.cimLabel.Size = new System.Drawing.Size(143, 16);
            this.cimLabel.TabIndex = 4;
            this.cimLabel.Text = "[Alkatresz letrehozasa]";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gyártó:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Típus:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ára:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Garancia:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "hónap";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ft";
            // 
            // dinamikusGomb
            // 
            this.dinamikusGomb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dinamikusGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinamikusGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinamikusGomb.Location = new System.Drawing.Point(177, 358);
            this.dinamikusGomb.Name = "dinamikusGomb";
            this.dinamikusGomb.Size = new System.Drawing.Size(238, 54);
            this.dinamikusGomb.TabIndex = 11;
            this.dinamikusGomb.Text = "[dinamikus]";
            this.dinamikusGomb.UseVisualStyleBackColor = true;
            this.dinamikusGomb.Click += new System.EventHandler(this.dinamikusGomb_Click);
            // 
            // gyartoCB
            // 
            this.gyartoCB.BackColor = System.Drawing.Color.MidnightBlue;
            this.gyartoCB.ForeColor = System.Drawing.Color.White;
            this.gyartoCB.FormattingEnabled = true;
            this.gyartoCB.Location = new System.Drawing.Point(40, 86);
            this.gyartoCB.Name = "gyartoCB";
            this.gyartoCB.Size = new System.Drawing.Size(164, 24);
            this.gyartoCB.TabIndex = 12;
            this.gyartoCB.SelectedIndexChanged += new System.EventHandler(this.gyartoCB_SelectedIndexChanged);
            this.gyartoCB.TextChanged += new System.EventHandler(this.gyartoCB_TextChanged);
            // 
            // BaseAlkatreszForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.gyartoCB);
            this.Controls.Add(this.dinamikusGomb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cimLabel);
            this.Controls.Add(this.garanciaNUD);
            this.Controls.Add(this.arNUD);
            this.Controls.Add(this.tipusTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseAlkatreszForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseAlkatreszForm";
            ((System.ComponentModel.ISupportInitialize)(this.arNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garanciaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dinamikusGomb;
        protected System.Windows.Forms.TextBox tipusTB;
        protected System.Windows.Forms.NumericUpDown arNUD;
        protected System.Windows.Forms.NumericUpDown garanciaNUD;
        protected System.Windows.Forms.Label cimLabel;
        protected System.Windows.Forms.ComboBox gyartoCB;
    }
}