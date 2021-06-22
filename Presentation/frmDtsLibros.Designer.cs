namespace Biblioteca.Presentation
{
    partial class frmDtsLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDtsLibros));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAutor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTitulo = new MaterialSkin.Controls.MaterialTextBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbGeneros = new MaterialSkin.Controls.MaterialComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet2 = new Biblioteca.bibliotecaDataSet2();
            this.generosTableAdapter = new Biblioteca.bibliotecaDataSet2TableAdapters.GenerosTableAdapter();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPas = new MaterialSkin.Controls.MaterialComboBox();
            this.pasillosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasillosTableAdapter = new Biblioteca.bibliotecaDataSet2TableAdapters.PasillosTableAdapter();
            this.cmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet4 = new Biblioteca.bibliotecaDataSet4();
            this.btnNoDisponible = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bibliotecaDataSet3 = new Biblioteca.bibliotecaDataSet3();
            this.bibliotecaDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new Biblioteca.bibliotecaDataSet4TableAdapters.EstadosTableAdapter();
            this.pasillosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pasillosTableAdapter1 = new Biblioteca.bibliotecaDataSet3TableAdapters.PasillosTableAdapter();
            this.fKLibrosPasillosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new Biblioteca.bibliotecaDataSet2TableAdapters.LibrosTableAdapter();
            this.pasillosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasillosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasillosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLibrosPasillosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasillosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(337, 312);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Estado:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(71, 124);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(43, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Autor:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(71, 178);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Título:";
            // 
            // txtAutor
            // 
            this.txtAutor.AcceptsTab = true;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Depth = 0;
            this.txtAutor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutor.LeadingIcon = null;
            this.txtAutor.Location = new System.Drawing.Point(133, 103);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(454, 50);
            this.txtAutor.TabIndex = 6;
            this.txtAutor.Text = "";
            this.txtAutor.TrailingIcon = null;
            this.txtAutor.TextChanged += new System.EventHandler(this.MaterialTextBox1_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AcceptsTab = true;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Depth = 0;
            this.txtTitulo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTitulo.LeadingIcon = null;
            this.txtTitulo.Location = new System.Drawing.Point(133, 168);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(454, 50);
            this.txtTitulo.TabIndex = 7;
            this.txtTitulo.Text = "";
            this.txtTitulo.TrailingIcon = null;
            this.txtTitulo.TextChanged += new System.EventHandler(this.MaterialTextBox2_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Icon")));
            this.btnGuardar.Location = new System.Drawing.Point(275, 372);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(55, 306);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(65, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Fecha de";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(39, 325);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(87, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "publicación:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(139, 312);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(184, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(55, 249);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Géneros:";
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.AutoResize = false;
            this.cmbGeneros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGeneros.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.generosBindingSource, "Genero", true));
            this.cmbGeneros.DataSource = this.generosBindingSource;
            this.cmbGeneros.Depth = 0;
            this.cmbGeneros.DisplayMember = "Genero";
            this.cmbGeneros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGeneros.DropDownHeight = 174;
            this.cmbGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneros.DropDownWidth = 121;
            this.cmbGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGeneros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.IntegralHeight = false;
            this.cmbGeneros.ItemHeight = 43;
            this.cmbGeneros.Location = new System.Drawing.Point(133, 233);
            this.cmbGeneros.MaxDropDownItems = 4;
            this.cmbGeneros.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(190, 49);
            this.cmbGeneros.StartIndex = 0;
            this.cmbGeneros.TabIndex = 14;
            this.cmbGeneros.ValueMember = "Clave";
            this.cmbGeneros.SelectedIndexChanged += new System.EventHandler(this.CmbGeneros_SelectedIndexChanged);
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.bibliotecaDataSet2;
            // 
            // bibliotecaDataSet2
            // 
            this.bibliotecaDataSet2.DataSetName = "bibliotecaDataSet2";
            this.bibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(334, 249);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(53, 19);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "Pasillo:";
            // 
            // cmbPas
            // 
            this.cmbPas.AutoResize = false;
            this.cmbPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pasillosBindingSource, "ClavePasillo", true));
            this.cmbPas.DataSource = this.pasillosBindingSource2;
            this.cmbPas.Depth = 0;
            this.cmbPas.DisplayMember = "ClavePasillo";
            this.cmbPas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPas.DropDownHeight = 174;
            this.cmbPas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPas.DropDownWidth = 121;
            this.cmbPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPas.FormattingEnabled = true;
            this.cmbPas.IntegralHeight = false;
            this.cmbPas.ItemHeight = 43;
            this.cmbPas.Location = new System.Drawing.Point(397, 232);
            this.cmbPas.MaxDropDownItems = 4;
            this.cmbPas.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPas.Name = "cmbPas";
            this.cmbPas.Size = new System.Drawing.Size(190, 49);
            this.cmbPas.StartIndex = 0;
            this.cmbPas.TabIndex = 17;
            this.cmbPas.ValueMember = "ClavePasillo";
            // 
            // pasillosBindingSource
            // 
            this.pasillosBindingSource.DataMember = "Pasillos";
            this.pasillosBindingSource.DataSource = this.bibliotecaDataSet2;
            this.pasillosBindingSource.CurrentChanged += new System.EventHandler(this.PasillosBindingSource_CurrentChanged);
            // 
            // pasillosTableAdapter
            // 
            this.pasillosTableAdapter.ClearBeforeFill = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoResize = false;
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pasillosBindingSource, "ClavePasillo", true));
            this.cmbEstado.DataSource = this.estadosBindingSource;
            this.cmbEstado.Depth = 0;
            this.cmbEstado.DisplayMember = "Estado";
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownHeight = 174;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownWidth = 121;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Location = new System.Drawing.Point(397, 295);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(190, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 18;
            this.cmbEstado.ValueMember = "Estado";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.bibliotecaDataSet4;
            // 
            // bibliotecaDataSet4
            // 
            this.bibliotecaDataSet4.DataSetName = "bibliotecaDataSet4";
            this.bibliotecaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNoDisponible
            // 
            this.btnNoDisponible.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoDisponible.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNoDisponible.Depth = 0;
            this.btnNoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoDisponible.HighEmphasis = true;
            this.btnNoDisponible.Icon = ((System.Drawing.Image)(resources.GetObject("btnNoDisponible.Icon")));
            this.btnNoDisponible.Location = new System.Drawing.Point(398, 308);
            this.btnNoDisponible.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNoDisponible.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNoDisponible.Name = "btnNoDisponible";
            this.btnNoDisponible.Size = new System.Drawing.Size(156, 36);
            this.btnNoDisponible.TabIndex = 19;
            this.btnNoDisponible.Text = "No disponible";
            this.btnNoDisponible.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNoDisponible.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNoDisponible.UseAccentColor = false;
            this.btnNoDisponible.UseVisualStyleBackColor = true;
            this.btnNoDisponible.Visible = false;
            this.btnNoDisponible.Click += new System.EventHandler(this.BtnNoDisponible_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bibliotecaDataSet3
            // 
            this.bibliotecaDataSet3.DataSetName = "bibliotecaDataSet3";
            this.bibliotecaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bibliotecaDataSet3BindingSource
            // 
            this.bibliotecaDataSet3BindingSource.DataSource = this.bibliotecaDataSet3;
            this.bibliotecaDataSet3BindingSource.Position = 0;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // pasillosBindingSource1
            // 
            this.pasillosBindingSource1.DataMember = "Pasillos";
            this.pasillosBindingSource1.DataSource = this.bibliotecaDataSet3BindingSource;
            // 
            // pasillosTableAdapter1
            // 
            this.pasillosTableAdapter1.ClearBeforeFill = true;
            // 
            // fKLibrosPasillosBindingSource
            // 
            this.fKLibrosPasillosBindingSource.DataMember = "FK_Libros_Pasillos";
            this.fKLibrosPasillosBindingSource.DataSource = this.pasillosBindingSource;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // pasillosBindingSource2
            // 
            this.pasillosBindingSource2.DataMember = "Pasillos";
            this.pasillosBindingSource2.DataSource = this.bibliotecaDataSet3;
            // 
            // frmDtsLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnNoDisponible);
            this.Controls.Add(this.cmbPas);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cmbGeneros);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmDtsLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Libro";
            this.Load += new System.EventHandler(this.FrmDtsLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasillosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasillosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLibrosPasillosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasillosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtAutor;
        private MaterialSkin.Controls.MaterialTextBox txtTitulo;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmbGeneros;
        private bibliotecaDataSet2 bibliotecaDataSet2;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private bibliotecaDataSet2TableAdapters.GenerosTableAdapter generosTableAdapter;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cmbPas;
        private System.Windows.Forms.BindingSource pasillosBindingSource;
        private bibliotecaDataSet2TableAdapters.PasillosTableAdapter pasillosTableAdapter;
        private MaterialSkin.Controls.MaterialComboBox cmbEstado;
        private MaterialSkin.Controls.MaterialButton btnNoDisponible;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bibliotecaDataSet3BindingSource;
        private bibliotecaDataSet3 bibliotecaDataSet3;
        private bibliotecaDataSet4 bibliotecaDataSet4;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private bibliotecaDataSet4TableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.BindingSource pasillosBindingSource1;
        private bibliotecaDataSet3TableAdapters.PasillosTableAdapter pasillosTableAdapter1;
        private System.Windows.Forms.BindingSource fKLibrosPasillosBindingSource;
        private bibliotecaDataSet2TableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.BindingSource pasillosBindingSource2;
    }
}