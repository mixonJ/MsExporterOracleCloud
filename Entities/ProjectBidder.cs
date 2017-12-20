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
    
    public partial class ProjectBidder
    {
        public ProjectBidder()
        {
            this.BidderQuotes = new HashSet<BidderQuote>();
            this.ProjectBidderCharges = new HashSet<ProjectBidderCharge>();
            this.ProjectBidderNotes = new HashSet<ProjectBidderNote>();
            this.ProjectBidderProducts = new HashSet<ProjectBidderProduct>();
            this.Quotes = new HashSet<Quote>();
        }
    
        public int ProjectBidderID { get; set; }
        public int ProjectID { get; set; }
        public int ProspectID { get; set; }
        public Nullable<bool> Quoted { get; set; }
        public Nullable<bool> StatusSub { get; set; }
        public Nullable<System.DateTime> QuoteDate { get; set; }
        public Nullable<bool> NotLIkeLIst { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> PlantID { get; set; }
        public string ProjectCode { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string PONumber { get; set; }
        public Nullable<int> MinLoadCharge { get; set; }
        public Nullable<int> SundryCharge { get; set; }
        public Nullable<int> SeasonalCharge { get; set; }
        public Nullable<int> UnloadCharge { get; set; }
        public string CustJobNbr { get; set; }
        public System.DateTime MsModificationDate { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> DateLastExported { get; set; }
    
        public virtual ICollection<BidderQuote> BidderQuotes { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ICollection<ProjectBidderCharge> ProjectBidderCharges { get; set; }
        public virtual ICollection<ProjectBidderNote> ProjectBidderNotes { get; set; }
        public virtual ICollection<ProjectBidderProduct> ProjectBidderProducts { get; set; }
        public virtual ProjectCharge ProjectCharge { get; set; }
        public virtual ProjectBidderStatus ProjectBidderStatus { get; set; }
        public virtual Project Project { get; set; }
        public virtual Prospect Prospect { get; set; }
        public virtual ProjectCharge ProjectCharge1 { get; set; }
        public virtual ProjectCharge ProjectCharge2 { get; set; }
        public virtual ProjectCharge ProjectCharge3 { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
    }
}
