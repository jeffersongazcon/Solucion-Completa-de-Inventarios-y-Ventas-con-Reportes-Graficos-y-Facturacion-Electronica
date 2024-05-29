namespace proyecto
{
    partial class FormFactura
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.pnlInvercion = new System.Windows.Forms.Panel();
            this.lblGananciaTotal = new System.Windows.Forms.Label();
            this.lblCantidadInvertida = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblInvercion = new System.Windows.Forms.Label();
            this.labelFactura = new System.Windows.Forms.Label();
            this.PanelCantidad = new System.Windows.Forms.Panel();
            this.pnlFiltrado = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaFinal = new proyecto.CalendarioPersonalizado();
            this.dtpFechaInicio = new proyecto.CalendarioPersonalizado();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaDeInicio = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.BtnCerrarVenta = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.panelVenta.SuspendLayout();
            this.pnlInvercion.SuspendLayout();
            this.PanelCantidad.SuspendLayout();
            this.pnlFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelVenta.Controls.Add(this.pnlInvercion);
            this.panelVenta.Controls.Add(this.labelFactura);
            this.panelVenta.Controls.Add(this.PanelCantidad);
            this.panelVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVenta.Location = new System.Drawing.Point(0, 0);
            this.panelVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(870, 457);
            this.panelVenta.TabIndex = 1;
            // 
            // pnlInvercion
            // 
            this.pnlInvercion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pnlInvercion.Controls.Add(this.lblGananciaTotal);
            this.pnlInvercion.Controls.Add(this.lblCantidadInvertida);
            this.pnlInvercion.Controls.Add(this.lblGanancia);
            this.pnlInvercion.Controls.Add(this.lblInvercion);
            this.pnlInvercion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInvercion.Location = new System.Drawing.Point(0, 352);
            this.pnlInvercion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInvercion.Name = "pnlInvercion";
            this.pnlInvercion.Size = new System.Drawing.Size(870, 105);
            this.pnlInvercion.TabIndex = 33;
            // 
            // lblGananciaTotal
            // 
            this.lblGananciaTotal.AutoSize = true;
            this.lblGananciaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciaTotal.ForeColor = System.Drawing.Color.White;
            this.lblGananciaTotal.Location = new System.Drawing.Point(166, 54);
            this.lblGananciaTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGananciaTotal.Name = "lblGananciaTotal";
            this.lblGananciaTotal.Size = new System.Drawing.Size(40, 20);
            this.lblGananciaTotal.TabIndex = 3;
            this.lblGananciaTotal.Text = "$0.0";
            // 
            // lblCantidadInvertida
            // 
            this.lblCantidadInvertida.AutoSize = true;
            this.lblCantidadInvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInvertida.ForeColor = System.Drawing.Color.White;
            this.lblCantidadInvertida.Location = new System.Drawing.Point(166, 12);
            this.lblCantidadInvertida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadInvertida.Name = "lblCantidadInvertida";
            this.lblCantidadInvertida.Size = new System.Drawing.Size(40, 20);
            this.lblCantidadInvertida.TabIndex = 2;
            this.lblCantidadInvertida.Text = "$0.0";
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.White;
            this.lblGanancia.Location = new System.Drawing.Point(11, 54);
            this.lblGanancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(82, 20);
            this.lblGanancia.TabIndex = 1;
            this.lblGanancia.Text = "Ganancia:";
            // 
            // lblInvercion
            // 
            this.lblInvercion.AutoSize = true;
            this.lblInvercion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvercion.ForeColor = System.Drawing.Color.White;
            this.lblInvercion.Location = new System.Drawing.Point(11, 12);
            this.lblInvercion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvercion.Name = "lblInvercion";
            this.lblInvercion.Size = new System.Drawing.Size(142, 20);
            this.lblInvercion.TabIndex = 0;
            this.lblInvercion.Text = "Cantidad Invertida:";
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura.ForeColor = System.Drawing.Color.White;
            this.labelFactura.Location = new System.Drawing.Point(49, 12);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(64, 20);
            this.labelFactura.TabIndex = 31;
            this.labelFactura.Text = "Factura";
            // 
            // PanelCantidad
            // 
            this.PanelCantidad.Controls.Add(this.pnlFiltrado);
            this.PanelCantidad.Controls.Add(this.BtnCerrarVenta);
            this.PanelCantidad.Controls.Add(this.dgvReporte);
            this.PanelCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCantidad.Location = new System.Drawing.Point(0, 0);
            this.PanelCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelCantidad.Name = "PanelCantidad";
            this.PanelCantidad.Size = new System.Drawing.Size(870, 457);
            this.PanelCantidad.TabIndex = 30;
            // 
            // pnlFiltrado
            // 
            this.pnlFiltrado.Controls.Add(this.label1);
            this.pnlFiltrado.Controls.Add(this.pictureBox1);
            this.pnlFiltrado.Controls.Add(this.dtpFechaFinal);
            this.pnlFiltrado.Controls.Add(this.dtpFechaInicio);
            this.pnlFiltrado.Controls.Add(this.lblFechaFinal);
            this.pnlFiltrado.Controls.Add(this.lblFechaDeInicio);
            this.pnlFiltrado.Controls.Add(this.btnGenerateReport);
            this.pnlFiltrado.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFiltrado.Location = new System.Drawing.Point(628, 0);
            this.pnlFiltrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFiltrado.Name = "pnlFiltrado";
            this.pnlFiltrado.Size = new System.Drawing.Size(242, 457);
            this.pnlFiltrado.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Filtrado Por Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 249);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpFechaFinal.BorderSize = 0;
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaFinal.Location = new System.Drawing.Point(14, 167);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaFinal.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(212, 35);
            this.dtpFechaFinal.SkinColor = System.Drawing.Color.YellowGreen;
            this.dtpFechaFinal.TabIndex = 39;
            this.dtpFechaFinal.TextColor = System.Drawing.Color.White;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpFechaInicio.BorderSize = 0;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(14, 110);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaInicio.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(212, 35);
            this.dtpFechaInicio.SkinColor = System.Drawing.Color.YellowGreen;
            this.dtpFechaInicio.TabIndex = 39;
            this.dtpFechaInicio.TextColor = System.Drawing.Color.White;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.ForeColor = System.Drawing.Color.White;
            this.lblFechaFinal.Location = new System.Drawing.Point(22, 150);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(71, 14);
            this.lblFechaFinal.TabIndex = 39;
            this.lblFechaFinal.Text = "FechaFinal";
            // 
            // lblFechaDeInicio
            // 
            this.lblFechaDeInicio.AutoSize = true;
            this.lblFechaDeInicio.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaDeInicio.Location = new System.Drawing.Point(22, 95);
            this.lblFechaDeInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDeInicio.Name = "lblFechaDeInicio";
            this.lblFechaDeInicio.Size = new System.Drawing.Size(87, 14);
            this.lblFechaDeInicio.TabIndex = 39;
            this.lblFechaDeInicio.Text = "FechaDeInicio";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(52, 220);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 24);
            this.btnGenerateReport.TabIndex = 37;
            this.btnGenerateReport.Text = "Generar Reporte";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // BtnCerrarVenta
            // 
            this.BtnCerrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarVenta.FlatAppearance.BorderSize = 0;
            this.BtnCerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarVenta.Image = global::proyecto.Properties.Resources.Close;
            this.BtnCerrarVenta.Location = new System.Drawing.Point(4, 3);
            this.BtnCerrarVenta.Name = "BtnCerrarVenta";
            this.BtnCerrarVenta.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrarVenta.TabIndex = 34;
            this.BtnCerrarVenta.UseVisualStyleBackColor = true;
            this.BtnCerrarVenta.Click += new System.EventHandler(this.BtnCerrarVenta_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporte.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvReporte.Location = new System.Drawing.Point(24, 53);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.Size = new System.Drawing.Size(598, 227);
            this.dgvReporte.TabIndex = 32;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.panelVenta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.panelVenta.ResumeLayout(false);
            this.panelVenta.PerformLayout();
            this.pnlInvercion.ResumeLayout(false);
            this.pnlInvercion.PerformLayout();
            this.PanelCantidad.ResumeLayout(false);
            this.pnlFiltrado.ResumeLayout(false);
            this.pnlFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.Panel PanelCantidad;
        private System.Windows.Forms.Panel pnlInvercion;
        private System.Windows.Forms.Label lblGananciaTotal;
        private System.Windows.Forms.Label lblCantidadInvertida;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblInvercion;
        private System.Windows.Forms.Button BtnCerrarVenta;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel pnlFiltrado;
        private System.Windows.Forms.Label lblFechaDeInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private CalendarioPersonalizado dtpFechaInicio;
        private CalendarioPersonalizado dtpFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
