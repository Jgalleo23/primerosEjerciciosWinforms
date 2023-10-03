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
    public partial class formMetodoPago : Form
    {
        public formMetodoPago()
        {
            InitializeComponent();
            lbCambio.Visible = false;
            lbEntregado.Visible = false;
            lbFcaducidad.Visible = false;
            lbNtarjeta.Visible = false;
            lbTotal.Visible = false;
            txtCambio.Visible = false;
            txtEntregado.Visible = false;
            txtNtarjeta.Visible = false;
            txtTotal.Visible = false;
            dtimeFechaCducidad.Visible=false;
        }

        private void comboMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMetodoPago.SelectedItem.Equals("Tarjeta"))
            {
                lbNtarjeta.Visible = true;
                lbFcaducidad.Visible = true;
                txtNtarjeta.Visible = true;
                dtimeFechaCducidad.Visible = true;

                lbCambio.Visible = false;
                lbEntregado.Visible = false;
                lbTotal.Visible = false;
                txtCambio.Visible = false;
                txtEntregado.Visible = false;
                txtTotal.Visible = false;
            }
            if (comboMetodoPago.SelectedItem.Equals("Efectivo"))
            {
                lbCambio.Visible = true;
                lbEntregado.Visible = true;
                lbTotal.Visible = true;
                txtCambio.Visible = true;
                txtEntregado.Visible = true;
                txtTotal.Visible = true;

                lbNtarjeta.Visible = false;
                lbFcaducidad.Visible = false;
                txtNtarjeta.Visible = false;
                dtimeFechaCducidad.Visible = false;
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }
    }
}
