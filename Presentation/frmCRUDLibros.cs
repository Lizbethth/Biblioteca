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

namespace Biblioteca.Presentation
{
    public partial class frmCRUDLibros : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    
        public frmCRUDLibros()
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

        private void FrmCRUDLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet3.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter1.Fill(this.bibliotecaDataSet3.Libros);
            

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmDtsLibros ofrmLibros = new frmDtsLibros();
            ofrmLibros.ShowDialog();
            refresh();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region HELPER
        private void refresh()
        {
            // Obtener los datos de la tabla con LINQ
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                var lst = from d in db.Libros select d;
                dtvLibros.DataSource = lst.ToList();
            }
        }
        #endregion

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                frmDtsLibros ofrm = new frmDtsLibros(id);
                ofrm.ShowDialog();
                refresh();
            }
        }
        #region HELPER
        private int? getId()
        {
            try
            {
                return int.Parse(dtvLibros.Rows[dtvLibros.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }

        #endregion

        private void MaterialButton3_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    Libros libro = db.Libros.Find(id);
                    db.Libros.Remove(libro);
                    db.SaveChanges();
                }
                refresh();
            }
        }
    }
}
