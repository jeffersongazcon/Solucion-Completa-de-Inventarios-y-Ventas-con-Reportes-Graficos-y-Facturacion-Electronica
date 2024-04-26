namespace proyecto
{
    partial class Confirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmacion));
            this.labelMessage = new System.Windows.Forms.Label();
            this.LabelCaption = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.pictureMessage = new System.Windows.Forms.PictureBox();
            this.panelCaption = new System.Windows.Forms.Panel();
            this.pictureCaption = new System.Windows.Forms.PictureBox();
            this.panelButton.SuspendLayout();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMessage)).BeginInit();
            this.panelCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaption)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.labelMessage.Location = new System.Drawing.Point(62, 67);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(280, 20);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "¿Esta seguro de cerrar el programa?";
            // 
            // LabelCaption
            // 
            this.LabelCaption.AutoSize = true;
            this.LabelCaption.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCaption.Location = new System.Drawing.Point(39, 6);
            this.LabelCaption.Name = "LabelCaption";
            this.LabelCaption.Size = new System.Drawing.Size(99, 20);
            this.LabelCaption.TabIndex = 1;
            this.LabelCaption.Text = "Advertencia";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(64, 10);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 35);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(214, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Black;
            this.panelButton.Controls.Add(this.btnCancelar);
            this.panelButton.Controls.Add(this.btnAceptar);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 112);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(372, 57);
            this.panelButton.TabIndex = 5;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.Black;
            this.panelMessage.Controls.Add(this.pictureMessage);
            this.panelMessage.Controls.Add(this.labelMessage);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.Location = new System.Drawing.Point(0, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(372, 169);
            this.panelMessage.TabIndex = 6;
            this.panelMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMessage_Paint);
            // 
            // pictureMessage
            // 
            this.pictureMessage.Image = ((System.Drawing.Image)(resources.GetObject("pictureMessage.Image")));
            this.pictureMessage.Location = new System.Drawing.Point(8, 53);
            this.pictureMessage.Name = "pictureMessage";
            this.pictureMessage.Size = new System.Drawing.Size(51, 44);
            this.pictureMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMessage.TabIndex = 1;
            this.pictureMessage.TabStop = false;
            // 
            // panelCaption
            // 
            this.panelCaption.BackColor = System.Drawing.Color.YellowGreen;
            this.panelCaption.Controls.Add(this.pictureCaption);
            this.panelCaption.Controls.Add(this.LabelCaption);
            this.panelCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCaption.Location = new System.Drawing.Point(0, 0);
            this.panelCaption.Name = "panelCaption";
            this.panelCaption.Size = new System.Drawing.Size(372, 33);
            this.panelCaption.TabIndex = 7;
            // 
            // pictureCaption
            // 
            this.pictureCaption.Image = ((System.Drawing.Image)(resources.GetObject("pictureCaption.Image")));
            this.pictureCaption.Location = new System.Drawing.Point(1, 0);
            this.pictureCaption.Name = "pictureCaption";
            this.pictureCaption.Size = new System.Drawing.Size(32, 33);
            this.pictureCaption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCaption.TabIndex = 1;
            this.pictureCaption.TabStop = false;
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 169);
            this.Controls.Add(this.panelCaption);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmacion";
            this.panelButton.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMessage)).EndInit();
            this.panelCaption.ResumeLayout(false);
            this.panelCaption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaption)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label LabelCaption;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Panel panelCaption;
        private System.Windows.Forms.PictureBox pictureCaption;
        private System.Windows.Forms.PictureBox pictureMessage;
    }
}