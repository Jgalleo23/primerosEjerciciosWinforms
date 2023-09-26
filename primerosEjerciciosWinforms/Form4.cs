using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace primerosEjerciciosWinforms
{
    public partial class formPalabrasLetras : Form
    {
        public formPalabrasLetras()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void btContar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            String a = txtPalabra.Text;
            Char b = txtLetra.Text[0];


            foreach (char c in a)
            {
                if (c == b)
                    contador++;
            }
            lbResultado.Text = contador.ToString();
        }
    }
}
