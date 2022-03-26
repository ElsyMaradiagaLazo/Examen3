namespace examen
{
    partial class Login
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
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox1 = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Location = new System.Drawing.Point(34, 108);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbutton1.TabIndex = 0;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.Location = new System.Drawing.Point(197, 107);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton2.TabIndex = 1;
            this.Cancelarbutton2.Text = "Cancelar";
            this.Cancelarbutton2.UseVisualStyleBackColor = true;
            this.Cancelarbutton2.Click += new System.EventHandler(this.Cancelarbutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // UsuariotextBox1
            // 
            this.UsuariotextBox1.Location = new System.Drawing.Point(158, 29);
            this.UsuariotextBox1.Name = "UsuariotextBox1";
            this.UsuariotextBox1.Size = new System.Drawing.Size(100, 20);
            this.UsuariotextBox1.TabIndex = 4;
            // 
            // ContraseñatextBox2
            // 
            this.ContraseñatextBox2.Location = new System.Drawing.Point(158, 61);
            this.ContraseñatextBox2.Name = "ContraseñatextBox2";
            this.ContraseñatextBox2.Size = new System.Drawing.Size(100, 20);
            this.ContraseñatextBox2.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 143);
            this.Controls.Add(this.ContraseñatextBox2);
            this.Controls.Add(this.UsuariotextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox1;
        private System.Windows.Forms.TextBox ContraseñatextBox2;
    }
}

