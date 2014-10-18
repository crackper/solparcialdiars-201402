using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sol.Parcial.BusinessEntities
{
    public class Participantes
    {
        public Int32 PeliculaId { get; set; }
        public Int32 PersonaId { get; set; }
        public decimal AporteProductor { get; set; }
        public string PapelActor { get; set; }

        public Pelicula Pelicula { get; set; }
        public Persona Persona { get; set; }
    }
}
