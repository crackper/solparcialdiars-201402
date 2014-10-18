using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol.Parcial.BusinessEntities;

namespace Sol.Parcial.Repository.Mapping
{
    public class ActorMap:EntityTypeConfiguration<Actor>
    {
        public ActorMap()
        {
            //Propiedades
            Property(p => p.Biografia)
                .HasMaxLength(200)
                .IsRequired();

            //tabla
            ToTable("Actor");
        }
    }
}
