using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio.Dominio
{
    class Docente
    {
        private short _id;
        private string _nombre;
        private string _apellido;

        public short Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public override string ToString()
        {
            return this.Id + " " + this.Nombre + " " + this.Apellido;
        }
        public Docente(short pId, string pNombre, string pApellido)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }

    }
}
