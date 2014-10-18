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
    public class PeliculaMap:EntityTypeConfiguration<Pelicula>
    {
        public PeliculaMap()
        {
            //key
            HasKey(p => p.Id);

            //popiedades
            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Titulo)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Resumen)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Nacionalidad)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.Fecha)
                .IsRequired();

            Property(p => p.Cartel)
                .HasColumnType("image")
                .IsOptional();

            ToTable("Pelicula");
        }
    }
}
