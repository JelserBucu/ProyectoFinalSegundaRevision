﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comprension_Lectora.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DESARROLLO_WEBEntities : DbContext
    {
        public DESARROLLO_WEBEntities()
            : base("name=DESARROLLO_WEBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CSTATE> CSTATE { get; set; }
        public virtual DbSet<DISPONIBLES> DISPONIBLES { get; set; }
        public virtual DbSet<ENFERMEDAD> ENFERMEDAD { get; set; }
        public virtual DbSet<HISTORIAL_CLINICO> HISTORIAL_CLINICO { get; set; }
        public virtual DbSet<PERSONAL_ADMISTRATIVO> PERSONAL_ADMISTRATIVO { get; set; }
        public virtual DbSet<PRODUCTOS> PRODUCTOS { get; set; }
        public virtual DbSet<PUESTO> PUESTO { get; set; }
        public virtual DbSet<SEXO> SEXO { get; set; }
        public virtual DbSet<SOLICITUD_CISTAS> SOLICITUD_CISTAS { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<HABITACION> HABITACION { get; set; }
        public virtual DbSet<PACIENTE> PACIENTE { get; set; }
    }
}
