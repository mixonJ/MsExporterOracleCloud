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
    
    public partial class ProjectBidderCharge
    {
        public int ProjectBidderChargeID { get; set; }
        public int ProjectBidderID { get; set; }
        public int ProductLineID { get; set; }
        public int ProjectChargeID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
        public bool Exported { get; set; }
    
        public virtual ProductLine ProductLine { get; set; }
        public virtual ProjectBidder ProjectBidder { get; set; }
        public virtual ProjectCharge ProjectCharge { get; set; }
    }
}
