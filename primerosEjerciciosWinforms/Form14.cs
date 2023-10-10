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
    public partial class formAlumnos : Form
    {
        public formAlumnos()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formPantalla2 menu = new formPantalla2();
            menu.Show();
            this.Close();
        }

        static int codigo;
        private void btAnadirAlum_Click(object sender, EventArgs e)
        {

            formAnadirAlumno anadirAlumno = new formAnadirAlumno();
            if (anadirAlumno.ShowDialog(this) == DialogResult.OK)
            {
                var index = gridviewAlumnos.Rows.Add();
                gridviewAlumnos.Rows[index].Cells["columCodigoAlumno"].Value = index + 1;
                gridviewAlumnos.Rows[index].Cells["columNombre"].Value = anadirAlumno.txtf2Nombre.Text;
                gridviewAlumnos.Rows[index].Cells["columApellidos"].Value = anadirAlumno.txtf2Apellidos.Text;
                gridviewAlumnos.Rows[index].Cells["columTelefono"].Value = anadirAlumno.txtf2Telefono.Text;
            }
        }

        private DataGridView GetGridviewAlumnos()
        {
            return gridviewAlumnos;
        }

        private void btAnadirNota_Click(object sender, EventArgs e)
        {

            formAnadirNota anadirNota = new formAnadirNota();
            if (anadirNota.txtf3Codigo.Enabled)
            {
                var index1 = gridviewAlumnos.Rows.Add();
                anadirNota.txtf3Codigo.Text = gridviewAlumnos.SelectedRows[index1].Cells["columCodigo"].Value.ToString();
            }
            if (anadirNota.ShowDialog(this) == DialogResult.OK)
            {
                var index = gridviewNotas.Rows.Add();
                var index1 = gridviewAlumnos.Rows.Add();
                gridviewNotas.Rows[index1].Cells["columCodigo"].Value = anadirNota.txtf3Codigo.Text;
                gridviewNotas.Rows[index].Cells["columAsignatura"].Value = anadirNota.txtf3Asignatura.Text;
                gridviewNotas.Rows[index].Cells["columNotaAsignatura"].Value = anadirNota.txtf3Nota.Text;
            }
        }
    }
}

