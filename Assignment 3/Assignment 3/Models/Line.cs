//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Line
    {
        public Nullable<int> INV_NUMBER { get; set; }
        public int LINE_NUMBER { get; set; }
        public int INV_LINE { get; set; }
        public string P_CODE { get; set; }
        public Nullable<float> LINE_UNITS { get; set; }
        public Nullable<float> LINE_PRICE { get; set; }
        public Nullable<float> LINE_TOTAL { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
