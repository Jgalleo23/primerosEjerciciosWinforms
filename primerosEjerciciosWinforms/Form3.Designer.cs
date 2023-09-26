namespace primerosEjerciciosWinforms
{
    partial class formCalculadora
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
            lbNum1 = new Label();
            txtNum1 = new TextBox();
            lbNum2 = new Label();
            txtNum2 = new TextBox();
            lbResultado = new Label();
            txtResultado = new TextBox();
            btSuma = new Button();
            btResta = new Button();
            btMult = new Button();
            btDivision = new Button();
            btVolver = new Button();
            SuspendLayout();
            // 
            // lbNum1
            // 
            lbNum1.AutoSize = true;
            lbNum1.Location = new Point(286, 132);
            lbNum1.Name = "lbNum1";
            lbNum1.Size = new Size(75, 20);
            lbNum1.TabIndex = 0;
            lbNum1.Text = "Número 1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(367, 132);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 1;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // lbNum2
            // 
            lbNum2.AutoSize = true;
            lbNum2.Location = new Point(286, 166);
            lbNum2.Name = "lbNum2";
            lbNum2.Size = new Size(75, 20);
            lbNum2.TabIndex = 2;
            lbNum2.Text = "Número 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(367, 166);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 3;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(286, 202);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(75, 20);
            lbResultado.TabIndex = 4;
            lbResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(367, 202);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 5;
            // 
            // btSuma
            // 
            btSuma.Cursor = Cursors.Hand;
            btSuma.Location = new Point(286, 246);
            btSuma.Name = "btSuma";
            btSuma.Size = new Size(94, 29);
            btSuma.TabIndex = 6;
            btSuma.Text = "+";
            btSuma.UseVisualStyleBackColor = true;
            btSuma.Click += btSuma_Click;
            // 
            // btResta
            // 
            btResta.Cursor = Cursors.Hand;
            btResta.Location = new Point(398, 246);
            btResta.Name = "btResta";
            btResta.Size = new Size(94, 29);
            btResta.TabIndex = 7;
            btResta.Text = "-";
            btResta.UseVisualStyleBackColor = true;
            btResta.Click += btResta_Click;
            // 
            // btMult
            // 
            btMult.Cursor = Cursors.Hand;
            btMult.Location = new Point(286, 281);
            btMult.Name = "btMult";
            btMult.Size = new Size(94, 29);
            btMult.TabIndex = 8;
            btMult.Text = "x";
            btMult.UseVisualStyleBackColor = true;
            btMult.Click += btMult_Click;
            // 
            // btDivision
            // 
            btDivision.Cursor = Cursors.Hand;
            btDivision.Location = new Point(398, 281);
            btDivision.Name = "btDivision";
            btDivision.Size = new Size(94, 29);
            btDivision.TabIndex = 9;
            btDivision.Text = "%";
            btDivision.UseVisualStyleBackColor = true;
            btDivision.Click += btDivision_Click;
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
            // formCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btVolver);
            Controls.Add(btDivision);
            Controls.Add(btMult);
            Controls.Add(btResta);
            Controls.Add(btSuma);
            Controls.Add(txtResultado);
            Controls.Add(lbResultado);
            Controls.Add(txtNum2);
            Controls.Add(lbNum2);
            Controls.Add(txtNum1);
            Controls.Add(lbNum1);
            Name = "formCalculadora";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNum1;
        private TextBox txtNum1;
        private Label lbNum2;
        private TextBox txtNum2;
        private Label lbResultado;
        private TextBox txtResultado;
        private Button btSuma;
        private Button btResta;
        private Button btMult;
        private Button btDivision;
        private Button btVolver;
        private Label lbResul;
    }
}