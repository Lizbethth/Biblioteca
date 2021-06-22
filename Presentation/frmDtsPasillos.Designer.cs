namespace Biblioteca.Presentation
{
    partial class frmDtsPasillos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDtsPasillos));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtNum = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbLetra = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(45, 200);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Número:";
            this.materialLabel1.Click += new System.EventHandler(this.MaterialLabel1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Icon")));
            this.btnGuardar.Location = new System.Drawing.Point(262, 294);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 36);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Depth = 0;
            this.txtNum.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNum.LeadingIcon = null;
            this.txtNum.Location = new System.Drawing.Point(135, 183);
            this.txtNum.MaxLength = 50;
            this.txtNum.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNum.Multiline = false;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(429, 50);
            this.txtNum.TabIndex = 2;
            this.txtNum.Text = "";
            this.txtNum.TrailingIcon = null;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFabricante_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(65, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(41, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Letra:";
            // 
            // cbLetra
            // 
            this.cbLetra.AutoResize = false;
            this.cbLetra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbLetra.Depth = 0;
            this.cbLetra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbLetra.DropDownHeight = 174;
            this.cbLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetra.DropDownWidth = 121;
            this.cbLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbLetra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbLetra.FormattingEnabled = true;
            this.cbLetra.IntegralHeight = false;
            this.cbLetra.ItemHeight = 43;
            this.cbLetra.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "X",
            "Y",
            "Z"});
            this.cbLetra.Location = new System.Drawing.Point(135, 115);
            this.cbLetra.MaxDropDownItems = 4;
            this.cbLetra.MouseState = MaterialSkin.MouseState.OUT;
            this.cbLetra.Name = "cbLetra";
            this.cbLetra.Size = new System.Drawing.Size(429, 49);
            this.cbLetra.StartIndex = 0;
            this.cbLetra.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDtsPasillos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.cbLetra);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmDtsPasillos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasillo";
            this.Load += new System.EventHandler(this.FrmDtsPasillos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox txtNum;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbLetra;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}