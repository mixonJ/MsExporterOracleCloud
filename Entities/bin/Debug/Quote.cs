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
    
    public partial class Quote
    {
        public Quote()
        {
            this.QuoteDetails = new HashSet<QuoteDetail>();
            this.QuoteStandardClauses = new HashSet<QuoteStandardClaus>();
            this.QuoteSurcharges = new HashSet<QuoteSurcharge>();
        }
    
        public int QuoteID { get; set; }
        public int ProjectBidderID { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<int> TermsID { get; set; }
        public string Attention { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public System.DateTime QuoteDate { get; set; }
        public System.DateTime FirmUntilDate { get; set; }
        public int QuoteSequenceNumber { get; set; }
        public int QuoteTypeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateLastModified { get; set; }
        public string CustomerQuoteID { get; set; }
        public bool Exported { get; set; }
        public Nullable<System.DateTime> EscalationDate { get; set; }
        public Nullable<System.DateTime> EscalationDate2 { get; set; }
        public Nullable<System.DateTime> EscalationDate3 { get; set; }
        public Nullable<System.DateTime> EscalationDate4 { get; set; }
        public string QuoteNote { get; set; }
        public string EscalationAmount { get; set; }
        public string EscalationAmount2 { get; set; }
        public string EscalationAmount3 { get; set; }
        public string EscalationAmount4 { get; set; }
        public int QuoteStatusID { get; set; }
        public string Notes { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> StartOrderDate { get; set; }
        public Nullable<System.DateTime> ExpireOrderDate { get; set; }
        public Nullable<int> VehicleTypeID_1 { get; set; }
        public Nullable<int> VehicleTypeID_2 { get; set; }
        public Nullable<int> VehicleTypeID_3 { get; set; }
        public Nullable<int> VehicleTypeID_4 { get; set; }
        public Nullable<int> VehicleTypeID_5 { get; set; }
        public string CustomerOrderID { get; set; }
        public string PurchaseOrder { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<bool> AllowBeforeStart { get; set; }
        public Nullable<bool> AllowAfterEnd { get; set; }
        public Nullable<bool> AllowExceedQty { get; set; }
        public Nullable<bool> AllowExceedLoads { get; set; }
        public Nullable<bool> AllowAfterComplete { get; set; }
        public System.DateTime MsModificationDate { get; set; }
        public Nullable<int> SalespersonID { get; set; }
        public Nullable<int> ApexNoteID { get; set; }
        public Nullable<System.DateTime> DateLastEmailed { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ProjectBidder ProjectBidder { get; set; }
        public virtual ICollection<QuoteDetail> QuoteDetails { get; set; }
        public virtual QuoteType QuoteType { get; set; }
        public virtual QuoteStatus QuoteStatus { get; set; }
        public virtual User User { get; set; }
        public virtual Terms_Discount Terms_Discount { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<QuoteStandardClaus> QuoteStandardClauses { get; set; }
        public virtual ICollection<QuoteSurcharge> QuoteSurcharges { get; set; }
    }
}
