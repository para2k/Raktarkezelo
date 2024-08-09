namespace ProOktatasVizsgaFeladat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.raktarMegnyitasGomb = new System.Windows.Forms.Button();
            this.alkatreszHozzaadasGomb = new System.Windows.Forms.Button();
            this.alkatreszCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.raktarSzamaCB = new System.Windows.Forms.ComboBox();
            this.alkatreszekLB = new System.Windows.Forms.ListBox();
            this.alkatreszModositasGomb = new System.Windows.Forms.Button();
            this.alkatreszTorlesGomb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.csvBeolvasasPB = new System.Windows.Forms.PictureBox();
            this.sqlPB = new System.Windows.Forms.PictureBox();
            this.sqlCsatlakozasLabel = new System.Windows.Forms.Label();
            this.csvBetoltesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.csvBeolvasasPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raktár száma:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raktárok kezelése";
            // 
            // raktarMegnyitasGomb
            // 
            this.raktarMegnyitasGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raktarMegnyitasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raktarMegnyitasGomb.Location = new System.Drawing.Point(39, 117);
            this.raktarMegnyitasGomb.Name = "raktarMegnyitasGomb";
            this.raktarMegnyitasGomb.Size = new System.Drawing.Size(274, 49);
            this.raktarMegnyitasGomb.TabIndex = 3;
            this.raktarMegnyitasGomb.Text = "Megnyitás";
            this.raktarMegnyitasGomb.UseVisualStyleBackColor = true;
            this.raktarMegnyitasGomb.Click += new System.EventHandler(this.raktarMegnyitasGomb_Click);
            // 
            // alkatreszHozzaadasGomb
            // 
            this.alkatreszHozzaadasGomb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alkatreszHozzaadasGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alkatreszHozzaadasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alkatreszHozzaadasGomb.Location = new System.Drawing.Point(632, 267);
            this.alkatreszHozzaadasGomb.Name = "alkatreszHozzaadasGomb";
            this.alkatreszHozzaadasGomb.Size = new System.Drawing.Size(274, 49);
            this.alkatreszHozzaadasGomb.TabIndex = 4;
            this.alkatreszHozzaadasGomb.Text = "Alkatrész hozzáadása";
            this.alkatreszHozzaadasGomb.UseVisualStyleBackColor = true;
            this.alkatreszHozzaadasGomb.Click += new System.EventHandler(this.alkatreszHozzaadasGomb_Click);
            // 
            // alkatreszCB
            // 
            this.alkatreszCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alkatreszCB.FormattingEnabled = true;
            this.alkatreszCB.Location = new System.Drawing.Point(633, 219);
            this.alkatreszCB.Margin = new System.Windows.Forms.Padding(4);
            this.alkatreszCB.Name = "alkatreszCB";
            this.alkatreszCB.Size = new System.Drawing.Size(273, 24);
            this.alkatreszCB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(630, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alkatrész típusa:";
            // 
            // raktarSzamaCB
            // 
            this.raktarSzamaCB.FormattingEnabled = true;
            this.raktarSzamaCB.Location = new System.Drawing.Point(149, 78);
            this.raktarSzamaCB.Name = "raktarSzamaCB";
            this.raktarSzamaCB.Size = new System.Drawing.Size(60, 24);
            this.raktarSzamaCB.TabIndex = 7;
            // 
            // alkatreszekLB
            // 
            this.alkatreszekLB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.alkatreszekLB.ForeColor = System.Drawing.Color.White;
            this.alkatreszekLB.FormattingEnabled = true;
            this.alkatreszekLB.ItemHeight = 16;
            this.alkatreszekLB.Location = new System.Drawing.Point(39, 199);
            this.alkatreszekLB.Name = "alkatreszekLB";
            this.alkatreszekLB.Size = new System.Drawing.Size(569, 340);
            this.alkatreszekLB.TabIndex = 8;
            // 
            // alkatreszModositasGomb
            // 
            this.alkatreszModositasGomb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alkatreszModositasGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alkatreszModositasGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alkatreszModositasGomb.Location = new System.Drawing.Point(632, 333);
            this.alkatreszModositasGomb.Name = "alkatreszModositasGomb";
            this.alkatreszModositasGomb.Size = new System.Drawing.Size(274, 49);
            this.alkatreszModositasGomb.TabIndex = 9;
            this.alkatreszModositasGomb.Text = "Alkatrész módosítása";
            this.alkatreszModositasGomb.UseVisualStyleBackColor = true;
            this.alkatreszModositasGomb.Click += new System.EventHandler(this.alkatreszModositasGomb_Click);
            // 
            // alkatreszTorlesGomb
            // 
            this.alkatreszTorlesGomb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alkatreszTorlesGomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alkatreszTorlesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alkatreszTorlesGomb.Location = new System.Drawing.Point(632, 399);
            this.alkatreszTorlesGomb.Name = "alkatreszTorlesGomb";
            this.alkatreszTorlesGomb.Size = new System.Drawing.Size(274, 49);
            this.alkatreszTorlesGomb.TabIndex = 10;
            this.alkatreszTorlesGomb.Text = "Alkatrész törlése";
            this.alkatreszTorlesGomb.UseVisualStyleBackColor = true;
            this.alkatreszTorlesGomb.Click += new System.EventHandler(this.alkatreszTorlesGomb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Összes elérhető alkatrész:";
            // 
            // csvBeolvasasPB
            // 
            this.csvBeolvasasPB.Image = ((System.Drawing.Image)(resources.GetObject("csvBeolvasasPB.Image")));
            this.csvBeolvasasPB.Location = new System.Drawing.Point(842, 17);
            this.csvBeolvasasPB.Name = "csvBeolvasasPB";
            this.csvBeolvasasPB.Size = new System.Drawing.Size(80, 80);
            this.csvBeolvasasPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.csvBeolvasasPB.TabIndex = 12;
            this.csvBeolvasasPB.TabStop = false;
            this.csvBeolvasasPB.DoubleClick += new System.EventHandler(this.csvBeolvasasPB_DoubleClick);
            this.csvBeolvasasPB.MouseEnter += new System.EventHandler(this.csvBeolvasasPB_MouseEnter);
            this.csvBeolvasasPB.MouseLeave += new System.EventHandler(this.csvBeolvasasPB_MouseLeave);
            // 
            // sqlPB
            // 
            this.sqlPB.Image = ((System.Drawing.Image)(resources.GetObject("sqlPB.Image")));
            this.sqlPB.Location = new System.Drawing.Point(661, 17);
            this.sqlPB.Name = "sqlPB";
            this.sqlPB.Size = new System.Drawing.Size(80, 80);
            this.sqlPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sqlPB.TabIndex = 13;
            this.sqlPB.TabStop = false;
            this.sqlPB.DoubleClick += new System.EventHandler(this.sqlCsatlakozasLabel_DoubleClick);
            this.sqlPB.MouseEnter += new System.EventHandler(this.sqlPB_MouseEnter);
            this.sqlPB.MouseLeave += new System.EventHandler(this.sqlPB_MouseLeave);
            // 
            // sqlCsatlakozasLabel
            // 
            this.sqlCsatlakozasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlCsatlakozasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlCsatlakozasLabel.Location = new System.Drawing.Point(640, 108);
            this.sqlCsatlakozasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sqlCsatlakozasLabel.Name = "sqlCsatlakozasLabel";
            this.sqlCsatlakozasLabel.Size = new System.Drawing.Size(121, 48);
            this.sqlCsatlakozasLabel.TabIndex = 14;
            this.sqlCsatlakozasLabel.Text = "Csatlakozás SQL-hez";
            this.sqlCsatlakozasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sqlCsatlakozasLabel.DoubleClick += new System.EventHandler(this.sqlCsatlakozasLabel_DoubleClick);
            this.sqlCsatlakozasLabel.MouseEnter += new System.EventHandler(this.sqlPB_MouseEnter);
            this.sqlCsatlakozasLabel.MouseLeave += new System.EventHandler(this.sqlPB_MouseLeave);
            // 
            // csvBetoltesLabel
            // 
            this.csvBetoltesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csvBetoltesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvBetoltesLabel.Location = new System.Drawing.Point(801, 108);
            this.csvBetoltesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.csvBetoltesLabel.Name = "csvBetoltesLabel";
            this.csvBetoltesLabel.Size = new System.Drawing.Size(166, 58);
            this.csvBetoltesLabel.TabIndex = 15;
            this.csvBetoltesLabel.Text = "Alkatrész betöltése CSV-ből";
            this.csvBetoltesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.csvBetoltesLabel.DoubleClick += new System.EventHandler(this.csvBeolvasasPB_DoubleClick);
            this.csvBetoltesLabel.MouseEnter += new System.EventHandler(this.csvBeolvasasPB_MouseEnter);
            this.csvBetoltesLabel.MouseLeave += new System.EventHandler(this.csvBeolvasasPB_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(980, 557);
            this.Controls.Add(this.csvBetoltesLabel);
            this.Controls.Add(this.sqlCsatlakozasLabel);
            this.Controls.Add(this.sqlPB);
            this.Controls.Add(this.csvBeolvasasPB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alkatreszTorlesGomb);
            this.Controls.Add(this.alkatreszModositasGomb);
            this.Controls.Add(this.alkatreszekLB);
            this.Controls.Add(this.raktarSzamaCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alkatreszCB);
            this.Controls.Add(this.alkatreszHozzaadasGomb);
            this.Controls.Add(this.raktarMegnyitasGomb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Raktár Menedzser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.csvBeolvasasPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button raktarMegnyitasGomb;
        private System.Windows.Forms.Button alkatreszHozzaadasGomb;
        private System.Windows.Forms.ComboBox alkatreszCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox raktarSzamaCB;
        private System.Windows.Forms.ListBox alkatreszekLB;
        private System.Windows.Forms.Button alkatreszModositasGomb;
        private System.Windows.Forms.Button alkatreszTorlesGomb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox csvBeolvasasPB;
        private System.Windows.Forms.PictureBox sqlPB;
        private System.Windows.Forms.Label sqlCsatlakozasLabel;
        private System.Windows.Forms.Label csvBetoltesLabel;
    }
}

