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
    public partial class frmCRUDPasillos : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    
        public frmCRUDPasillos()
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

        private void FrmCRUDPasillos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Pasillos' Puede moverla o quitarla según sea necesario.
            this.pasillosTableAdapter.Fill(this.bibliotecaDataSet.Pasillos);
            refresh();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            frmDtsPasillos ofrmPasillos = new frmDtsPasillos();
            ofrmPasillos.ShowDialog();
            refresh();
        }

        #region HELPER
        private void refresh()
        {
            // Obtener los datos de la tabla con LINQ
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                var lst = from d in db.Pasillos select d;
                dtvPasillos.DataSource = lst.ToList();
            }
        }
        #endregion

        #region HELPER
        private int? getId()
        {
            try
            {
                return int.Parse(dtvPasillos.Rows[dtvPasillos.CurrentRow.Index].Cells[0].Value.ToString());
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
                frmDtsPasillos ofrm = new frmDtsPasillos(id);
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
                    Pasillos p = db.Pasillos.Find(id);
                    db.Pasillos.Remove(p);
                    db.SaveChanges();
                }
                refresh();
            }
        }

        private void DtvPasillos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                frmDtsPasillos ofrm = new frmDtsPasillos(id);
                ofrm.ShowDialog();
                refresh();
            }
        }

        private void BtnBorrar_Click_1(object sender, EventArgs e)
        {
            int? id = getId();
            if (id != null)
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    Pasillos p = db.Pasillos.Find(id);
                    db.Pasillos.Remove(p);
                    db.SaveChanges();
                }
                refresh();
            }
        }
    }
}
