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
    public partial class formAnadirNota : Form
    {
        public formAnadirNota()
        {
            InitializeComponent();
            formAlumnos alumnos = new formAlumnos();
            txtf3Codigo.Enabled = false;
        }

        private void btf3Anadir_Click(object sender, EventArgs e)
        {
            btf3Anadir.DialogResult = DialogResult.OK;
        }
    }
}
