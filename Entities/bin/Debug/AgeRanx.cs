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
    
    public partial class AgeRanx
    {
        public int AgeRangeID { get; set; }
        public int CompanyID { get; set; }
        public int RangeStart { get; set; }
        public Nullable<int> RangeEnd { get; set; }
        public string Description { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
