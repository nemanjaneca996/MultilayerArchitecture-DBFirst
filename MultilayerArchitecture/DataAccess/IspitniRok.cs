//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultilayerArchitecture.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class IspitniRok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IspitniRok()
        {
            this.Ispit = new HashSet<Ispit>();
        }
    
        public short idIspitniRok { get; set; }
        public short godina { get; set; }
        public string ispitniRokNaziv { get; set; }
        public bool popravni { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ispit> Ispit { get; set; }
    }
}