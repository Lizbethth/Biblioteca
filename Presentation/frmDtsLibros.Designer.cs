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
            this.cmbPasillo = new MaterialSkin.Controls.MaterialComboBox();
            this.pasillosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pasillosTableAdapter = new Biblioteca.bibliotecaDataSet2TableAdapters.PasillosTableAdapter();
            this.cmbEstado = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasillosBindingSource)).BeginInit();
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
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(275, 372);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 36);
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
            // cmbPasillo
            // 
            this.cmbPasillo.AutoResize = false;
            this.cmbPasillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPasillo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pasillosBindingSource, "ClavePasillo", true));
            this.cmbPasillo.DataSource = this.pasillosBindingSource;
            this.cmbPasillo.Depth = 0;
            this.cmbPasillo.DisplayMember = "ClavePasillo";
            this.cmbPasillo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPasillo.DropDownHeight = 174;
            this.cmbPasillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPasillo.DropDownWidth = 121;
            this.cmbPasillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPasillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPasillo.FormattingEnabled = true;
            this.cmbPasillo.IntegralHeight = false;
            this.cmbPasillo.ItemHeight = 43;
            this.cmbPasillo.Location = new System.Drawing.Point(397, 233);
            this.cmbPasillo.MaxDropDownItems = 4;
            this.cmbPasillo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPasillo.Name = "cmbPasillo";
            this.cmbPasillo.Size = new System.Drawing.Size(190, 49);
            this.cmbPasillo.StartIndex = 0;
            this.cmbPasillo.TabIndex = 17;
            this.cmbPasillo.ValueMember = "ClavePasillo";
            this.cmbPasillo.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox2_SelectedIndexChanged_1);
            // 
            // pasillosBindingSource
            // 
            this.pasillosBindingSource.DataMember = "Pasillos";
            this.pasillosBindingSource.DataSource = this.bibliotecaDataSet2;
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
            this.cmbEstado.Depth = 0;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownHeight = 174;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.DropDownWidth = 121;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 43;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponible",
            "En préstamo",
            "No disponible"});
            this.cmbEstado.Location = new System.Drawing.Point(397, 295);
            this.cmbEstado.MaxDropDownItems = 4;
            this.cmbEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(190, 49);
            this.cmbEstado.StartIndex = 0;
            this.cmbEstado.TabIndex = 18;
            // 
            // frmDtsLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbPasillo);
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
        private MaterialSkin.Controls.MaterialComboBox cmbPasillo;
        private System.Windows.Forms.BindingSource pasillosBindingSource;
        private bibliotecaDataSet2TableAdapters.PasillosTableAdapter pasillosTableAdapter;
        private MaterialSkin.Controls.MaterialComboBox cmbEstado;
    }
}