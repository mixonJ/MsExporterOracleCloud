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
    
    public partial class Source
    {
        public Source()
        {
            this.Projects = new HashSet<Project>();
        }
    
        public int SourceID { get; set; }
        public int CompanyID { get; set; }
        public string SourceName { get; set; }
        public Nullable<System.DateTime> Inserted { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public bool Inactive { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
