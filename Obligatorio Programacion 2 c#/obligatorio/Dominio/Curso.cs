using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio.Dominio
{
    class Curso
    {
        private short _id;
        private string _especialidad;
        private List<Docente> _listaDocentesDelCurso = new List<Docente>();
        static List<Estudiante> _listaEstudiantesDelCurso = new List<Estudiante>();

        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public List<Docente> DocentesDelCurso()
        {
            return _listaDocentesDelCurso;
        }

        public Docente BuscarDocente(short pId)
        {
            foreach (Docente unDoc in _listaDocentesDelCurso)
            {
                if (unDoc.Id == pId)
                {
                    return unDoc;
                }
            }
            return null;
        }

        public bool AltaDocenteDelCurso(Docente pDocente)
        {
            Docente unDoc = this.BuscarDocente(pDocente.Id);
            if (unDoc == null)
            {
                _listaDocentesDelCurso.Add(pDocente);
                return true;
            }
            else
                return false;
        }

        public bool BajaDocenteDelCurso(Docente pDocente)
        {
            Docente unDoc = this.BuscarDocente(pDocente.Id);
            if (unDoc != null)
            {
                _listaDocentesDelCurso.Remove(unDoc);
                return true;
            }
            else
                return false;
        }

        public List<Estudiante> EstudiantesDelCurso()
        {
            return _listaEstudiantesDelCurso;
        }

        public Estudiante BuscarEstudiante(short pId)
        {
            foreach (Estudiante unEs in _listaEstudiantesDelCurso)
            {
                if (unEs.Id == pId)
                {
                    return unEs;
                }
            }
            return null;
        }

        public bool AltaEstudianteDelCurso(Estudiante pEstudiante)
        {
            bool existe = false;
            Estudiante unEs = this.BuscarEstudiante(pEstudiante.Id);
            if (unEs == null)
            {
                if (_listaEstudiantesDelCurso.Count < 20)
                {
                    _listaEstudiantesDelCurso.Add(pEstudiante);
                    existe = true;
                }
            }

            return existe;
        }

        public bool BajaEstudianteDelCurso(Estudiante pEstudiante)
        {
            Estudiante unEs = this.BuscarEstudiante(pEstudiante.Id);
            if (unEs != null)
            {
                _listaEstudiantesDelCurso.Remove(unEs);
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return this.Id + " " + this.Especialidad;
        }
        public Curso(short pId, string pEspecialidad)
        {
            this.Id = pId;
            this.Especialidad = pEspecialidad;
        }

    }
}
