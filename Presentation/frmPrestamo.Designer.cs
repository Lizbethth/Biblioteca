namespace Biblioteca.Presentation
{
    partial class frmPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamo));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFolioB = new MaterialSkin.Controls.MaterialTextBox();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.dtvPrestamo = new System.Windows.Forms.DataGridView();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet3 = new Biblioteca.bibliotecaDataSet3();
            this.librosTableAdapter = new Biblioteca.bibliotecaDataSet3TableAdapters.LibrosTableAdapter();
            this.bibliotecaDataSet1 = new Biblioteca.bibliotecaDataSet();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clavePasilloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(179, 132);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Folio: ";
            // 
            // txtFolioB
            // 
            this.txtFolioB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolioB.Depth = 0;
            this.txtFolioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolioB.LeadingIcon = null;
            this.txtFolioB.Location = new System.Drawing.Point(254, 111);
            this.txtFolioB.MaxLength = 50;
            this.txtFolioB.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFolioB.Multiline = false;
            this.txtFolioB.Name = "txtFolioB";
            this.txtFolioB.Size = new System.Drawing.Size(429, 50);
            this.txtFolioB.TabIndex = 2;
            this.txtFolioB.Text = "";
            this.txtFolioB.TrailingIcon = null;
            this.txtFolioB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerosKeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.Location = new System.Drawing.Point(254, 197);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(1, 0);
            this.lblNombre.TabIndex = 3;
            // 
            // dtvPrestamo
            // 
            this.dtvPrestamo.AllowUserToDeleteRows = false;
            this.dtvPrestamo.AutoGenerateColumns = false;
            this.dtvPrestamo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtvPrestamo.BackgroundColor = System.Drawing.Color.White;
            this.dtvPrestamo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvPrestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvPrestamo.ColumnHeadersHeight = 25;
            this.dtvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.claveGeneroDataGridViewTextBoxColumn,
            this.clavePasilloDataGridViewTextBoxColumn,
            this.claveLibroDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.fechaPublicacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dtvPrestamo.DataSource = this.librosBindingSource;
            this.dtvPrestamo.EnableHeadersVisualStyles = false;
            this.dtvPrestamo.Location = new System.Drawing.Point(27, 266);
            this.dtvPrestamo.MultiSelect = false;
            this.dtvPrestamo.Name = "dtvPrestamo";
            this.dtvPrestamo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvPrestamo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvPrestamo.RowHeadersWidth = 32;
            this.dtvPrestamo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dtvPrestamo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dtvPrestamo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtvPrestamo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtvPrestamo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtvPrestamo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvPrestamo.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvPrestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvPrestamo.Size = new System.Drawing.Size(874, 237);
            this.dtvPrestamo.TabIndex = 4;
            this.dtvPrestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtvPrestamo_CellContentClick);
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.bibliotecaDataSet3;
            // 
            // bibliotecaDataSet3
            // 
            this.bibliotecaDataSet3.DataSetName = "bibliotecaDataSet3";
            this.bibliotecaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "bibliotecaDataSet";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(23, 223);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(164, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Libros Disponibles";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 36.48029F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 38;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 38;
            // 
            // claveGeneroDataGridViewTextBoxColumn
            // 
            this.claveGeneroDataGridViewTextBoxColumn.DataPropertyName = "ClaveGenero";
            this.claveGeneroDataGridViewTextBoxColumn.FillWeight = 107.413F;
            this.claveGeneroDataGridViewTextBoxColumn.HeaderText = "ClaveGenero";
            this.claveGeneroDataGridViewTextBoxColumn.MinimumWidth = 90;
            this.claveGeneroDataGridViewTextBoxColumn.Name = "claveGeneroDataGridViewTextBoxColumn";
            this.claveGeneroDataGridViewTextBoxColumn.ReadOnly = true;
            this.claveGeneroDataGridViewTextBoxColumn.Width = 90;
            // 
            // clavePasilloDataGridViewTextBoxColumn
            // 
            this.clavePasilloDataGridViewTextBoxColumn.DataPropertyName = "ClavePasillo";
            this.clavePasilloDataGridViewTextBoxColumn.FillWeight = 78.88837F;
            this.clavePasilloDataGridViewTextBoxColumn.HeaderText = "ClavePasillo";
            this.clavePasilloDataGridViewTextBoxColumn.MinimumWidth = 83;
            this.clavePasilloDataGridViewTextBoxColumn.Name = "clavePasilloDataGridViewTextBoxColumn";
            this.clavePasilloDataGridViewTextBoxColumn.ReadOnly = true;
            this.clavePasilloDataGridViewTextBoxColumn.Width = 83;
            // 
            // claveLibroDataGridViewTextBoxColumn
            // 
            this.claveLibroDataGridViewTextBoxColumn.DataPropertyName = "ClaveLibro";
            this.claveLibroDataGridViewTextBoxColumn.FillWeight = 78.88837F;
            this.claveLibroDataGridViewTextBoxColumn.HeaderText = "ClaveLibro";
            this.claveLibroDataGridViewTextBoxColumn.MinimumWidth = 83;
            this.claveLibroDataGridViewTextBoxColumn.Name = "claveLibroDataGridViewTextBoxColumn";
            this.claveLibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.claveLibroDataGridViewTextBoxColumn.Width = 83;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.FillWeight = 78.88837F;
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.FillWeight = 78.88837F;
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 206;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 206;
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.FillWeight = 162.4366F;
            this.fechaPublicacionDataGridViewTextBoxColumn.HeaderText = "FechaPublicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            this.fechaPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPublicacionDataGridViewTextBoxColumn.Width = 120;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.FillWeight = 178.1166F;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 70;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Icon")));
            this.btnBuscar.Location = new System.Drawing.Point(702, 122);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 36);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.HighEmphasis = true;
            this.btnAceptar.Icon = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Icon")));
            this.btnAceptar.Location = new System.Drawing.Point(430, 512);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(114, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptar.UseAccentColor = false;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 568);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtvPrestamo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtFolioB);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamo de Libros";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAceptar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtFolioB;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private System.Windows.Forms.DataGridView dtvPrestamo;
        private bibliotecaDataSet3 bibliotecaDataSet3;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private bibliotecaDataSet3TableAdapters.LibrosTableAdapter librosTableAdapter;
        private bibliotecaDataSet bibliotecaDataSet1;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavePasilloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}