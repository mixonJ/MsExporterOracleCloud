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
    
    public partial class TQS_work
    {
        public string workability_code { get; set; }
        public string descr { get; set; }
        public string short_descr { get; set; }
        public string workability_type { get; set; }
        public Nullable<decimal> nominal_workability { get; set; }
        public string workability_base_uom { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string u_version { get; set; }
        public int CompanyID { get; set; }
    
        public virtual Company Company { get; set; }
    }
}