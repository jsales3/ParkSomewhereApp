//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkSomewhereApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ReviewID { get; set; }
        public int ParkID { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewComments { get; set; }
        public Nullable<System.DateTime> ReviewTimeStamp { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<int> TotalVotes { get; set; }
        public string UserID { get; set; }
    
        public virtual Park Park { get; set; }
    }
}
