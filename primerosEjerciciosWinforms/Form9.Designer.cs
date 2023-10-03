namespace primerosEjerciciosWinforms
{
    partial class formTienda
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
            lbTituloTienda = new Label();
            comboArt1 = new ComboBox();
            comboArt2 = new ComboBox();
            comboArt3 = new ComboBox();
            groupArticulos = new GroupBox();
            groupCantidad = new GroupBox();
            numericCant3 = new NumericUpDown();
            numericCant2 = new NumericUpDown();
            numericCant1 = new NumericUpDown();
            groupPrecioTotal = new GroupBox();
            numericPT3 = new NumericUpDown();
            numericPT2 = new NumericUpDown();
            numericPT1 = new NumericUpDown();
            btVolver = new Button();
            groupPrecioSolo = new GroupBox();
            numericPU3 = new NumericUpDown();
            numericPU2 = new NumericUpDown();
            numericPU1 = new NumericUpDown();
            groupPrecioFinal = new GroupBox();
            numericPF3 = new NumericUpDown();
            numericPF2 = new NumericUpDown();
            numericPF1 = new NumericUpDown();
            groupTotal = new GroupBox();
            numericTodo = new NumericUpDown();
            groupArticulos.SuspendLayout();
            groupCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCant3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCant2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCant1).BeginInit();
            groupPrecioTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPT3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPT2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPT1).BeginInit();
            groupPrecioSolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPU3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPU2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPU1).BeginInit();
            groupPrecioFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPF3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPF2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPF1).BeginInit();
            groupTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTodo).BeginInit();
            SuspendLayout();
            // 
            // lbTituloTienda
            // 
            lbTituloTienda.AutoSize = true;
            lbTituloTienda.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloTienda.Location = new Point(312, 31);
            lbTituloTienda.Name = "lbTituloTienda";
            lbTituloTienda.Size = new Size(173, 30);
            lbTituloTienda.TabIndex = 0;
            lbTituloTienda.Text = "Productos Mari";
            // 
            // comboArt1
            // 
            comboArt1.FormattingEnabled = true;
            comboArt1.Items.AddRange(new object[] { "Pan", "Café en polvo", "Croissant", "Fairy" });
            comboArt1.Location = new Point(6, 46);
            comboArt1.Name = "comboArt1";
            comboArt1.Size = new Size(127, 28);
            comboArt1.TabIndex = 5;
            comboArt1.SelectedIndexChanged += comboArt1_SelectedIndexChanged;
            // 
            // comboArt2
            // 
            comboArt2.FormattingEnabled = true;
            comboArt2.Items.AddRange(new object[] { "Pan", "Café en polvo", "Croissant", "Fairy" });
            comboArt2.Location = new Point(5, 80);
            comboArt2.Name = "comboArt2";
            comboArt2.Size = new Size(128, 28);
            comboArt2.TabIndex = 6;
            comboArt2.SelectedIndexChanged += comboArt2_SelectedIndexChanged;
            // 
            // comboArt3
            // 
            comboArt3.FormattingEnabled = true;
            comboArt3.Items.AddRange(new object[] { "Pan", "Café en polvo", "Croissant", "Fairy" });
            comboArt3.Location = new Point(6, 114);
            comboArt3.Name = "comboArt3";
            comboArt3.Size = new Size(127, 28);
            comboArt3.TabIndex = 7;
            comboArt3.SelectedIndexChanged += comboArt3_SelectedIndexChanged;
            // 
            // groupArticulos
            // 
            groupArticulos.Controls.Add(comboArt3);
            groupArticulos.Controls.Add(comboArt2);
            groupArticulos.Controls.Add(comboArt1);
            groupArticulos.Location = new Point(33, 106);
            groupArticulos.Name = "groupArticulos";
            groupArticulos.Size = new Size(144, 155);
            groupArticulos.TabIndex = 4;
            groupArticulos.TabStop = false;
            groupArticulos.Text = "Artículo";
            // 
            // groupCantidad
            // 
            groupCantidad.Controls.Add(numericCant3);
            groupCantidad.Controls.Add(numericCant2);
            groupCantidad.Controls.Add(numericCant1);
            groupCantidad.Location = new Point(183, 106);
            groupCantidad.Name = "groupCantidad";
            groupCantidad.Size = new Size(144, 155);
            groupCantidad.TabIndex = 9;
            groupCantidad.TabStop = false;
            groupCantidad.Text = "Cantidad";
            // 
            // numericCant3
            // 
            numericCant3.Location = new Point(6, 115);
            numericCant3.Name = "numericCant3";
            numericCant3.Size = new Size(128, 27);
            numericCant3.TabIndex = 12;
            numericCant3.ValueChanged += numericCant3_ValueChanged;
            // 
            // numericCant2
            // 
            numericCant2.Location = new Point(6, 81);
            numericCant2.Name = "numericCant2";
            numericCant2.Size = new Size(128, 27);
            numericCant2.TabIndex = 11;
            numericCant2.ValueChanged += numericCant2_ValueChanged;
            // 
            // numericCant1
            // 
            numericCant1.Location = new Point(6, 46);
            numericCant1.Name = "numericCant1";
            numericCant1.Size = new Size(128, 27);
            numericCant1.TabIndex = 10;
            numericCant1.ValueChanged += numericCant1_ValueChanged;
            // 
            // groupPrecioTotal
            // 
            groupPrecioTotal.Controls.Add(numericPT3);
            groupPrecioTotal.Controls.Add(numericPT2);
            groupPrecioTotal.Controls.Add(numericPT1);
            groupPrecioTotal.Location = new Point(483, 106);
            groupPrecioTotal.Name = "groupPrecioTotal";
            groupPrecioTotal.Size = new Size(144, 155);
            groupPrecioTotal.TabIndex = 14;
            groupPrecioTotal.TabStop = false;
            groupPrecioTotal.Text = "Precio total";
            // 
            // numericPT3
            // 
            numericPT3.Location = new Point(6, 114);
            numericPT3.Name = "numericPT3";
            numericPT3.Size = new Size(127, 27);
            numericPT3.TabIndex = 15;
            // 
            // numericPT2
            // 
            numericPT2.Location = new Point(6, 81);
            numericPT2.Name = "numericPT2";
            numericPT2.Size = new Size(127, 27);
            numericPT2.TabIndex = 14;
            // 
            // numericPT1
            // 
            numericPT1.Location = new Point(6, 47);
            numericPT1.Name = "numericPT1";
            numericPT1.Size = new Size(127, 27);
            numericPT1.TabIndex = 13;
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 16;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // groupPrecioSolo
            // 
            groupPrecioSolo.Controls.Add(numericPU3);
            groupPrecioSolo.Controls.Add(numericPU2);
            groupPrecioSolo.Controls.Add(numericPU1);
            groupPrecioSolo.Location = new Point(333, 106);
            groupPrecioSolo.Name = "groupPrecioSolo";
            groupPrecioSolo.Size = new Size(144, 155);
            groupPrecioSolo.TabIndex = 13;
            groupPrecioSolo.TabStop = false;
            groupPrecioSolo.Text = "Precio Unitario";
            // 
            // numericPU3
            // 
            numericPU3.Location = new Point(6, 115);
            numericPU3.Name = "numericPU3";
            numericPU3.Size = new Size(127, 27);
            numericPU3.TabIndex = 12;
            // 
            // numericPU2
            // 
            numericPU2.Location = new Point(6, 81);
            numericPU2.Name = "numericPU2";
            numericPU2.Size = new Size(127, 27);
            numericPU2.TabIndex = 11;
            // 
            // numericPU1
            // 
            numericPU1.Location = new Point(6, 47);
            numericPU1.Name = "numericPU1";
            numericPU1.Size = new Size(127, 27);
            numericPU1.TabIndex = 10;
            // 
            // groupPrecioFinal
            // 
            groupPrecioFinal.Controls.Add(numericPF3);
            groupPrecioFinal.Controls.Add(numericPF2);
            groupPrecioFinal.Controls.Add(numericPF1);
            groupPrecioFinal.Location = new Point(633, 106);
            groupPrecioFinal.Name = "groupPrecioFinal";
            groupPrecioFinal.Size = new Size(144, 155);
            groupPrecioFinal.TabIndex = 16;
            groupPrecioFinal.TabStop = false;
            groupPrecioFinal.Text = "Precio final";
            // 
            // numericPF3
            // 
            numericPF3.Location = new Point(6, 114);
            numericPF3.Name = "numericPF3";
            numericPF3.Size = new Size(127, 27);
            numericPF3.TabIndex = 15;
            numericPF3.ValueChanged += numericPF3_ValueChanged;
            // 
            // numericPF2
            // 
            numericPF2.Location = new Point(6, 81);
            numericPF2.Name = "numericPF2";
            numericPF2.Size = new Size(127, 27);
            numericPF2.TabIndex = 14;
            numericPF2.ValueChanged += numericPF2_ValueChanged;
            // 
            // numericPF1
            // 
            numericPF1.Location = new Point(6, 47);
            numericPF1.Name = "numericPF1";
            numericPF1.Size = new Size(127, 27);
            numericPF1.TabIndex = 13;
            numericPF1.ValueChanged += numericPF1_ValueChanged;
            // 
            // groupTotal
            // 
            groupTotal.Controls.Add(numericTodo);
            groupTotal.Location = new Point(33, 267);
            groupTotal.Name = "groupTotal";
            groupTotal.Size = new Size(744, 49);
            groupTotal.TabIndex = 17;
            groupTotal.TabStop = false;
            groupTotal.Text = "Total";
            // 
            // numericTodo
            // 
            numericTodo.Location = new Point(606, 16);
            numericTodo.Name = "numericTodo";
            numericTodo.Size = new Size(127, 27);
            numericTodo.TabIndex = 16;
            // 
            // formTienda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(groupTotal);
            Controls.Add(groupPrecioFinal);
            Controls.Add(groupPrecioSolo);
            Controls.Add(btVolver);
            Controls.Add(groupPrecioTotal);
            Controls.Add(groupCantidad);
            Controls.Add(groupArticulos);
            Controls.Add(lbTituloTienda);
            Name = "formTienda";
            Text = "Ejercicio 8";
            groupArticulos.ResumeLayout(false);
            groupCantidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericCant3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCant2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCant1).EndInit();
            groupPrecioTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericPT3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPT2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPT1).EndInit();
            groupPrecioSolo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericPU3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPU2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPU1).EndInit();
            groupPrecioFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericPF3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPF2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPF1).EndInit();
            groupTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericTodo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloTienda;
        private ComboBox comboArt1;
        private ComboBox comboArt2;
        private ComboBox comboArt3;
        private ComboBox comboBox4;
        private GroupBox groupArticulos;
        private GroupBox groupCantidad;
        private NumericUpDown numericCant3;
        private NumericUpDown numericCant2;
        private NumericUpDown numericCant1;
        private GroupBox groupPrecioTotal;
        private Label label3;
        private Label label2;
        private Button btVolver;
        private GroupBox groupPrecioSolo;
        private NumericUpDown numericPU3;
        private NumericUpDown numericPU2;
        private NumericUpDown numericPU1;
        private NumericUpDown numericPT3;
        private NumericUpDown numericPT2;
        private NumericUpDown numericPT1;
        private GroupBox groupPrecioFinal;
        private NumericUpDown numericPF3;
        private NumericUpDown numericPF2;
        private NumericUpDown numericPF1;
        private GroupBox groupTotal;
        private NumericUpDown numericTodo;
    }
}