using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obligatorio.Presentacion
{
    public partial class frmDocentes : Form
    {
        public frmDocentes()
        {
            InitializeComponent();
        }

        #region "Metodos Auxiliares"

        private void Limpiar()
        {
            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtId.Focus();
        }

        private void ListarDocente()
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            this.lstDocentes.DataSource = null;
            this.lstDocentes.DataSource = unaControladora.ListaDocentes();
        }

        private bool Faltandatos()
        {
            if (this.txtId.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CargarDocente(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Docente unDoc = unaControladora.BuscarDocente(pId);
            this.txtId.Text = unDoc.Id.ToString();
            this.txtNombre.Text = unDoc.Nombre;
            this.txtApellido.Text = unDoc.Apellido;
        }

        #endregion

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (this.Faltandatos())
            {
                this.lblMensajes.Text = "ERROR : Faltan Datos";
                this.Limpiar();

            }
            else
            {


                Dominio.Controladora unaControladora = new Dominio.Controladora();
                short Id = short.Parse(this.txtId.Text);
                Dominio.Docente unDoc = unaControladora.BuscarDocente(Id);

                if (unDoc == null)
                {
                    string Nombre = this.txtNombre.Text;
                    string Apellido = this.txtApellido.Text;
                    Dominio.Docente elDoc = new Dominio.Docente(Id, Nombre, Apellido);
                    if (unaControladora.AltaDocente(elDoc))
                    {
                        Limpiar();
                        ListarDocente();
                        this.lblMensajes.Text = "Ingresado correctamente !!";

                    }
                    else
                    {
                        Limpiar();
                        this.lblMensajes.Text = "ERROR: No se pudo ingresar !!";
                    }

                }

            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            short Id = short.Parse(this.txtId.Text);
            Dominio.Docente unDoc = unaControladora.BuscarDocente(Id);
            if (unDoc != null)
            {
                if (unaControladora.BajaDocente(Id))
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "Docente dado de baja de forma correcta";
                    this.ListarDocente();
                }
                else
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "Error critico";
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            short Id = short.Parse(this.txtId.Text);
            Dominio.Docente unDoc = unaControladora.BuscarDocente(Id);
            if (unDoc != null)
            {
                Id = short.Parse(this.txtId.Text);
                string Nombre = this.txtNombre.Text;
                string Apellido = this.txtApellido.Text;
                
                if (unaControladora.ModificarDocente(Id, Nombre, Apellido))
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "Docente Modificado correctamente";
                    this.ListarDocente();
                }
                else
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "ERROR!! El Docente no existe";
                }
            }
        }

        private void lstDocentes_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstDocentes.SelectedIndex > -1)
            {
                string linea = lstDocentes.GetItemText(lstDocentes.SelectedItem);
                string[] partes = linea.Split(' ');
                short id = short.Parse(partes[0]);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Docente unDoc = unaControladora.BuscarDocente(id);
                CargarDocente(id);
            }
            else
            {
                this.lblMensajes.Text = "No se pudo ingresar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
