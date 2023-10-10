namespace primerosEjerciciosWinforms
{
    partial class formAnadirAlumno
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
            txtf2Nombre = new TextBox();
            lbf2Nombre = new Label();
            lbf2Apellidos = new Label();
            txtf2Apellidos = new TextBox();
            lbf2Telefono = new Label();
            txtf2Telefono = new TextBox();
            btf2Anadir = new Button();
            btf2Cancelar = new Button();
            SuspendLayout();
            // 
            // txtf2Nombre
            // 
            txtf2Nombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtf2Nombre.Location = new Point(198, 128);
            txtf2Nombre.Name = "txtf2Nombre";
            txtf2Nombre.Size = new Size(125, 41);
            txtf2Nombre.TabIndex = 0;
            // 
            // lbf2Nombre
            // 
            lbf2Nombre.AutoSize = true;
            lbf2Nombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbf2Nombre.Location = new Point(84, 134);
            lbf2Nombre.Name = "lbf2Nombre";
            lbf2Nombre.Size = new Size(108, 35);
            lbf2Nombre.TabIndex = 1;
            lbf2Nombre.Text = "Nombre";
            // 
            // lbf2Apellidos
            // 
            lbf2Apellidos.AutoSize = true;
            lbf2Apellidos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbf2Apellidos.Location = new Point(77, 178);
            lbf2Apellidos.Name = "lbf2Apellidos";
            lbf2Apellidos.Size = new Size(118, 35);
            lbf2Apellidos.TabIndex = 3;
            lbf2Apellidos.Text = "Apellidos";
            // 
            // txtf2Apellidos
            // 
            txtf2Apellidos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtf2Apellidos.Location = new Point(198, 172);
            txtf2Apellidos.Name = "txtf2Apellidos";
            txtf2Apellidos.Size = new Size(125, 41);
            txtf2Apellidos.TabIndex = 2;
            // 
            // lbf2Telefono
            // 
            lbf2Telefono.AutoSize = true;
            lbf2Telefono.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbf2Telefono.Location = new Point(82, 222);
            lbf2Telefono.Name = "lbf2Telefono";
            lbf2Telefono.Size = new Size(110, 35);
            lbf2Telefono.TabIndex = 5;
            lbf2Telefono.Text = "Telefono";
            // 
            // txtf2Telefono
            // 
            txtf2Telefono.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtf2Telefono.Location = new Point(198, 216);
            txtf2Telefono.Name = "txtf2Telefono";
            txtf2Telefono.Size = new Size(125, 41);
            txtf2Telefono.TabIndex = 4;
            // 
            // btf2Anadir
            // 
            btf2Anadir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btf2Anadir.Location = new Point(198, 263);
            btf2Anadir.Name = "btf2Anadir";
            btf2Anadir.Size = new Size(125, 33);
            btf2Anadir.TabIndex = 6;
            btf2Anadir.Text = "Añadir";
            btf2Anadir.UseVisualStyleBackColor = true;
            btf2Anadir.Click += btf2Anadir_Click;
            // 
            // btf2Cancelar
            // 
            btf2Cancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btf2Cancelar.Location = new Point(198, 302);
            btf2Cancelar.Name = "btf2Cancelar";
            btf2Cancelar.Size = new Size(125, 33);
            btf2Cancelar.TabIndex = 7;
            btf2Cancelar.Text = "Cancelar";
            btf2Cancelar.UseVisualStyleBackColor = true;
            // 
            // formAnadirAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(457, 450);
            Controls.Add(btf2Cancelar);
            Controls.Add(btf2Anadir);
            Controls.Add(lbf2Telefono);
            Controls.Add(txtf2Telefono);
            Controls.Add(lbf2Apellidos);
            Controls.Add(txtf2Apellidos);
            Controls.Add(lbf2Nombre);
            Controls.Add(txtf2Nombre);
            Name = "formAnadirAlumno";
            Text = "Añadir alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtf2Nombre;
        public Label lbf2Nombre;
        public Label lbf2Apellidos;
        public TextBox txtf2Apellidos;
        public Label lbf2Telefono;
        public TextBox txtf2Telefono;
        public Button btf2Anadir;
        public Button btf2Cancelar;
    }
}