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
    public partial class frm : MaterialForm
    {
        Usuarios user = null;
        public int? id;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frm(int? id = null)
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

        private bool validarCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingresar nombre");

            }
            if (txtApPaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApPaterno, "Ingresar Apellido Paterno");
            }
            if (txtApMaterno.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApMaterno, "Ingresar Apellido Materno");
            }
            return ok;
        }

        private void borrarErrorMsj()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApPaterno, "");
            errorProvider1.SetError(txtApMaterno, "");
        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        public int generarFolio()
        {
            int anio = DateTime.Now.Year;
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                var folio = db.Folios.FirstOrDefault(x => x.Anio == anio);

                if (folio == null)
                {
                    folio = new Folios();
                    folio.Anio = anio;
                    folio.Secuencia = 1;
                    db.Folios.Add(folio);
                }
                else
                {
                    folio.Secuencia = folio.Secuencia + 1;
                    db.Entry(folio).State = EntityState.Modified;
                }

                db.SaveChanges();
                var s = folio.Secuencia.ToString("D5");
                return int.Parse(anio + s);
            }
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            borrarErrorMsj();
            if (validarCampos())
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    if (id == null)
                    {
                        Usuarios user = new Usuarios
                        {
                            Nombre = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtNombre.Text),
                            Apaterno = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtApPaterno.Text),
                            Amaterno = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtApMaterno.Text),
                            Fecha = DateTime.Now,
                            Folio = generarFolio()
                        };
                        db.Usuarios.Add(user);
                    }
                    else
                    {
                        var usuario = db.Usuarios.Find(id);
                        usuario.Nombre = txtNombre.Text;
                        usuario.Apaterno = txtApPaterno.Text;
                        usuario.Amaterno = txtApMaterno.Text;
                        db.Entry(usuario).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void MaterialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblApPaterno_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void cargarDatos()
        {
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                user = db.Usuarios.Find(id);
                txtNombre.Text = user.Nombre;
                txtApMaterno.Text = user.Amaterno;
                txtApPaterno.Text = user.Apaterno;
            }
        }

        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //errorProvider1.SetError(txtNombre, "Solo se permiten letras");
                //errorProvider1.SetError(txtApMaterno, "Solo se permiten letras");
                //errorProvider1.SetError(txtApPaterno, "Solo se permiten letras");
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
