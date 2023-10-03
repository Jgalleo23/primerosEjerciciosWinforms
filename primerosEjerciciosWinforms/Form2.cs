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

        private void btPalabrasCombo_Click(object sender, EventArgs e)
        {
            formSeleccionPalabras seleccionPalabras = new formSeleccionPalabras();
            seleccionPalabras.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMetodoPago metodoPago = new formMetodoPago();
            metodoPago.Show();
            this.Close();
        }

        private void btCalcular2_Click(object sender, EventArgs e)
        {
            formCalcular2 calcular2 = new formCalcular2();
            calcular2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formTienda tienda = new formTienda();
            tienda.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            formEmpresa empresa = new formEmpresa();
            empresa.Show();
            this.Close();
        }

        private void btSuperTienda_Click(object sender, EventArgs e)
        {
            formSuperTienda superTienda = new formSuperTienda();
            superTienda.Show();
            this.Close();
        }

        private void btEncuesta_Click(object sender, EventArgs e)
        {
            formEncuesta encuesta = new formEncuesta();
            encuesta.Show();
            this.Close();
        }

        private void btPalabrasContando_Click(object sender, EventArgs e)
        {
            formEjercicio12 ejercicio12 = new formEjercicio12();
            ejercicio12.Show();
            this.Close();
        }
    }
}
