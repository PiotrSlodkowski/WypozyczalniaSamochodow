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
    using System.Collections.Generic;
    
    public partial class EquipmentTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EquipmentTable()
        {
            this.OrdersTable = new HashSet<OrdersTable>();
        }
    
        public int idEquipment { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public Nullable<int> yearOfProduction { get; set; }
        public Nullable<int> countOfDoors { get; set; }
        public Nullable<decimal> pricePerDay { get; set; }
        public Nullable<int> access { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersTable> OrdersTable { get; set; }
    }
}
