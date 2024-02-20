using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace VegaJuego
{
    internal class Personaje
    {
        private int cordX;
        private int cordY;
        private Level1 lienzo;
        private PictureBox caja = new PictureBox();
        private String direccion;

        public Personaje(Level1 VegaZelda, int x, int y)
        {
            cordX = x;
            cordY = y;
            lienzo = VegaZelda;
            direccion = "Derecha";
            caja.Location = new System.Drawing.Point(cordX, CordY);
            caja.BackColor = System.Drawing.Color.Transparent;
            caja.Size = new System.Drawing.Size(110, 110);
            caja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            caja.BackgroundImage = global::VegaJuego.Properties.Resources.derecha;

            VegaZelda.Controls.Add(caja); caja.Visible = true;
        }

        public int CordX
        {
            get { return cordX; }
            set { cordX = value; }
        }

        public int CordY
        {
            get { return cordY; }
            set { cordY = value; }
        }

        public Level1 Lienzo
        {
            get { return lienzo; }
            set { lienzo = value; }
        }

        public PictureBox Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public void mover()
        {

        }
    }
}
