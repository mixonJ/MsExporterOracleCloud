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
    
    public partial class usersDivision
    {
        public int UserDivisionID { get; set; }
        public int UserID { get; set; }
        public int LocationDivisionID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Locations_Divisions_Lookup Locations_Divisions_Lookup { get; set; }
        public virtual User User { get; set; }
    }
}
