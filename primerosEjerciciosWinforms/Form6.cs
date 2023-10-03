using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace primerosEjerciciosWinforms
{
    public partial class formSeleccionPalabras : Form
    {
        public formSeleccionPalabras()
        {
            InitializeComponent();
        }

       
        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {

            string palabrita = txtPalabra.Text.Trim();
            if (!string.IsNullOrEmpty(palabrita))
            {
                if (!comboPalabras.Items.Contains(palabrita))
                {
                    comboPalabras.Items.Add(palabrita);
                    lbTexto.Text = $"La palabra '{palabrita}' ha sido incluida";

                }
                else
                {
                    lbTexto.Text = $"La palabra '{palabrita}' ya está incluida";

                }
            }
            else
            {
                lbTexto.Text = $"Ingrese antes una palabra";
            }



        }

        private void comboPalabras_SelectedIndexChanged(object sender, EventArgs e, ComboBox comboPalabras)
        {
            int posicion = comboPalabras.SelectedIndex;
            string palabra = comboPalabras.SelectedItem.ToString();
            lbTexto.Text = $"La palabra seleccionada es '{palabra}' en la posición {posicion + 1}.";
            
        }

        
    }
}
