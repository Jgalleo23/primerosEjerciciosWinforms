namespace primerosEjerciciosWinforms
{
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Hide();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}