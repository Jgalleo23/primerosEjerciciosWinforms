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
    public partial class formCalculadora : Form
    {
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int total = a + b;
            txtResultado.Text = total.ToString();
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int total = a - b;
            txtResultado.Text = total.ToString();

        }

        private void btMult_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int total = a * b;
            txtResultado.Text = total.ToString();

        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int total = a / b;
            txtResultado.Text = total.ToString();

        }
    }
}
