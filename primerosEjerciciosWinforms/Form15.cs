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
    public partial class formAnadirAlumno : Form
    {
        public formAnadirAlumno()
        {
            InitializeComponent();
        }

        private void btf2Anadir_Click(object sender, EventArgs e)
        {
            btf2Anadir.DialogResult = DialogResult.OK;
        }
    }
}
