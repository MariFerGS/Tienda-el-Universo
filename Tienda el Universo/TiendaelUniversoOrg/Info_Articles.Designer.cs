namespace TiendaelUniversoOrg
{
    partial class Info_Articles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Articles));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.códigoArtículoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBArtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBArt = new TiendaelUniversoOrg.DBArt();
            this.label1 = new System.Windows.Forms.Label();
            this.dBTableAdapter = new TiendaelUniversoOrg.DBArtTableAdapters.DBTableAdapter();
            this.salir = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBArtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
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
            this.dataGridView.Location = new System.Drawing.Point(12, 116);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 200;
            this.dataGridView.Size = new System.Drawing.Size(844, 335);
            this.dataGridView.TabIndex = 0;
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
            // dBBindingSource
            // 
            this.dBBindingSource.DataMember = "DB";
            this.dBBindingSource.DataSource = this.dBArtBindingSource;
            // 
            // dBArtBindingSource
            // 
            this.dBArtBindingSource.DataSource = this.dBArt;
            this.dBArtBindingSource.Position = 0;
            // 
            // dBArt
            // 
            this.dBArt.DataSetName = "DBArt";
            this.dBArt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(198, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tienda El Universo";
            // 
            // dBTableAdapter
            // 
            this.dBTableAdapter.ClearBeforeFill = true;
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
            this.salir.Location = new System.Drawing.Point(705, 479);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(118, 36);
            this.salir.TabIndex = 15;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Transparent;
            this.btnreturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnreturn.BackgroundImage")));
            this.btnreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreturn.FlatAppearance.BorderSize = 0;
            this.btnreturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnreturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Location = new System.Drawing.Point(12, 479);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(145, 36);
            this.btnreturn.TabIndex = 14;
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Buscar:";
            // 
            // tx_search
            // 
            this.tx_search.Location = new System.Drawing.Point(87, 85);
            this.tx_search.Name = "tx_search";
            this.tx_search.Size = new System.Drawing.Size(769, 20);
            this.tx_search.TabIndex = 60;
            this.tx_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_search_KeyPress);
            // 
            // Info_Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 527);
            this.Controls.Add(this.tx_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Info_Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información de Artículos";
            this.Load += new System.EventHandler(this.Info_Articles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBArtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dBArtBindingSource;
        private DBArt dBArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dBBindingSource;
        private DBArtTableAdapters.DBTableAdapter dBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoArtículoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_search;
    }
}