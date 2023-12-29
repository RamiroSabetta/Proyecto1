using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class ControladorPersona
    {

        private List<Persona> listadoPersona;

        public ControladorPersona()
        {
            listadoPersona = new List<Persona>();

        }
        public void adicionarPersona(Persona persona) {
            listadoPersona.Add(persona);

        }
        public List<Persona> listadoPersonas()
        {
            return listadoPersona;
        }
        public void borrarPersona(Persona persona)
        {
            listadoPersona.Remove(persona);
        }

    }
}