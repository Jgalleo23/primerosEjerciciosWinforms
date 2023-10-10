namespace primerosEjerciciosWinforms
{
    partial class formEjercicio15
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
            btVolver = new Button();
            datetimeEntrada = new DateTimePicker();
            btRegistrarEntrada = new Button();
            btRegistrarSalida = new Button();
            datetimeSalida = new DateTimePicker();
            groupHoras = new GroupBox();
            groupPrecio = new GroupBox();
            lbPrecioHora = new Label();
            btCalcular = new Button();
            groupHoras.SuspendLayout();
            groupPrecio.SuspendLayout();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 10;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // datetimeEntrada
            // 
            datetimeEntrada.Format = DateTimePickerFormat.Custom;
            datetimeEntrada.Location = new Point(32, 31);
            datetimeEntrada.Name = "datetimeEntrada";
            datetimeEntrada.Size = new Size(479, 27);
            datetimeEntrada.TabIndex = 11;
            // 
            // btRegistrarEntrada
            // 
            btRegistrarEntrada.Location = new Point(517, 29);
            btRegistrarEntrada.Name = "btRegistrarEntrada";
            btRegistrarEntrada.Size = new Size(94, 29);
            btRegistrarEntrada.TabIndex = 12;
            btRegistrarEntrada.Text = "Registrar";
            btRegistrarEntrada.UseVisualStyleBackColor = true;
            btRegistrarEntrada.Click += btRegistrarEntrada_Click;
            // 
            // btRegistrarSalida
            // 
            btRegistrarSalida.Location = new Point(517, 76);
            btRegistrarSalida.Name = "btRegistrarSalida";
            btRegistrarSalida.Size = new Size(94, 29);
            btRegistrarSalida.TabIndex = 14;
            btRegistrarSalida.Text = "Registrar";
            btRegistrarSalida.UseVisualStyleBackColor = true;
            btRegistrarSalida.Click += btRegistrarSalida_Click;
            // 
            // datetimeSalida
            // 
            datetimeSalida.Format = DateTimePickerFormat.Custom;
            datetimeSalida.Location = new Point(32, 77);
            datetimeSalida.Name = "datetimeSalida";
            datetimeSalida.Size = new Size(479, 27);
            datetimeSalida.TabIndex = 13;
            // 
            // groupHoras
            // 
            groupHoras.Controls.Add(btRegistrarSalida);
            groupHoras.Controls.Add(datetimeEntrada);
            groupHoras.Controls.Add(datetimeSalida);
            groupHoras.Controls.Add(btRegistrarEntrada);
            groupHoras.Location = new Point(91, 146);
            groupHoras.Name = "groupHoras";
            groupHoras.Size = new Size(623, 124);
            groupHoras.TabIndex = 15;
            groupHoras.TabStop = false;
            groupHoras.Text = "Registro";
            // 
            // groupPrecio
            // 
            groupPrecio.Controls.Add(lbPrecioHora);
            groupPrecio.Location = new Point(187, 256);
            groupPrecio.Name = "groupPrecio";
            groupPrecio.Size = new Size(433, 71);
            groupPrecio.TabIndex = 16;
            groupPrecio.TabStop = false;
            groupPrecio.Text = "Total";
            // 
            // lbPrecioHora
            // 
            lbPrecioHora.AutoSize = true;
            lbPrecioHora.Location = new Point(32, 30);
            lbPrecioHora.Name = "lbPrecioHora";
            lbPrecioHora.Size = new Size(27, 20);
            lbPrecioHora.TabIndex = 0;
            lbPrecioHora.Text = "......";
            // 
            // btCalcular
            // 
            btCalcular.Location = new Point(360, 333);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(94, 29);
            btCalcular.TabIndex = 17;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // formEjercicio15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btCalcular);
            Controls.Add(groupPrecio);
            Controls.Add(groupHoras);
            Controls.Add(btVolver);
            Name = "formEjercicio15";
            Text = "Ejercicio 15";
            groupHoras.ResumeLayout(false);
            groupPrecio.ResumeLayout(false);
            groupPrecio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btVolver;
        private DateTimePicker datetimeEntrada;
        private Button btRegistrarEntrada;
        private Button btRegistrarSalida;
        private DateTimePicker datetimeSalida;
        private GroupBox groupHoras;
        private GroupBox groupPrecio;
        private Label lbPrecioHora;
        private Button btCalcular;
    }
}