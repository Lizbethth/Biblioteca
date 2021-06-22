using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Biblioteca.Models;
using System.Data.Entity;
using System.Globalization;

namespace Biblioteca.Presentation
{
    public partial class frmDtsGeneros : MaterialForm
    {
        Generos g = null;
        public int? id;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frmDtsGeneros(int? id = null)
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
            this.id = id;
            if (id != null)
                cargarDatos();
        }

        private void FrmDtsGeneros_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            borrarErrorMsj();
            if (validarCampos())
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    if (id == null)
                    {
                        Generos g = new Generos
                        {
                            Genero = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtGenero.Text),
                            Clave = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtClave.Text)
                        };
                        db.Generos.Add(g);
                    }

                    else
                    {
                        var gen = db.Generos.Find(id);
                        gen.Genero = txtGenero.Text;
                        gen.Clave = txtClave.Text;
                        db.Entry(gen).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void cargarDatos()
        {
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                g = db.Generos.Find(id);
                txtGenero.Text = g.Genero;
                txtClave.Text = g.Clave;
            }
        }


        private bool validarCampos()
        {
            bool ok = true;
            if (txtGenero.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGenero, "Ingresar género");
            }
            if (txtClave.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtClave, "Ingresar clave");
            }
            return ok;
        }

        private void borrarErrorMsj()
        {
            errorProvider1.SetError(txtGenero, "");
            errorProvider1.SetError(txtClave, "");
        }

        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
   if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
     if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
