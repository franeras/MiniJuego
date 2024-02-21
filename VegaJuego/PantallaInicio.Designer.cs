namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            button1 = new Button();
            checkSonido = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.Boton;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(309, 393);
            button1.Name = "button1";
            button1.Size = new Size(207, 41);
            button1.TabIndex = 0;
            button1.Text = "              Comienza la aventura";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Location = new Point(575, 147);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(110, 19);
            checkSonido.TabIndex = 1;
            checkSonido.Text = "Sonido ON/OFF";
            checkSonido.UseVisualStyleBackColor = false;
            checkSonido.CheckedChanged += checkSonido_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(521, 22);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 2;
            label1.Text = "Creado por Francisco Gadea";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ZeldaLogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(521, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 95);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.LogoBueno;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 230);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoPantalla;
            ClientSize = new Size(806, 467);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(checkSonido);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FormClosed;
            Load += PantallaInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkSonido;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}