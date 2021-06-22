using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Models;
using MaterialSkin.Controls;
namespace Biblioteca.Presentation
{

    public partial class frmDevolucion : MaterialForm
    {
        Boolean bandera = false;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmDevolucion()
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

        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet3.Libros' Puede moverla o quitarla según sea necesario.
            //this.librosTableAdapter.Fill(this.bibliotecaDataSet3.Libros);
            this.librosTableAdapter.FillByPrestamo(this.bibliotecaDataSet3.Libros);
        }

        private void FillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.librosTableAdapter.FillByPrestamo(this.bibliotecaDataSet3.Libros);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        #region HELPER
        private int? getId()
        {
            try
            {
                return int.Parse(dtvDevolver.Rows[dtvDevolver.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }

        #endregion


        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (bandera == true && txtFolioB.Text != null) //lo encontro
            {
                //si hay folio
                int? id = getId();
                if (id != null)
                {
                    using (bibliotecaEntities db = new bibliotecaEntities())
                    {
                        Libros libro = db.Libros.Find(id);
                        libro.Estado = "Disponible";
                        db.Entry(libro).State = EntityState.Modified;
                        db.SaveChanges();
                        librosTableAdapter.FillByPrestamo(bibliotecaDataSet3.Libros);
                    }
                }
            }
            else if (txtFolioB.Text == "")
            { //Si no hay folio
                MessageBox.Show("Proporcione folio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtFolioB.Text != "")
            {
                int num = Int32.Parse(txtFolioB.Text);


                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    var folio = db.Usuarios.FirstOrDefault(x => x.Folio.Equals(num));
                    if (folio != null) //lo encontro
                    {
                        string nom = folio.Nombre + " " + folio.Apaterno + " " + folio.Amaterno;
                        lblNombre.Text = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(nom);
                        bandera = true;
                    }
                    else
                    {
                        lblNombre.Text = "Folio no encontrado";
                    }
                }
            }
        }

        private void TxtFolioB_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtFolioB.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
