﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShootingRange.Persistence
{
    using ShootingRange.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShootingRangeEntities : DbContext
    {
        public ShootingRangeEntities()
            : base("name=ShootingRangeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<t_bestshot> t_bestshot { get; set; }
        public DbSet<t_club> t_club { get; set; }
        public DbSet<t_event> t_event { get; set; }
        public DbSet<t_order> t_order { get; set; }
        public DbSet<t_orderitem> t_orderitem { get; set; }
        public DbSet<t_participation> t_participation { get; set; }
        public DbSet<t_participationdescription> t_participationdescription { get; set; }
        public DbSet<t_person> t_person { get; set; }
        public DbSet<t_programitem> t_programitem { get; set; }
        public DbSet<t_programsubtotal> t_programsubtotal { get; set; }
        public DbSet<t_session> t_session { get; set; }
        public DbSet<t_sessionsubtotal> t_sessionsubtotal { get; set; }
        public DbSet<t_shooter> t_shooter { get; set; }
        public DbSet<t_shooternumberconfig> t_shooternumberconfig { get; set; }
        public DbSet<t_shooterparticipation> t_shooterparticipation { get; set; }
        public DbSet<t_shot> t_shot { get; set; }
    }
}
