namespace proyecto
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.textCantidadPagina = new System.Windows.Forms.TextBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.lblDe = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.cbxPagina = new System.Windows.Forms.ComboBox();
            this.BtnCerrarVenta = new System.Windows.Forms.Button();
            this.lblPaginaVenta = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.PanelCantidad = new System.Windows.Forms.Panel();
            this.panelVentaPagina = new System.Windows.Forms.Panel();
            this.panelVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.PanelCantidad.SuspendLayout();
            this.panelVentaPagina.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelVenta.Controls.Add(this.panelVentaPagina);
            this.panelVenta.Controls.Add(this.dgvVenta);
            this.panelVenta.Controls.Add(this.labelProductos);
            this.panelVenta.Controls.Add(this.BtnCerrarVenta);
            this.panelVenta.Controls.Add(this.PanelCantidad);
            this.panelVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVenta.Location = new System.Drawing.Point(0, 0);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(1160, 562);
            this.panelVenta.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(8, 145);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(133, 22);
            this.txtCantidad.TabIndex = 42;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(5, 126);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 41;
            this.lblCantidad.Text = "Cantidad";
            // 
            // textCantidadPagina
            // 
            this.textCantidadPagina.Location = new System.Drawing.Point(201, 5);
            this.textCantidadPagina.Name = "textCantidadPagina";
            this.textCantidadPagina.Size = new System.Drawing.Size(39, 22);
            this.textCantidadPagina.TabIndex = 40;
            // 
            // dgvVenta
            // 
            this.dgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvVenta.ColumnHeadersHeight = 30;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvVenta.Location = new System.Drawing.Point(32, 69);
            this.dgvVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvVenta.RowHeadersWidth = 51;
            this.dgvVenta.Size = new System.Drawing.Size(948, 464);
            this.dgvVenta.TabIndex = 32;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.ForeColor = System.Drawing.Color.Silver;
            this.lblDe.Location = new System.Drawing.Point(161, 11);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(25, 16);
            this.lblDe.TabIndex = 39;
            this.lblDe.Text = "De";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.Color.White;
            this.labelProductos.Location = new System.Drawing.Point(65, 15);
            this.labelProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(64, 25);
            this.labelProductos.TabIndex = 31;
            this.labelProductos.Text = "Venta";
            // 
            // cbxPagina
            // 
            this.cbxPagina.FormattingEnabled = true;
            this.cbxPagina.Location = new System.Drawing.Point(84, 3);
            this.cbxPagina.Name = "cbxPagina";
            this.cbxPagina.Size = new System.Drawing.Size(56, 24);
            this.cbxPagina.TabIndex = 38;
            // 
            // BtnCerrarVenta
            // 
            this.BtnCerrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarVenta.FlatAppearance.BorderSize = 0;
            this.BtnCerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarVenta.Image = global::proyecto.Properties.Resources.Close;
            this.BtnCerrarVenta.Location = new System.Drawing.Point(0, 0);
            this.BtnCerrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrarVenta.Name = "BtnCerrarVenta";
            this.BtnCerrarVenta.Size = new System.Drawing.Size(57, 53);
            this.BtnCerrarVenta.TabIndex = 33;
            this.BtnCerrarVenta.UseVisualStyleBackColor = true;
            // 
            // lblPaginaVenta
            // 
            this.lblPaginaVenta.AutoSize = true;
            this.lblPaginaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.lblPaginaVenta.ForeColor = System.Drawing.Color.Silver;
            this.lblPaginaVenta.Location = new System.Drawing.Point(28, 6);
            this.lblPaginaVenta.Name = "lblPaginaVenta";
            this.lblPaginaVenta.Size = new System.Drawing.Size(50, 16);
            this.lblPaginaVenta.TabIndex = 37;
            this.lblPaginaVenta.Text = "Pagina";
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.Silver;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(8, 59);
            this.btnVender.Margin = new System.Windows.Forms.Padding(4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(133, 37);
            this.btnVender.TabIndex = 36;
            this.btnVender.Text = "Vender";
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // PanelCantidad
            // 
            this.PanelCantidad.Controls.Add(this.txtCantidad);
            this.PanelCantidad.Controls.Add(this.btnVender);
            this.PanelCantidad.Controls.Add(this.lblCantidad);
            this.PanelCantidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelCantidad.Location = new System.Drawing.Point(987, 0);
            this.PanelCantidad.Name = "PanelCantidad";
            this.PanelCantidad.Size = new System.Drawing.Size(173, 562);
            this.PanelCantidad.TabIndex = 43;
            // 
            // panelVentaPagina
            // 
            this.panelVentaPagina.Controls.Add(this.textCantidadPagina);
            this.panelVentaPagina.Controls.Add(this.cbxPagina);
            this.panelVentaPagina.Controls.Add(this.lblDe);
            this.panelVentaPagina.Controls.Add(this.lblPaginaVenta);
            this.panelVentaPagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVentaPagina.Location = new System.Drawing.Point(0, 527);
            this.panelVentaPagina.Name = "panelVentaPagina";
            this.panelVentaPagina.Size = new System.Drawing.Size(987, 35);
            this.panelVentaPagina.TabIndex = 44;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 562);
            this.Controls.Add(this.panelVenta);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.panelVenta.ResumeLayout(false);
            this.panelVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.PanelCantidad.ResumeLayout(false);
            this.PanelCantidad.PerformLayout();
            this.panelVentaPagina.ResumeLayout(false);
            this.panelVentaPagina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.TextBox textCantidadPagina;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.ComboBox cbxPagina;
        private System.Windows.Forms.Label lblPaginaVenta;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button BtnCerrarVenta;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Panel PanelCantidad;
        private System.Windows.Forms.Panel panelVentaPagina;
    }
}