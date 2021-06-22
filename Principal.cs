using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Models;
using Biblioteca.Presentation;
namespace Biblioteca
{
    public partial class Principal : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Principal()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialButton1_Click(object sender, EventArgs e)

        {
            //  Presentation.frm jj = new Presentation.frm();
            frmUsuarios ofrmUsuarios = new frmUsuarios();
            ofrmUsuarios.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenero_Click(object sender, EventArgs e)
        {
            frmCRUDGeneros ofrmUsuarios = new frmCRUDGeneros();
            ofrmUsuarios.ShowDialog();
        }

        private void MaterialButton1_Click_1(object sender, EventArgs e)
        {
            frmPrestamo ofrmPrestamo = new frmPrestamo();
            ofrmPrestamo.ShowDialog();
        }

        private void BtnPasillos_Click_1(object sender, EventArgs e)
        {
            frmCRUDPasillos ofrmPasillos = new frmCRUDPasillos();
            ofrmPasillos.ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Genero_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void MaterialButton2_Click(object sender, EventArgs e)
        {
            frmDevolucion ofrmdevLibros = new frmDevolucion();
            ofrmdevLibros.ShowDialog();
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            frmCRUDLibros ofrmLibros = new frmCRUDLibros();
            ofrmLibros.ShowDialog();
        }
    }
}
