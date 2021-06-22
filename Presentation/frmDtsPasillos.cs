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
namespace Biblioteca.Presentation
{
    public partial class frmDtsPasillos : MaterialForm
    {
        Pasillos p = null;
        public int? id;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmDtsPasillos(int? id = null)
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

        private void FrmDtsPasillos_Load(object sender, EventArgs e)
        {

        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cargarDatos()
        {
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                p = db.Pasillos.Find(id);
                txtNum.Text = p.ClavePasillo.Substring(1, 1);
                cbLetra.SelectedItem = p.ClavePasillo.Substring(0, 1);
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            borrarErrorMsj();
            if (validarCampos())
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    var cv = db.Pasillos.Any(x => x.ClavePasillo == (cbLetra.SelectedItem.ToString() + txtNum.Text));
                    if (id == null)
                    {
                        Pasillos p = new Pasillos
                        {
                            ClavePasillo = cbLetra.SelectedItem.ToString() + txtNum.Text,
                        };
                        if (cv)
                        {
                            MessageBox.Show("Este pasillo ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            db.Pasillos.Add(p);
                        }
                        db.SaveChanges();
                    }

                    else
                    {
                        var pas = db.Pasillos.Find(id);
                        pas.ClavePasillo = txtNum.Text;
                        string letra = cbLetra.SelectedItem.ToString();
                        string num = txtNum.Text;
                        pas.ClavePasillo = letra + num;
                        db.Entry(pas).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    this.Close();
                }
            }

        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txtNum.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNum, "Ingresar número");
            }
            return ok;
        }

        private void borrarErrorMsj()
        {
            errorProvider1.SetError(txtNum, "");
        }

        private void txtCodigoFabricante_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
