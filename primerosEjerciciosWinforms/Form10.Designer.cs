namespace primerosEjerciciosWinforms
{
    partial class formEmpresa
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
            lbTituloEmpresa = new Label();
            groupBox1 = new GroupBox();
            lbConcepSal = new Label();
            lbConceptoPen = new Label();
            lbDiasTrab = new Label();
            lbSalario = new Label();
            numericSalud = new NumericUpDown();
            numericPension = new NumericUpDown();
            numericDias = new NumericUpDown();
            numericSalario = new NumericUpDown();
            groupBox2 = new GroupBox();
            numericTotal = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSalud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPension).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSalario).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 1;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // lbTituloEmpresa
            // 
            lbTituloEmpresa.AutoSize = true;
            lbTituloEmpresa.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloEmpresa.Location = new Point(315, 69);
            lbTituloEmpresa.Name = "lbTituloEmpresa";
            lbTituloEmpresa.Size = new Size(162, 30);
            lbTituloEmpresa.TabIndex = 19;
            lbTituloEmpresa.Text = "Empresa Wera";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbConcepSal);
            groupBox1.Controls.Add(lbConceptoPen);
            groupBox1.Controls.Add(lbDiasTrab);
            groupBox1.Controls.Add(lbSalario);
            groupBox1.Controls.Add(numericSalud);
            groupBox1.Controls.Add(numericPension);
            groupBox1.Controls.Add(numericDias);
            groupBox1.Controls.Add(numericSalario);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(186, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 239);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            // 
            // lbConcepSal
            // 
            lbConcepSal.AutoSize = true;
            lbConcepSal.Location = new Point(6, 127);
            lbConcepSal.Name = "lbConcepSal";
            lbConcepSal.Size = new Size(286, 20);
            lbConcepSal.TabIndex = 29;
            lbConcepSal.Text = "Concepto de salud...................................................";
            // 
            // lbConceptoPen
            // 
            lbConceptoPen.AutoSize = true;
            lbConceptoPen.Location = new Point(6, 92);
            lbConceptoPen.Name = "lbConceptoPen";
            lbConceptoPen.Size = new Size(285, 20);
            lbConceptoPen.TabIndex = 28;
            lbConceptoPen.Text = "Concepto de pensión.............................................";
            // 
            // lbDiasTrab
            // 
            lbDiasTrab.AutoSize = true;
            lbDiasTrab.Location = new Point(6, 59);
            lbDiasTrab.Name = "lbDiasTrab";
            lbDiasTrab.Size = new Size(284, 20);
            lbDiasTrab.TabIndex = 27;
            lbDiasTrab.Text = "Días trabajados.........................................................";
            // 
            // lbSalario
            // 
            lbSalario.AutoSize = true;
            lbSalario.Location = new Point(6, 28);
            lbSalario.Name = "lbSalario";
            lbSalario.Size = new Size(283, 20);
            lbSalario.TabIndex = 26;
            lbSalario.Text = "Salario............................................................................";
            // 
            // numericSalud
            // 
            numericSalud.Location = new Point(294, 125);
            numericSalud.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericSalud.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericSalud.Name = "numericSalud";
            numericSalud.Size = new Size(150, 27);
            numericSalud.TabIndex = 4;
            // 
            // numericPension
            // 
            numericPension.Location = new Point(294, 92);
            numericPension.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericPension.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericPension.Name = "numericPension";
            numericPension.Size = new Size(150, 27);
            numericPension.TabIndex = 3;
            // 
            // numericDias
            // 
            numericDias.Location = new Point(294, 59);
            numericDias.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericDias.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericDias.Name = "numericDias";
            numericDias.Size = new Size(150, 27);
            numericDias.TabIndex = 2;
            numericDias.ValueChanged += numericDias_ValueChanged;
            // 
            // numericSalario
            // 
            numericSalario.Location = new Point(294, 26);
            numericSalario.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericSalario.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericSalario.Name = "numericSalario";
            numericSalario.Size = new Size(150, 27);
            numericSalario.TabIndex = 1;
            numericSalario.ValueChanged += numericSalario_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericTotal);
            groupBox2.Location = new Point(0, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 58);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total";
            // 
            // numericTotal
            // 
            numericTotal.Location = new Point(294, 21);
            numericTotal.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericTotal.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(150, 27);
            numericTotal.TabIndex = 5;
            // 
            // formEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lbTituloEmpresa);
            Controls.Add(btVolver);
            Name = "formEmpresa";
            Text = "Ejercicio 9";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSalud).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPension).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSalario).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private Label lbTituloEmpresa;
        private GroupBox groupBox1;
        private NumericUpDown numericSalud;
        private NumericUpDown numericPension;
        private NumericUpDown numericDias;
        private NumericUpDown numericSalario;
        private GroupBox groupBox2;
        private NumericUpDown numericTotal;
        private Label lbConcepSal;
        private Label lbConceptoPen;
        private Label lbDiasTrab;
        private Label lbSalario;
    }
}