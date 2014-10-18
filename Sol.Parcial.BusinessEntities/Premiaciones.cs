using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sol.Parcial.BusinessEntities
{
    public class Premiaciones
    {
        public Int32 PeliculaId { get; set; }
        public Int32 FestivalId { get; set; }
        public string Premio { get; set; }

        public Pelicula Pelicula { get; set; }
        public Festival Festival { get; set; }
    }
}
