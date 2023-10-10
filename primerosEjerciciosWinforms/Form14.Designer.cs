namespace primerosEjerciciosWinforms
{
    partial class formAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridviewAlumnos = new DataGridView();
            columCodigoAlumno = new DataGridViewTextBoxColumn();
            columNombre = new DataGridViewTextBoxColumn();
            columApellidos = new DataGridViewTextBoxColumn();
            columTelefono = new DataGridViewTextBoxColumn();
            columNotaMedia = new DataGridViewTextBoxColumn();
            btcolumAnadirNota = new DataGridViewButtonColumn();
            btAnadirAlum = new Button();
            btVolver = new Button();
            btAnadirNota = new Button();
            gridviewNotas = new DataGridView();
            columCodigo = new DataGridViewTextBoxColumn();
            columAsignatura = new DataGridViewTextBoxColumn();
            columNotaAsignatura = new DataGridViewTextBoxColumn();
            btAnadirNota1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridviewAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridviewNotas).BeginInit();
            SuspendLayout();
            // 
            // gridviewAlumnos
            // 
            gridviewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewAlumnos.Columns.AddRange(new DataGridViewColumn[] { columCodigoAlumno, columNombre, columApellidos, columTelefono, columNotaMedia, btcolumAnadirNota });
            gridviewAlumnos.Location = new Point(12, 57);
            gridviewAlumnos.Name = "gridviewAlumnos";
            gridviewAlumnos.RowHeadersWidth = 51;
            gridviewAlumnos.RowTemplate.Height = 29;
            gridviewAlumnos.Size = new Size(776, 133);
            gridviewAlumnos.TabIndex = 0;
            // 
            // columCodigoAlumno
            // 
            columCodigoAlumno.HeaderText = "Código";
            columCodigoAlumno.MinimumWidth = 6;
            columCodigoAlumno.Name = "columCodigoAlumno";
            columCodigoAlumno.Width = 125;
            // 
            // columNombre
            // 
            columNombre.HeaderText = "Nombre";
            columNombre.MinimumWidth = 6;
            columNombre.Name = "columNombre";
            columNombre.Width = 125;
            // 
            // columApellidos
            // 
            columApellidos.HeaderText = "Apellidos";
            columApellidos.MinimumWidth = 6;
            columApellidos.Name = "columApellidos";
            columApellidos.Width = 125;
            // 
            // columTelefono
            // 
            columTelefono.HeaderText = "Telefono";
            columTelefono.MinimumWidth = 6;
            columTelefono.Name = "columTelefono";
            columTelefono.Width = 125;
            // 
            // columNotaMedia
            // 
            columNotaMedia.HeaderText = "Nota";
            columNotaMedia.MinimumWidth = 6;
            columNotaMedia.Name = "columNotaMedia";
            columNotaMedia.Width = 125;
            // 
            // btcolumAnadirNota
            // 
            btcolumAnadirNota.HeaderText = "Añadir Nota";
            btcolumAnadirNota.MinimumWidth = 6;
            btcolumAnadirNota.Name = "btcolumAnadirNota";
            btcolumAnadirNota.Width = 125;
            // 
            // btAnadirAlum
            // 
            btAnadirAlum.Location = new Point(338, 196);
            btAnadirAlum.Name = "btAnadirAlum";
            btAnadirAlum.Size = new Size(129, 29);
            btAnadirAlum.TabIndex = 1;
            btAnadirAlum.Text = "Añadir Alumno";
            btAnadirAlum.UseVisualStyleBackColor = true;
            btAnadirAlum.Click += btAnadirAlum_Click;
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 9;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // btAnadirNota
            // 
            btAnadirNota.Location = new Point(0, 0);
            btAnadirNota.Name = "btAnadirNota";
            btAnadirNota.Size = new Size(75, 23);
            btAnadirNota.TabIndex = 0;
            // 
            // gridviewNotas
            // 
            gridviewNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewNotas.Columns.AddRange(new DataGridViewColumn[] { columCodigo, columAsignatura, columNotaAsignatura });
            gridviewNotas.Location = new Point(186, 274);
            gridviewNotas.Name = "gridviewNotas";
            gridviewNotas.RowHeadersWidth = 51;
            gridviewNotas.RowTemplate.Height = 29;
            gridviewNotas.Size = new Size(432, 73);
            gridviewNotas.TabIndex = 10;
            // 
            // columCodigo
            // 
            columCodigo.HeaderText = "Código";
            columCodigo.MinimumWidth = 6;
            columCodigo.Name = "columCodigo";
            columCodigo.Width = 125;
            // 
            // columAsignatura
            // 
            columAsignatura.HeaderText = "Asignatura";
            columAsignatura.MinimumWidth = 6;
            columAsignatura.Name = "columAsignatura";
            columAsignatura.Width = 125;
            // 
            // columNotaAsignatura
            // 
            columNotaAsignatura.HeaderText = "Nota";
            columNotaAsignatura.MinimumWidth = 6;
            columNotaAsignatura.Name = "columNotaAsignatura";
            columNotaAsignatura.Width = 125;
            // 
            // btAnadirNota1
            // 
            btAnadirNota1.Location = new Point(382, 376);
            btAnadirNota1.Name = "btAnadirNota1";
            btAnadirNota1.Size = new Size(105, 29);
            btAnadirNota1.TabIndex = 11;
            btAnadirNota1.Text = "Añadir Nota";
            btAnadirNota1.UseVisualStyleBackColor = true;
            btAnadirNota1.Click += btAnadirNota_Click;
            // 
            // formAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btAnadirNota1);
            Controls.Add(btAnadirNota);
            Controls.Add(gridviewNotas);
            Controls.Add(btVolver);
            Controls.Add(btAnadirAlum);
            Controls.Add(gridviewAlumnos);
            Name = "formAlumnos";
            Text = "Ejercicio 14";
            ((System.ComponentModel.ISupportInitialize)gridviewAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridviewNotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridviewAlumnos;
        private DataGridViewTextBoxColumn columNota;
        private Button btAnadirAlum;
        private Button btVolver;
        private Button btAnadirNota;
        private DataGridView gridviewNotas;
        private DataGridViewTextBoxColumn columCodigo;
        private DataGridViewTextBoxColumn columAsignatura;
        private DataGridViewTextBoxColumn columNotaAsignatura;
        private DataGridViewTextBoxColumn columCodigoAlumno;
        private DataGridViewTextBoxColumn columNombre;
        private DataGridViewTextBoxColumn columApellidos;
        private DataGridViewTextBoxColumn columTelefono;
        private DataGridViewTextBoxColumn columNotaMedia;
        private DataGridViewButtonColumn btcolumAnadirNota;
        private Button btAnadirNota1;
    }
}