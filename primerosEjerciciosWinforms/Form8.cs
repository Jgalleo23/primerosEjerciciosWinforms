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
    public partial class formCalcular2 : Form
    {
        public formCalcular2()
        {
            InitializeComponent();
            txtN1.Visible = false;
            txtN2.Visible = false;
            txtN3.Visible = false;
        }

        private void formCalcular2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtSumar.Checked)
                {
                    double n1 = (double)numericN1.Value;
                    double n2 = (double)numericN2.Value;
                    double n3 = (double)numericN3.Value;
                    double totalSuma = n1 + n2 + n3;
                    lbSumar.Text = $"El resultado de la suma es '{totalSuma}'.";
                    lbSumar.Visible = true;
                    lbDividir.Visible = false;
                    lbMultiplicar.Visible = false;
                    lbRestar.Visible = false;
                }
                if (rbtRestar.Checked)
                {
                    double n1 = (double)numericN1.Value;
                    double n2 = (double)numericN2.Value;
                    double n3 = (double)numericN3.Value;
                    double totalResta = n1 - n2 - n3;
                    lbRestar.Text = $"El resultado de la resta es '{totalResta}'.";
                    lbRestar.Visible = true;
                    lbSumar.Visible = false;
                    lbDividir.Visible = false;
                    lbMultiplicar.Visible = false;
                }
                if (rbtMultiplicar.Checked)
                {
                    double n1 = (double)numericN1.Value;
                    double n2 = (double)numericN2.Value;   
                    double n3 = (double)numericN3.Value;
                    double totalMult = n1 * n2 * n3;
                    lbMultiplicar.Text = $"El resultado de la multiplicación es '{totalMult}'.";
                    lbMultiplicar.Visible = true;
                    lbDividir.Visible = false;
                    lbRestar.Visible = false;
                    lbSumar.Visible = false;
                }
                if (rbtDividir.Checked)
                {
                    if (numericN2.Value != 0 && numericN3.Value != 0)
                    {
                        double n1 = (double)numericN1.Value;
                        double n2 = (double)numericN2.Value;
                        double n3 = (double)numericN3.Value;
                        double totalDivision = n1 / n2 / n3;
                        lbDividir.Text = $"El resultado de la división es '{totalDivision}'.";
                        lbDividir.Visible = true;
                        lbMultiplicar.Visible = false;
                        lbRestar.Visible = false;
                        lbSumar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El valor 2 o 3 no pueden ser '0'");
                    }
                }
                if (rbtTodas.Checked)
                {
                    if (numericN2.Value != 0 && numericN3.Value != 0)
                    {
                        double n1 = (double)numericN1.Value;
                        double n2 = (double)numericN2.Value;
                        double n3 = (double)numericN3.Value;
                        double totalSuma = n1 + n2 + n3;
                        lbSumar.Text = $"El resultado de la suma es '{totalSuma}'.";
                        double totalResta = n1 - n2 - n3;
                        lbRestar.Text = $"El resultado de la resta es '{totalResta}'.";
                        double totalMult = n1 * n2 * n3;
                        lbMultiplicar.Text = $"El resultado de la multiplicación es '{totalMult}'.";
                        double totalDivision = n1 / n2 / n3;
                        lbDividir.Text = $"El resultado de la división es '{totalDivision}'.";
                        lbDividir.Visible = true;
                        lbMultiplicar.Visible = true;
                        lbRestar.Visible = true;
                        lbSumar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("El valor 2 o 3 no pueden ser '0'");
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("No puede haber ningún campo vacío");
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            numericN1.Value = 0;
            numericN2.Value = 0;
            numericN3.Value = 0;
            lbDividir.Visible = false;
            lbMultiplicar.Visible = false;
            lbRestar.Visible = false;
            lbSumar.Visible = false;
        }
    }
}
