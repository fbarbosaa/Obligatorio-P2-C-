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
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
            ListarDocentes();
            ListarEstudiantes();
        }

        #region "Metodos Auxiliares"
        private bool FaltanDatos()
        {
            if (this.txtId.Text == "" ||
                this.txtEspecialidad.Text == "")
            {
                return true;
            }
            else
                return false;
        }

        private void Limpiar()
        {
            this.txtId.Text = "";
            this.txtEspecialidad.Text = "";
            this.txtId.Focus();
        }
        private void ListarDocentes()
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            this.lstDocentes.DataSource = null;
            this.lstDocentes.DataSource = unaC.ListaDocentes();         
        }

        private void ListarEstudiantes()
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            this.lstEstudiantes.DataSource = null;
            this.lstEstudiantes.DataSource = unaC.ListaEstudiantes();
        }

        private void ListarCursos()
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            this.lstCursos.DataSource = null;
            this.lstCursos.DataSource = unaC.ListaCursos();
        }

        private void CargarCurso(short pId)
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            Dominio.Curso unCur = unaC.BuscarCurso(pId);
            this.txtId.Text = unCur.Id.ToString();
            this.txtEspecialidad.Text = unCur.Especialidad;
            this.lstDocentesDelCurso.DataSource = null;
            this.lstDocentesDelCurso.DataSource = unCur.DocentesDelCurso();
            this.lstEstudiantesDelCurso.DataSource = null;
            this.lstEstudiantesDelCurso.DataSource = unCur.EstudiantesDelCurso();
        }

        #endregion

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (this.FaltanDatos())
            {
                this.lblMensajes.Text = "Faltan Datos";
            }
            else
            {
                short Id = short.Parse(this.txtId.Text);
                string Especialidad = this.txtEspecialidad.Text;
                Dominio.Curso unCur = new Dominio.Curso(Id, Especialidad);
                Dominio.Controladora unaC = new Dominio.Controladora();
                if (unaC.AltaCurso(unCur))
                {
                    this.lblMensajes.Text = "Curso ingresado con exito!!";
                    this.ListarCursos();
                    this.Limpiar();
                }
                else
                {
                    this.lblMensajes.Text = "Ya existe, no se puede ingresar";
                    this.Limpiar();
                }
            }
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {

            if(this.lstDocentes.SelectedIndex > -1)
            {
                string linea = this.lstDocentes.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short Id = short.Parse(partes[0]);
                Dominio.Controladora unaC = new Dominio.Controladora();
                Dominio.Docente unDoc = unaC.BuscarDocente(Id);

                short IdCur = short.Parse(this.txtId.Text);
                Dominio.Curso unCur = unaC.BuscarCurso(IdCur);
                if (unCur.AltaDocenteDelCurso(unDoc))
                {
                    this.lblMensajes.Text = "Docente ingresado con exito!!";
                    this.lstDocentesDelCurso.DataSource = null;
                    this.lstDocentesDelCurso.DataSource = unCur.DocentesDelCurso();
                }
                else
                {
                    this.lblMensajes.Text = "Ya existe ";
                }
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (this.lstDocentesDelCurso.SelectedIndex > -1)
            {
                Dominio.Controladora unaC = new Dominio.Controladora();
                string linea = this.lstDocentesDelCurso.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short IdDoc = short.Parse(partes[0]);
                Dominio.Docente unDoc = unaC.BuscarDocente(IdDoc);

                short IdCur = short.Parse(this.txtId.Text);
                Dominio.Curso unCur = unaC.BuscarCurso(IdCur);

                if (unCur.BajaDocenteDelCurso(unDoc))
                {
                    this.lblMensajes.Text = "El docente fue eliminado del curso correctamente";
                    this.lstDocentesDelCurso.DataSource = null;
                    this.lstDocentesDelCurso.DataSource = unCur.DocentesDelCurso();
                }
                else
                {
                    this.lblMensajes.Text = "ERROR";
                }
            }
        }

        private void lstCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstCursos.SelectedIndex > -1)
            {
                string linea = this.lstCursos.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short Id = short.Parse(partes[0]);
                this.CargarCurso(Id);
            }
            else
            {
                this.lblMensajes.Text = "ERROR : Debe seleccionar un Curso";
            }
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            if (this.lstEstudiantes.SelectedIndex > -1)
            {
                string linea = this.lstEstudiantes.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short Id = short.Parse(partes[0]);
                Dominio.Controladora unaC = new Dominio.Controladora();
                Dominio.Estudiante unEs = unaC.BuscarEstudiante(Id);

                short IdCur = short.Parse(this.txtId.Text);
                Dominio.Curso unCur = unaC.BuscarCurso(IdCur);
                if (unCur.AltaEstudianteDelCurso(unEs))
                {
                    this.lblMensajes.Text = "Estudiante ingresado con exito!!";
                    this.lstEstudiantesDelCurso.DataSource = null;
                    this.lstEstudiantesDelCurso.DataSource = unCur.EstudiantesDelCurso();
                }
                else
                {
                    this.lblMensajes.Text = "Ya existe ";
                }
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (this.lstEstudiantesDelCurso.SelectedIndex > -1)
            {
                Dominio.Controladora unaC = new Dominio.Controladora();
                string linea = this.lstEstudiantesDelCurso.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short IdEs = short.Parse(partes[0]);
                Dominio.Estudiante unEs = unaC.BuscarEstudiante(IdEs);

                short IdCur = short.Parse(this.txtId.Text);
                Dominio.Curso unCur = unaC.BuscarCurso(IdCur);

                if (unCur.BajaEstudianteDelCurso(unEs))
                {
                    this.lblMensajes.Text = "El estudiante fue eliminado del curso correctamente";
                    this.lstEstudiantesDelCurso.DataSource = null;
                    this.lstEstudiantesDelCurso.DataSource = unCur.EstudiantesDelCurso();
                }
                else
                {
                    this.lblMensajes.Text = "ERROR";
                }
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            short Id = short.Parse(this.txtId.Text);
            Dominio.Curso unCur = unaC.BuscarCurso(Id);  
            if(unCur != null)
            {
                if (unaC.BajaCurso(Id))
                {
                    this.lblMensajes.Text = "Curso BAJADO con exito!!";
                    this.ListarCursos();
                    this.Limpiar();
                }
                else
                {
                    this.lblMensajes.Text = "Ya existe, no se puede ingresar";
                    this.Limpiar();
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
