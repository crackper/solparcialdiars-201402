using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sol.Parcial.BusinessEntities
{
    public class Festival
    {
        public Int32 Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

        public List<Premiaciones> Premiaciones { get; set; }
    }
}
