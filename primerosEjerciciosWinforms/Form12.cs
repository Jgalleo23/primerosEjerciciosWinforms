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
    public partial class formEncuesta : Form
    {
        public formEncuesta()
        {
            InitializeComponent();
            lbTextoVotosTot.Visible = false;
            lbSi.Visible = false;
            lbNo.Visible = false;
            lbNoseNocont.Visible = false;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }
        int contSi = 0;
        int contNo = 0;
        int contNsNc = 0;

        private void btVotar_Click(object sender, EventArgs e)
        {
        lbTextoVotosTot.Visible = true;
            lbSi.Visible = true;
            lbNo.Visible = true;
            lbNoseNocont.Visible = true;

            int votosTotal = contSi + contNo + contNsNc + 1;
            int porcentajeSi = (contSi * 100) / votosTotal;
            int porcentajeNo = (contNo * 100) / votosTotal;
            int porcentajeNsNc = (contNsNc * 100) / votosTotal;

            pbSi.Value = porcentajeSi;
            pbNoseNocont.Value = porcentajeNsNc;
            pbNo.Value = porcentajeNo;

            if (rbtSi.Checked) { contSi = contSi + 1; lbSi.Text = contSi.ToString(); pbSi.Value = porcentajeSi ;
                
            }
            
            
            if (rbtNo.Checked) { contNo = contNo + 1; lbNo.Text = contNo.ToString(); pbNo.Value = porcentajeNo;
                
                
            }
            
            

            if (rbtNoseNocont.Checked) { contNsNc = contNsNc + 1; lbNoseNocont.Text = contNsNc.ToString();pbNoseNocont.Value = porcentajeNsNc;                
            }
            
            
            lbTextoVotosTot.Text = $"Los votos totales son '{votosTotal}'.";

            
        }
    }
}
