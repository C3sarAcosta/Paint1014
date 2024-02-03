namespace Paint1014
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picBoxPapel = new PictureBox();
            btnBorrador = new Button();
            btnPinncel = new Button();
            trackBarTamnioPincel = new TrackBar();
            PicBoxNegro = new PictureBox();
            picBoxColores = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)picBoxPapel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamnioPincel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxNegro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColores).BeginInit();
            SuspendLayout();
            // 
            // picBoxPapel
            // 
            picBoxPapel.BackColor = Color.White;
            picBoxPapel.Location = new Point(168, 12);
            picBoxPapel.Name = "picBoxPapel";
            picBoxPapel.Size = new Size(1166, 632);
            picBoxPapel.TabIndex = 0;
            picBoxPapel.TabStop = false;
            picBoxPapel.MouseDown += picBoxPapel_MouseDown;
            picBoxPapel.MouseMove += picBoxPapel_MouseMove;
            picBoxPapel.MouseUp += picBoxPapel_MouseUp;
            // 
            // btnBorrador
            // 
            btnBorrador.Location = new Point(12, 12);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(94, 29);
            btnBorrador.TabIndex = 1;
            btnBorrador.Text = "Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // btnPinncel
            // 
            btnPinncel.Location = new Point(12, 47);
            btnPinncel.Name = "btnPinncel";
            btnPinncel.Size = new Size(94, 29);
            btnPinncel.TabIndex = 2;
            btnPinncel.Text = "Pincel";
            btnPinncel.UseVisualStyleBackColor = true;
            btnPinncel.Click += btnPinncel_Click;
            // 
            // trackBarTamnioPincel
            // 
            trackBarTamnioPincel.Location = new Point(12, 92);
            trackBarTamnioPincel.Maximum = 20;
            trackBarTamnioPincel.Minimum = 1;
            trackBarTamnioPincel.Name = "trackBarTamnioPincel";
            trackBarTamnioPincel.Orientation = Orientation.Vertical;
            trackBarTamnioPincel.Size = new Size(56, 212);
            trackBarTamnioPincel.TabIndex = 3;
            trackBarTamnioPincel.Value = 3;
            // 
            // PicBoxNegro
            // 
            PicBoxNegro.BackColor = Color.Black;
            PicBoxNegro.Location = new Point(12, 310);
            PicBoxNegro.Name = "PicBoxNegro";
            PicBoxNegro.Size = new Size(26, 29);
            PicBoxNegro.TabIndex = 4;
            PicBoxNegro.TabStop = false;
            PicBoxNegro.Click += PicBoxNegro_Click;
            // 
            // picBoxColores
            // 
            picBoxColores.BackColor = Color.IndianRed;
            picBoxColores.Location = new Point(44, 310);
            picBoxColores.Name = "picBoxColores";
            picBoxColores.Size = new Size(26, 29);
            picBoxColores.TabIndex = 5;
            picBoxColores.TabStop = false;
            picBoxColores.Click += picBoxColores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 353);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 6;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 383);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 7;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 416);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // txtR
            // 
            txtR.Location = new Point(36, 350);
            txtR.Name = "txtR";
            txtR.Size = new Size(59, 27);
            txtR.TabIndex = 9;
            txtR.Text = "0";
            // 
            // txtG
            // 
            txtG.Location = new Point(36, 383);
            txtG.Name = "txtG";
            txtG.Size = new Size(59, 27);
            txtG.TabIndex = 10;
            txtG.Text = "0";
            // 
            // txtB
            // 
            txtB.Location = new Point(36, 416);
            txtB.Name = "txtB";
            txtB.Size = new Size(59, 27);
            txtB.TabIndex = 11;
            txtB.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 656);
            Controls.Add(txtB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picBoxColores);
            Controls.Add(PicBoxNegro);
            Controls.Add(trackBarTamnioPincel);
            Controls.Add(btnPinncel);
            Controls.Add(btnBorrador);
            Controls.Add(picBoxPapel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBoxPapel).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTamnioPincel).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBoxNegro).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxPapel;
        private Button btnBorrador;
        private Button btnPinncel;
        private TrackBar trackBarTamnioPincel;
        private PictureBox PicBoxNegro;
        private PictureBox picBoxColores;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private ColorDialog colorDialog1;
    }
}