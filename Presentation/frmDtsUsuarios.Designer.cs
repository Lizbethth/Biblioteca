namespace Biblioteca.Presentation
{
    partial class frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.guardar = new MaterialSkin.Controls.MaterialButton();
            this.lblNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lblApPaterno = new MaterialSkin.Controls.MaterialLabel();
            this.txtApPaterno = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApMaterno = new MaterialSkin.Controls.MaterialTextBox();
            this.lblApMaterno = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guardar
            // 
            this.guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.guardar.Depth = 0;
            this.guardar.HighEmphasis = true;
            this.guardar.Icon = ((System.Drawing.Image)(resources.GetObject("guardar.Icon")));
            this.guardar.Location = new System.Drawing.Point(277, 344);
            this.guardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(116, 36);
            this.guardar.TabIndex = 7;
            this.guardar.Text = "Guardar";
            this.guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.guardar.UseAccentColor = false;
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Depth = 0;
            this.lblNombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombre.Location = new System.Drawing.Point(56, 134);
            this.lblNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 19);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.Click += new System.EventHandler(this.MaterialLabel1_Click);
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Depth = 0;
            this.lblApPaterno.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApPaterno.Location = new System.Drawing.Point(14, 209);
            this.lblApPaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(121, 19);
            this.lblApPaterno.TabIndex = 10;
            this.lblApPaterno.Text = "Apellido Paterno:";
            this.lblApPaterno.Click += new System.EventHandler(this.LblApPaterno_Click);
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.AcceptsTab = true;
            this.txtApPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApPaterno.Depth = 0;
            this.txtApPaterno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApPaterno.LeadingIcon = null;
            this.txtApPaterno.Location = new System.Drawing.Point(141, 194);
            this.txtApPaterno.MaxLength = 50;
            this.txtApPaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApPaterno.Multiline = false;
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(429, 50);
            this.txtApPaterno.TabIndex = 11;
            this.txtApPaterno.Text = "";
            this.txtApPaterno.TrailingIcon = null;
            this.txtApPaterno.TextChanged += new System.EventHandler(this.MaterialTextBox1_TextChanged);
            this.txtApPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(141, 124);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(429, 50);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.AcceptsTab = true;
            this.txtApMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApMaterno.Depth = 0;
            this.txtApMaterno.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApMaterno.LeadingIcon = null;
            this.txtApMaterno.Location = new System.Drawing.Point(141, 263);
            this.txtApMaterno.MaxLength = 50;
            this.txtApMaterno.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApMaterno.Multiline = false;
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(429, 50);
            this.txtApMaterno.TabIndex = 14;
            this.txtApMaterno.Text = "";
            this.txtApMaterno.TrailingIcon = null;
            this.txtApMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Depth = 0;
            this.lblApMaterno.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblApMaterno.Location = new System.Drawing.Point(11, 278);
            this.lblApMaterno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(125, 19);
            this.lblApMaterno.TabIndex = 13;
            this.lblApMaterno.Text = "Apellido Materno:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm
            // 
            this.AcceptButton = this.guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.lblApMaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.lblApPaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.guardar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton guardar;
        private MaterialSkin.Controls.MaterialLabel lblNombre;
        private MaterialSkin.Controls.MaterialLabel lblApPaterno;
        private MaterialSkin.Controls.MaterialTextBox txtApPaterno;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialTextBox txtApMaterno;
        private MaterialSkin.Controls.MaterialLabel lblApMaterno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}