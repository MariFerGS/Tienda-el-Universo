namespace TiendaelUniversoOrg
{
    partial class Agregar_Carrito_Articulo_Comprados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Carrito_Articulo_Comprados));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.codigoArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arti_AdmiDataSet1 = new TiendaelUniversoOrg.Arti_AdmiDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.bSATableAdapter = new TiendaelUniversoOrg.Arti_AdmiDataSet1TableAdapters.BSATableAdapter();
            this.regresar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_subtotal_compra = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tx_telefono = new System.Windows.Forms.TextBox();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_total_compra = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lk_imprimir = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.tx_iva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arti_AdmiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoArticuloDataGridViewTextBoxColumn,
            this.columna_precio,
            this.clasificaciónDataGridViewTextBoxColumn,
            this.unidadMedidaDataGridViewTextBoxColumn,
            this.descripciónDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bSABindingSource;
            this.dataGridView.Location = new System.Drawing.Point(24, 240);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(593, 207);
            this.dataGridView.TabIndex = 50;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // codigoArticuloDataGridViewTextBoxColumn
            // 
            this.codigoArticuloDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Articulo";
            this.codigoArticuloDataGridViewTextBoxColumn.HeaderText = "Codigo Artículo";
            this.codigoArticuloDataGridViewTextBoxColumn.Name = "codigoArticuloDataGridViewTextBoxColumn";
            // 
            // columna_precio
            // 
            this.columna_precio.DataPropertyName = "Precio";
            this.columna_precio.HeaderText = "Precio";
            this.columna_precio.Name = "columna_precio";
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
            this.descripciónDataGridViewTextBoxColumn.Width = 150;
            // 
            // bSABindingSource
            // 
            this.bSABindingSource.DataMember = "BSA";
            this.bSABindingSource.DataSource = this.arti_AdmiDataSet1;
            // 
            // arti_AdmiDataSet1
            // 
            this.arti_AdmiDataSet1.DataSetName = "Arti_AdmiDataSet1";
            this.arti_AdmiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 43);
            this.label1.TabIndex = 51;
            this.label1.Text = "TIENDA EL UNIVERSO";
            // 
            // bSATableAdapter
            // 
            this.bSATableAdapter.ClearBeforeFill = true;
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
            this.regresar.Location = new System.Drawing.Point(12, 591);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(115, 40);
            this.regresar.TabIndex = 52;
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
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
            this.salir.Location = new System.Drawing.Point(499, 591);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(118, 36);
            this.salir.TabIndex = 53;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Articulos Seleccionados Para La Compra";
            // 
            // tx_subtotal_compra
            // 
            this.tx_subtotal_compra.Location = new System.Drawing.Point(438, 465);
            this.tx_subtotal_compra.Name = "tx_subtotal_compra";
            this.tx_subtotal_compra.Size = new System.Drawing.Size(174, 20);
            this.tx_subtotal_compra.TabIndex = 56;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.WindowText;
            this.linkLabel1.Location = new System.Drawing.Point(362, 527);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 57;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Total:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tx_telefono
            // 
            this.tx_telefono.Location = new System.Drawing.Point(158, 146);
            this.tx_telefono.Name = "tx_telefono";
            this.tx_telefono.Size = new System.Drawing.Size(274, 20);
            this.tx_telefono.TabIndex = 63;
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(158, 85);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(274, 20);
            this.tx_name.TabIndex = 62;
            // 
            // tx_direccion
            // 
            this.tx_direccion.Location = new System.Drawing.Point(158, 114);
            this.tx_direccion.Name = "tx_direccion";
            this.tx_direccion.Size = new System.Drawing.Size(274, 20);
            this.tx_direccion.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Numero de teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nombre Completo:";
            // 
            // tx_total_compra
            // 
            this.tx_total_compra.Location = new System.Drawing.Point(438, 525);
            this.tx_total_compra.Name = "tx_total_compra";
            this.tx_total_compra.Size = new System.Drawing.Size(174, 20);
            this.tx_total_compra.TabIndex = 56;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.WindowText;
            this.linkLabel2.Location = new System.Drawing.Point(362, 467);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(57, 15);
            this.linkLabel2.TabIndex = 64;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Subtotal:";
            // 
            // lk_imprimir
            // 
            this.lk_imprimir.AutoSize = true;
            this.lk_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.lk_imprimir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lk_imprimir.LinkColor = System.Drawing.Color.DarkBlue;
            this.lk_imprimir.Location = new System.Drawing.Point(557, 557);
            this.lk_imprimir.Name = "lk_imprimir";
            this.lk_imprimir.Size = new System.Drawing.Size(55, 14);
            this.lk_imprimir.TabIndex = 65;
            this.lk_imprimir.TabStop = true;
            this.lk_imprimir.Text = "Imprimir";
            this.lk_imprimir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_imprimir_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.WindowText;
            this.linkLabel3.Location = new System.Drawing.Point(362, 496);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(23, 15);
            this.linkLabel3.TabIndex = 66;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "I.V:";
            // 
            // tx_iva
            // 
            this.tx_iva.Location = new System.Drawing.Point(438, 496);
            this.tx_iva.Name = "tx_iva";
            this.tx_iva.Size = new System.Drawing.Size(174, 20);
            this.tx_iva.TabIndex = 67;
            // 
            // Agregar_Carrito_Articulo_Comprados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(653, 639);
            this.Controls.Add(this.tx_iva);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.lk_imprimir);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.tx_telefono);
            this.Controls.Add(this.tx_name);
            this.Controls.Add(this.tx_direccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tx_total_compra);
            this.Controls.Add(this.tx_subtotal_compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Agregar_Carrito_Articulo_Comprados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tienda el Universo";
            this.Load += new System.EventHandler(this.Agregar_Carrito_Articulo_Comprados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arti_AdmiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private Arti_AdmiDataSet1 arti_AdmiDataSet1;
        private System.Windows.Forms.BindingSource bSABindingSource;
        private Arti_AdmiDataSet1TableAdapters.BSATableAdapter bSATableAdapter;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_subtotal_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tx_telefono;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_total_compra;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel lk_imprimir;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox tx_iva;
    }
}