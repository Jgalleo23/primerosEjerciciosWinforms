namespace primerosEjerciciosWinforms
{
    partial class formInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicio));
            btInicio = new Button();
            btSalir = new Button();
            imgPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgPortada).BeginInit();
            SuspendLayout();
            // 
            // btInicio
            // 
            btInicio.Cursor = Cursors.Hand;
            btInicio.Location = new Point(327, 330);
            btInicio.Name = "btInicio";
            btInicio.Size = new Size(111, 47);
            btInicio.TabIndex = 0;
            btInicio.Text = "Ver ejercicios";
            btInicio.UseVisualStyleBackColor = true;
            btInicio.Click += btInicio_Click;
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(335, 383);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(96, 31);
            btSalir.TabIndex = 1;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // imgPortada
            // 
            imgPortada.ImageLocation = resources.GetString("imgPortada.ImageLocation");
            imgPortada.Location = new Point(180, 93);
            imgPortada.Name = "imgPortada";
            imgPortada.Size = new Size(415, 231);
            imgPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPortada.TabIndex = 2;
            imgPortada.TabStop = false;
            // 
            // formInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(imgPortada);
            Controls.Add(btSalir);
            Controls.Add(btInicio);
            Name = "formInicio";
            Text = "Desarrollo de interfaces";
            ((System.ComponentModel.ISupportInitialize)imgPortada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btInicio;
        private Button btSalir;
        private PictureBox imgPortada;
    }
}