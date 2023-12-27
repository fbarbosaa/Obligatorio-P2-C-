using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obligatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "Patron Singleton"

        private void Singleton(string pFormulario)
        {
            bool encontrado = false;
            foreach (Form unFrm in this.MdiChildren)
            {
                if (unFrm.Name.Equals(pFormulario)) 
                {
                    encontrado = true;
                    unFrm.Activate(); 
                }
            }
            if (!encontrado)
            {
                switch (pFormulario)
                {
                    case "frmDocentes":
                        Presentacion.frmDocentes unFrmDocente = new Presentacion.frmDocentes();
                        unFrmDocente.MdiParent = this;
                        unFrmDocente.Show();
                        break;


                    case "frmEstudiantes":
                        Presentacion.frmEstudiantes unFrmEstudiante = new Presentacion.frmEstudiantes();
                        unFrmEstudiante.MdiParent = this;
                        unFrmEstudiante.Show();   
                        break;


                    case "frmCursos":
                        Presentacion.frmCursos unFrmCurso = new Presentacion.frmCursos();
                        unFrmCurso.MdiParent = this;      
                        unFrmCurso.Show();  
                        break;

                    case "frmEstadisticas":
                        Presentacion.frmEstadisticas unFrmEstadistica = new Presentacion.frmEstadisticas();
                        unFrmEstadistica.MdiParent = this;
                        unFrmEstadistica.Show();
                        break;

                }
            }
        }


        #endregion

        private void ingresoDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFormulario = "frmDocentes";
            this.Singleton(nombreFormulario);
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFormulario = "frmEstudiantes";
            this.Singleton(nombreFormulario);
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFormulario = "frmCursos";
            this.Singleton(nombreFormulario);
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFormulario = "frmEstadisticas";
            this.Singleton(nombreFormulario);
        }
    }
}
