namespace primerosEjerciciosWinforms
{
    partial class formPalabrasLetras
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
            label1 = new Label();
            txtPalabra = new TextBox();
            label2 = new Label();
            txtLetra = new TextBox();
            label3 = new Label();
            btContar = new Button();
            btVolver = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 158);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Palabra/Frase";
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(334, 158);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(194, 27);
            txtPalabra.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 192);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Letra";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(334, 192);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(100, 27);
            txtLetra.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 228);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 4;
            label3.Text = "Numero de letras";
            // 
            // btContar
            // 
            btContar.Cursor = Cursors.Hand;
            btContar.Location = new Point(344, 258);
            btContar.Name = "btContar";
            btContar.Size = new Size(80, 29);
            btContar.TabIndex = 6;
            btContar.Text = "Contar";
            btContar.UseVisualStyleBackColor = true;
            btContar.Click += btContar_Click;
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 7;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(344, 228);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(17, 20);
            lbResultado.TabIndex = 8;
            lbResultado.Text = "0";
            // 
            // formPalabrasLetras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btVolver);
            Controls.Add(btContar);
            Controls.Add(label3);
            Controls.Add(txtLetra);
            Controls.Add(label2);
            Controls.Add(txtPalabra);
            Controls.Add(label1);
            Name = "formPalabrasLetras";
            Text = "Ejercicio 2 ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPalabra;
        private Label label2;
        private TextBox txtLetra;
        private Label label3;
        private Button btContar;
        private Button btVolver;
        private Label lbResultado;
    }
}