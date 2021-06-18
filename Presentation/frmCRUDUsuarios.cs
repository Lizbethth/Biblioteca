using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using Biblioteca.Models;
using System.Linq;
using Biblioteca.Presentation;

namespace Biblioteca.Presentation
{
    public partial class frmUsuarios : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmUsuarios()
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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet2.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter1.Fill(this.bibliotecaDataSet2.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bibliotecaDataSet.Usuarios);
            refresh();

        }

        #region HELPER

        private void refresh()
        {
            // Obtener los datos de la tabla con LINQ
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                var lst = from d in db.Usuarios select d;
                dtvUsuarios.DataSource = lst.ToList();

            }

        }
        #endregion
        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e) // si esta bien boton agregar
        {
            Presentation.frm ofrm = new Presentation.frm();
            ofrm.ShowDialog();
            refresh();
        }

        private void DtvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region HELPER
        private int? getId()
        {
            try
            {
                return int.Parse(dtvUsuarios.Rows[dtvUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }

        #endregion


        private void Editar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                Presentation.frm ofrm = new Presentation.frm(id);
                ofrm.ShowDialog();
                refresh();
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    
                    Usuarios user = db.Usuarios.Find(id);
                    db.Usuarios.Remove(user);
                    db.SaveChanges();
                }
                refresh();
            }
        }
    }
}
