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
    
    public partial class Locations_Divisions_Lookup
    {
        public Locations_Divisions_Lookup()
        {
            this.usersDivisions = new HashSet<usersDivision>();
        }
    
        public int RecordID { get; set; }
        public int DivisionID { get; set; }
        public string Division_Name { get; set; }
        public string Location1_Code { get; set; }
        public string Location1_Name { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual ICollection<usersDivision> usersDivisions { get; set; }
    }
}
