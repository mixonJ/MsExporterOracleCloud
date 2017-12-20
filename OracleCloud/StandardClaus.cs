//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OracleCloud
{
    using System;
    using System.Collections.Generic;
    
    public partial class StandardClaus
    {
        public StandardClaus()
        {
            this.QuoteStandardClauses = new HashSet<QuoteStandardClaus>();
        }
    
        public int StandardClauseID { get; set; }
        public string Name { get; set; }
        public string StandardClauseText { get; set; }
        public Nullable<int> ProductLineID { get; set; }
        public Nullable<int> PlantID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public bool Inactive { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> ProductUsageID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductLine ProductLine { get; set; }
        public virtual ProductUsage ProductUsage { get; set; }
        public virtual ICollection<QuoteStandardClaus> QuoteStandardClauses { get; set; }
    }
}
