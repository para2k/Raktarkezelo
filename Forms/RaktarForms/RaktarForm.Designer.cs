namespace ProOktatasVizsgaFeladat
{
    partial class RaktarForm
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
            this.raktarLB = new System.Windows.Forms.ListBox();
            this.alkatreszHozzaadasGomb = new System.Windows.Forms.Button();
            this.alkatreszTorlesGomb = new System.Windows.Forms.Button();
            this.raktarOsszertekGomb = new System.Windows.Forms.Button();
            this.raktarNeveLabel = new System.Windows.Forms.Label();
            this.szuresTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minArNUD = new System.Windows.Forms.NumericUpDown();
            this.maxArNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.szuresArAlapjanGomb = new System.Windows.Forms.Button();
            this.visszaallitasGomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minArNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxArNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // raktarLB
            // 
            this.raktarLB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.raktarLB.ForeColor = System.Drawing.Color.White;
            this.raktarLB.FormattingEnabled = true;
            this.raktarLB.ItemHeight = 16;
            this.raktarLB.Location = new System.Drawing.Point(13, 129);
            this.raktarLB.Margin = new System.Windows.Forms.Padding(4);
            this.raktarLB.Name = "raktarLB";
            this.raktarLB.Size = new System.Drawing.Size(591, 420);
            this.raktarLB.TabIndex = 0;
            this.raktarLB.DoubleClick += new System.EventHandler(this.raktarLB_DoubleClick);
            // 
            // alkatreszHozzaadasGomb
            // 
            this.alkatreszHozzaadasGomb.BackColor = System.Drawing.Color.SteelBlue;
            this.alkatreszHozzaadasGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alkatreszHozzaadasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alkatreszHozzaadasGomb.Location = new System.Drawing.Point(622, 167);
            this.alkatreszHozzaadasGomb.Name = "alkatreszHozzaadasGomb";
            this.alkatreszHozzaadasGomb.Size = new System.Drawing.Size(133, 88);
            this.alkatreszHozzaadasGomb.TabIndex = 1;
            this.alkatreszHozzaadasGomb.Text = "Alkatrész hozzáadása raktárhoz";
            this.alkatreszHozzaadasGomb.UseVisualStyleBackColor = false;
            this.alkatreszHozzaadasGomb.Click += new System.EventHandler(this.alkatreszHozzaadasGomb_Click);
            // 
            // alkatreszTorlesGomb
            // 
            this.alkatreszTorlesGomb.BackColor = System.Drawing.Color.SteelBlue;
            this.alkatreszTorlesGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alkatreszTorlesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alkatreszTorlesGomb.Location = new System.Drawing.Point(622, 261);
            this.alkatreszTorlesGomb.Name = "alkatreszTorlesGomb";
            this.alkatreszTorlesGomb.Size = new System.Drawing.Size(133, 88);
            this.alkatreszTorlesGomb.TabIndex = 2;
            this.alkatreszTorlesGomb.Text = "Alkatrész törlése raktárból";
            this.alkatreszTorlesGomb.UseVisualStyleBackColor = false;
            this.alkatreszTorlesGomb.Click += new System.EventHandler(this.alkatreszTorlesGomb_Click);
            // 
            // raktarOsszertekGomb
            // 
            this.raktarOsszertekGomb.BackColor = System.Drawing.Color.SteelBlue;
            this.raktarOsszertekGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raktarOsszertekGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raktarOsszertekGomb.Location = new System.Drawing.Point(622, 355);
            this.raktarOsszertekGomb.Name = "raktarOsszertekGomb";
            this.raktarOsszertekGomb.Size = new System.Drawing.Size(133, 88);
            this.raktarOsszertekGomb.TabIndex = 3;
            this.raktarOsszertekGomb.Text = "Raktár összértéke";
            this.raktarOsszertekGomb.UseVisualStyleBackColor = false;
            this.raktarOsszertekGomb.Click += new System.EventHandler(this.raktarOsszertekGomb_Click);
            // 
            // raktarNeveLabel
            // 
            this.raktarNeveLabel.AutoSize = true;
            this.raktarNeveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raktarNeveLabel.Location = new System.Drawing.Point(341, 26);
            this.raktarNeveLabel.Name = "raktarNeveLabel";
            this.raktarNeveLabel.Size = new System.Drawing.Size(82, 16);
            this.raktarNeveLabel.TabIndex = 4;
            this.raktarNeveLabel.Text = "[raktarnev]";
            // 
            // szuresTB
            // 
            this.szuresTB.Location = new System.Drawing.Point(170, 97);
            this.szuresTB.Name = "szuresTB";
            this.szuresTB.Size = new System.Drawing.Size(197, 22);
            this.szuresTB.TabIndex = 5;
            this.szuresTB.TextChanged += new System.EventHandler(this.szuresTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Raktárelem szűrése:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Raktár tartalma:";
            // 
            // minArNUD
            // 
            this.minArNUD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.minArNUD.ForeColor = System.Drawing.Color.White;
            this.minArNUD.Location = new System.Drawing.Point(484, 73);
            this.minArNUD.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.minArNUD.Name = "minArNUD";
            this.minArNUD.Size = new System.Drawing.Size(120, 22);
            this.minArNUD.TabIndex = 10;
            this.minArNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxArNUD
            // 
            this.maxArNUD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.maxArNUD.ForeColor = System.Drawing.Color.White;
            this.maxArNUD.Location = new System.Drawing.Point(484, 101);
            this.maxArNUD.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.maxArNUD.Name = "maxArNUD";
            this.maxArNUD.Size = new System.Drawing.Size(120, 22);
            this.maxArNUD.TabIndex = 11;
            this.maxArNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minimum ár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Maximum ár:";
            // 
            // szuresArAlapjanGomb
            // 
            this.szuresArAlapjanGomb.BackColor = System.Drawing.Color.SteelBlue;
            this.szuresArAlapjanGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.szuresArAlapjanGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.szuresArAlapjanGomb.Location = new System.Drawing.Point(622, 73);
            this.szuresArAlapjanGomb.Name = "szuresArAlapjanGomb";
            this.szuresArAlapjanGomb.Size = new System.Drawing.Size(133, 88);
            this.szuresArAlapjanGomb.TabIndex = 14;
            this.szuresArAlapjanGomb.Text = "Szűrés minimum és maximum alapján";
            this.szuresArAlapjanGomb.UseVisualStyleBackColor = false;
            this.szuresArAlapjanGomb.Click += new System.EventHandler(this.szuresArAlapjanGomb_Click);
            // 
            // visszaallitasGomb
            // 
            this.visszaallitasGomb.BackColor = System.Drawing.Color.SteelBlue;
            this.visszaallitasGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visszaallitasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visszaallitasGomb.Location = new System.Drawing.Point(622, 449);
            this.visszaallitasGomb.Name = "visszaallitasGomb";
            this.visszaallitasGomb.Size = new System.Drawing.Size(133, 88);
            this.visszaallitasGomb.TabIndex = 15;
            this.visszaallitasGomb.Text = "Eredeti raktár visszaállítása";
            this.visszaallitasGomb.UseVisualStyleBackColor = false;
            this.visszaallitasGomb.Click += new System.EventHandler(this.visszaallitasGomb_Click);
            // 
            // RaktarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.visszaallitasGomb);
            this.Controls.Add(this.szuresArAlapjanGomb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxArNUD);
            this.Controls.Add(this.minArNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szuresTB);
            this.Controls.Add(this.raktarNeveLabel);
            this.Controls.Add(this.raktarOsszertekGomb);
            this.Controls.Add(this.alkatreszTorlesGomb);
            this.Controls.Add(this.alkatreszHozzaadasGomb);
            this.Controls.Add(this.raktarLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RaktarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raktárkezelő";
            ((System.ComponentModel.ISupportInitialize)(this.minArNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxArNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox raktarLB;
        private System.Windows.Forms.Button alkatreszHozzaadasGomb;
        private System.Windows.Forms.Button alkatreszTorlesGomb;
        private System.Windows.Forms.Button raktarOsszertekGomb;
        private System.Windows.Forms.Label raktarNeveLabel;
        private System.Windows.Forms.TextBox szuresTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown minArNUD;
        private System.Windows.Forms.NumericUpDown maxArNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button szuresArAlapjanGomb;
        private System.Windows.Forms.Button visszaallitasGomb;
    }
}