using System;

namespace Biblioteca
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnUsuarios = new MaterialSkin.Controls.MaterialButton();
            this.btnLibros = new MaterialSkin.Controls.MaterialButton();
            this.btnGenero = new MaterialSkin.Controls.MaterialButton();
            this.btnPasillos = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Genero = new System.Windows.Forms.PictureBox();
            this.Libros = new System.Windows.Forms.PictureBox();
            this.Usuarios = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUsuarios.Depth = 0;
            this.btnUsuarios.HighEmphasis = true;
            this.btnUsuarios.Icon = null;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(171, 195);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(91, 36);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsuarios.UseAccentColor = false;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLibros.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLibros.Depth = 0;
            this.btnLibros.HighEmphasis = true;
            this.btnLibros.Icon = null;
            this.btnLibros.Location = new System.Drawing.Point(437, 195);
            this.btnLibros.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLibros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(71, 36);
            this.btnLibros.TabIndex = 4;
            this.btnLibros.Text = "Libros";
            this.btnLibros.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLibros.UseAccentColor = false;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.BtnLibros_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenero.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenero.Depth = 0;
            this.btnGenero.HighEmphasis = true;
            this.btnGenero.Icon = null;
            this.btnGenero.Location = new System.Drawing.Point(697, 195);
            this.btnGenero.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenero.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(78, 36);
            this.btnGenero.TabIndex = 5;
            this.btnGenero.Text = "Género";
            this.btnGenero.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenero.UseAccentColor = false;
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.BtnGenero_Click);
            // 
            // btnPasillos
            // 
            this.btnPasillos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPasillos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPasillos.Depth = 0;
            this.btnPasillos.HighEmphasis = true;
            this.btnPasillos.Icon = null;
            this.btnPasillos.Location = new System.Drawing.Point(171, 433);
            this.btnPasillos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPasillos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPasillos.Name = "btnPasillos";
            this.btnPasillos.Size = new System.Drawing.Size(88, 36);
            this.btnPasillos.TabIndex = 7;
            this.btnPasillos.Text = "Pasillos";
            this.btnPasillos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPasillos.UseAccentColor = false;
            this.btnPasillos.UseVisualStyleBackColor = true;
            this.btnPasillos.Click += new System.EventHandler(this.BtnPasillos_Click_1);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(427, 430);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(99, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "Préstamo";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.MaterialButton1_Click_1);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(680, 434);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(111, 36);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "Devolución";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.MaterialButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(653, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(396, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(138, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Genero
            // 
            this.Genero.Image = ((System.Drawing.Image)(resources.GetObject("Genero.Image")));
            this.Genero.InitialImage = ((System.Drawing.Image)(resources.GetObject("Genero.InitialImage")));
            this.Genero.Location = new System.Drawing.Point(654, 36);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(150, 150);
            this.Genero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Genero.TabIndex = 2;
            this.Genero.TabStop = false;
            this.Genero.Click += new System.EventHandler(this.Genero_Click);
            // 
            // Libros
            // 
            this.Libros.Image = ((System.Drawing.Image)(resources.GetObject("Libros.Image")));
            this.Libros.Location = new System.Drawing.Point(397, 36);
            this.Libros.Name = "Libros";
            this.Libros.Size = new System.Drawing.Size(150, 150);
            this.Libros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Libros.TabIndex = 1;
            this.Libros.TabStop = false;
            this.Libros.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Usuarios.Image")));
            this.Usuarios.InitialImage = null;
            this.Usuarios.Location = new System.Drawing.Point(138, 36);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(151, 150);
            this.Usuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Usuarios.TabIndex = 0;
            this.Usuarios.TabStop = false;
            this.Usuarios.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Libros);
            this.panel1.Controls.Add(this.materialButton2);
            this.panel1.Controls.Add(this.btnLibros);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Usuarios);
            this.panel1.Controls.Add(this.btnGenero);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Genero);
            this.panel1.Controls.Add(this.materialButton1);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnPasillos);
            this.panel1.Location = new System.Drawing.Point(-5, 64);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(920, 495);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(921, 565);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Libros;
        private System.Windows.Forms.PictureBox Genero;
        private MaterialSkin.Controls.MaterialButton btnUsuarios;
        private MaterialSkin.Controls.MaterialButton btnLibros;
        private MaterialSkin.Controls.MaterialButton btnGenero;
        public System.Windows.Forms.PictureBox Usuarios;
        public System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnPasillos;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private EventHandler BtnPasillos_Click;
        private System.Windows.Forms.Panel panel1;
    }
}

