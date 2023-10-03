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
    public partial class formSuperTienda : Form
    {
        public formSuperTienda()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void btCalculado_Click_1(object sender, EventArgs e)
        {

        }

        private void comboArt1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboArt1.SelectedItem.Equals("Tornillo")) { numericPU1.Value = 1; }
            if (comboArt1.SelectedItem.Equals("Tablón de madera")) { numericPU1.Value = 2; }
            if (comboArt1.SelectedItem.Equals("Ladrillo")) { numericPU1.Value = 2; }
            if (comboArt1.SelectedItem.Equals("Tuerca")) { numericPU1.Value = 1; }
            if (comboArt1.SelectedItem.Equals("Arandela")) { numericPU1.Value = 1; }
        }

        private void comboArt2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboArt2.SelectedItem.Equals("Tornillo")) { numericPU2.Value = 1; }
            if (comboArt2.SelectedItem.Equals("Tablón de madera")) { numericPU2.Value = 2; }
            if (comboArt2.SelectedItem.Equals("Ladrillo")) { numericPU2.Value = 2; }
            if (comboArt2.SelectedItem.Equals("Tuerca")) { numericPU2.Value = 1; }
            if (comboArt2.SelectedItem.Equals("Arandela")) { numericPU2.Value = 1; }
        }

        private void comboArt3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboArt3.SelectedItem.Equals("Tornillo")) { numericPU3.Value = 1; }
            if (comboArt3.SelectedItem.Equals("Tablón de madera")) { numericPU3.Value = 2; }
            if (comboArt3.SelectedItem.Equals("Ladrillo")) { numericPU3.Value = 2; }
            if (comboArt3.SelectedItem.Equals("Tuerca")) { numericPU3.Value = 1; }
            if (comboArt3.SelectedItem.Equals("Arandela")) { numericPU3.Value = 1; }
        }

        private void numericCant1_ValueChanged(object sender, EventArgs e)
        {
            if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) >= 10000 && (numericCant1.Value + numericCant2.Value + numericCant3.Value) <= 20000)
            {
                MessageBox.Show("Descuento 10% aplicado");

                numericPF1.Value = (numericCant1.Value * numericPU1.Value) - ((numericCant1.Value * numericPU1.Value) * 10) / 100;


            }
            else if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) >= 20001 && (numericCant1.Value + numericCant2.Value + numericCant3.Value) <= 50000)
            {
                MessageBox.Show("Descuento 30% aplicado");

                numericPF1.Value = (numericCant1.Value * numericPU1.Value) - ((numericCant1.Value * numericPU1.Value) * 30) / 100;

            }
            else if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) > 50000)
            {
                MessageBox.Show("Descuento 50% aplicado");

                numericPF1.Value = (numericCant1.Value * numericPU1.Value) - ((numericCant1.Value * numericPU1.Value) * 50) / 100;

            }
            else
            {
                numericPF1.Value = (numericCant1.Value * numericPU1.Value);
            }
            numericTodo.Value = numericPF1.Value + numericPF2.Value + numericPF3.Value;
        }

        private void numericCant2_ValueChanged(object sender, EventArgs e)
        {
            if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) >= 10000 && (numericCant1.Value + numericCant2.Value + numericCant3.Value) <= 20000)
            {
                MessageBox.Show("Descuento 10% aplicado");

                numericPF2.Value = (numericCant2.Value * numericPU2.Value) - ((numericCant2.Value * numericPU2.Value) * 10) / 100;


            }
            else if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) >= 20001 && (numericCant1.Value + numericCant2.Value + numericCant3.Value) <= 50000)
            {
                MessageBox.Show("Descuento 30% aplicado");

                numericPF2.Value = (numericCant2.Value * numericPU2.Value) - ((numericCant2.Value * numericPU2.Value) * 30) / 100;
            }
            else if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) > 50000)
            {
                MessageBox.Show("Descuento 50% aplicado");

                numericPF2.Value = (numericCant2.Value * numericPU2.Value) - ((numericCant2.Value * numericPU2.Value) * 50) / 100;
            }
            else
            {
                numericPF2.Value = (numericCant2.Value * numericPU2.Value);
            }

            numericTodo.Value = numericPF1.Value + numericPF2.Value + numericPF3.Value;
        }

        private void numericCant3_ValueChanged(object sender, EventArgs e)
        {
            if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) >= 10000 && (numericCant1.Value + numericCant2.Value + numericCant3.Value) <= 20000)
            {
                MessageBox.Show("Descuento 10% aplicado");

                numericPF3.Value = (numericCant3.Value * numericPU3.Value) - ((numericCant3.Value * numericPU1.Value) * 10) / 100;


            }
            else if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) >= 20001 && (numericCant1.Value + numericCant2.Value + numericCant3.Value) <= 50000)
            {
                MessageBox.Show("Descuento 30% aplicado");

                numericPF3.Value = (numericCant3.Value * numericPU3.Value) - ((numericCant3.Value * numericPU1.Value) * 30) / 100;
            }
            else if ((numericCant1.Value + numericCant2.Value + numericCant3.Value) > 50000)
            {
                MessageBox.Show("Descuento 50% aplicado");

                numericPF3.Value = (numericCant3.Value * numericPU3.Value) - ((numericCant3.Value * numericPU1.Value) * 50) / 100;
            }
            else
            {
                numericPF3.Value = (numericCant3.Value * numericPU3.Value);
            }

            numericTodo.Value = numericPF1.Value + numericPF2.Value + numericPF3.Value;
        }

    }
}
