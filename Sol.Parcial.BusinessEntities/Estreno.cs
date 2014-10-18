using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol.Parcial.BusinessEntities
{
    public class Estreno
    {
        public Int32 Id { get; set; }
        public string Lugar { get; set; }
        public DateTime Fecha { get; set; }

        public Pelicula Pelicula { get; set; }
    }
}
