using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol.Parcial.BusinessEntities;

namespace Sol.Parcial.Repository.Mapping
{
    public class DirectorMap:EntityTypeConfiguration<Director>
    {
        public DirectorMap()
        {
            Property(p => p.TipoDirector)
                .HasMaxLength(200);
        }
    }
}
