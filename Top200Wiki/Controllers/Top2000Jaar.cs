//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Top200Wiki.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Top2000Jaar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Top2000Jaar()
        {
            this.Lijsts = new HashSet<Lijst>();
        }
    
        public int Jaar { get; set; }
        public string Titel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lijst> Lijsts { get; set; }
    }
}
