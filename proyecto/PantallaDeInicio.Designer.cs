namespace proyecto
{
    partial class PantallaDeInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeInicio));
            this.BarraDeOpciones = new System.Windows.Forms.Panel();
            this.ContenedorInfo = new System.Windows.Forms.Panel();
            this.btnElementos = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.ContenedorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnElementos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraDeOpciones
            // 
            this.BarraDeOpciones.BackColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.BarraDeOpciones, "BarraDeOpciones");
            this.BarraDeOpciones.Name = "BarraDeOpciones";
            // 
            // ContenedorInfo
            // 
            this.ContenedorInfo.Controls.Add(this.panel1);
            resources.ApplyResources(this.ContenedorInfo, "ContenedorInfo");
            this.ContenedorInfo.Name = "ContenedorInfo";
            // 
            // btnElementos
            // 
            this.btnElementos.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnElementos, "btnElementos");
            this.btnElementos.Name = "btnElementos";
            this.btnElementos.TabStop = false;
            this.btnElementos.Click += new System.EventHandler(this.btnElementos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnElementos);
            this.panel1.Controls.Add(this.btnCerrar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnMaximizar
            // 
            resources.ApplyResources(this.btnMaximizar, "btnMaximizar");
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            resources.ApplyResources(this.btnRestaurar, "btnRestaurar");
            this.btnRestaurar.BackColor = System.Drawing.Color.White;
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // PantallaDeInicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ContenedorInfo);
            this.Controls.Add(this.BarraDeOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaDeInicio";
            this.Load += new System.EventHandler(this.PantallaDeInicio_Load);
            this.ContenedorInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnElementos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraDeOpciones;
        private System.Windows.Forms.Panel ContenedorInfo;
        private System.Windows.Forms.PictureBox btnElementos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
    }
}