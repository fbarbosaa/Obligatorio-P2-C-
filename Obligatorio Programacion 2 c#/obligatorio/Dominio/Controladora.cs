using System.Collections.Generic;
using System.Linq;

namespace obligatorio.Dominio
{
    class Controladora
    {
        static List<Docente> _listaDocentes = new List<Docente>();
        static List<Estudiante> _listaEstudiantes = new List<Estudiante>();
        static List<Curso> _listaCursos = new List<Curso>();

        #region "ABM Docentes"
        public List<Docente> ListaDocentes()
        {
            return _listaDocentes;
        }

        public Docente BuscarDocente(short pId)
        {
            foreach (Docente unDoc in _listaDocentes)
            {
                if (unDoc.Id == pId)
                {
                    return unDoc;
                }
            }
            return null;
        }
        public bool AltaDocente(Docente pDocente)
        {
            Docente unDoc = this.BuscarDocente(pDocente.Id);
            if (unDoc == null)
            {
                _listaDocentes.Add(pDocente);
                return true;
            }
            else
                return false;
        }
        public bool BajaDocente(short pId)
        {
            Docente unDoc = this.BuscarDocente(pId);
            if (unDoc != null)
            {
                _listaDocentes.Remove(unDoc);
                return true;
            }
            else
                return false;
        }

        public bool ModificarDocente(short pId, string pNombre, string pApellido)
        {
            Docente unDoc = this.BuscarDocente(pId);
            if (unDoc != null)
            {
                unDoc.Nombre = pNombre;
                unDoc.Apellido = pApellido;
                return true;
            }
            else
                return false;
        }
        #endregion

        #region "ABM Estudiantes"
        public List<Estudiante> ListaEstudiantes()
        {
            return _listaEstudiantes;
        }
        public Estudiante BuscarEstudiante(short pId)
        {
            foreach (Estudiante unEs in _listaEstudiantes)
            {
                if (unEs.Id == pId)
                {
                    return unEs;
                }
            }
            return null;
        }
        public bool AltaEstudiante(Estudiante pEstudiante)
        {
            Estudiante unEs = this.BuscarEstudiante(pEstudiante.Id);
            if (unEs == null)
            {
                _listaEstudiantes.Add(pEstudiante);
                return true;
            }
            else
                return false;
        }
        public bool BajaEstudiante(short pId)
        {
            Estudiante unEs = this.BuscarEstudiante(pId);
            if (unEs != null)
            {
                _listaEstudiantes.Remove(unEs);
                return true;
            }
            else
                return false;
        }

        public bool ModificarEstudiante(short pId, string pNombre, string pApellido)
        {
            Estudiante unEs = this.BuscarEstudiante(pId);
            if (unEs != null)
            {
                unEs.Nombre = pNombre;
                unEs.Apellido = pApellido;
                return true;
            }
            else
                return false;
        }

        public List<Estudiante> OrdenoEstudiantes()
        {
            List<Estudiante> EstudiantesOrdenados = new List<Estudiante>(_listaEstudiantes);
            Estudiante auxEstudiante;
            for (int i = 0; i < EstudiantesOrdenados.Count; i++)
                for (int j = 0; j < EstudiantesOrdenados.Count - 1; j++)
                {
                    if (EstudiantesOrdenados[j].Apellido.ToUpper().CompareTo(EstudiantesOrdenados[j + 1].Apellido.ToUpper()) > 0)
                    {
                        auxEstudiante = EstudiantesOrdenados[j];
                        EstudiantesOrdenados[j] = EstudiantesOrdenados[j + 1];
                        EstudiantesOrdenados[j + 1] = auxEstudiante;
                    }
                }
            return EstudiantesOrdenados;
        }
        #endregion

        #region "ABM Cursos"
        public List<Curso> ListaCursos()
        {
            return _listaCursos;
        }

        public Curso BuscarCurso(short pId)
        {
            foreach (Curso unCur in _listaCursos)
            {
                if (unCur.Id == pId)
                {
                    return unCur;
                }
            }
            return null;
        }
        public bool AltaCurso(Curso pCurso)
        {
            Curso unCur = this.BuscarCurso(pCurso.Id);
            if (unCur == null)
            {
                _listaCursos.Add(pCurso);
                return true;
            }
            else
                return false;
        }
        public bool BajaCurso(short pId)
        {
            Curso unCur = this.BuscarCurso(pId);
            if (unCur != null)
            {
                _listaCursos.Remove(unCur);
                return true;
            }
            else
                return false;
        }

        public List<Curso> OrdenoCursos()
        {
            List<Curso> CursosOrdenados = new List<Curso>(_listaCursos);
            Curso auxCurso;
            for (int i = 0; i < CursosOrdenados.Count; i++)
                for (int j = 0; j < CursosOrdenados.Count - 1; j++)
                {
                    if (CursosOrdenados[j].Especialidad.ToUpper().CompareTo(CursosOrdenados[j + 1].Especialidad.ToUpper()) > 0)
                    {
                        auxCurso = CursosOrdenados[j];
                        CursosOrdenados[j] = CursosOrdenados[j + 1];
                        CursosOrdenados[j + 1] = auxCurso;
                    }
                }
            return CursosOrdenados;
        }
        #endregion

        public List<Curso> EstudiantesEnCursos(short pId)
        {
            List<Curso> _listaCursosDelEstudiante = new List<Curso>();
            foreach (Curso unCur in _listaCursos)
            {
                foreach (Estudiante unEs in unCur.EstudiantesDelCurso())
                {
                    if (unEs.Id == pId)
                    {
                        _listaCursosDelEstudiante.Add(unCur);
                    }
                }
            }
            return _listaCursosDelEstudiante;

        }
        
        public List<Curso> MayorEstudiantes()
        {
            /*
            List < Curso > Cursos = new List<Curso>(_listaCursos);
            List<Curso> Mayor = new List<Curso>();

            Curso auxCurso;
            for (int i = 0; i < Cursos.Count; i++)
            {
                for (int j = 0; j < Cursos.Count - 1; j++)
                {
                    if (Cursos[j].EstudiantesDelCurso() < Cursos[j + 1].EstudiantesDelCurso())
                    {
                        auxCurso = Cursos[j];
                        Cursos[j] = Cursos[j + 1];
                        Cursos[j + 1] = auxCurso;
                    }
                }
            }
            Mayor.Add(Cursos[0]);
            int n = 1;
            while (Cursos[n].EstudiantesDelCurso() == Cursos[0].EstudiantesDelCurso())
            {
                Mayor.Add(Cursos[n]);
                n++;
            }

            return Mayor;
            */
        }
    }
}
    

