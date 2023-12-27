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
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
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

        private void ListarEstudiante()
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            this.lstEstudiantes.DataSource = null;
            this.lstEstudiantes.DataSource = unaControladora.ListaEstudiantes();
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

        private void CargarEstudiante(short pId)
        {
            Dominio.Controladora unaControladora = new Dominio.Controladora();
            Dominio.Estudiante unEs = unaControladora.BuscarEstudiante(pId);
            this.txtId.Text = unEs.Id.ToString();
            this.txtNombre.Text = unEs.Nombre;
            this.txtApellido.Text = unEs.Apellido;
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
                Dominio.Estudiante unEs = unaControladora.BuscarEstudiante(Id);

                if (unEs == null)
                {
                    string Nombre = this.txtNombre.Text;
                    string Apellido = this.txtApellido.Text;
                    Dominio.Estudiante elEs = new Dominio.Estudiante(Id, Nombre, Apellido);
                    if (unaControladora.AltaEstudiante(elEs))
                    {
                        Limpiar();
                        ListarEstudiante();
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
            Dominio.Estudiante unEs = unaControladora.BuscarEstudiante(Id);
            if (unEs != null)
            {
                if (unaControladora.BajaEstudiante(Id))
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "Estudiante dado de baja de forma correcta";
                    this.ListarEstudiante();
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
            Dominio.Estudiante unEs = unaControladora.BuscarEstudiante(Id);
            if (unEs != null)
            {
                Id = short.Parse(this.txtId.Text);
                string Nombre = this.txtNombre.Text;
                string Apellido = this.txtApellido.Text;

                if (unaControladora.ModificarEstudiante(Id, Nombre, Apellido))
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "Estudiante Modificado correctamente";
                    this.ListarEstudiante();
                }
                else
                {
                    this.Limpiar();
                    this.lblMensajes.Text = "ERROR!! El Estudiante no existe";
                }
            }
        }

        private void lstEstudiantes_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstEstudiantes.SelectedIndex > -1)
            {
                string linea = lstEstudiantes.GetItemText(lstEstudiantes.SelectedItem);
                string[] partes = linea.Split(' ');
                short id = short.Parse(partes[0]);
                Dominio.Controladora unaControladora = new Dominio.Controladora();
                Dominio.Estudiante unEs = unaControladora.BuscarEstudiante(id);
                CargarEstudiante(id);
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
