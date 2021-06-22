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
using MaterialSkin.Controls;
using System.Data.Entity;
using System.Globalization;

namespace Biblioteca.Presentation
{
    public partial class frmDtsLibros : MaterialForm
    {
        Libros l = null;
        public int? id;

        string claveLibro;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmDtsLibros(int? id = null)
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

        }

        private void FrmDtsLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet2.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bibliotecaDataSet2.Libros);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet3.Pasillos' Puede moverla o quitarla según sea necesario.
            this.pasillosTableAdapter1.Fill(this.bibliotecaDataSet3.Pasillos);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet4.Estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.bibliotecaDataSet4.Estados);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet2.Generos' Puede moverla o quitarla según sea necesario.
            this.generosTableAdapter.Fill(this.bibliotecaDataSet2.Generos);
            if (id != null)
            {
                cargarDatos();
                cmbGeneros.Enabled = false;
                cmbPas.Enabled = false;
                cmbEstado.Visible = false;
                materialLabel1.Visible = false;
                btnNoDisponible.Visible = true;
            }
        }

        private void MaterialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaterialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaterialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.generosTableAdapter.FillBy(this.bibliotecaDataSet2.Generos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MaterialComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public string generarSecyClaveLibro(string generoClave, string pasillo)
        {

            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                var secuencia = db.SecuenciasGeneros.FirstOrDefault();

                if (secuencia == null)
                {
                    secuencia = new SecuenciasGeneros();
                    secuencia.SecuenciaDR = 1000;
                    secuencia.SecuenciaCF = 2000;
                    secuencia.SecuenciaRO = 3000;
                    secuencia.SecuenciaDI = 4000;
                    secuencia.SecuenciaIN = 5000;
                    secuencia.SecuenciaSU = 6000;
                    db.SecuenciasGeneros.Add(secuencia);
                }
                else
                {
                    //Si si existe secuencia
                    char c = char.Parse(generoClave.Substring(0, 1));
                    if (generoClave == "DI")
                    {
                        c = 'X';
                    }

                    switch (c)
                    {
                        case 'D':
                            claveLibro = generoClave + pasillo + secuencia.SecuenciaDR;
                            secuencia.SecuenciaDR += 1;
                            break;
                        case 'C':
                            claveLibro = generoClave + pasillo + secuencia.SecuenciaCF;
                            secuencia.SecuenciaCF += 1;
                            break;
                        case 'R':
                            claveLibro = generoClave + pasillo + secuencia.SecuenciaRO;
                            secuencia.SecuenciaRO += 1;
                            break;
                        case 'X':
                            claveLibro = generoClave + pasillo + secuencia.SecuenciaDI;
                            secuencia.SecuenciaDI += 1;
                            break;
                        case 'I':
                            claveLibro = generoClave + pasillo + secuencia.SecuenciaIN;
                            secuencia.SecuenciaIN += 1;
                            break;
                        case 'S':
                            claveLibro = generoClave + pasillo + secuencia.SecuenciaSU;
                            secuencia.SecuenciaSU += 1;
                            break;
                    }
                    db.Entry(secuencia).State = EntityState.Modified;
                }
                db.SaveChanges();
                return claveLibro.Replace(" ", "");
            }
        }

        private void cargarDatos()
        {
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                l = db.Libros.Find(id);
                cmbGeneros.SelectedValue = l.ClaveGenero;
                cmbPas.SelectedValue = l.ClavePasillo;
                cmbEstado.SelectedValue = l.Estado;
                txtAutor.Text = l.Autor;
                txtTitulo.Text = l.Titulo;
                dtpFecha.Value = l.FechaPublicacion;
            }

        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            borrarErrorMsj();
            if (validarCampos())
            {
                using (bibliotecaEntities db = new bibliotecaEntities())
                {
                    if (id == null) //no hay registros
                    {
                        Libros l = new Libros
                        {
                            Autor = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtAutor.Text),
                            Titulo = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtTitulo.Text),
                            ClaveGenero = cmbGeneros.SelectedValue.ToString().Trim(),
                            Estado = cmbEstado.SelectedValue.ToString().Trim(),
                            ClavePasillo = cmbPas.SelectedValue.ToString(),
                            FechaPublicacion = dtpFecha.Value,
                            ClaveLibro = generarSecyClaveLibro(cmbGeneros.SelectedValue.ToString().Trim(), cmbPas.SelectedValue.ToString().Trim()),
                        };
                        db.Libros.Add(l);
                    }
                    else
                    { //Si lo encuentra lo modifica
                        var lb = db.Libros.Find(id);
                        lb.Autor = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtAutor.Text);
                        lb.Titulo = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtTitulo.Text);
                        lb.ClavePasillo = cmbPas.SelectedValue.ToString();
                        lb.ClaveGenero = cmbGeneros.SelectedValue.ToString().Trim();  //**
                        lb.Estado = cmbEstado.SelectedValue.ToString().Trim();
                        lb.FechaPublicacion = dtpFecha.Value;
                        db.Entry(lb).State = EntityState.Modified;

                    }
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void PasillosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnNoDisponible_Click(object sender, EventArgs e)
        {
            //
            using (bibliotecaEntities db = new bibliotecaEntities())
            {
                if (id != null) //si hay registros
                {
                    var lb = db.Libros.Find(id);
                    lb.Estado = "No Disponible";
                    db.Entry(lb).State = EntityState.Modified;
                    db.SaveChanges();
                    this.Close();
                }

            }

        }


        private bool validarCampos()
        {
            bool ok = true;
            if (txtAutor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAutor, "Ingresar autor");
            }

            if (txtTitulo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTitulo, "Ingresar título");
            }
            return ok;
        }

        private void borrarErrorMsj()
        {
            errorProvider1.SetError(txtAutor, "");
            errorProvider1.SetError(txtTitulo, "");
        }
    }
}
