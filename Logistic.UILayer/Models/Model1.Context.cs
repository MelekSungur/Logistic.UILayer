//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logistic.UILayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBLogisticEntities : DbContext
    {
        public DBLogisticEntities()
            : base("name=DBLogisticEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_CATEGORY> TBL_CATEGORY { get; set; }
        public virtual DbSet<TBL_CUSTOMER> TBL_CUSTOMER { get; set; }
        public virtual DbSet<TBL_CITY> TBL_CITY { get; set; }
        public virtual DbSet<TBL_ORDER> TBL_ORDER { get; set; }
        public virtual DbSet<TBL_MESSAGE> TBL_MESSAGE { get; set; }
    }
}
