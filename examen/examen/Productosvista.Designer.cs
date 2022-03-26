namespace examen
{
    partial class Productosvista
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productosLdataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoProductotextBox1 = new System.Windows.Forms.TextBox();
            this.DescripciontextBox2 = new System.Windows.Forms.TextBox();
            this.PreciotextBox3 = new System.Windows.Forms.TextBox();
            this.ExistenciatextBox4 = new System.Windows.Forms.TextBox();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.Guardarbutton2 = new System.Windows.Forms.Button();
            this.Cancelarbutton3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productosLdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia:";
            // 
            // productosLdataGridView1
            // 
            this.productosLdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosLdataGridView1.Location = new System.Drawing.Point(49, 182);
            this.productosLdataGridView1.Name = "productosLdataGridView1";
            this.productosLdataGridView1.Size = new System.Drawing.Size(494, 150);
            this.productosLdataGridView1.TabIndex = 4;
            // 
            // CodigoProductotextBox1
            // 
            this.CodigoProductotextBox1.Location = new System.Drawing.Point(221, 28);
            this.CodigoProductotextBox1.Name = "CodigoProductotextBox1";
            this.CodigoProductotextBox1.Size = new System.Drawing.Size(100, 20);
            this.CodigoProductotextBox1.TabIndex = 5;
            // 
            // DescripciontextBox2
            // 
            this.DescripciontextBox2.Location = new System.Drawing.Point(221, 62);
            this.DescripciontextBox2.Name = "DescripciontextBox2";
            this.DescripciontextBox2.Size = new System.Drawing.Size(100, 20);
            this.DescripciontextBox2.TabIndex = 6;
            // 
            // PreciotextBox3
            // 
            this.PreciotextBox3.Location = new System.Drawing.Point(221, 106);
            this.PreciotextBox3.Name = "PreciotextBox3";
            this.PreciotextBox3.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox3.TabIndex = 7;
            // 
            // ExistenciatextBox4
            // 
            this.ExistenciatextBox4.Location = new System.Drawing.Point(221, 146);
            this.ExistenciatextBox4.Name = "ExistenciatextBox4";
            this.ExistenciatextBox4.Size = new System.Drawing.Size(100, 20);
            this.ExistenciatextBox4.TabIndex = 8;
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.Location = new System.Drawing.Point(409, 31);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton1.TabIndex = 9;
            this.Nuevobutton1.Text = "Nuevo";
            this.Nuevobutton1.UseVisualStyleBackColor = true;
            this.Nuevobutton1.Click += new System.EventHandler(this.Nuevobutton1_Click);
            // 
            // Guardarbutton2
            // 
            this.Guardarbutton2.Location = new System.Drawing.Point(409, 84);
            this.Guardarbutton2.Name = "Guardarbutton2";
            this.Guardarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton2.TabIndex = 10;
            this.Guardarbutton2.Text = "Guardar";
            this.Guardarbutton2.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton3
            // 
            this.Cancelarbutton3.Location = new System.Drawing.Point(409, 135);
            this.Cancelarbutton3.Name = "Cancelarbutton3";
            this.Cancelarbutton3.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton3.TabIndex = 11;
            this.Cancelarbutton3.Text = "Cancelar";
            this.Cancelarbutton3.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Productosvista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 334);
            this.Controls.Add(this.Cancelarbutton3);
            this.Controls.Add(this.Guardarbutton2);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.ExistenciatextBox4);
            this.Controls.Add(this.PreciotextBox3);
            this.Controls.Add(this.DescripciontextBox2);
            this.Controls.Add(this.CodigoProductotextBox1);
            this.Controls.Add(this.productosLdataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productosvista";
            this.Text = "Productosvista";
            this.Load += new System.EventHandler(this.Productosvista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosLdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView productosLdataGridView1;
        private System.Windows.Forms.TextBox CodigoProductotextBox1;
        private System.Windows.Forms.TextBox DescripciontextBox2;
        private System.Windows.Forms.TextBox PreciotextBox3;
        private System.Windows.Forms.TextBox ExistenciatextBox4;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.Button Guardarbutton2;
        private System.Windows.Forms.Button Cancelarbutton3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}