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
    
    public partial class Dos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dos()
        {
            this.DoseResultDescriptions = new HashSet<DoseResultDescription>();
            this.DoseResultDescriptions1 = new HashSet<DoseResultDescription>();
        }
    
        public int ID { get; set; }
        public int SupplementTypeID { get; set; }
        public decimal MorningQuantity { get; set; }
        public decimal AfternoonQuantity { get; set; }
        public decimal EveningQuantity { get; set; }
        public decimal MorningWeight { get; set; }
        public decimal AfternoonWeight { get; set; }
        public decimal EveningWeight { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Evening { get; set; }
        public int FrequencyByWeek { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public Nullable<int> DoseResultDescription_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoseResultDescription> DoseResultDescriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoseResultDescription> DoseResultDescriptions1 { get; set; }
        public virtual DoseResultDescription DoseResultDescription { get; set; }
        public virtual SupplementType SupplementType { get; set; }
    }
}
