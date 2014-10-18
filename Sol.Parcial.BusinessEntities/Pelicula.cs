using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol.Parcial.BusinessEntities
{
    public class Pelicula
    {
        public Int32 Id { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Cartel { get; set; }

        public List<Estreno> Estrenos { get; set; }
        public List<Premiaciones> Premiaciones { get; set; }
        public List<Participantes> Participantes { get; set; }
       
    }
}
