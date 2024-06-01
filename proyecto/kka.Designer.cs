namespace proyecto
{
    partial class FormReporteGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartTopMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopMenosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProducto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCantidadDeProductos = new System.Windows.Forms.Label();
            this.labelNumeroDeCategorias = new System.Windows.Forms.Label();
            this.labelCantidadDeProductos = new System.Windows.Forms.Label();
            this.labelCantidadDeClientes = new System.Windows.Forms.Label();
            this.labelGanancia = new System.Windows.Forms.Label();
            this.lblNumeroDeCategorias = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblCantidadInvertid = new System.Windows.Forms.Label();
            this.lblCantidadInvertida = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTodo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDEprueba = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMenosVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducto)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlTodo.SuspendLayout();
            this.panelDEprueba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartTopMenosVendidos);
            this.panel1.Controls.Add(this.chartTopMasVendidos);
            this.panel1.Location = new System.Drawing.Point(878, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 425);
            this.panel1.TabIndex = 3;
            // 
            // chartTopMasVendidos
            // 
            this.chartTopMasVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTopMasVendidos.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartTopMasVendidos.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.OliveDrab;
            legend2.Name = "Legend1";
            this.chartTopMasVendidos.Legends.Add(legend2);
            this.chartTopMasVendidos.Location = new System.Drawing.Point(31, 52);
            this.chartTopMasVendidos.Name = "chartTopMasVendidos";
            this.chartTopMasVendidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopMasVendidos.Series.Add(series2);
            this.chartTopMasVendidos.Size = new System.Drawing.Size(231, 150);
            this.chartTopMasVendidos.TabIndex = 1;
            this.chartTopMasVendidos.Text = "chart1";
            title2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.YellowGreen;
            title2.Name = "Title1";
            title2.Text = "Productos Mas vendidos";
            this.chartTopMasVendidos.Titles.Add(title2);
            // 
            // chartTopMenosVendidos
            // 
            this.chartTopMenosVendidos.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartTopMenosVendidos.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.OliveDrab;
            legend1.Name = "Legend1";
            this.chartTopMenosVendidos.Legends.Add(legend1);
            this.chartTopMenosVendidos.Location = new System.Drawing.Point(0, 225);
            this.chartTopMenosVendidos.Name = "chartTopMenosVendidos";
            this.chartTopMenosVendidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTopMenosVendidos.Series.Add(series1);
            this.chartTopMenosVendidos.Size = new System.Drawing.Size(304, 134);
            this.chartTopMenosVendidos.TabIndex = 2;
            this.chartTopMenosVendidos.Text = "chart1";
            title1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.YellowGreen;
            title1.Name = "Title1";
            title1.Text = "Productos Menos Vendidos";
            this.chartTopMenosVendidos.Titles.Add(title1);
            // 
            // chartProducto
            // 
            this.chartProducto.AllowDrop = true;
            this.chartProducto.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.OliveDrab;
            chartArea3.AxisX.LineColor = System.Drawing.Color.YellowGreen;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.YellowGreen;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.OliveDrab;
            chartArea3.AxisY.LineColor = System.Drawing.Color.YellowGreen;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.YellowGreen;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartProducto.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartProducto.Legends.Add(legend3);
            this.chartProducto.Location = new System.Drawing.Point(0, 117);
            this.chartProducto.Name = "chartProducto";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.LabelForeColor = System.Drawing.Color.OliveDrab;
            series3.Legend = "Legend1";
            series3.Name = "S";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartProducto.Series.Add(series3);
            this.chartProducto.Size = new System.Drawing.Size(325, 460);
            this.chartProducto.TabIndex = 0;
            this.chartProducto.Text = "chart1";
            title3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.YellowGreen;
            title3.Name = "Title1";
            title3.Text = "Productos Vendidos";
            this.chartProducto.Titles.Add(title3);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.lblCantidadInvertida);
            this.panel2.Controls.Add(this.lblCantidadInvertid);
            this.panel2.Controls.Add(this.lblCantidadDeClientes);
            this.panel2.Controls.Add(this.lblGanancia);
            this.panel2.Controls.Add(this.lblNumeroDeCategorias);
            this.panel2.Controls.Add(this.labelGanancia);
            this.panel2.Controls.Add(this.labelCantidadDeClientes);
            this.panel2.Controls.Add(this.labelCantidadDeProductos);
            this.panel2.Controls.Add(this.labelNumeroDeCategorias);
            this.panel2.Controls.Add(this.lblCantidadDeProductos);
            this.panel2.Location = new System.Drawing.Point(381, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 432);
            this.panel2.TabIndex = 4;
            // 
            // lblCantidadDeProductos
            // 
            this.lblCantidadDeProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadDeProductos.AutoEllipsis = true;
            this.lblCantidadDeProductos.AutoSize = true;
            this.lblCantidadDeProductos.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeProductos.Location = new System.Drawing.Point(75, 327);
            this.lblCantidadDeProductos.Name = "lblCantidadDeProductos";
            this.lblCantidadDeProductos.Size = new System.Drawing.Size(176, 20);
            this.lblCantidadDeProductos.TabIndex = 0;
            this.lblCantidadDeProductos.Text = "CantidadDeProductos";
            // 
            // labelNumeroDeCategorias
            // 
            this.labelNumeroDeCategorias.AutoEllipsis = true;
            this.labelNumeroDeCategorias.AutoSize = true;
            this.labelNumeroDeCategorias.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeCategorias.Location = new System.Drawing.Point(150, 194);
            this.labelNumeroDeCategorias.Name = "labelNumeroDeCategorias";
            this.labelNumeroDeCategorias.Size = new System.Drawing.Size(46, 20);
            this.labelNumeroDeCategorias.TabIndex = 0;
            this.labelNumeroDeCategorias.Text = "label";
            // 
            // labelCantidadDeProductos
            // 
            this.labelCantidadDeProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCantidadDeProductos.AutoEllipsis = true;
            this.labelCantidadDeProductos.AutoSize = true;
            this.labelCantidadDeProductos.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadDeProductos.Location = new System.Drawing.Point(150, 363);
            this.labelCantidadDeProductos.Name = "labelCantidadDeProductos";
            this.labelCantidadDeProductos.Size = new System.Drawing.Size(46, 20);
            this.labelCantidadDeProductos.TabIndex = 0;
            this.labelCantidadDeProductos.Text = "label";
            // 
            // labelCantidadDeClientes
            // 
            this.labelCantidadDeClientes.AutoEllipsis = true;
            this.labelCantidadDeClientes.AutoSize = true;
            this.labelCantidadDeClientes.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadDeClientes.Location = new System.Drawing.Point(150, 280);
            this.labelCantidadDeClientes.Name = "labelCantidadDeClientes";
            this.labelCantidadDeClientes.Size = new System.Drawing.Size(46, 20);
            this.labelCantidadDeClientes.TabIndex = 0;
            this.labelCantidadDeClientes.Text = "label";
            // 
            // labelGanancia
            // 
            this.labelGanancia.AutoSize = true;
            this.labelGanancia.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanancia.Location = new System.Drawing.Point(150, 115);
            this.labelGanancia.Name = "labelGanancia";
            this.labelGanancia.Size = new System.Drawing.Size(46, 20);
            this.labelGanancia.TabIndex = 0;
            this.labelGanancia.Text = "label";
            // 
            // lblNumeroDeCategorias
            // 
            this.lblNumeroDeCategorias.AutoSize = true;
            this.lblNumeroDeCategorias.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeCategorias.Location = new System.Drawing.Point(79, 158);
            this.lblNumeroDeCategorias.Name = "lblNumeroDeCategorias";
            this.lblNumeroDeCategorias.Size = new System.Drawing.Size(172, 20);
            this.lblNumeroDeCategorias.TabIndex = 0;
            this.lblNumeroDeCategorias.Text = "NumeroDeCategorias";
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.Location = new System.Drawing.Point(128, 78);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(81, 20);
            this.lblGanancia.TabIndex = 0;
            this.lblGanancia.Text = "Ganancia";
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.AutoSize = true;
            this.lblCantidadDeClientes.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(91, 236);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(160, 20);
            this.lblCantidadDeClientes.TabIndex = 0;
            this.lblCantidadDeClientes.Text = "CantidadDeClientes";
            // 
            // lblCantidadInvertid
            // 
            this.lblCantidadInvertid.AutoEllipsis = true;
            this.lblCantidadInvertid.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInvertid.Location = new System.Drawing.Point(150, 38);
            this.lblCantidadInvertid.Name = "lblCantidadInvertid";
            this.lblCantidadInvertid.Size = new System.Drawing.Size(46, 20);
            this.lblCantidadInvertid.TabIndex = 0;
            this.lblCantidadInvertid.Text = "label";
            // 
            // lblCantidadInvertida
            // 
            this.lblCantidadInvertida.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadInvertida.Location = new System.Drawing.Point(0, 0);
            this.lblCantidadInvertida.Name = "lblCantidadInvertida";
            this.lblCantidadInvertida.Size = new System.Drawing.Size(294, 20);
            this.lblCantidadInvertida.TabIndex = 0;
            this.lblCantidadInvertida.Text = "CantidadInvertida";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1279, 39);
            this.panel3.TabIndex = 5;
            // 
            // pnlTodo
            // 
            this.pnlTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.pnlTodo.Controls.Add(this.panel3);
            this.pnlTodo.Controls.Add(this.panel2);
            this.pnlTodo.Controls.Add(this.chartProducto);
            this.pnlTodo.Controls.Add(this.panel1);
            this.pnlTodo.Controls.Add(this.panelDEprueba);
            this.pnlTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTodo.Location = new System.Drawing.Point(0, 0);
            this.pnlTodo.Name = "pnlTodo";
            this.pnlTodo.Size = new System.Drawing.Size(1279, 577);
            this.pnlTodo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(322, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 81);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelDEprueba
            // 
            this.panelDEprueba.Controls.Add(this.tableLayoutPanel1);
            this.panelDEprueba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDEprueba.Location = new System.Drawing.Point(0, 0);
            this.panelDEprueba.Name = "panelDEprueba";
            this.panelDEprueba.Padding = new System.Windows.Forms.Padding(10);
            this.panelDEprueba.Size = new System.Drawing.Size(1279, 577);
            this.panelDEprueba.TabIndex = 7;
            // 
            // FormReporteGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 577);
            this.Controls.Add(this.pnlTodo);
            this.Name = "FormReporteGrafico";
            this.Text = "FormReporteGrafico";
            this.Load += new System.EventHandler(this.FormReporteGrafico_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopMenosVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTodo.ResumeLayout(false);
            this.pnlTodo.PerformLayout();
            this.panelDEprueba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopMenosVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCantidadInvertida;
        private System.Windows.Forms.Label lblCantidadInvertid;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label lblNumeroDeCategorias;
        private System.Windows.Forms.Label labelGanancia;
        private System.Windows.Forms.Label labelCantidadDeClientes;
        private System.Windows.Forms.Label labelCantidadDeProductos;
        private System.Windows.Forms.Label labelNumeroDeCategorias;
        private System.Windows.Forms.Label lblCantidadDeProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTodo;
        private System.Windows.Forms.Panel panelDEprueba;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}