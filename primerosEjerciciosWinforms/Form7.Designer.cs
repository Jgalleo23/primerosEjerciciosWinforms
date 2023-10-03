namespace primerosEjerciciosWinforms
{
    partial class formMetodoPago
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
            comboMetodoPago = new ComboBox();
            lbMetodoPago = new Label();
            txtTotal = new TextBox();
            txtEntregado = new TextBox();
            txtCambio = new TextBox();
            txtNtarjeta = new TextBox();
            lbTotal = new Label();
            lbEntregado = new Label();
            lbCambio = new Label();
            lbNtarjeta = new Label();
            lbFcaducidad = new Label();
            btVolver = new Button();
            dtimeFechaCducidad = new DateTimePicker();
            SuspendLayout();
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Items.AddRange(new object[] { "Tarjeta", "Efectivo" });
            comboMetodoPago.Location = new Point(190, 85);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(151, 28);
            comboMetodoPago.TabIndex = 0;
            comboMetodoPago.SelectedIndexChanged += comboMetodoPago_SelectedIndexChanged;
            // 
            // lbMetodoPago
            // 
            lbMetodoPago.AutoSize = true;
            lbMetodoPago.Location = new Point(62, 85);
            lbMetodoPago.Name = "lbMetodoPago";
            lbMetodoPago.Size = new Size(122, 20);
            lbMetodoPago.TabIndex = 1;
            lbMetodoPago.Text = "Método de pago";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(190, 147);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(151, 27);
            txtTotal.TabIndex = 2;
            // 
            // txtEntregado
            // 
            txtEntregado.Location = new Point(190, 201);
            txtEntregado.Name = "txtEntregado";
            txtEntregado.Size = new Size(151, 27);
            txtEntregado.TabIndex = 3;
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(190, 252);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(151, 27);
            txtCambio.TabIndex = 4;
            // 
            // txtNtarjeta
            // 
            txtNtarjeta.Location = new Point(477, 147);
            txtNtarjeta.Name = "txtNtarjeta";
            txtNtarjeta.Size = new Size(151, 27);
            txtNtarjeta.TabIndex = 5;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(105, 147);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 7;
            lbTotal.Text = "Total";
            // 
            // lbEntregado
            // 
            lbEntregado.AutoSize = true;
            lbEntregado.Location = new Point(105, 201);
            lbEntregado.Name = "lbEntregado";
            lbEntregado.Size = new Size(78, 20);
            lbEntregado.TabIndex = 8;
            lbEntregado.Text = "Entregado";
            // 
            // lbCambio
            // 
            lbCambio.AutoSize = true;
            lbCambio.Location = new Point(105, 252);
            lbCambio.Name = "lbCambio";
            lbCambio.Size = new Size(61, 20);
            lbCambio.TabIndex = 9;
            lbCambio.Text = "Cambio";
            // 
            // lbNtarjeta
            // 
            lbNtarjeta.AutoSize = true;
            lbNtarjeta.Location = new Point(397, 147);
            lbNtarjeta.Name = "lbNtarjeta";
            lbNtarjeta.Size = new Size(74, 20);
            lbNtarjeta.TabIndex = 10;
            lbNtarjeta.Text = "Nº Tarjeta";
            // 
            // lbFcaducidad
            // 
            lbFcaducidad.AutoSize = true;
            lbFcaducidad.Location = new Point(351, 201);
            lbFcaducidad.Name = "lbFcaducidad";
            lbFcaducidad.Size = new Size(120, 20);
            lbFcaducidad.TabIndex = 11;
            lbFcaducidad.Text = "Fecha caducidad";
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 12;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // dtimeFechaCducidad
            // 
            dtimeFechaCducidad.Location = new Point(477, 199);
            dtimeFechaCducidad.Name = "dtimeFechaCducidad";
            dtimeFechaCducidad.Size = new Size(270, 27);
            dtimeFechaCducidad.TabIndex = 13;
            // 
            // formMetodoPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(dtimeFechaCducidad);
            Controls.Add(btVolver);
            Controls.Add(lbFcaducidad);
            Controls.Add(lbNtarjeta);
            Controls.Add(lbCambio);
            Controls.Add(lbEntregado);
            Controls.Add(lbTotal);
            Controls.Add(txtNtarjeta);
            Controls.Add(txtCambio);
            Controls.Add(txtEntregado);
            Controls.Add(txtTotal);
            Controls.Add(lbMetodoPago);
            Controls.Add(comboMetodoPago);
            Name = "formMetodoPago";
            Text = "Ejercicio 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboMetodoPago;
        private Label lbMetodoPago;
        private TextBox txtTotal;
        private TextBox txtEntregado;
        private TextBox txtCambio;
        private TextBox txtNtarjeta;
        private Label lbTotal;
        private Label lbEntregado;
        private Label lbCambio;
        private Label lbNtarjeta;
        private Label lbFcaducidad;
        private Button btVolver;
        private DateTimePicker dtimeFechaCducidad;
    }
}