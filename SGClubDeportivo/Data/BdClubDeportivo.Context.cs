﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGClubDeportivo.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BdClubDeportivoEntities : DbContext
    {
        public BdClubDeportivoEntities()
            : base("name=BdClubDeportivoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<Jugador> Jugador { get; set; }
        public virtual DbSet<Jugador_cat> Jugador_cat { get; set; }
        public virtual DbSet<Secretaria> Secretaria { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
