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
    
    public partial class User
    {
        public User()
        {
            this.BudgetedYards = new HashSet<BudgetedYard>();
            this.CompanyUsers = new HashSet<CompanyUser>();
            this.Competitors = new HashSet<Competitor>();
            this.Contacts = new HashSet<Contact>();
            this.ContactNotes = new HashSet<ContactNote>();
            this.CustomerEvents = new HashSet<CustomerEvent>();
            this.CustomerEvents1 = new HashSet<CustomerEvent>();
            this.Logins = new HashSet<Login>();
            this.ManagersSalesmen = new HashSet<ManagersSalesman>();
            this.ManagersSalesmen1 = new HashSet<ManagersSalesman>();
            this.ProjectBidderNotes = new HashSet<ProjectBidderNote>();
            this.ProjectNotes = new HashSet<ProjectNote>();
            this.Projects = new HashSet<Project>();
            this.Projects1 = new HashSet<Project>();
            this.ProspectNotes = new HashSet<ProspectNote>();
            this.Prospects = new HashSet<Prospect>();
            this.Quotes = new HashSet<Quote>();
            this.Quotes1 = new HashSet<Quote>();
            this.SalespersonContacts = new HashSet<SalespersonContact>();
            this.SalesPersonRegions = new HashSet<SalesPersonRegion>();
            this.UserRoles = new HashSet<UserRole>();
            this.usersDivisions = new HashSet<usersDivision>();
        }
    
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string EmailAddress { get; set; }
        public string Handle { get; set; }
        public byte[] Password { get; set; }
        public string CellPhoneNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string SalesmanCode { get; set; }
        public Nullable<int> ReportsToID { get; set; }
        public int DeviationTypeID { get; set; }
        public Nullable<decimal> DeviationAmount { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string ST { get; set; }
        public string Zip { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public bool UsesSAML { get; set; }
        public string Country { get; set; }
        public string DefaultMailMessage { get; set; }
        public System.DateTime MsModificationDate { get; set; }
        public Nullable<int> AdministratorID { get; set; }
    
        public virtual ICollection<BudgetedYard> BudgetedYards { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<Competitor> Competitors { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<ContactNote> ContactNotes { get; set; }
        public virtual ICollection<CustomerEvent> CustomerEvents { get; set; }
        public virtual ICollection<CustomerEvent> CustomerEvents1 { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<ManagersSalesman> ManagersSalesmen { get; set; }
        public virtual ICollection<ManagersSalesman> ManagersSalesmen1 { get; set; }
        public virtual ICollection<ProjectBidderNote> ProjectBidderNotes { get; set; }
        public virtual ICollection<ProjectNote> ProjectNotes { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Project> Projects1 { get; set; }
        public virtual ICollection<ProspectNote> ProspectNotes { get; set; }
        public virtual ICollection<Prospect> Prospects { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<Quote> Quotes1 { get; set; }
        public virtual ICollection<SalespersonContact> SalespersonContacts { get; set; }
        public virtual ICollection<SalesPersonRegion> SalesPersonRegions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<usersDivision> usersDivisions { get; set; }
    }
}
