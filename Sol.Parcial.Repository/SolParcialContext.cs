﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sol.Parcial.BusinessEntities;
using Sol.Parcial.Repository.Mapping;

namespace Sol.Parcial.Repository
{
    public class SolParcialContext:DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Estreno> Estrenos { get; set; }
        public DbSet<Director> Directores { get; set; }
        public DbSet<Festival> Festivales { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Premiaciones> Premiacioneses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ParticipantesMap());
            modelBuilder.Configurations.Add(new PremiacionesMap());
        }
    }
}