using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerosEjerciciosWinforms
{
    public partial class formPantalla2 : Form
    {
        public formPantalla2()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formInicio pantallaInicio = new formInicio();
            pantallaInicio.Show();
            this.Close();
        }

        private void btCalculadora_Click(object sender, EventArgs e)
        {
            formCalculadora calculadora = new formCalculadora();
            calculadora.Show();
            this.Close();
        }

        private void btPalabras_Click(object sender, EventArgs e)
        {
            formPalabrasLetras palabrasLetras = new formPalabrasLetras();
            palabrasLetras.Show();
            this.Close();
        }

        private void btAdivino_Click(object sender, EventArgs e)
        {
            formAdivino adivino = new formAdivino();
            adivino.Show();
            this.Close();
        }
    }
}
