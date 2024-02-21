using System.Media;
using System.Xml;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link player;
        Broncas Enemigo1;
        SoundPlayer Musica;
        Boolean HaySonido=false;
        public Level1(CheckBox onOff)
        {
            InitializeComponent();
            IniciarPersonajes();
            InicarOpcionesDelMapa(onOff);
        }
        private void IniciarPersonajes()
        {
            player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }

        private void Level1_Load(object sender, EventArgs e)
        {

        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            player.mover(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemigo1.mover();
        }

        private void InicarOpcionesDelMapa(CheckBox onOff)
        {

            if(onOff.Checked==true)
            {
                Musica = new SoundPlayer(global::VegaJuego.Properties.Resources.sonido);
                Musica.PlayLooping();
                HaySonido = true;
            }

            LabelVida.Text = "Salud-> " + player.Salud;
            label2Arma.Text = "Arma-> " + player.Arma;
            label3Escudo.Text = "Escudo-> "+player.Escudo;
        
        }

        private void MovEnemigos_Tick(Object sender, EventArgs e)
        {
            LabelVida.Text = "Salud-> " + player.Salud;
            label2Arma.Text = "Arma-> " + player.Arma;
            label3Escudo.Text = "Escudo-> " + player.Escudo;

            if (player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
            {
                player.Salud = player.Salud - 1;
            }
            Enemigo1.mover();

        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            LabelVida.Text = "Salud-> " + player.Salud;
            label2Arma.Text = "Arma-> " + player.Arma;
            label3Escudo.Text = "Escudo-> " + player.Escudo;

            if (player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
            {
                player.Salud = player.Salud - 1;
            }
            Enemigo1.mover();

            if (player.Salud <= 0)
            {
                this.Hide();
                if (HaySonido == true)
                {
                    Musica.Stop();
                }
                   
                Final End = new Final();
                MoverEnemigos.Stop();
                End.Show();

            }
        }

    }
}
