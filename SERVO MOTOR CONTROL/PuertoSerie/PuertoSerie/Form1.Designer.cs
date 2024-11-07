namespace PuertoSerie
{
    partial class frmSerie
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
            label1 = new Label();
            cmbPuertos = new ComboBox();
            btnConectar = new Button();
            label2 = new Label();
            btnActualizar = new Button();
            trackBar1 = new TrackBar();
            label3 = new Label();
            labelValor = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 0;
            label1.Text = "CONTROL SERVOMOTOR";
            // 
            // cmbPuertos
            // 
            cmbPuertos.FormattingEnabled = true;
            cmbPuertos.Location = new Point(14, 36);
            cmbPuertos.Margin = new Padding(3, 4, 3, 4);
            cmbPuertos.Name = "cmbPuertos";
            cmbPuertos.Size = new Size(313, 28);
            cmbPuertos.TabIndex = 1;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(334, 35);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(86, 31);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 99);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(426, 35);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(99, 99);
            trackBar1.Maximum = 179;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(321, 56);
            trackBar1.TabIndex = 8;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 194);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(76, 194);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(0, 20);
            labelValor.TabIndex = 10;
            // 
            // frmSerie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(526, 231);
            Controls.Add(labelValor);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(btnActualizar);
            Controls.Add(label2);
            Controls.Add(btnConectar);
            Controls.Add(cmbPuertos);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSerie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SERVO MOTOR";
            Load += frmSerie_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPuertos;
        private Button btnConectar;
        private Label label2;
        private Button btnActualizar;
        private TrackBar trackBar1;
        private Label label3;
        private Label labelValor;
    }
}
