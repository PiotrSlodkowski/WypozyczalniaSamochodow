//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WypozyczalniaSamochodow
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class wypozyczalniaSamochodowEntities : DbContext
    {
        public wypozyczalniaSamochodowEntities()
            : base("name=wypozyczalniaSamochodowEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientTable> ClientTable { get; set; }
        public virtual DbSet<EquipmentTable> EquipmentTable { get; set; }
        public virtual DbSet<OrdersTable> OrdersTable { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
