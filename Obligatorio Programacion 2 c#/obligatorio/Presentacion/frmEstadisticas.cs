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
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            Dominio.Controladora unaC = new Dominio.Controladora();

            this.lstEstudiantes.DataSource = null;
            this.lstEstudiantes.DataSource = unaC.ListaEstudiantes();

            this.lstEstudiantes.SelectedIndex = -1;

            this.lstCursos.DataSource = null;
            this.lstCursos.DataSource = unaC.ListaCursos();

            this.lstCursos.SelectedIndex = -1;
        }

        private void rdbEstudiantesOrdenados_CheckedChanged(object sender, EventArgs e)
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            this.lstEstudiantes.DataSource = null;
            this.lstEstudiantes.DataSource = unaC.OrdenoEstudiantes();
        }

        private void rdbEstudiantesOrdenOriginal_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarEstudiantes();
        }

        private void ListarEstudiantes()
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            this.lstEstudiantes.DataSource = null;
            this.lstEstudiantes.DataSource = unaC.ListaEstudiantes();
            this.lstEstudiantes.SelectedIndex = -1;
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            if (this.lstCursos.SelectedIndex > -1)
            {
                string linea = this.lstEstudiantes.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short Id = short.Parse(partes[0]);
                Dominio.Controladora unaC = new Dominio.Controladora();
                Dominio.Curso unCur = unaC.BuscarCurso(Id);
                this.lstCursosDelEstudiante.DataSource = null;
                this.lstCursosDelEstudiante.DataSource = unaC.EstudiantesEnCursos(Id);
            }
        }

        private void rdbCursosOrdenados_CheckedChanged(object sender, EventArgs e)
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            this.lstCursos.DataSource = null;
            this.lstCursos.DataSource = unaC.OrdenoCursos();
        }

        private void ListarCursos()
        {
            Dominio.Controladora unaC = new Dominio.Controladora();
            this.lstCursos.DataSource = null;
            this.lstCursos.DataSource = unaC.ListaCursos();
            this.lstCursos.SelectedIndex = -1;
        }

        private void rdbCursosOrdenOriginal_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarCursos();
        }

        private void btnMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            if (this.lstCursos.SelectedIndex > -1)
            {
                string linea = this.lstCursos.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short Id = short.Parse(partes[0]);
                Dominio.Controladora unaC = new Dominio.Controladora();
                Dominio.Curso unCur = unaC.BuscarCurso(Id);
                this.lstEstudiantes.DataSource = null;
                this.lstEstudiantes.DataSource = unCur.EstudiantesDelCurso();

            }
        }
    }
}
 
