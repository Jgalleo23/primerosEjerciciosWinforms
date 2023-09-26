namespace primerosEjerciciosWinforms
{
    partial class formAdivino
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
            btJugar = new Button();
            btVolver = new Button();
            lbAyuda = new Label();
            lbTextoAyuda = new Label();
            txtNumero = new TextBox();
            lbNumero = new Label();
            btVolverJug = new Button();
            lbPrueba = new Label();
            btComprobar = new Button();
            lbIntentos = new Label();
            lbContador = new Label();
            txtNumPer1 = new TextBox();
            txtNumPer2 = new TextBox();
            lbComa = new Label();
            lbNumPersonalizado = new Label();
            btElegir = new Button();
            lbPruebaN1 = new Label();
            lbPruebaN2 = new Label();
            SuspendLayout();
            // 
            // btJugar
            // 
            btJugar.Cursor = Cursors.Hand;
            btJugar.Location = new Point(283, 223);
            btJugar.Name = "btJugar";
            btJugar.Size = new Size(121, 29);
            btJugar.TabIndex = 0;
            btJugar.Text = "Jugar";
            btJugar.UseVisualStyleBackColor = true;
            btJugar.Click += btJugar_Click;
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 11;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // lbAyuda
            // 
            lbAyuda.AutoSize = true;
            lbAyuda.Location = new Point(181, 164);
            lbAyuda.Name = "lbAyuda";
            lbAyuda.Size = new Size(58, 20);
            lbAyuda.TabIndex = 12;
            lbAyuda.Text = "Ayuda: ";
            // 
            // lbTextoAyuda
            // 
            lbTextoAyuda.AutoSize = true;
            lbTextoAyuda.Location = new Point(245, 164);
            lbTextoAyuda.Name = "lbTextoAyuda";
            lbTextoAyuda.Size = new Size(463, 20);
            lbTextoAyuda.TabIndex = 13;
            lbTextoAyuda.Text = "Mensaje que indicará si el número es mayor, menor o se ha acertado";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(327, 114);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(162, 27);
            txtNumero.TabIndex = 14;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(258, 117);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(63, 20);
            lbNumero.TabIndex = 15;
            lbNumero.Text = "Número";
            // 
            // btVolverJug
            // 
            btVolverJug.Cursor = Cursors.Hand;
            btVolverJug.Location = new Point(410, 223);
            btVolverJug.Name = "btVolverJug";
            btVolverJug.Size = new Size(121, 29);
            btVolverJug.TabIndex = 16;
            btVolverJug.Text = "Volver a jugar";
            btVolverJug.UseVisualStyleBackColor = true;
            btVolverJug.Click += btVolverJug_Click;
            // 
            // lbPrueba
            // 
            lbPrueba.AutoSize = true;
            lbPrueba.Location = new Point(784, 0);
            lbPrueba.Name = "lbPrueba";
            lbPrueba.Size = new Size(17, 20);
            lbPrueba.TabIndex = 17;
            lbPrueba.Text = "0";
            // 
            // btComprobar
            // 
            btComprobar.Cursor = Cursors.Hand;
            btComprobar.Location = new Point(495, 113);
            btComprobar.Name = "btComprobar";
            btComprobar.Size = new Size(100, 29);
            btComprobar.TabIndex = 18;
            btComprobar.Text = "Comprobar";
            btComprobar.UseVisualStyleBackColor = true;
            btComprobar.Click += btComprobar_Click;
            // 
            // lbIntentos
            // 
            lbIntentos.AutoSize = true;
            lbIntentos.Location = new Point(181, 202);
            lbIntentos.Name = "lbIntentos";
            lbIntentos.Size = new Size(65, 20);
            lbIntentos.TabIndex = 19;
            lbIntentos.Text = "Intentos:";
            // 
            // lbContador
            // 
            lbContador.AutoSize = true;
            lbContador.Location = new Point(252, 202);
            lbContador.Name = "lbContador";
            lbContador.Size = new Size(17, 20);
            lbContador.TabIndex = 20;
            lbContador.Text = "0";
            // 
            // txtNumPer1
            // 
            txtNumPer1.Location = new Point(387, 267);
            txtNumPer1.Name = "txtNumPer1";
            txtNumPer1.Size = new Size(56, 27);
            txtNumPer1.TabIndex = 21;
            txtNumPer1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumPer2
            // 
            txtNumPer2.Location = new Point(452, 267);
            txtNumPer2.Name = "txtNumPer2";
            txtNumPer2.Size = new Size(56, 27);
            txtNumPer2.TabIndex = 22;
            txtNumPer2.TextChanged += textBox2_TextChanged;
            // 
            // lbComa
            // 
            lbComa.AutoSize = true;
            lbComa.Location = new Point(443, 274);
            lbComa.Name = "lbComa";
            lbComa.Size = new Size(12, 20);
            lbComa.TabIndex = 23;
            lbComa.Text = ",";
            lbComa.Click += lbComa_Click;
            // 
            // lbNumPersonalizado
            // 
            lbNumPersonalizado.AutoSize = true;
            lbNumPersonalizado.Location = new Point(146, 270);
            lbNumPersonalizado.Name = "lbNumPersonalizado";
            lbNumPersonalizado.Size = new Size(235, 20);
            lbNumPersonalizado.TabIndex = 24;
            lbNumPersonalizado.Text = "Elige entre los valores del random";
            lbNumPersonalizado.Click += lbNumPersonalizado_Click;
            // 
            // btElegir
            // 
            btElegir.Location = new Point(514, 267);
            btElegir.Name = "btElegir";
            btElegir.Size = new Size(94, 29);
            btElegir.TabIndex = 25;
            btElegir.Text = "Aceptar";
            btElegir.UseVisualStyleBackColor = true;
            btElegir.Click += btElegir_Click;
            // 
            // lbPruebaN1
            // 
            lbPruebaN1.AutoSize = true;
            lbPruebaN1.Location = new Point(397, 319);
            lbPruebaN1.Name = "lbPruebaN1";
            lbPruebaN1.Size = new Size(17, 20);
            lbPruebaN1.TabIndex = 26;
            lbPruebaN1.Text = "0";
            // 
            // lbPruebaN2
            // 
            lbPruebaN2.AutoSize = true;
            lbPruebaN2.Location = new Point(473, 319);
            lbPruebaN2.Name = "lbPruebaN2";
            lbPruebaN2.Size = new Size(17, 20);
            lbPruebaN2.TabIndex = 27;
            lbPruebaN2.Text = "0";
            // 
            // formAdivino
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPruebaN2);
            Controls.Add(lbPruebaN1);
            Controls.Add(btElegir);
            Controls.Add(lbNumPersonalizado);
            Controls.Add(lbComa);
            Controls.Add(txtNumPer2);
            Controls.Add(txtNumPer1);
            Controls.Add(lbContador);
            Controls.Add(lbIntentos);
            Controls.Add(btComprobar);
            Controls.Add(lbPrueba);
            Controls.Add(btVolverJug);
            Controls.Add(lbNumero);
            Controls.Add(txtNumero);
            Controls.Add(lbTextoAyuda);
            Controls.Add(lbAyuda);
            Controls.Add(btVolver);
            Controls.Add(btJugar);
            Name = "formAdivino";
            Text = "Ejercicio 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btJugar;
        private Button btVolver;
        private Label lbAyuda;
        private Label lbTextoAyuda;
        private TextBox txtNumero;
        private Label lbNumero;
        private Button btVolverJug;
        private Label lbPrueba;
        private Button btComprobar;
        private Label lbIntentos;
        private Label lbContador;
        private TextBox txtNumPer1;
        private TextBox txtNumPer2;
        private Label lbComa;
        private Label lbNumPersonalizado;
        private Button btElegir;
        private Label lbPruebaN1;
        private Label lbPruebaN2;
    }
}