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
    public partial class formEmpresa : Form
    {
        public formEmpresa()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void numericSalario_ValueChanged(object sender, EventArgs e)
        {
            numericPension.Value = ((numericSalario.Value * numericDias.Value) * 10) / 100;
            numericSalud.Value = ((numericSalario.Value * numericDias.Value) * 15) / 100;

            numericTotal.Value = (numericSalario.Value * numericDias.Value) - numericPension.Value - numericSalud.Value;
        }

        private void btCalculado_Click(object sender, EventArgs e)
        {



        }

        private void numericDias_ValueChanged(object sender, EventArgs e)
        {
            numericPension.Value = ((numericSalario.Value * numericDias.Value) * 10) / 100;
            numericSalud.Value = ((numericSalario.Value * numericDias.Value) * 15) / 100;

            numericTotal.Value = (numericSalario.Value * numericDias.Value) - numericPension.Value - numericSalud.Value;
        }
    }
}
