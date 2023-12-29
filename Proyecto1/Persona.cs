using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string materia;
        private string mail;


        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
            }
        }
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
    }
}
