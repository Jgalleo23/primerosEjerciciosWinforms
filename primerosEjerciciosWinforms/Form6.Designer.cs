namespace primerosEjerciciosWinforms
{
    partial class formSeleccionPalabras
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
            comboPalabras = new ComboBox();
            txtPalabra = new TextBox();
            btCargar = new Button();
            btVolver = new Button();
            lbTexto = new Label();
            SuspendLayout();
            // 
            // comboPalabras
            // 
            comboPalabras.FormattingEnabled = true;
            comboPalabras.Location = new Point(410, 129);
            comboPalabras.Name = "comboPalabras";
            comboPalabras.Size = new Size(151, 28);
            comboPalabras.TabIndex = 0;
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(253, 130);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(125, 27);
            txtPalabra.TabIndex = 1;
            // 
            // btCargar
            // 
            btCargar.Location = new Point(331, 171);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(119, 29);
            btCargar.TabIndex = 2;
            btCargar.Text = "Cargar palabra";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 8;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // lbTexto
            // 
            lbTexto.AutoSize = true;
            lbTexto.Location = new Point(149, 212);
            lbTexto.Name = "lbTexto";
            lbTexto.Size = new Size(0, 20);
            lbTexto.TabIndex = 9;
            // 
            // formSeleccionPalabras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTexto);
            Controls.Add(btVolver);
            Controls.Add(btCargar);
            Controls.Add(txtPalabra);
            Controls.Add(comboPalabras);
            Name = "formSeleccionPalabras";
            Text = "Ejercicio 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboPalabras;
        private TextBox txtPalabra;
        private Button btCargar;
        private Button btVolver;
        private Label lbTexto;
    }
}