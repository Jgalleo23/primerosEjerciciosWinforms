namespace primerosEjerciciosWinforms
{
    partial class formCalcular2
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
            lbTitulo = new Label();
            rbtSumar = new RadioButton();
            rbtRestar = new RadioButton();
            rbtMultiplicar = new RadioButton();
            rbtDividir = new RadioButton();
            rbtTodas = new RadioButton();
            groupAcciones = new GroupBox();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtN3 = new TextBox();
            lbTextoResultados = new Label();
            lbSumar = new Label();
            lbRestar = new Label();
            lbMultiplicar = new Label();
            lbDividir = new Label();
            lbTotal = new Label();
            btAceptar = new Button();
            btBorrar = new Button();
            btVolver = new Button();
            numericN1 = new NumericUpDown();
            numericN2 = new NumericUpDown();
            numericN3 = new NumericUpDown();
            groupAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericN1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericN2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericN3).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitulo.Location = new Point(275, 57);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(274, 37);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Sumar tres números";
            lbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbtSumar
            // 
            rbtSumar.AutoSize = true;
            rbtSumar.Location = new Point(6, 26);
            rbtSumar.Name = "rbtSumar";
            rbtSumar.Size = new Size(89, 32);
            rbtSumar.TabIndex = 1;
            rbtSumar.TabStop = true;
            rbtSumar.Text = "Sumar";
            rbtSumar.UseVisualStyleBackColor = true;
            rbtSumar.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbtRestar
            // 
            rbtRestar.AutoSize = true;
            rbtRestar.Location = new Point(6, 56);
            rbtRestar.Name = "rbtRestar";
            rbtRestar.Size = new Size(86, 32);
            rbtRestar.TabIndex = 2;
            rbtRestar.TabStop = true;
            rbtRestar.Text = "Restar";
            rbtRestar.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicar
            // 
            rbtMultiplicar.AutoSize = true;
            rbtMultiplicar.Location = new Point(6, 86);
            rbtMultiplicar.Name = "rbtMultiplicar";
            rbtMultiplicar.Size = new Size(127, 32);
            rbtMultiplicar.TabIndex = 3;
            rbtMultiplicar.TabStop = true;
            rbtMultiplicar.Text = "Multiplicar";
            rbtMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtDividir
            // 
            rbtDividir.AutoSize = true;
            rbtDividir.Location = new Point(6, 116);
            rbtDividir.Name = "rbtDividir";
            rbtDividir.Size = new Size(91, 32);
            rbtDividir.TabIndex = 4;
            rbtDividir.TabStop = true;
            rbtDividir.Text = "Dividir";
            rbtDividir.UseVisualStyleBackColor = true;
            // 
            // rbtTodas
            // 
            rbtTodas.AutoSize = true;
            rbtTodas.Location = new Point(6, 152);
            rbtTodas.Name = "rbtTodas";
            rbtTodas.Size = new Size(83, 32);
            rbtTodas.TabIndex = 5;
            rbtTodas.TabStop = true;
            rbtTodas.Text = "Todas";
            rbtTodas.UseVisualStyleBackColor = true;
            // 
            // groupAcciones
            // 
            groupAcciones.Controls.Add(rbtSumar);
            groupAcciones.Controls.Add(rbtRestar);
            groupAcciones.Controls.Add(rbtTodas);
            groupAcciones.Controls.Add(rbtMultiplicar);
            groupAcciones.Controls.Add(rbtDividir);
            groupAcciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupAcciones.Location = new Point(51, 109);
            groupAcciones.Name = "groupAcciones";
            groupAcciones.Size = new Size(140, 188);
            groupAcciones.TabIndex = 7;
            groupAcciones.TabStop = false;
            groupAcciones.Text = "Acciones";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(685, 62);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(103, 27);
            txtN1.TabIndex = 8;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(685, 95);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(103, 27);
            txtN2.TabIndex = 9;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(685, 29);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(103, 27);
            txtN3.TabIndex = 10;
            // 
            // lbTextoResultados
            // 
            lbTextoResultados.AutoSize = true;
            lbTextoResultados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTextoResultados.Location = new Point(254, 165);
            lbTextoResultados.Name = "lbTextoResultados";
            lbTextoResultados.Size = new Size(181, 28);
            lbTextoResultados.TabIndex = 11;
            lbTextoResultados.Text = "Los resultados son: ";
            // 
            // lbSumar
            // 
            lbSumar.AutoSize = true;
            lbSumar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbSumar.Location = new Point(254, 202);
            lbSumar.Name = "lbSumar";
            lbSumar.Size = new Size(0, 23);
            lbSumar.TabIndex = 12;
            // 
            // lbRestar
            // 
            lbRestar.AutoSize = true;
            lbRestar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbRestar.Location = new Point(254, 225);
            lbRestar.Name = "lbRestar";
            lbRestar.Size = new Size(0, 23);
            lbRestar.TabIndex = 13;
            // 
            // lbMultiplicar
            // 
            lbMultiplicar.AutoSize = true;
            lbMultiplicar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbMultiplicar.Location = new Point(254, 248);
            lbMultiplicar.Name = "lbMultiplicar";
            lbMultiplicar.Size = new Size(0, 23);
            lbMultiplicar.TabIndex = 14;
            // 
            // lbDividir
            // 
            lbDividir.AutoSize = true;
            lbDividir.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbDividir.Location = new Point(254, 274);
            lbDividir.Name = "lbDividir";
            lbDividir.Size = new Size(0, 23);
            lbDividir.TabIndex = 15;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(254, 307);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(0, 23);
            lbTotal.TabIndex = 16;
            // 
            // btAceptar
            // 
            btAceptar.Location = new Point(303, 346);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(103, 29);
            btAceptar.TabIndex = 17;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            btAceptar.Click += btAceptar_Click;
            // 
            // btBorrar
            // 
            btBorrar.Location = new Point(423, 346);
            btBorrar.Name = "btBorrar";
            btBorrar.Size = new Size(103, 29);
            btBorrar.TabIndex = 18;
            btBorrar.Text = "Borrar";
            btBorrar.UseVisualStyleBackColor = true;
            btBorrar.Click += btBorrar_Click;
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 20;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // numericN1
            // 
            numericN1.Location = new Point(254, 109);
            numericN1.Name = "numericN1";
            numericN1.Size = new Size(103, 27);
            numericN1.TabIndex = 21;
            // 
            // numericN2
            // 
            numericN2.Location = new Point(363, 109);
            numericN2.Name = "numericN2";
            numericN2.Size = new Size(103, 27);
            numericN2.TabIndex = 22;
            // 
            // numericN3
            // 
            numericN3.Location = new Point(472, 109);
            numericN3.Name = "numericN3";
            numericN3.Size = new Size(103, 27);
            numericN3.TabIndex = 23;
            // 
            // formCalcular2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(numericN3);
            Controls.Add(numericN2);
            Controls.Add(numericN1);
            Controls.Add(btVolver);
            Controls.Add(btBorrar);
            Controls.Add(btAceptar);
            Controls.Add(lbTotal);
            Controls.Add(lbDividir);
            Controls.Add(lbMultiplicar);
            Controls.Add(lbRestar);
            Controls.Add(lbSumar);
            Controls.Add(lbTextoResultados);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(groupAcciones);
            Controls.Add(lbTitulo);
            Name = "formCalcular2";
            Text = "Ejercicio 7";
            Load += formCalcular2_Load;
            groupAcciones.ResumeLayout(false);
            groupAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericN1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericN2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericN3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private RadioButton rbtSumar;
        private RadioButton rbtRestar;
        private RadioButton rbtMultiplicar;
        private RadioButton rbtDividir;
        private RadioButton rbtTodas;
        private GroupBox groupAcciones;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private Label lbTextoResultados;
        private Label lbSumar;
        private Label lbRestar;
        private Label lbMultiplicar;
        private Label lbDividir;
        private Label lbTotal;
        private Button btAceptar;
        private Button btBorrar;
        private Button btVolver;
        private NumericUpDown numericN1;
        private NumericUpDown numericN2;
        private NumericUpDown numericN3;
    }
}