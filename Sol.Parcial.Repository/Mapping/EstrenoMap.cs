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
    public class EstrenoMap:EntityTypeConfiguration<Estreno>
    {
        public EstrenoMap()
        {
            //key
            HasKey(p => p.Id);

            //popiedades
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Lugar)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Fecha)
                .IsOptional();

            //tabla
            ToTable("Estreno");

            //relaciones
            HasRequired(p => p.Pelicula)
                .WithMany(pp => pp.Estrenos)
                .HasForeignKey(p=>p.PeliculaId)
                .WillCascadeOnDelete(false);
        }
    }
}
