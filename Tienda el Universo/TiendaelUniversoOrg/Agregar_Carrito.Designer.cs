namespace TiendaelUniversoOrg
{
    partial class Agregar_Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Carrito));
            this.bSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arti_AdmiDataSet = new TiendaelUniversoOrg.Arti_AdmiDataSet();
            this.dBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new TiendaelUniversoOrg.DatabaseDataSet();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificaciónDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBTableAdapter = new TiendaelUniversoOrg.DatabaseDataSetTableAdapters.DBTableAdapter();
            this.bSATableAdapter = new TiendaelUniversoOrg.Arti_AdmiDataSetTableAdapters.BSATableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_codeart = new System.Windows.Forms.Label();
            this.tx_descripcion = new System.Windows.Forms.Label();
            this.tx_inventario = new System.Windows.Forms.Label();
            this.panel_add_articles = new System.Windows.Forms.Panel();
            this.n = new System.Windows.Forms.Label();
            this.tx_precio = new System.Windows.Forms.Label();
            this.cbx_medida = new System.Windows.Forms.Label();
            this.cmb_clasificacion = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.códigoArtículoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.salir = new System.Windows.Forms.Button();
            this.tx_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arti_AdmiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_add_articles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bSABindingSource
            // 
            this.bSABindingSource.DataMember = "BSA";
            this.bSABindingSource.DataSource = this.arti_AdmiDataSet;
            // 
            // arti_AdmiDataSet
            // 
            this.arti_AdmiDataSet.DataSetName = "Arti_AdmiDataSet";
            this.arti_AdmiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBBindingSource
            // 
            this.dBBindingSource.DataMember = "DB";
            this.dBBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.Transparent;
            this.btn_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_new.BackgroundImage")));
            this.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(310, 468);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(63, 54);
            this.btn_new.TabIndex = 52;
            this.btn_new.Text = "Nuevo";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(554, 465);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 61);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "Añadir";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Transparent;
            this.regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regresar.BackgroundImage")));
            this.regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regresar.FlatAppearance.BorderSize = 0;
            this.regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Location = new System.Drawing.Point(13, 645);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(115, 38);
            this.regresar.TabIndex = 50;
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Articulo,
            this.precioDataGridViewTextBoxColumn1,
            this.inventarioDataGridViewTextBoxColumn1,
            this.clasificaciónDataGridViewTextBoxColumn1,
            this.unidadMedidaDataGridViewTextBoxColumn1,
            this.descripciónDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bSABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(150, 530);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 153);
            this.dataGridView1.TabIndex = 49;
 
            // 
            // Codigo_Articulo
            // 
            this.Codigo_Articulo.DataPropertyName = "Codigo_Articulo";
            this.Codigo_Articulo.HeaderText = "Codigo Artículo";
            this.Codigo_Articulo.Name = "Codigo_Articulo";
            this.Codigo_Articulo.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn1
            // 
            this.precioDataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn1.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn1.Name = "precioDataGridViewTextBoxColumn1";
            this.precioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inventarioDataGridViewTextBoxColumn1
            // 
            this.inventarioDataGridViewTextBoxColumn1.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn1.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn1.Name = "inventarioDataGridViewTextBoxColumn1";
            this.inventarioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clasificaciónDataGridViewTextBoxColumn1
            // 
            this.clasificaciónDataGridViewTextBoxColumn1.DataPropertyName = "Clasificación";
            this.clasificaciónDataGridViewTextBoxColumn1.HeaderText = "Clasificación";
            this.clasificaciónDataGridViewTextBoxColumn1.Name = "clasificaciónDataGridViewTextBoxColumn1";
            this.clasificaciónDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unidadMedidaDataGridViewTextBoxColumn1
            // 
            this.unidadMedidaDataGridViewTextBoxColumn1.DataPropertyName = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn1.HeaderText = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn1.Name = "unidadMedidaDataGridViewTextBoxColumn1";
            this.unidadMedidaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descripciónDataGridViewTextBoxColumn1
            // 
            this.descripciónDataGridViewTextBoxColumn1.DataPropertyName = "Descripción";
            this.descripciónDataGridViewTextBoxColumn1.HeaderText = "Descripción";
            this.descripciónDataGridViewTextBoxColumn1.Name = "descripciónDataGridViewTextBoxColumn1";
            this.descripciónDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dBTableAdapter
            // 
            this.dBTableAdapter.ClearBeforeFill = true;
            // 
            // bSATableAdapter
            // 
            this.bSATableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tienda El Universo";
            // 
            // mostrar
            // 
            this.mostrar.BackColor = System.Drawing.Color.Transparent;
            this.mostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mostrar.BackgroundImage")));
            this.mostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mostrar.FlatAppearance.BorderSize = 0;
            this.mostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.Location = new System.Drawing.Point(444, 468);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(63, 54);
            this.mostrar.TabIndex = 54;
            this.mostrar.Text = "Mostrar";
            this.mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mostrar.UseVisualStyleBackColor = false;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(750, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Inventario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Clasificación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Unidad medida:";
            // 
            // tx_codeart
            // 
            this.tx_codeart.AutoSize = true;
            this.tx_codeart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSABindingSource, "Precio", true));
            this.tx_codeart.Location = new System.Drawing.Point(135, 33);
            this.tx_codeart.Name = "tx_codeart";
            this.tx_codeart.Size = new System.Drawing.Size(35, 13);
            this.tx_codeart.TabIndex = 28;
            this.tx_codeart.Text = "label2";
            // 
            // tx_descripcion
            // 
            this.tx_descripcion.AutoSize = true;
            this.tx_descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSABindingSource, "Descripción", true));
            this.tx_descripcion.Location = new System.Drawing.Point(750, 33);
            this.tx_descripcion.Name = "tx_descripcion";
            this.tx_descripcion.Size = new System.Drawing.Size(35, 13);
            this.tx_descripcion.TabIndex = 30;
            this.tx_descripcion.Text = "label2";
            // 
            // tx_inventario
            // 
            this.tx_inventario.AutoSize = true;
            this.tx_inventario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSABindingSource, "Inventario", true));
            this.tx_inventario.Location = new System.Drawing.Point(237, 33);
            this.tx_inventario.Name = "tx_inventario";
            this.tx_inventario.Size = new System.Drawing.Size(35, 13);
            this.tx_inventario.TabIndex = 31;
            this.tx_inventario.Text = "label9";
            // 
            // panel_add_articles
            // 
            this.panel_add_articles.BackColor = System.Drawing.Color.Transparent;
            this.panel_add_articles.Controls.Add(this.n);
            this.panel_add_articles.Controls.Add(this.tx_precio);
            this.panel_add_articles.Controls.Add(this.cbx_medida);
            this.panel_add_articles.Controls.Add(this.cmb_clasificacion);
            this.panel_add_articles.Controls.Add(this.tx_inventario);
            this.panel_add_articles.Controls.Add(this.tx_descripcion);
            this.panel_add_articles.Controls.Add(this.tx_codeart);
            this.panel_add_articles.Controls.Add(this.label8);
            this.panel_add_articles.Controls.Add(this.label7);
            this.panel_add_articles.Controls.Add(this.label5);
            this.panel_add_articles.Controls.Add(this.label4);
            this.panel_add_articles.Controls.Add(this.label14);
            this.panel_add_articles.Location = new System.Drawing.Point(12, 56);
            this.panel_add_articles.Name = "panel_add_articles";
            this.panel_add_articles.Size = new System.Drawing.Size(895, 88);
            this.panel_add_articles.TabIndex = 46;
            this.panel_add_articles.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_add_articles_Paint);
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(0, 16);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(109, 17);
            this.n.TabIndex = 36;
            this.n.Text = "Código Articulo:";
            // 
            // tx_precio
            // 
            this.tx_precio.AutoSize = true;
            this.tx_precio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSABindingSource, "Codigo_Articulo", true));
            this.tx_precio.Location = new System.Drawing.Point(7, 33);
            this.tx_precio.Name = "tx_precio";
            this.tx_precio.Size = new System.Drawing.Size(35, 13);
            this.tx_precio.TabIndex = 35;
            this.tx_precio.Text = "label2";
            // 
            // cbx_medida
            // 
            this.cbx_medida.AutoSize = true;
            this.cbx_medida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSABindingSource, "Unidad Medida", true));
            this.cbx_medida.Location = new System.Drawing.Point(553, 33);
            this.cbx_medida.Name = "cbx_medida";
            this.cbx_medida.Size = new System.Drawing.Size(41, 13);
            this.cbx_medida.TabIndex = 34;
            this.cbx_medida.Text = "label12";
            // 
            // cmb_clasificacion
            // 
            this.cmb_clasificacion.AutoSize = true;
            this.cmb_clasificacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bSABindingSource, "Clasificación", true));
            this.cmb_clasificacion.Location = new System.Drawing.Point(366, 33);
            this.cmb_clasificacion.Name = "cmb_clasificacion";
            this.cmb_clasificacion.Size = new System.Drawing.Size(41, 13);
            this.cmb_clasificacion.TabIndex = 33;
            this.cmb_clasificacion.Text = "label11";
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoArtículoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.inventarioDataGridViewTextBoxColumn,
            this.clasificaciónDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.descripciónDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn});
            this.dataGridView.DataSource = this.dBBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 187);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 200;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(909, 277);
            this.dataGridView.TabIndex = 55;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // códigoArtículoDataGridViewTextBoxColumn
            // 
            this.códigoArtículoDataGridViewTextBoxColumn.DataPropertyName = "Código Artículo";
            this.códigoArtículoDataGridViewTextBoxColumn.HeaderText = "Código Artículo";
            this.códigoArtículoDataGridViewTextBoxColumn.Name = "códigoArtículoDataGridViewTextBoxColumn";
            this.códigoArtículoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            this.inventarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clasificaciónDataGridViewTextBoxColumn
            // 
            this.clasificaciónDataGridViewTextBoxColumn.DataPropertyName = "Clasificación";
            this.clasificaciónDataGridViewTextBoxColumn.HeaderText = "Clasificación";
            this.clasificaciónDataGridViewTextBoxColumn.Name = "clasificaciónDataGridViewTextBoxColumn";
            this.clasificaciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            this.unidadMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripciónDataGridViewTextBoxColumn
            // 
            this.descripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.Name = "descripciónDataGridViewTextBoxColumn";
            this.descripciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripciónDataGridViewTextBoxColumn.Width = 150;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            this.imagenDataGridViewImageColumn.Width = 200;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salir.BackgroundImage")));
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Location = new System.Drawing.Point(803, 647);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(118, 36);
            this.salir.TabIndex = 56;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // tx_search
            // 
            this.tx_search.Location = new System.Drawing.Point(97, 157);
            this.tx_search.Name = "tx_search";
            this.tx_search.Size = new System.Drawing.Size(810, 20);
            this.tx_search.TabIndex = 58;
    
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Buscar:";
            // 
            // Agregar_Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 695);
            this.Controls.Add(this.tx_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_add_articles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Carrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tienda el Universo";
            this.Load += new System.EventHandler(this.Agregar_Carrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arti_AdmiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_add_articles.ResumeLayout(false);
            this.panel_add_articles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Arti_AdmiDataSet arti_AdmiDataSet;
        private System.Windows.Forms.BindingSource bSABindingSource;
        private Arti_AdmiDataSetTableAdapters.BSATableAdapter bSATableAdapter;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource dBBindingSource;
        private DatabaseDataSetTableAdapters.DBTableAdapter dBTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label tx_codeart;
        private System.Windows.Forms.Label tx_descripcion;
        private System.Windows.Forms.Label tx_inventario;
        private System.Windows.Forms.Panel panel_add_articles;
        private System.Windows.Forms.Label cbx_medida;
        private System.Windows.Forms.Label cmb_clasificacion;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoArtículoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Label tx_precio;
        private System.Windows.Forms.Button salir;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificaciónDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox tx_search;
        private System.Windows.Forms.Label label2;
    }
}