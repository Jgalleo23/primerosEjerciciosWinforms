namespace primerosEjerciciosWinforms
{
    partial class formSuperTienda
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
            groupPrecioSolo = new GroupBox();
            numericPU3 = new NumericUpDown();
            numericPU2 = new NumericUpDown();
            numericPU1 = new NumericUpDown();
            groupPrecioFinal = new GroupBox();
            numericPF3 = new NumericUpDown();
            numericPF2 = new NumericUpDown();
            numericPF1 = new NumericUpDown();
            groupCantidad = new GroupBox();
            numericCant3 = new NumericUpDown();
            numericCant2 = new NumericUpDown();
            numericCant1 = new NumericUpDown();
            groupArticulos = new GroupBox();
            comboArt3 = new ComboBox();
            comboArt2 = new ComboBox();
            comboArt1 = new ComboBox();
            lbTituloTienda = new Label();
            groupTotal = new GroupBox();
            numericTodo = new NumericUpDown();
            groupPrecioSolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPU3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPU2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPU1).BeginInit();
            groupPrecioFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPF3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPF2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPF1).BeginInit();
            groupCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCant3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCant2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCant1).BeginInit();
            groupArticulos.SuspendLayout();
            groupTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTodo).BeginInit();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 2;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // groupPrecioSolo
            // 
            groupPrecioSolo.Controls.Add(numericPU3);
            groupPrecioSolo.Controls.Add(numericPU2);
            groupPrecioSolo.Controls.Add(numericPU1);
            groupPrecioSolo.Location = new Point(400, 136);
            groupPrecioSolo.Name = "groupPrecioSolo";
            groupPrecioSolo.Size = new Size(162, 155);
            groupPrecioSolo.TabIndex = 22;
            groupPrecioSolo.TabStop = false;
            groupPrecioSolo.Text = "Precio Unitario";
            // 
            // numericPU3
            // 
            numericPU3.Location = new Point(6, 115);
            numericPU3.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericPU3.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericPU3.Name = "numericPU3";
            numericPU3.Size = new Size(150, 27);
            numericPU3.TabIndex = 12;
            // 
            // numericPU2
            // 
            numericPU2.Location = new Point(6, 81);
            numericPU2.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericPU2.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericPU2.Name = "numericPU2";
            numericPU2.Size = new Size(150, 27);
            numericPU2.TabIndex = 11;
            // 
            // numericPU1
            // 
            numericPU1.Location = new Point(6, 47);
            numericPU1.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericPU1.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericPU1.Name = "numericPU1";
            numericPU1.Size = new Size(150, 27);
            numericPU1.TabIndex = 10;
            // 
            // groupPrecioFinal
            // 
            groupPrecioFinal.Controls.Add(numericPF3);
            groupPrecioFinal.Controls.Add(numericPF2);
            groupPrecioFinal.Controls.Add(numericPF1);
            groupPrecioFinal.Location = new Point(568, 136);
            groupPrecioFinal.Name = "groupPrecioFinal";
            groupPrecioFinal.Size = new Size(162, 155);
            groupPrecioFinal.TabIndex = 23;
            groupPrecioFinal.TabStop = false;
            groupPrecioFinal.Text = "Precio final";
            // 
            // numericPF3
            // 
            numericPF3.Location = new Point(6, 114);
            numericPF3.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericPF3.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericPF3.Name = "numericPF3";
            numericPF3.Size = new Size(150, 27);
            numericPF3.TabIndex = 15;
            // 
            // numericPF2
            // 
            numericPF2.Location = new Point(6, 81);
            numericPF2.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericPF2.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericPF2.Name = "numericPF2";
            numericPF2.Size = new Size(150, 27);
            numericPF2.TabIndex = 14;
            // 
            // numericPF1
            // 
            numericPF1.Location = new Point(6, 47);
            numericPF1.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericPF1.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericPF1.Name = "numericPF1";
            numericPF1.Size = new Size(150, 27);
            numericPF1.TabIndex = 13;
            // 
            // groupCantidad
            // 
            groupCantidad.Controls.Add(numericCant3);
            groupCantidad.Controls.Add(numericCant2);
            groupCantidad.Controls.Add(numericCant1);
            groupCantidad.Location = new Point(232, 136);
            groupCantidad.Name = "groupCantidad";
            groupCantidad.Size = new Size(162, 155);
            groupCantidad.TabIndex = 21;
            groupCantidad.TabStop = false;
            groupCantidad.Text = "Cantidad";
            // 
            // numericCant3
            // 
            numericCant3.Location = new Point(6, 115);
            numericCant3.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericCant3.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericCant3.Name = "numericCant3";
            numericCant3.Size = new Size(150, 27);
            numericCant3.TabIndex = 12;
            numericCant3.ValueChanged += numericCant3_ValueChanged;
            // 
            // numericCant2
            // 
            numericCant2.Location = new Point(6, 81);
            numericCant2.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericCant2.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericCant2.Name = "numericCant2";
            numericCant2.Size = new Size(150, 27);
            numericCant2.TabIndex = 11;
            numericCant2.ValueChanged += numericCant2_ValueChanged;
            // 
            // numericCant1
            // 
            numericCant1.Location = new Point(6, 47);
            numericCant1.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericCant1.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericCant1.Name = "numericCant1";
            numericCant1.Size = new Size(150, 27);
            numericCant1.TabIndex = 10;
            numericCant1.ValueChanged += numericCant1_ValueChanged;
            // 
            // groupArticulos
            // 
            groupArticulos.Controls.Add(comboArt3);
            groupArticulos.Controls.Add(comboArt2);
            groupArticulos.Controls.Add(comboArt1);
            groupArticulos.Location = new Point(64, 136);
            groupArticulos.Name = "groupArticulos";
            groupArticulos.Size = new Size(162, 155);
            groupArticulos.TabIndex = 20;
            groupArticulos.TabStop = false;
            groupArticulos.Text = "Artículo";
            // 
            // comboArt3
            // 
            comboArt3.FormattingEnabled = true;
            comboArt3.Items.AddRange(new object[] { "Tornillo", "Tablón de madera", "Ladrillo", "Tuerca", "Arandela" });
            comboArt3.Location = new Point(6, 114);
            comboArt3.Name = "comboArt3";
            comboArt3.Size = new Size(151, 28);
            comboArt3.TabIndex = 7;
            comboArt3.SelectedIndexChanged += comboArt3_SelectedIndexChanged_1;
            // 
            // comboArt2
            // 
            comboArt2.FormattingEnabled = true;
            comboArt2.Items.AddRange(new object[] { "Tornillo", "Tablón de madera", "Ladrillo", "Tuerca", "Arandela" });
            comboArt2.Location = new Point(5, 80);
            comboArt2.Name = "comboArt2";
            comboArt2.Size = new Size(151, 28);
            comboArt2.TabIndex = 6;
            comboArt2.SelectedIndexChanged += comboArt2_SelectedIndexChanged_1;
            // 
            // comboArt1
            // 
            comboArt1.FormattingEnabled = true;
            comboArt1.Items.AddRange(new object[] { "Tornillo", "Tablón de madera", "Ladrillo", "Tuerca", "Arandela" });
            comboArt1.Location = new Point(6, 46);
            comboArt1.Name = "comboArt1";
            comboArt1.Size = new Size(151, 28);
            comboArt1.TabIndex = 5;
            comboArt1.SelectedIndexChanged += comboArt1_SelectedIndexChanged_1;
            // 
            // lbTituloTienda
            // 
            lbTituloTienda.AutoSize = true;
            lbTituloTienda.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloTienda.Location = new Point(257, 72);
            lbTituloTienda.Name = "lbTituloTienda";
            lbTituloTienda.Size = new Size(280, 30);
            lbTituloTienda.TabIndex = 19;
            lbTituloTienda.Text = "Materiales Dolores y Paco";
            // 
            // groupTotal
            // 
            groupTotal.Controls.Add(numericTodo);
            groupTotal.Location = new Point(64, 297);
            groupTotal.Name = "groupTotal";
            groupTotal.Size = new Size(666, 50);
            groupTotal.TabIndex = 25;
            groupTotal.TabStop = false;
            groupTotal.Text = "Total";
            // 
            // numericTodo
            // 
            numericTodo.Location = new Point(510, 17);
            numericTodo.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numericTodo.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            numericTodo.Name = "numericTodo";
            numericTodo.Size = new Size(150, 27);
            numericTodo.TabIndex = 16;
            // 
            // formSuperTienda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(groupTotal);
            Controls.Add(groupPrecioSolo);
            Controls.Add(groupPrecioFinal);
            Controls.Add(groupCantidad);
            Controls.Add(groupArticulos);
            Controls.Add(lbTituloTienda);
            Controls.Add(btVolver);
            Name = "formSuperTienda";
            Text = "Ejercicio 10";
            groupPrecioSolo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericPU3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPU2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPU1).EndInit();
            groupPrecioFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericPF3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPF2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPF1).EndInit();
            groupCantidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericCant3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCant2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCant1).EndInit();
            groupArticulos.ResumeLayout(false);
            groupTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericTodo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private GroupBox groupPrecioSolo;
        private NumericUpDown numericPU3;
        private NumericUpDown numericPU2;
        private NumericUpDown numericPU1;
        private GroupBox groupPrecioFinal;
        private NumericUpDown numericPF3;
        private NumericUpDown numericPF2;
        private NumericUpDown numericPF1;
        private GroupBox groupCantidad;
        private NumericUpDown numericCant3;
        private NumericUpDown numericCant2;
        private NumericUpDown numericCant1;
        private GroupBox groupArticulos;
        private ComboBox comboArt3;
        private ComboBox comboArt2;
        private ComboBox comboArt1;
        private Label lbTituloTienda;
        private GroupBox groupTotal;
        private NumericUpDown numericTodo;
    }
}