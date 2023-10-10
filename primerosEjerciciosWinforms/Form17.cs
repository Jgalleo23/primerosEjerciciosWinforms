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
    public partial class formEjercicio15 : Form
    {
        public formEjercicio15()
        {
            InitializeComponent();
            datetimeSalida.Enabled = false;
            btRegistrarSalida.Enabled = false;
            btCalcular.Enabled = false;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        DateTime entrada;
        DateTime salida;
        private void btRegistrarEntrada_Click(object sender, EventArgs e)
        {
            entrada = datetimeEntrada.Value;
            datetimeEntrada.Enabled = false;
            btRegistrarEntrada.Enabled = false;
            datetimeSalida.Enabled = true;
            btRegistrarSalida.Enabled = true;
        }

        private void btRegistrarSalida_Click(object sender, EventArgs e)
        {
            salida = datetimeSalida.Value;
            datetimeSalida.Enabled = false;
            btRegistrarSalida.Enabled = false;
            btCalcular.Enabled = true;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double precioHora = 1.5;
            double totalHoras = (salida - entrada).TotalHours;
            double precioTotal = totalHoras * precioHora;
            double nr = Math.Round(precioTotal, 2);

            lbPrecioHora.Text = $"Precio hora: '{precioHora}'..........Total: " + nr + "€";
        }
    }
}
