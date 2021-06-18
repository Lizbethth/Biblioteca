using System;

using System.Drawing;
using System.Linq;

using MaterialSkin.Controls;
using Biblioteca.Presentation;
using Biblioteca.Models;
using System.Windows.Forms;

namespace Biblioteca.Presentation
{
    public partial class frmCRUDGeneros : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frmCRUDGeneros()
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


        private void FrmCRUDGeneros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet1.Generos' Puede moverla o quitarla según sea necesario.
            this.generosTableAdapter.Fill(this.bibliotecaDataSet1.Generos);
            refresh();
        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Presentation.frmDtsGeneros ofrmGeneros = new Presentation.frmDtsGeneros();
            ofrmGeneros.ShowDialog();
            refresh();
        }

        #region HELPER
        private void refresh()
        {
            // Obtener los datos de la tabla con LINQ
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                var lst = from d in db.Generos select d;
                dtvGeneros.DataSource = lst.ToList();
            }
        }
        #endregion

        #region HELPER
        private int? getId()
        {
            try
            {
                return int.Parse(dtvGeneros.Rows[dtvGeneros.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }

        }

        #endregion


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                frmDtsGeneros ofrm = new frmDtsGeneros(id);
                ofrm.ShowDialog();
                refresh();
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    Generos g = db.Generos.Find(id);
                    db.Generos.Remove(g);
                    db.SaveChanges();
                }
                refresh();
            }
        }
    }
}
