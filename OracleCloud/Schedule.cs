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
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.ScheduleItems = new HashSet<ScheduleItem>();
        }
    
        public int ScheduleID { get; set; }
        public int ProjectProductID { get; set; }
        public bool Active { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual ProjectProduct ProjectProduct { get; set; }
        public virtual ICollection<ScheduleItem> ScheduleItems { get; set; }
    }
}
