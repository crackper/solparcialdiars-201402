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
    public class PremiacionesMap:EntityTypeConfiguration<Premiaciones>
    {
        public PremiacionesMap()
        {
            //key
            this.HasKey(p => new {p.FestivalId,p.PeliculaId});

            //propiedades
            this.Property(p => p.FestivalId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(p => p.PeliculaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(p => p.Premio)
                .HasMaxLength(200)
                .IsRequired();

            //table
            this.ToTable("Premiaciones");

            //relaciones
            this.HasRequired(p => p.Festival)
                .WithMany(f => f.Premiaciones)
                .HasForeignKey(p => p.FestivalId);

            this.HasRequired(p => p.Pelicula)
                .WithMany(pp => pp.Premiaciones)
                .HasForeignKey(p => p.PeliculaId);

        }
    }
}
