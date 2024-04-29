namespace proyecto
{
    partial class bienvenidaDeUsuario
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bienvenidaDeUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBienvenida = new System.Windows.Forms.PictureBox();
            this.labelBienvenidaTitulo = new System.Windows.Forms.Label();
            this.labelBienvenidaDescripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBienvenida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pictureBienvenida
            // 
            this.pictureBienvenida.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("pictureBienvenida.Image")));
            this.pictureBienvenida.Location = new System.Drawing.Point(29, 65);
            this.pictureBienvenida.Name = "pictureBienvenida";
            this.pictureBienvenida.Size = new System.Drawing.Size(350, 354);
            this.pictureBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBienvenida.TabIndex = 11;
            this.pictureBienvenida.TabStop = false;
            // 
            // labelBienvenidaTitulo
            // 
            this.labelBienvenidaTitulo.AutoSize = true;
            this.labelBienvenidaTitulo.Font = new System.Drawing.Font("Playbill", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenidaTitulo.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelBienvenidaTitulo.Location = new System.Drawing.Point(511, 31);
            this.labelBienvenidaTitulo.Name = "labelBienvenidaTitulo";
            this.labelBienvenidaTitulo.Size = new System.Drawing.Size(419, 38);
            this.labelBienvenidaTitulo.TabIndex = 12;
            this.labelBienvenidaTitulo.Text = "BIENVENIDO AL INVENTARIO DEL DUENDE";
            // 
            // labelBienvenidaDescripcion
            // 
            this.labelBienvenidaDescripcion.AutoSize = true;
            this.labelBienvenidaDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labelBienvenidaDescripcion.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenidaDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.labelBienvenidaDescripcion.Location = new System.Drawing.Point(414, 212);
            this.labelBienvenidaDescripcion.Name = "labelBienvenidaDescripcion";
            this.labelBienvenidaDescripcion.Size = new System.Drawing.Size(712, 60);
            this.labelBienvenidaDescripcion.TabIndex = 14;
            this.labelBienvenidaDescripcion.Text = resources.GetString("labelBienvenidaDescripcion.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(926, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // bienvenidaDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelBienvenidaDescripcion);
            this.Controls.Add(this.labelBienvenidaTitulo);
            this.Controls.Add(this.pictureBienvenida);
            this.Controls.Add(this.label1);
            this.Name = "bienvenidaDeUsuario";
            this.Size = new System.Drawing.Size(1209, 511);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBienvenida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBienvenida;
        private System.Windows.Forms.Label labelBienvenidaTitulo;
        private System.Windows.Forms.Label labelBienvenidaDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
