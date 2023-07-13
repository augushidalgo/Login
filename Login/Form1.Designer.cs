namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxnombre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RentaCar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(113, 115);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(152, 22);
            this.txtclave.TabIndex = 4;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(32, 185);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(97, 48);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxnombre
            // 
            this.cbxnombre.FormattingEnabled = true;
            this.cbxnombre.Items.AddRange(new object[] {
            "ADMIN",
            "ESTUDIANTES",
            "DOCENTES",
            "EXTERNOS"});
            this.cbxnombre.Location = new System.Drawing.Point(113, 54);
            this.cbxnombre.Name = "cbxnombre";
            this.cbxnombre.Size = new System.Drawing.Size(152, 24);
            this.cbxnombre.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 259);
            this.Controls.Add(this.cbxnombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxnombre;
    }
}

