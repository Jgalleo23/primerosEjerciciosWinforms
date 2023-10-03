using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerosEjerciciosWinforms
{
    public partial class formTienda : Form
    {
        public formTienda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void comboArt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboArt1.SelectedItem.Equals("Pan")) { numericPU1.Value = 2; }
            if (comboArt1.SelectedItem.Equals("Café en polvo")) { numericPU1.Value = 2; }
            if (comboArt1.SelectedItem.Equals("Croissant")) { numericPU1.Value = 3; }
            if (comboArt1.SelectedItem.Equals("Fairy")) { numericPU1.Value = 5; }
        }

        private void comboArt2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboArt2.SelectedItem.Equals("Pan")) { numericPU2.Value = 2; }
            if (comboArt2.SelectedItem.Equals("Café en polvo")) { numericPU2.Value = 2; }
            if (comboArt2.SelectedItem.Equals("Croissant")) { numericPU2.Value = 3; }
            if (comboArt2.SelectedItem.Equals("Fairy")) { numericPU2.Value = 5; }
        }

        private void comboArt3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboArt3.SelectedItem.Equals("Pan")) { numericPU3.Value = 2; }
            if (comboArt3.SelectedItem.Equals("Café en polvo")) { numericPU3.Value = 2; }
            if (comboArt3.SelectedItem.Equals("Croissant")) { numericPU3.Value = 3; }
            if (comboArt3.SelectedItem.Equals("Fairy")) { numericPU3.Value = 5; }
        }


        private void btCalculado_Click(object sender, EventArgs e)
        { }

        private void numericCant1_ValueChanged(object sender, EventArgs e)
        {
            numericPF1.Value = (numericCant1.Value * numericPU1.Value) + ((numericCant1.Value * numericPU1.Value) * 21) / 100;
            numericPT1.Value = numericCant1.Value * numericPU1.Value;

        }

        private void numericCant2_ValueChanged(object sender, EventArgs e)
        {
            numericPF2.Value = (numericCant2.Value * numericPU2.Value) + ((numericCant2.Value * numericPU2.Value) * 21) / 100;
            numericPT2.Value = numericCant2.Value * numericPU2.Value;
        }

        private void numericCant3_ValueChanged(object sender, EventArgs e)
        {
            numericPF3.Value = (numericCant3.Value * numericPU3.Value) + ((numericCant3.Value * numericPU1.Value) * 21) / 100;
            numericPT3.Value = numericCant3.Value * numericPU3.Value;
        }

        private void numericPF1_ValueChanged(object sender, EventArgs e)
        {
            numericTodo.Value = numericPF1.Value + numericPF2.Value + numericPF3.Value;
        }

        private void numericPF2_ValueChanged(object sender, EventArgs e)
        {
            numericTodo.Value = numericPF1.Value + numericPF2.Value + numericPF3.Value;
        }

        private void numericPF3_ValueChanged(object sender, EventArgs e)
        {
            numericTodo.Value = numericPF1.Value + numericPF2.Value + numericPF3.Value;
        }
    }
}
