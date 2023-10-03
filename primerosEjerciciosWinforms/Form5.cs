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
    public partial class formAdivino : Form
    {

        int n1 = 0;
        int n2 = 50;
        int intentos = 0;

        public formAdivino()
        {
            InitializeComponent();
            btVolverJug.Enabled = false;
            btComprobar.Enabled = false;
            btJugar.Enabled = true;
            lbPrueba.Visible = false;
            lbAyuda.Visible = false;
            lbTextoAyuda.Visible = false;
            txtNumero.Enabled = false;

        }


        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void btJugar_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int numRandom = random.Next(n1, n2);
            lbPrueba.Text = numRandom.ToString();


            btComprobar.Enabled = true;
            btJugar.Enabled = false;
            lbAyuda.Visible = true;
            lbTextoAyuda.Visible = true;
            txtNumero.Enabled = true;
            btElegir.Enabled = false;
            txtNumPer1.Enabled = false;
            txtNumPer2.Enabled = false;
            btJugar.Visible = false;
            btVolverJug.Enabled = false;

        }

        private void btVolverJug_Click(object sender, EventArgs e)
        {
            btJugar.Enabled = true;
            btVolverJug.Enabled = false;
            txtNumPer1.Enabled = true;
            txtNumPer2.Enabled = true;
            btElegir.Enabled = true;
        }

        private void btComprobar_Click(object sender, EventArgs e)
        {

            int a = int.Parse(txtNumero.Text);
            int b = int.Parse(lbPrueba.Text);

            intentos++;
            lbContador.Text = intentos.ToString();

            if (a > b)
            {
                lbTextoAyuda.Text = "El número introducido es mayor";

            }
            else if (a < b)
            {
                lbTextoAyuda.Text = "El número introducido es menor";

            }
            else if (a == b)
            {
                lbTextoAyuda.Text = "¡Número acertado!";
                btComprobar.Enabled = false;
                btVolverJug.Enabled = true;
                txtNumero.Enabled = false;
                btJugar.Visible = true;
                btVolverJug.Visible = true;
                intentos = 0;
                lbContador.Text = "0";
            }

        }

        private void btElegir_Click(object sender, EventArgs e)
        {
            lbPruebaN1.Text = n1.ToString();
            lbPruebaN2.Text = n2.ToString();
            n1 = int.Parse(txtNumPer1.Text);
            n2 = int.Parse(txtNumPer2.Text);
        }

        private void lbNumPersonalizado_Click(object sender, EventArgs e)
        {
        }

        private void lbComa_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
