namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link player;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }
        private void IniciarPersonajes()
        {
            player = new Link(this, 0, 0, 30, 0, 0);
        }

        private void Level1_Load(object sender, EventArgs e)
        {

        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            player.mover(e);
        }
    }
}
