﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegaJuego
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void PantallaInicio_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void checkSonido_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Level1 Level1 = new Level1(checkSonido);
            Level1.Show();
        }
    }
}
