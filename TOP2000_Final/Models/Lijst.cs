//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TOP2000_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lijst
    {
        public int songid { get; set; }
        public int top2000jaar { get; set; }
        public int positie { get; set; }
    
        public virtual Song Song { get; set; }
        public virtual Top2000Jaar Top2000Jaar1 { get; set; }
    }
}
