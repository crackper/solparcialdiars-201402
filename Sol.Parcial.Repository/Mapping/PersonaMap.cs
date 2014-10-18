using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol.Parcial.BusinessEntities;

namespace Sol.Parcial.Repository.Mapping
{
    public class PersonaMap:EntityTypeConfiguration<Persona>
    {
        public PersonaMap()
        {
            //key
            HasKey(p => p.Id);

            //popiedades
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nombre)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Direccion)
                .HasMaxLength(200)
                .IsOptional();

            Property(p => p.EstadoCivil)
                .HasMaxLength(200)
                .IsOptional();

            //tabla
            ToTable("Persona");
        }
    }
}
