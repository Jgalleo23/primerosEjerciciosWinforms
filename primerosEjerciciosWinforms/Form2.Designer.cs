namespace primerosEjerciciosWinforms
{
    partial class formPantalla2
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
            btCalculadora = new Button();
            imgCalculadora = new PictureBox();
            pictureBox1 = new PictureBox();
            btPalabras = new Button();
            pictureBox2 = new PictureBox();
            btAdivino = new Button();
            ((System.ComponentModel.ISupportInitialize)imgCalculadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 0;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // btCalculadora
            // 
            btCalculadora.Cursor = Cursors.Hand;
            btCalculadora.Location = new Point(34, 119);
            btCalculadora.Name = "btCalculadora";
            btCalculadora.Size = new Size(94, 29);
            btCalculadora.TabIndex = 1;
            btCalculadora.Text = "Ejercicio 1";
            btCalculadora.UseVisualStyleBackColor = true;
            btCalculadora.Click += btCalculadora_Click;
            // 
            // imgCalculadora
            // 
            imgCalculadora.ImageLocation = "https://imgs.search.brave.com/PSezixCFzzcItWlc2iWQ7WCtIDRxTOTXh_q47ch-ozk/rs:fit:500:0:0/g:ce/aHR0cHM6Ly9jYWxj/dWxhdG9yLTEuY29t/L2ltYWdlcy90ZW1w/bGF0ZS9vbmxpbmUt/Y2FsY3VsYXRvci0x/LnBuZw";
            imgCalculadora.Location = new Point(34, 12);
            imgCalculadora.Name = "imgCalculadora";
            imgCalculadora.Size = new Size(94, 89);
            imgCalculadora.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCalculadora.TabIndex = 2;
            imgCalculadora.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://imgs.search.brave.com/Lm1Jt_jmD-UjtZHG4eY4TZSB5NcVcZW-sRtqVjDsq3k/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9kbGUu/cmFlLmVzL2FwcC9k/b2MvZXMvaW1nL2Rs/ZS5qcGc";
            pictureBox1.Location = new Point(162, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btPalabras
            // 
            btPalabras.Cursor = Cursors.Hand;
            btPalabras.Location = new Point(162, 119);
            btPalabras.Name = "btPalabras";
            btPalabras.Size = new Size(94, 29);
            btPalabras.TabIndex = 4;
            btPalabras.Text = "Ejercicio 2";
            btPalabras.UseVisualStyleBackColor = true;
            btPalabras.Click += btPalabras_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "https://imgs.search.brave.com/NAMPmvW54KB54rejVQXh74j4Cb46rHQ1p_dyMaQOCtw/rs:fit:860:0:0/g:ce/aHR0cHM6Ly9kZWZp/bmljaW9uLmRlL3dw/LWNvbnRlbnQvdXBs/b2Fkcy8yMDA5LzA1/L251bWVyb3MtMS5q/cGc";
            pictureBox2.Location = new Point(287, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btAdivino
            // 
            btAdivino.Cursor = Cursors.Hand;
            btAdivino.Location = new Point(287, 119);
            btAdivino.Name = "btAdivino";
            btAdivino.Size = new Size(94, 29);
            btAdivino.TabIndex = 6;
            btAdivino.Text = "Ejercicio 3";
            btAdivino.UseVisualStyleBackColor = true;
            btAdivino.Click += btAdivino_Click;
            // 
            // formPantalla2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btAdivino);
            Controls.Add(pictureBox2);
            Controls.Add(btPalabras);
            Controls.Add(pictureBox1);
            Controls.Add(imgCalculadora);
            Controls.Add(btCalculadora);
            Controls.Add(btVolver);
            Name = "formPantalla2";
            Text = "Ejercicios";
            ((System.ComponentModel.ISupportInitialize)imgCalculadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btVolver;
        private Button btCalculadora;
        private PictureBox imgCalculadora;
        private PictureBox pictureBox1;
        private Button btPalabras;
        private PictureBox pictureBox2;
        private Button btAdivino;
    }
}