namespace examen
{
    partial class UsuarioVista
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
            this.label3 = new System.Windows.Forms.Label();
            this.CodigotextBox1 = new System.Windows.Forms.TextBox();
            this.NombretextBox2 = new System.Windows.Forms.TextBox();
            this.ContraseñatextBox3 = new System.Windows.Forms.TextBox();
            this.UsuariosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.Agregarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // CodigotextBox1
            // 
            this.CodigotextBox1.Location = new System.Drawing.Point(147, 54);
            this.CodigotextBox1.Name = "CodigotextBox1";
            this.CodigotextBox1.Size = new System.Drawing.Size(100, 20);
            this.CodigotextBox1.TabIndex = 3;
            // 
            // NombretextBox2
            // 
            this.NombretextBox2.Location = new System.Drawing.Point(147, 87);
            this.NombretextBox2.Name = "NombretextBox2";
            this.NombretextBox2.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox2.TabIndex = 4;
            // 
            // ContraseñatextBox3
            // 
            this.ContraseñatextBox3.Location = new System.Drawing.Point(147, 125);
            this.ContraseñatextBox3.Name = "ContraseñatextBox3";
            this.ContraseñatextBox3.Size = new System.Drawing.Size(100, 20);
            this.ContraseñatextBox3.TabIndex = 5;
            // 
            // UsuariosdataGridView1
            // 
            this.UsuariosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView1.Location = new System.Drawing.Point(12, 197);
            this.UsuariosdataGridView1.Name = "UsuariosdataGridView1";
            this.UsuariosdataGridView1.Size = new System.Drawing.Size(419, 150);
            this.UsuariosdataGridView1.TabIndex = 6;
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.Location = new System.Drawing.Point(307, 49);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton1.TabIndex = 7;
            this.Nuevobutton1.Text = "Nuevo";
            this.Nuevobutton1.UseVisualStyleBackColor = true;
            this.Nuevobutton1.Click += new System.EventHandler(this.Nuevobutton1_Click);
            // 
            // Agregarbutton1
            // 
            this.Agregarbutton1.Location = new System.Drawing.Point(307, 90);
            this.Agregarbutton1.Name = "Agregarbutton1";
            this.Agregarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton1.TabIndex = 8;
            this.Agregarbutton1.Text = "Agregar";
            this.Agregarbutton1.UseVisualStyleBackColor = true;
            this.Agregarbutton1.Click += new System.EventHandler(this.Agregarbutton1_Click);
            // 
            // Cancelarbutton1
            // 
            this.Cancelarbutton1.Location = new System.Drawing.Point(307, 128);
            this.Cancelarbutton1.Name = "Cancelarbutton1";
            this.Cancelarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton1.TabIndex = 9;
            this.Cancelarbutton1.Text = "Cancelar";
            this.Cancelarbutton1.UseVisualStyleBackColor = true;
            // 
            // UsuarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 375);
            this.Controls.Add(this.Cancelarbutton1);
            this.Controls.Add(this.Agregarbutton1);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.UsuariosdataGridView1);
            this.Controls.Add(this.ContraseñatextBox3);
            this.Controls.Add(this.NombretextBox2);
            this.Controls.Add(this.CodigotextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioVista";
            this.Text = "UsuarioVista";
            this.Load += new System.EventHandler(this.UsuarioVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigotextBox1;
        private System.Windows.Forms.TextBox NombretextBox2;
        private System.Windows.Forms.TextBox ContraseñatextBox3;
        private System.Windows.Forms.DataGridView UsuariosdataGridView1;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.Button Agregarbutton1;
        private System.Windows.Forms.Button Cancelarbutton1;
    }
}