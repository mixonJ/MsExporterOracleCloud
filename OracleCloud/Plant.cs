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
    
    public partial class Plant
    {
        public Plant()
        {
            this.Orders = new HashSet<Order>();
            this.PlantLinesOfBusinesses = new HashSet<PlantLinesOfBusiness>();
            this.PlantProductPrices = new HashSet<PlantProductPrice>();
            this.PlantProducts = new HashSet<PlantProduct>();
            this.ProjectBidders = new HashSet<ProjectBidder>();
            this.ProjectDistances = new HashSet<ProjectDistance>();
            this.ProjectProducts = new HashSet<ProjectProduct>();
            this.Projects = new HashSet<Project>();
            this.SalesPersonRegions = new HashSet<SalesPersonRegion>();
            this.StandardClauses = new HashSet<StandardClaus>();
            this.Surcharges = new HashSet<Surcharge>();
            this.TemplatedProducts = new HashSet<TemplatedProduct>();
        }
    
        public int PlantID { get; set; }
        public string Description { get; set; }
        public string SystechCompNbr { get; set; }
        public string CSPlantCode { get; set; }
        public string CSShortName { get; set; }
        public string CSPlantName { get; set; }
        public System.DateTime Inserted { get; set; }
        public System.DateTime Modified { get; set; }
        public bool Inactive_Flag { get; set; }
        public int DivisionID { get; set; }
        public Nullable<decimal> PlantCost { get; set; }
        public Nullable<decimal> DeliveryCost { get; set; }
        public Nullable<decimal> MaterialCost { get; set; }
        public Nullable<decimal> SGACost { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public int LineOfBusinessID { get; set; }
        public string Country { get; set; }
        public Nullable<int> ProductLineID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Division Division { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ProductLine ProductLine { get; set; }
        public virtual ICollection<PlantLinesOfBusiness> PlantLinesOfBusinesses { get; set; }
        public virtual ICollection<PlantProductPrice> PlantProductPrices { get; set; }
        public virtual ICollection<PlantProduct> PlantProducts { get; set; }
        public virtual ICollection<ProjectBidder> ProjectBidders { get; set; }
        public virtual ICollection<ProjectDistance> ProjectDistances { get; set; }
        public virtual ICollection<ProjectProduct> ProjectProducts { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<SalesPersonRegion> SalesPersonRegions { get; set; }
        public virtual ICollection<StandardClaus> StandardClauses { get; set; }
        public virtual ICollection<Surcharge> Surcharges { get; set; }
        public virtual ICollection<TemplatedProduct> TemplatedProducts { get; set; }
    }
}