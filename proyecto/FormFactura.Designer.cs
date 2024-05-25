﻿namespace proyecto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelVenta = new System.Windows.Forms.Panel();
            this.pnlInvercion = new System.Windows.Forms.Panel();
            this.lblGananciaTotal = new System.Windows.Forms.Label();
            this.lblCantidadInvertida = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblInvercion = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.PanelCantidad = new System.Windows.Forms.Panel();
            this.pnlFiltrado = new System.Windows.Forms.Panel();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.BtnCerrarVenta = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.lblFechaDeInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.panelVenta.SuspendLayout();
            this.pnlInvercion.SuspendLayout();
            this.PanelCantidad.SuspendLayout();
            this.pnlFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVenta
            // 
            this.panelVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelVenta.Controls.Add(this.pnlInvercion);
            this.panelVenta.Controls.Add(this.labelProductos);
            this.panelVenta.Controls.Add(this.PanelCantidad);
            this.panelVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVenta.Location = new System.Drawing.Point(0, 0);
            this.panelVenta.Name = "panelVenta";
            this.panelVenta.Size = new System.Drawing.Size(1160, 562);
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
            this.pnlInvercion.Location = new System.Drawing.Point(0, 433);
            this.pnlInvercion.Name = "pnlInvercion";
            this.pnlInvercion.Size = new System.Drawing.Size(1160, 129);
            this.pnlInvercion.TabIndex = 33;
            // 
            // lblGananciaTotal
            // 
            this.lblGananciaTotal.AutoSize = true;
            this.lblGananciaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciaTotal.ForeColor = System.Drawing.Color.White;
            this.lblGananciaTotal.Location = new System.Drawing.Point(221, 66);
            this.lblGananciaTotal.Name = "lblGananciaTotal";
            this.lblGananciaTotal.Size = new System.Drawing.Size(50, 25);
            this.lblGananciaTotal.TabIndex = 3;
            this.lblGananciaTotal.Text = "$0.0";
            // 
            // lblCantidadInvertida
            // 
            this.lblCantidadInvertida.AutoSize = true;
            this.lblCantidadInvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInvertida.ForeColor = System.Drawing.Color.White;
            this.lblCantidadInvertida.Location = new System.Drawing.Point(221, 15);
            this.lblCantidadInvertida.Name = "lblCantidadInvertida";
            this.lblCantidadInvertida.Size = new System.Drawing.Size(50, 25);
            this.lblCantidadInvertida.TabIndex = 2;
            this.lblCantidadInvertida.Text = "$0.0";
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.White;
            this.lblGanancia.Location = new System.Drawing.Point(15, 66);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(102, 25);
            this.lblGanancia.TabIndex = 1;
            this.lblGanancia.Text = "Ganancia:";
            // 
            // lblInvercion
            // 
            this.lblInvercion.AutoSize = true;
            this.lblInvercion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvercion.ForeColor = System.Drawing.Color.White;
            this.lblInvercion.Location = new System.Drawing.Point(15, 15);
            this.lblInvercion.Name = "lblInvercion";
            this.lblInvercion.Size = new System.Drawing.Size(176, 25);
            this.lblInvercion.TabIndex = 0;
            this.lblInvercion.Text = "Cantidad Invertida:";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.Color.White;
            this.labelProductos.Location = new System.Drawing.Point(65, 15);
            this.labelProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(173, 25);
            this.labelProductos.TabIndex = 31;
            this.labelProductos.Text = "Lista de Productos";
            // 
            // PanelCantidad
            // 
            this.PanelCantidad.Controls.Add(this.pnlFiltrado);
            this.PanelCantidad.Controls.Add(this.BtnCerrarVenta);
            this.PanelCantidad.Controls.Add(this.dgvReporte);
            this.PanelCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCantidad.Location = new System.Drawing.Point(0, 0);
            this.PanelCantidad.Name = "PanelCantidad";
            this.PanelCantidad.Size = new System.Drawing.Size(1160, 562);
            this.PanelCantidad.TabIndex = 30;
            // 
            // pnlFiltrado
            // 
            this.pnlFiltrado.Controls.Add(this.lblFechaFinal);
            this.pnlFiltrado.Controls.Add(this.lblFechaDeInicio);
            this.pnlFiltrado.Controls.Add(this.dtpFechaInicio);
            this.pnlFiltrado.Controls.Add(this.dtpFechaFinal);
            this.pnlFiltrado.Controls.Add(this.btnGenerateReport);
            this.pnlFiltrado.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFiltrado.Location = new System.Drawing.Point(917, 0);
            this.pnlFiltrado.Name = "pnlFiltrado";
            this.pnlFiltrado.Size = new System.Drawing.Size(243, 562);
            this.pnlFiltrado.TabIndex = 38;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(17, 143);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 35;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(17, 202);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFinal.TabIndex = 36;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(17, 244);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(200, 30);
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
            this.BtnCerrarVenta.Location = new System.Drawing.Point(5, 4);
            this.BtnCerrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrarVenta.Name = "BtnCerrarVenta";
            this.BtnCerrarVenta.Size = new System.Drawing.Size(57, 53);
            this.BtnCerrarVenta.TabIndex = 34;
            this.BtnCerrarVenta.UseVisualStyleBackColor = true;
            this.BtnCerrarVenta.Click += new System.EventHandler(this.BtnCerrarVenta_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvReporte.ColumnHeadersHeight = 30;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvReporte.Location = new System.Drawing.Point(32, 65);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.Size = new System.Drawing.Size(878, 279);
            this.dgvReporte.TabIndex = 32;
            // 
            // lblFechaDeInicio
            // 
            this.lblFechaDeInicio.AutoSize = true;
            this.lblFechaDeInicio.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaDeInicio.Location = new System.Drawing.Point(14, 124);
            this.lblFechaDeInicio.Name = "lblFechaDeInicio";
            this.lblFechaDeInicio.Size = new System.Drawing.Size(97, 16);
            this.lblFechaDeInicio.TabIndex = 39;
            this.lblFechaDeInicio.Text = "FechaDeInicio";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.ForeColor = System.Drawing.Color.White;
            this.lblFechaFinal.Location = new System.Drawing.Point(14, 183);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(75, 16);
            this.lblFechaFinal.TabIndex = 39;
            this.lblFechaFinal.Text = "FechaFinal";
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 562);
            this.Controls.Add(this.panelVenta);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.panelVenta.ResumeLayout(false);
            this.panelVenta.PerformLayout();
            this.pnlInvercion.ResumeLayout(false);
            this.pnlInvercion.PerformLayout();
            this.PanelCantidad.ResumeLayout(false);
            this.pnlFiltrado.ResumeLayout(false);
            this.pnlFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVenta;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Panel PanelCantidad;
        private System.Windows.Forms.Panel pnlInvercion;
        private System.Windows.Forms.Label lblGananciaTotal;
        private System.Windows.Forms.Label lblCantidadInvertida;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblInvercion;
        private System.Windows.Forms.Button BtnCerrarVenta;

        // Declaración de nuevos controles
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel pnlFiltrado;
        private System.Windows.Forms.Label lblFechaDeInicio;
        private System.Windows.Forms.Label lblFechaFinal;
    }
}
