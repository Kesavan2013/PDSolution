//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pricing.Models
{
    using System;
    
    public partial class GetBoreHole_Result
    {
        public int BoreHoleId { get; set; }
        public string BoreHoleName { get; set; }
        public string WellName { get; set; }
        public Nullable<System.DateTime> pudDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public string Class { get; set; }
        public string Status { get; set; }
    }
}
