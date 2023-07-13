namespace Login
{
    partial class frmMatricula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxestudiantes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxasignatura = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiantes";
            // 
            // cbxestudiantes
            // 
            this.cbxestudiantes.FormattingEnabled = true;
            this.cbxestudiantes.Location = new System.Drawing.Point(18, 115);
            this.cbxestudiantes.Name = "cbxestudiantes";
            this.cbxestudiantes.Size = new System.Drawing.Size(241, 24);
            this.cbxestudiantes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asignatura";
            // 
            // cbxasignatura
            // 
            this.cbxasignatura.FormattingEnabled = true;
            this.cbxasignatura.Location = new System.Drawing.Point(18, 195);
            this.cbxasignatura.Name = "cbxasignatura";
            this.cbxasignatura.Size = new System.Drawing.Size(241, 24);
            this.cbxasignatura.TabIndex = 4;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(18, 270);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(133, 22);
            this.txtfecha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de matricula";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(170, 270);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 22);
            this.dtpfecha.TabIndex = 7;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(319, 115);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(107, 22);
            this.txtnota.TabIndex = 9;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(18, 341);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(115, 60);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(310, 341);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(116, 60);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // frmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 458);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.cbxasignatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxestudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMatricula";
            this.Load += new System.EventHandler(this.frmMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxestudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxasignatura;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncancelar;
    }
}