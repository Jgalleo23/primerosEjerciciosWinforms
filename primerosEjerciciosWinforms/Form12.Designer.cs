namespace primerosEjerciciosWinforms
{
    partial class formEncuesta
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
            rbtSi = new RadioButton();
            rbtNo = new RadioButton();
            rbtNoseNocont = new RadioButton();
            btVotar = new Button();
            lbNoseNocont = new Label();
            lbNo = new Label();
            lbSi = new Label();
            lbTextoVotosTot = new Label();
            btVolver = new Button();
            pbSi = new ProgressBar();
            pbNo = new ProgressBar();
            pbNoseNocont = new ProgressBar();
            groupVotar = new GroupBox();
            groupVotar.SuspendLayout();
            SuspendLayout();
            // 
            // rbtSi
            // 
            rbtSi.AutoSize = true;
            rbtSi.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rbtSi.Location = new Point(6, 26);
            rbtSi.Name = "rbtSi";
            rbtSi.Size = new Size(55, 36);
            rbtSi.TabIndex = 0;
            rbtSi.TabStop = true;
            rbtSi.Text = "Si";
            rbtSi.UseVisualStyleBackColor = true;
            // 
            // rbtNo
            // 
            rbtNo.AutoSize = true;
            rbtNo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rbtNo.Location = new Point(6, 68);
            rbtNo.Name = "rbtNo";
            rbtNo.Size = new Size(69, 36);
            rbtNo.TabIndex = 1;
            rbtNo.TabStop = true;
            rbtNo.Text = "No";
            rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtNoseNocont
            // 
            rbtNoseNocont.AutoSize = true;
            rbtNoseNocont.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rbtNoseNocont.Location = new Point(6, 110);
            rbtNoseNocont.Name = "rbtNoseNocont";
            rbtNoseNocont.Size = new Size(112, 36);
            rbtNoseNocont.TabIndex = 2;
            rbtNoseNocont.TabStop = true;
            rbtNoseNocont.Text = "NS/NC";
            rbtNoseNocont.UseVisualStyleBackColor = true;
            // 
            // btVotar
            // 
            btVotar.Location = new Point(6, 161);
            btVotar.Name = "btVotar";
            btVotar.Size = new Size(94, 29);
            btVotar.TabIndex = 3;
            btVotar.Text = "Votar";
            btVotar.UseVisualStyleBackColor = true;
            btVotar.Click += btVotar_Click;
            // 
            // lbNoseNocont
            // 
            lbNoseNocont.AutoSize = true;
            lbNoseNocont.Location = new Point(124, 122);
            lbNoseNocont.Name = "lbNoseNocont";
            lbNoseNocont.Size = new Size(17, 20);
            lbNoseNocont.TabIndex = 4;
            lbNoseNocont.Text = "0";
            // 
            // lbNo
            // 
            lbNo.AutoSize = true;
            lbNo.Location = new Point(124, 80);
            lbNo.Name = "lbNo";
            lbNo.Size = new Size(17, 20);
            lbNo.TabIndex = 5;
            lbNo.Text = "0";
            // 
            // lbSi
            // 
            lbSi.AutoSize = true;
            lbSi.Location = new Point(124, 38);
            lbSi.Name = "lbSi";
            lbSi.Size = new Size(17, 20);
            lbSi.TabIndex = 6;
            lbSi.Text = "0";
            // 
            // lbTextoVotosTot
            // 
            lbTextoVotosTot.AutoSize = true;
            lbTextoVotosTot.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbTextoVotosTot.Location = new Point(6, 211);
            lbTextoVotosTot.Name = "lbTextoVotosTot";
            lbTextoVotosTot.Size = new Size(73, 32);
            lbTextoVotosTot.TabIndex = 7;
            lbTextoVotosTot.Text = "Votos";
            // 
            // btVolver
            // 
            btVolver.Cursor = Cursors.Hand;
            btVolver.Location = new Point(694, 409);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(94, 29);
            btVolver.TabIndex = 8;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = true;
            btVolver.Click += btVolver_Click;
            // 
            // pbSi
            // 
            pbSi.Location = new Point(170, 33);
            pbSi.Name = "pbSi";
            pbSi.Size = new Size(125, 29);
            pbSi.TabIndex = 9;
            // 
            // pbNo
            // 
            pbNo.Location = new Point(170, 75);
            pbNo.Name = "pbNo";
            pbNo.Size = new Size(125, 29);
            pbNo.TabIndex = 10;
            // 
            // pbNoseNocont
            // 
            pbNoseNocont.Location = new Point(170, 117);
            pbNoseNocont.Name = "pbNoseNocont";
            pbNoseNocont.Size = new Size(125, 29);
            pbNoseNocont.TabIndex = 11;
            // 
            // groupVotar
            // 
            groupVotar.Controls.Add(rbtSi);
            groupVotar.Controls.Add(pbNoseNocont);
            groupVotar.Controls.Add(rbtNo);
            groupVotar.Controls.Add(pbNo);
            groupVotar.Controls.Add(rbtNoseNocont);
            groupVotar.Controls.Add(pbSi);
            groupVotar.Controls.Add(btVotar);
            groupVotar.Controls.Add(lbNoseNocont);
            groupVotar.Controls.Add(lbTextoVotosTot);
            groupVotar.Controls.Add(lbNo);
            groupVotar.Controls.Add(lbSi);
            groupVotar.Location = new Point(249, 71);
            groupVotar.Name = "groupVotar";
            groupVotar.Size = new Size(319, 281);
            groupVotar.TabIndex = 12;
            groupVotar.TabStop = false;
            groupVotar.Text = "Votar";
            // 
            // formEncuesta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(groupVotar);
            Controls.Add(btVolver);
            Name = "formEncuesta";
            Text = "Ejercicio 11";
            groupVotar.ResumeLayout(false);
            groupVotar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbtSi;
        private RadioButton rbtNo;
        private RadioButton rbtNoseNocont;
        private Button btVotar;
        private Label lbNoseNocont;
        private Label lbNo;
        private Label lbSi;
        private Label lbTextoVotosTot;
        private Button btVolver;
        private ProgressBar pbSi;
        private ProgressBar pbNo;
        private ProgressBar pbNoseNocont;
        private GroupBox groupVotar;
    }
}