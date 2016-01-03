//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supplements.ServiceAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoseResultDescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoseResultDescription()
        {
            this.Doses = new HashSet<Dos>();
            this.ResultDescriptions = new HashSet<ResultDescription>();
        }
    
        public int ID { get; set; }
        public int DosesID { get; set; }
        public int DescriptionID { get; set; }
        public Nullable<int> DescriptionsEntity_ID { get; set; }
        public Nullable<int> Doses_ID { get; set; }
        public Nullable<int> DosesEntity_ID { get; set; }
    
        public virtual Dos Dos { get; set; }
        public virtual Dos Dos1 { get; set; }
        public virtual ResultDescription ResultDescription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dos> Doses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultDescription> ResultDescriptions { get; set; }
    }
}
