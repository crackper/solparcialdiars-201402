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
    public class ParticipantesMap:EntityTypeConfiguration<Participantes>
    {
        public ParticipantesMap()
        {
            //key
            this.HasKey(p => new {p.PeliculaId,p.PersonaId});

            //propiedades
            Property(p => p.PersonaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.PeliculaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(p => p.AporteProductor)
                .HasPrecision(9, 2)
                .IsOptional();

            Property(p => p.PapelActor)
                .HasMaxLength(200)
                .IsOptional();

            //table
            ToTable("Participantes");

            //relaciones
            HasRequired(p => p.Pelicula)
                .WithMany(pp => pp.Participantes)
                .HasForeignKey(p => p.PeliculaId);

            HasRequired(p => p.Persona)
                .WithMany()
                .HasForeignKey(p => p.PersonaId);
        }
    }
}
