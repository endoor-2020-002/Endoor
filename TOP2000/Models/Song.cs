//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TOP2000.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        public Song()
        {
            this.Lijsts = new HashSet<Lijst>();
        }
    
        public int songid { get; set; }
        public int artiestid { get; set; }
        public string titel { get; set; }
        public Nullable<int> jaar { get; set; }
    
        public virtual Artiest Artiest { get; set; }
        public virtual ICollection<Lijst> Lijsts { get; set; }
    }
}
