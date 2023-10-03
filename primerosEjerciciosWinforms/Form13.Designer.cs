namespace primerosEjerciciosWinforms
{
    partial class formEjercicio12
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
            lbPalabra = new Label();
            txtPalabra = new TextBox();
            btAnadir = new Button();
            lboxPalabras = new ListBox();
            btVolver = new Button();
            gridviewEstadisticas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridviewEstadisticas).BeginInit();
            SuspendLayout();
            // 
            // lbPalabra
            // 
            lbPalabra.AutoSize = true;
            lbPalabra.Location = new Point(13, 112);
            lbPalabra.Name = "lbPalabra";
            lbPalabra.Size = new Size(58, 20);
            lbPalabra.TabIndex = 0;
            lbPalabra.Text = "Palabra";
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(77, 109);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(125, 27);
            txtPalabra.TabIndex = 1;
            // 
            // btAnadir
            // 
            btAnadir.Location = new Point(208, 109);
            btAnadir.Name = "btAnadir";
            btAnadir.Size = new Size(94, 29);
            btAnadir.TabIndex = 2;
            btAnadir.Text = "Añadir";
            btAnadir.UseVisualStyleBackColor = true;
            // 
            // lboxPalabras
            // 
            lboxPalabras.FormattingEnabled = true;
            lboxPalabras.ItemHeight = 20;
            lboxPalabras.Location = new Point(308, 57);
            lboxPalabras.Name = "lboxPalabras";
            lboxPalabras.Size = new Size(163, 284);
            lboxPalabras.TabIndex = 3;
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 17;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // gridviewEstadisticas
            // 
            gridviewEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewEstadisticas.Location = new Point(488, 109);
            gridviewEstadisticas.Name = "gridviewEstadisticas";
            gridviewEstadisticas.RowHeadersWidth = 51;
            gridviewEstadisticas.RowTemplate.Height = 29;
            gridviewEstadisticas.Size = new Size(300, 188);
            gridviewEstadisticas.TabIndex = 18;
            // 
            // formEjercicio12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(gridviewEstadisticas);
            Controls.Add(btVolver);
            Controls.Add(lboxPalabras);
            Controls.Add(btAnadir);
            Controls.Add(txtPalabra);
            Controls.Add(lbPalabra);
            Name = "formEjercicio12";
            Text = "Ejercicio 12";
            ((System.ComponentModel.ISupportInitialize)gridviewEstadisticas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPalabra;
        private TextBox txtPalabra;
        private Button btAnadir;
        private ListBox lboxPalabras;
        private Button btVolver;
        private DataGridView gridviewEstadisticas;
    }
}