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
    
    public partial class QuoteStandardClaus
    {
        public int QuoteStandardClauseID { get; set; }
        public int QuoteID { get; set; }
        public int StandardClauseID { get; set; }
        public System.DateTime MsModificationDate { get; set; }
    
        public virtual Quote Quote { get; set; }
        public virtual StandardClaus StandardClaus { get; set; }
    }
}
