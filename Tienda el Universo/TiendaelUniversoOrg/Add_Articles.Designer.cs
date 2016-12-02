namespace TiendaelUniversoOrg
{
    partial class Add_Articles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Articles));
            this.label1 = new System.Windows.Forms.Label();
            this.panel_add_articles = new System.Windows.Forms.Panel();
            this.cmb_clasificacion = new System.Windows.Forms.ComboBox();
            this.dBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBArt = new TiendaelUniversoOrg.DBArt();
            this.cbx_medida = new System.Windows.Forms.ComboBox();
            this.tx_descripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_inventario = new System.Windows.Forms.TextBox();
            this.tx_codeart = new System.Windows.Forms.TextBox();
            this.tx_code_user = new System.Windows.Forms.TextBox();
            this.tx_precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pb_add_articles = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoArtículoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_search = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dBTableAdapter = new TiendaelUniversoOrg.DBArtTableAdapters.DBTableAdapter();
            this.panel_add_articles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_articles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIENDA EL UNIVERSO";
            // 
            // panel_add_articles
            // 
            this.panel_add_articles.BackColor = System.Drawing.Color.Transparent;
            this.panel_add_articles.Controls.Add(this.cmb_clasificacion);
            this.panel_add_articles.Controls.Add(this.cbx_medida);
            this.panel_add_articles.Controls.Add(this.tx_descripcion);
            this.panel_add_articles.Controls.Add(this.label8);
            this.panel_add_articles.Controls.Add(this.label7);
            this.panel_add_articles.Controls.Add(this.tx_inventario);
            this.panel_add_articles.Controls.Add(this.tx_codeart);
            this.panel_add_articles.Controls.Add(this.tx_code_user);
            this.panel_add_articles.Controls.Add(this.tx_precio);
            this.panel_add_articles.Controls.Add(this.label6);
            this.panel_add_articles.Controls.Add(this.label5);
            this.panel_add_articles.Controls.Add(this.label4);
            this.panel_add_articles.Controls.Add(this.label3);
            this.panel_add_articles.Controls.Add(this.btn_buscar);
            this.panel_add_articles.Controls.Add(this.label14);
            this.panel_add_articles.Controls.Add(this.label13);
            this.panel_add_articles.Controls.Add(this.pb_add_articles);
            this.panel_add_articles.Location = new System.Drawing.Point(12, 55);
            this.panel_add_articles.Name = "panel_add_articles";
            this.panel_add_articles.Size = new System.Drawing.Size(733, 286);
            this.panel_add_articles.TabIndex = 36;
            // 
            // cmb_clasificacion
            // 
            this.cmb_clasificacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dBBindingSource, "Clasificación", true));
            this.cmb_clasificacion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clasificacion.FormattingEnabled = true;
            this.cmb_clasificacion.Items.AddRange(new object[] {
            "Perfumería",
            "Cosméticos",
            "Ropa",
            "Joyería"});
            this.cmb_clasificacion.Location = new System.Drawing.Point(123, 136);
            this.cmb_clasificacion.Name = "cmb_clasificacion";
            this.cmb_clasificacion.Size = new System.Drawing.Size(174, 25);
            this.cmb_clasificacion.TabIndex = 27;
            this.cmb_clasificacion.Text = "Seleccione...";
            // 
            // dBBindingSource
            // 
            this.dBBindingSource.DataMember = "DB";
            this.dBBindingSource.DataSource = this.dBArt;
            // 
            // dBArt
            // 
            this.dBArt.DataSetName = "DBArt";
            this.dBArt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbx_medida
            // 
            this.cbx_medida.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dBBindingSource, "Unidad Medida", true));
            this.cbx_medida.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_medida.FormattingEnabled = true;
            this.cbx_medida.Items.AddRange(new object[] {
            "30ml",
            "50ml",
            "75ml",
            "100ml",
            "125ml",
            "Creamy Natural",
            "Nude",
            "Sandy Beige",
            "S",
            "M",
            "L",
            "XL"});
            this.cbx_medida.Location = new System.Drawing.Point(123, 171);
            this.cbx_medida.Name = "cbx_medida";
            this.cbx_medida.Size = new System.Drawing.Size(174, 25);
            this.cbx_medida.TabIndex = 19;
            this.cbx_medida.Text = "Seleccione...";
            // 
            // tx_descripcion
            // 
            this.tx_descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBBindingSource, "Descripción", true));
            this.tx_descripcion.Location = new System.Drawing.Point(123, 209);
            this.tx_descripcion.Multiline = true;
            this.tx_descripcion.Name = "tx_descripcion";
            this.tx_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tx_descripcion.Size = new System.Drawing.Size(241, 63);
            this.tx_descripcion.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Unidad medida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Clasificación:";
            // 
            // tx_inventario
            // 
            this.tx_inventario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBBindingSource, "Inventario", true));
            this.tx_inventario.Location = new System.Drawing.Point(123, 68);
            this.tx_inventario.Name = "tx_inventario";
            this.tx_inventario.Size = new System.Drawing.Size(174, 20);
            this.tx_inventario.TabIndex = 25;
            // 
            // tx_codeart
            // 
            this.tx_codeart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBBindingSource, "Código Artículo", true));
            this.tx_codeart.Location = new System.Drawing.Point(123, 13);
            this.tx_codeart.Name = "tx_codeart";
            this.tx_codeart.Size = new System.Drawing.Size(174, 20);
            this.tx_codeart.TabIndex = 24;
            // 
            // tx_code_user
            // 
            this.tx_code_user.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBBindingSource, "Código Usuario", true));
            this.tx_code_user.Location = new System.Drawing.Point(123, 99);
            this.tx_code_user.Name = "tx_code_user";
            this.tx_code_user.Size = new System.Drawing.Size(174, 20);
            this.tx_code_user.TabIndex = 23;
            // 
            // tx_precio
            // 
            this.tx_precio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dBBindingSource, "Precio", true));
            this.tx_precio.Location = new System.Drawing.Point(123, 42);
            this.tx_precio.Name = "tx_precio";
            this.tx_precio.Size = new System.Drawing.Size(174, 20);
            this.tx_precio.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Código Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Inventario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Código  Articulo:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(511, 202);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(142, 55);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Descripción:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(547, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Imagen:";
            // 
            // pb_add_articles
            // 
            this.pb_add_articles.BackColor = System.Drawing.Color.White;
            this.pb_add_articles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_add_articles.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.dBBindingSource, "Imagen", true));
            this.pb_add_articles.Location = new System.Drawing.Point(501, 37);
            this.pb_add_articles.Name = "pb_add_articles";
            this.pb_add_articles.Size = new System.Drawing.Size(152, 159);
            this.pb_add_articles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_add_articles.TabIndex = 0;
            this.pb_add_articles.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.códigoArtículoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.inventarioDataGridViewTextBoxColumn,
            this.códigoUsuarioDataGridViewTextBoxColumn,
            this.clasificaciónDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.descripciónDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn});
            this.dataGridView.DataSource = this.dBBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(18, 383);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(733, 138);
            this.dataGridView.TabIndex = 37;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            // 
            // códigoArtículoDataGridViewTextBoxColumn
            // 
            this.códigoArtículoDataGridViewTextBoxColumn.DataPropertyName = "Código Artículo";
            this.códigoArtículoDataGridViewTextBoxColumn.HeaderText = "Código Artículo";
            this.códigoArtículoDataGridViewTextBoxColumn.Name = "códigoArtículoDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            // 
            // códigoUsuarioDataGridViewTextBoxColumn
            // 
            this.códigoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Código Usuario";
            this.códigoUsuarioDataGridViewTextBoxColumn.HeaderText = "Código Usuario";
            this.códigoUsuarioDataGridViewTextBoxColumn.Name = "códigoUsuarioDataGridViewTextBoxColumn";
            // 
            // clasificaciónDataGridViewTextBoxColumn
            // 
            this.clasificaciónDataGridViewTextBoxColumn.DataPropertyName = "Clasificación";
            this.clasificaciónDataGridViewTextBoxColumn.HeaderText = "Clasificación";
            this.clasificaciónDataGridViewTextBoxColumn.Name = "clasificaciónDataGridViewTextBoxColumn";
            // 
            // unidadMedidaDataGridViewTextBoxColumn
            // 
            this.unidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad Medida";
            this.unidadMedidaDataGridViewTextBoxColumn.Name = "unidadMedidaDataGridViewTextBoxColumn";
            // 
            // descripciónDataGridViewTextBoxColumn
            // 
            this.descripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripciónDataGridViewTextBoxColumn.Name = "descripciónDataGridViewTextBoxColumn";
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buscar:";
            // 
            // tx_search
            // 
            this.tx_search.Location = new System.Drawing.Point(93, 357);
            this.tx_search.Name = "tx_search";
            this.tx_search.Size = new System.Drawing.Size(652, 20);
            this.tx_search.TabIndex = 39;
            this.tx_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_search_KeyPress);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(492, 527);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 42);
            this.btn_cancel.TabIndex = 44;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.regresar.Location = new System.Drawing.Point(15, 529);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(115, 40);
            this.regresar.TabIndex = 43;
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(641, 529);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(110, 40);
            this.btn_salir.TabIndex = 42;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
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
            this.btn_new.Location = new System.Drawing.Point(155, 526);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(63, 54);
            this.btn_new.TabIndex = 41;
            this.btn_new.Text = "Nuevo";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click_1);
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
            this.btn_save.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(369, 529);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(67, 52);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(255, 527);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(63, 53);
            this.btn_editar.TabIndex = 45;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // dBTableAdapter
            // 
            this.dBTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(767, 581);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tx_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_add_articles);
            this.Controls.Add(this.label1);
            this.Name = "Add_Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Artículos";
            this.Load += new System.EventHandler(this.Add_Articles_Load);
            this.panel_add_articles.ResumeLayout(false);
            this.panel_add_articles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_articles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_add_articles;
        private System.Windows.Forms.ComboBox cbx_medida;
        private System.Windows.Forms.TextBox tx_descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_inventario;
        private System.Windows.Forms.TextBox tx_codeart;
        private System.Windows.Forms.TextBox tx_code_user;
        private System.Windows.Forms.TextBox tx_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pb_add_articles;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_search;
        private System.Windows.Forms.ComboBox cmb_clasificacion;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_editar;
        private DBArt dBArt;
        private System.Windows.Forms.BindingSource dBBindingSource;
        private DBArtTableAdapters.DBTableAdapter dBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoArtículoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
    }
}