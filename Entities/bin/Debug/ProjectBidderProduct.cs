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
    
    public partial class ProjectBidderProduct
    {
        public int ProjectBidderProductID { get; set; }
        public int ProjectBidderID { get; set; }
        public int ProjectProductID { get; set; }
        public decimal Price { get; set; }
        public System.DateTime Inserted { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<bool> SameAsList { get; set; }
        public Nullable<bool> Forecasted { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public Nullable<decimal> FreightPay { get; set; }
        public Nullable<decimal> ListPrice { get; set; }
        public Nullable<decimal> CustomerPrice { get; set; }
        public bool Exported { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> StatusID { get; set; }
        public int LineNbr { get; set; }
        public System.DateTime MsModificationDate { get; set; }
        public Nullable<decimal> PreviousPrice { get; set; }
        public Nullable<decimal> PreviousDeliveredPrice { get; set; }
    
        public virtual CompanyBidStatus CompanyBidStatus { get; set; }
        public virtual ProjectBidder ProjectBidder { get; set; }
        public virtual ProjectProduct ProjectProduct { get; set; }
    }
}
