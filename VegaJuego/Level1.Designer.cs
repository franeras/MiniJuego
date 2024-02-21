namespace VegaJuego
{
    partial class Level1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            MoverEnemigos = new System.Windows.Forms.Timer(components);
            LabelVida = new Label();
            pictureBox1 = new PictureBox();
            label3Escudo = new Label();
            label2Arma = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // MoverEnemigos
            // 
            MoverEnemigos.Enabled = true;
            MoverEnemigos.Tick += timer1_Tick;
            // 
            // LabelVida
            // 
            LabelVida.AutoSize = true;
            LabelVida.BackColor = Color.Transparent;
            LabelVida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelVida.ForeColor = Color.Gold;
            LabelVida.Location = new Point(362, 30);
            LabelVida.Name = "LabelVida";
            LabelVida.Size = new Size(41, 21);
            LabelVida.TabIndex = 0;
            LabelVida.Text = "Vida";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salud;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(313, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3Escudo
            // 
            label3Escudo.AutoSize = true;
            label3Escudo.BackColor = Color.Transparent;
            label3Escudo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3Escudo.ForeColor = Color.Gold;
            label3Escudo.Location = new Point(509, 30);
            label3Escudo.Name = "label3Escudo";
            label3Escudo.Size = new Size(59, 21);
            label3Escudo.TabIndex = 2;
            label3Escudo.Text = "Escudo";
            // 
            // label2Arma
            // 
            label2Arma.AutoSize = true;
            label2Arma.BackColor = Color.Transparent;
            label2Arma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2Arma.ForeColor = Color.Gold;
            label2Arma.Location = new Point(666, 30);
            label2Arma.Name = "label2Arma";
            label2Arma.Size = new Size(48, 21);
            label2Arma.TabIndex = 3;
            label2Arma.Text = "Arma";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.escudo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(460, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 39);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Arma;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(617, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 39);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Level1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoFinal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 467);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2Arma);
            Controls.Add(label3Escudo);
            Controls.Add(pictureBox1);
            Controls.Add(LabelVida);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Level1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VegaZelda";
            Load += Level1_Load;
            KeyPress += Level1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MoverEnemigos;
        private Label LabelVida;
        private PictureBox pictureBox1;
        private Label label3Escudo;
        private Label label2Arma;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
