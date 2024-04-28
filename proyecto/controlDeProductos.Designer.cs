namespace proyecto
{
    partial class controlDeProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.columnIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textID = new System.Windows.Forms.TextBox();
            this.textCodigoBarras = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textPrecioCompra = new System.Windows.Forms.TextBox();
            this.textPrecioVenta = new System.Windows.Forms.TextBox();
            this.textFechaRegistro = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCodigoBarras = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelPrecioCimpra = new System.Windows.Forms.Label();
            this.labelPrecioVenta = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.checkBoxProducto = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelControlProductos = new System.Windows.Forms.Panel();
            this.panelTabla = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.panelControlProductos.SuspendLayout();
            this.panelTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaDatos
            // 
            this.tablaDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tablaDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablaDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIDProducto,
            this.columnCodigoBarras,
            this.columnNombre,
            this.columnDescripcion,
            this.columnCategoria,
            this.columnCantidad,
            this.ColumnPrecioCompra,
            this.ColumnPrecioVenta,
            this.columnEstado,
            this.columnFechaRegistro});
            this.tablaDatos.EnableHeadersVisualStyles = false;
            this.tablaDatos.GridColor = System.Drawing.Color.LightGreen;
            this.tablaDatos.Location = new System.Drawing.Point(3, 3);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaDatos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaDatos.RowTemplate.Height = 24;
            this.tablaDatos.Size = new System.Drawing.Size(1188, 306);
            this.tablaDatos.TabIndex = 0;
            this.tablaDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDatos_CellClick);
            // 
            // columnIDProducto
            // 
            this.columnIDProducto.HeaderText = "ID";
            this.columnIDProducto.MinimumWidth = 6;
            this.columnIDProducto.Name = "columnIDProducto";
            this.columnIDProducto.Width = 125;
            // 
            // columnCodigoBarras
            // 
            this.columnCodigoBarras.HeaderText = "Codigo de barras";
            this.columnCodigoBarras.MinimumWidth = 6;
            this.columnCodigoBarras.Name = "columnCodigoBarras";
            this.columnCodigoBarras.Width = 125;
            // 
            // columnNombre
            // 
            this.columnNombre.HeaderText = "Nombre del producto";
            this.columnNombre.MinimumWidth = 6;
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.Width = 125;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.HeaderText = "Descripcion";
            this.columnDescripcion.MinimumWidth = 6;
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.Width = 125;
            // 
            // columnCategoria
            // 
            this.columnCategoria.HeaderText = "Categoria";
            this.columnCategoria.MinimumWidth = 6;
            this.columnCategoria.Name = "columnCategoria";
            this.columnCategoria.Width = 125;
            // 
            // columnCantidad
            // 
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.MinimumWidth = 6;
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.Width = 125;
            // 
            // ColumnPrecioCompra
            // 
            this.ColumnPrecioCompra.HeaderText = "Precio de compra";
            this.ColumnPrecioCompra.MinimumWidth = 6;
            this.ColumnPrecioCompra.Name = "ColumnPrecioCompra";
            this.ColumnPrecioCompra.Width = 125;
            // 
            // ColumnPrecioVenta
            // 
            this.ColumnPrecioVenta.HeaderText = "Precio de venta";
            this.ColumnPrecioVenta.MinimumWidth = 6;
            this.ColumnPrecioVenta.Name = "ColumnPrecioVenta";
            this.ColumnPrecioVenta.Width = 125;
            // 
            // columnEstado
            // 
            dataGridViewCellStyle7.Format = "Inactivo";
            dataGridViewCellStyle7.NullValue = null;
            this.columnEstado.DefaultCellStyle = dataGridViewCellStyle7;
            this.columnEstado.HeaderText = "Estado";
            this.columnEstado.MinimumWidth = 6;
            this.columnEstado.Name = "columnEstado";
            this.columnEstado.Width = 125;
            // 
            // columnFechaRegistro
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.columnFechaRegistro.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnFechaRegistro.HeaderText = "Fecha de registro";
            this.columnFechaRegistro.MinimumWidth = 6;
            this.columnFechaRegistro.Name = "columnFechaRegistro";
            this.columnFechaRegistro.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(17, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 33);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(17, 47);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 33);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.Black;
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textID.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.Color.LightGray;
            this.textID.Location = new System.Drawing.Point(171, 19);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(110, 20);
            this.textID.TabIndex = 5;
            // 
            // textCodigoBarras
            // 
            this.textCodigoBarras.BackColor = System.Drawing.Color.Black;
            this.textCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCodigoBarras.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigoBarras.ForeColor = System.Drawing.Color.LightGray;
            this.textCodigoBarras.Location = new System.Drawing.Point(287, 19);
            this.textCodigoBarras.Name = "textCodigoBarras";
            this.textCodigoBarras.Size = new System.Drawing.Size(110, 20);
            this.textCodigoBarras.TabIndex = 6;
            // 
            // textProducto
            // 
            this.textProducto.BackColor = System.Drawing.Color.Black;
            this.textProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProducto.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProducto.ForeColor = System.Drawing.Color.LightGray;
            this.textProducto.Location = new System.Drawing.Point(171, 88);
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(110, 20);
            this.textProducto.TabIndex = 7;
            // 
            // textDescripcion
            // 
            this.textDescripcion.BackColor = System.Drawing.Color.Black;
            this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescripcion.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.ForeColor = System.Drawing.Color.LightGray;
            this.textDescripcion.Location = new System.Drawing.Point(287, 88);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(110, 20);
            this.textDescripcion.TabIndex = 8;
            this.textDescripcion.Text = "\r\n";
            // 
            // textCategoria
            // 
            this.textCategoria.BackColor = System.Drawing.Color.Black;
            this.textCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCategoria.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.textCategoria.Location = new System.Drawing.Point(403, 88);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(110, 20);
            this.textCategoria.TabIndex = 9;
            // 
            // textCantidad
            // 
            this.textCantidad.BackColor = System.Drawing.Color.Black;
            this.textCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCantidad.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidad.ForeColor = System.Drawing.Color.LightGray;
            this.textCantidad.Location = new System.Drawing.Point(519, 88);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(110, 20);
            this.textCantidad.TabIndex = 10;
            // 
            // textPrecioCompra
            // 
            this.textPrecioCompra.BackColor = System.Drawing.Color.Black;
            this.textPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecioCompra.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioCompra.ForeColor = System.Drawing.Color.LightGray;
            this.textPrecioCompra.Location = new System.Drawing.Point(635, 88);
            this.textPrecioCompra.Name = "textPrecioCompra";
            this.textPrecioCompra.Size = new System.Drawing.Size(110, 20);
            this.textPrecioCompra.TabIndex = 11;
            // 
            // textPrecioVenta
            // 
            this.textPrecioVenta.BackColor = System.Drawing.Color.Black;
            this.textPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecioVenta.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioVenta.ForeColor = System.Drawing.Color.LightGray;
            this.textPrecioVenta.Location = new System.Drawing.Point(751, 88);
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.Size = new System.Drawing.Size(110, 20);
            this.textPrecioVenta.TabIndex = 12;
            // 
            // textFechaRegistro
            // 
            this.textFechaRegistro.BackColor = System.Drawing.Color.Black;
            this.textFechaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFechaRegistro.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFechaRegistro.ForeColor = System.Drawing.Color.LightGray;
            this.textFechaRegistro.Location = new System.Drawing.Point(983, 88);
            this.textFechaRegistro.Name = "textFechaRegistro";
            this.textFechaRegistro.Size = new System.Drawing.Size(123, 20);
            this.textFechaRegistro.TabIndex = 14;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.LightGray;
            this.labelID.Location = new System.Drawing.Point(168, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 18);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID";
            // 
            // labelCodigoBarras
            // 
            this.labelCodigoBarras.AutoSize = true;
            this.labelCodigoBarras.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigoBarras.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoBarras.ForeColor = System.Drawing.Color.LightGray;
            this.labelCodigoBarras.Location = new System.Drawing.Point(284, 0);
            this.labelCodigoBarras.Name = "labelCodigoBarras";
            this.labelCodigoBarras.Size = new System.Drawing.Size(119, 18);
            this.labelCodigoBarras.TabIndex = 16;
            this.labelCodigoBarras.Text = "Codigo de barras";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.BackColor = System.Drawing.Color.Transparent;
            this.labelProducto.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.LightGray;
            this.labelProducto.Location = new System.Drawing.Point(168, 69);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(68, 18);
            this.labelProducto.TabIndex = 17;
            this.labelProducto.Text = "Producto";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labelDescripcion.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.LightGray;
            this.labelDescripcion.Location = new System.Drawing.Point(284, 69);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(85, 18);
            this.labelDescripcion.TabIndex = 18;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.labelCategoria.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.labelCategoria.Location = new System.Drawing.Point(400, 69);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(72, 18);
            this.labelCategoria.TabIndex = 19;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.BackColor = System.Drawing.Color.Transparent;
            this.labelCantidad.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.LightGray;
            this.labelCantidad.Location = new System.Drawing.Point(516, 69);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(68, 18);
            this.labelCantidad.TabIndex = 20;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelPrecioCimpra
            // 
            this.labelPrecioCimpra.AutoSize = true;
            this.labelPrecioCimpra.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecioCimpra.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioCimpra.ForeColor = System.Drawing.Color.LightGray;
            this.labelPrecioCimpra.Location = new System.Drawing.Point(635, 69);
            this.labelPrecioCimpra.Name = "labelPrecioCimpra";
            this.labelPrecioCimpra.Size = new System.Drawing.Size(104, 18);
            this.labelPrecioCimpra.TabIndex = 21;
            this.labelPrecioCimpra.Text = "Precio compra";
            // 
            // labelPrecioVenta
            // 
            this.labelPrecioVenta.AutoSize = true;
            this.labelPrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecioVenta.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioVenta.ForeColor = System.Drawing.Color.LightGray;
            this.labelPrecioVenta.Location = new System.Drawing.Point(748, 69);
            this.labelPrecioVenta.Name = "labelPrecioVenta";
            this.labelPrecioVenta.Size = new System.Drawing.Size(92, 18);
            this.labelPrecioVenta.TabIndex = 22;
            this.labelPrecioVenta.Text = "Precio Venta";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.Color.Transparent;
            this.labelEstado.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.LightGray;
            this.labelEstado.Location = new System.Drawing.Point(864, 69);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(53, 18);
            this.labelEstado.TabIndex = 23;
            this.labelEstado.Text = "Estado";
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaRegistro.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRegistro.ForeColor = System.Drawing.Color.LightGray;
            this.labelFechaRegistro.Location = new System.Drawing.Point(980, 69);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(126, 18);
            this.labelFechaRegistro.TabIndex = 24;
            this.labelFechaRegistro.Text = "Fecha de Registro";
            // 
            // checkBoxProducto
            // 
            this.checkBoxProducto.AutoSize = true;
            this.checkBoxProducto.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxProducto.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProducto.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxProducto.Location = new System.Drawing.Point(866, 90);
            this.checkBoxProducto.Name = "checkBoxProducto";
            this.checkBoxProducto.Size = new System.Drawing.Size(72, 22);
            this.checkBoxProducto.TabIndex = 25;
            this.checkBoxProducto.Text = "Activo";
            this.checkBoxProducto.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Location = new System.Drawing.Point(171, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 5);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Location = new System.Drawing.Point(287, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 5);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Location = new System.Drawing.Point(171, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 5);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.Location = new System.Drawing.Point(286, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 5);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGreen;
            this.panel5.Location = new System.Drawing.Point(403, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 5);
            this.panel5.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGreen;
            this.panel6.Location = new System.Drawing.Point(519, 109);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 5);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGreen;
            this.panel7.Location = new System.Drawing.Point(635, 109);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(110, 5);
            this.panel7.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGreen;
            this.panel8.Location = new System.Drawing.Point(751, 109);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 5);
            this.panel8.TabIndex = 27;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGreen;
            this.panel9.Location = new System.Drawing.Point(983, 109);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(110, 5);
            this.panel9.TabIndex = 27;
            // 
            // panelControlProductos
            // 
            this.panelControlProductos.AutoSize = true;
            this.panelControlProductos.Controls.Add(this.panelTabla);
            this.panelControlProductos.Controls.Add(this.panel9);
            this.panelControlProductos.Controls.Add(this.panel8);
            this.panelControlProductos.Controls.Add(this.panel7);
            this.panelControlProductos.Controls.Add(this.panel6);
            this.panelControlProductos.Controls.Add(this.panel5);
            this.panelControlProductos.Controls.Add(this.panel4);
            this.panelControlProductos.Controls.Add(this.panel3);
            this.panelControlProductos.Controls.Add(this.panel2);
            this.panelControlProductos.Controls.Add(this.panel1);
            this.panelControlProductos.Controls.Add(this.checkBoxProducto);
            this.panelControlProductos.Controls.Add(this.labelFechaRegistro);
            this.panelControlProductos.Controls.Add(this.labelEstado);
            this.panelControlProductos.Controls.Add(this.labelPrecioVenta);
            this.panelControlProductos.Controls.Add(this.labelPrecioCimpra);
            this.panelControlProductos.Controls.Add(this.labelCantidad);
            this.panelControlProductos.Controls.Add(this.labelCategoria);
            this.panelControlProductos.Controls.Add(this.labelDescripcion);
            this.panelControlProductos.Controls.Add(this.labelProducto);
            this.panelControlProductos.Controls.Add(this.labelCodigoBarras);
            this.panelControlProductos.Controls.Add(this.labelID);
            this.panelControlProductos.Controls.Add(this.textFechaRegistro);
            this.panelControlProductos.Controls.Add(this.textPrecioVenta);
            this.panelControlProductos.Controls.Add(this.textPrecioCompra);
            this.panelControlProductos.Controls.Add(this.textCantidad);
            this.panelControlProductos.Controls.Add(this.textCategoria);
            this.panelControlProductos.Controls.Add(this.textDescripcion);
            this.panelControlProductos.Controls.Add(this.textProducto);
            this.panelControlProductos.Controls.Add(this.textCodigoBarras);
            this.panelControlProductos.Controls.Add(this.textID);
            this.panelControlProductos.Controls.Add(this.btnEliminar);
            this.panelControlProductos.Controls.Add(this.btnAgregar);
            this.panelControlProductos.Location = new System.Drawing.Point(0, 2);
            this.panelControlProductos.Name = "panelControlProductos";
            this.panelControlProductos.Size = new System.Drawing.Size(1200, 435);
            this.panelControlProductos.TabIndex = 31;
            // 
            // panelTabla
            // 
            this.panelTabla.AutoSize = true;
            this.panelTabla.Controls.Add(this.tablaDatos);
            this.panelTabla.Location = new System.Drawing.Point(3, 120);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1194, 312);
            this.panelTabla.TabIndex = 32;
            // 
            // controlDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelControlProductos);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "controlDeProductos";
            this.Size = new System.Drawing.Size(1203, 440);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.panelControlProductos.ResumeLayout(false);
            this.panelControlProductos.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textCodigoBarras;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textPrecioCompra;
        private System.Windows.Forms.TextBox textPrecioVenta;
        private System.Windows.Forms.TextBox textFechaRegistro;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCodigoBarras;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelPrecioCimpra;
        private System.Windows.Forms.Label labelPrecioVenta;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.CheckBox checkBoxProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaRegistro;
        private System.Windows.Forms.Panel panelControlProductos;
        private System.Windows.Forms.Panel panelTabla;
    }
}
