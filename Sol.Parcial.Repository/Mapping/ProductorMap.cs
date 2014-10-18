using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol.Parcial.BusinessEntities;

namespace Sol.Parcial.Repository.Mapping
{
    public class ProductorMap:EntityTypeConfiguration<Productor>
    {
        public ProductorMap()
        {
            Property(p => p.TipoProductor)
                .HasMaxLength(200);
        }
    }
}
