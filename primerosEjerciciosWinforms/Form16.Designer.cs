namespace primerosEjerciciosWinforms
{
    partial class formAnadirNota
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
            btf3Cancelar = new Button();
            btf3Anadir = new Button();
            lbf3Nota = new Label();
            txtf3Nota = new TextBox();
            lbf3Asignatura = new Label();
            txtf3Asignatura = new TextBox();
            lbf3Codigo = new Label();
            txtf3Codigo = new TextBox();
            SuspendLayout();
            // 
            // btf3Cancelar
            // 
            btf3Cancelar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btf3Cancelar.Location = new Point(182, 296);
            btf3Cancelar.Name = "btf3Cancelar";
            btf3Cancelar.Size = new Size(125, 33);
            btf3Cancelar.TabIndex = 15;
            btf3Cancelar.Text = "Cancelar";
            btf3Cancelar.UseVisualStyleBackColor = true;
            // 
            // btf3Anadir
            // 
            btf3Anadir.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btf3Anadir.Location = new Point(182, 257);
            btf3Anadir.Name = "btf3Anadir";
            btf3Anadir.Size = new Size(125, 33);
            btf3Anadir.TabIndex = 14;
            btf3Anadir.Text = "Añadir";
            btf3Anadir.UseVisualStyleBackColor = true;
            btf3Anadir.Click += btf3Anadir_Click;
            // 
            // lbf3Nota
            // 
            lbf3Nota.AutoSize = true;
            lbf3Nota.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbf3Nota.Location = new Point(108, 216);
            lbf3Nota.Name = "lbf3Nota";
            lbf3Nota.Size = new Size(70, 35);
            lbf3Nota.TabIndex = 13;
            lbf3Nota.Text = "Nota";
            // 
            // txtf3Nota
            // 
            txtf3Nota.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtf3Nota.Location = new Point(182, 210);
            txtf3Nota.Name = "txtf3Nota";
            txtf3Nota.Size = new Size(125, 41);
            txtf3Nota.TabIndex = 12;
            // 
            // lbf3Asignatura
            // 
            lbf3Asignatura.AutoSize = true;
            lbf3Asignatura.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbf3Asignatura.Location = new Point(43, 172);
            lbf3Asignatura.Name = "lbf3Asignatura";
            lbf3Asignatura.Size = new Size(134, 35);
            lbf3Asignatura.TabIndex = 11;
            lbf3Asignatura.Text = "Asignatura";
            // 
            // txtf3Asignatura
            // 
            txtf3Asignatura.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtf3Asignatura.Location = new Point(182, 166);
            txtf3Asignatura.Name = "txtf3Asignatura";
            txtf3Asignatura.Size = new Size(125, 41);
            txtf3Asignatura.TabIndex = 10;
            // 
            // lbf3Codigo
            // 
            lbf3Codigo.AutoSize = true;
            lbf3Codigo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbf3Codigo.Location = new Point(81, 128);
            lbf3Codigo.Name = "lbf3Codigo";
            lbf3Codigo.Size = new Size(96, 35);
            lbf3Codigo.TabIndex = 9;
            lbf3Codigo.Text = "Código";
            // 
            // txtf3Codigo
            // 
            txtf3Codigo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtf3Codigo.Location = new Point(183, 122);
            txtf3Codigo.Name = "txtf3Codigo";
            txtf3Codigo.Size = new Size(125, 41);
            txtf3Codigo.TabIndex = 16;
            // 
            // formAnadirNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(406, 450);
            Controls.Add(txtf3Codigo);
            Controls.Add(btf3Cancelar);
            Controls.Add(btf3Anadir);
            Controls.Add(lbf3Nota);
            Controls.Add(txtf3Nota);
            Controls.Add(lbf3Asignatura);
            Controls.Add(txtf3Asignatura);
            Controls.Add(lbf3Codigo);
            Name = "formAnadirNota";
            Text = "Añadir Nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btf3Cancelar;
        public Button btf3Anadir;
        public Label lbf3Nota;
        public TextBox txtf3Nota;
        public Label lbf3Asignatura;
        public TextBox txtf3Asignatura;
        public Label lbf3Codigo;
        public TextBox txtf3Codigo;
    }
}