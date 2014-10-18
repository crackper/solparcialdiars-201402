using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sol.Parcial.BusinessEntities
{
    public class Persona
    {
        public Int32 Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string EstadoCivil { get; set; }
    }
}
