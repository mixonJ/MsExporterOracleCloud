//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TQS_mtlp
    {
        public int CompanyID { get; set; }
        public string matl_class_id { get; set; }
        public string matl_class_type { get; set; }
        public string plant_code { get; set; }
        public string plant_status { get; set; }
        public Nullable<decimal> cem_strgth_class { get; set; }
        public string cem_strgth_subclass { get; set; }
        public Nullable<decimal> cement_offset { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string u_version { get; set; }
    
        public virtual Company Company { get; set; }
    }
}