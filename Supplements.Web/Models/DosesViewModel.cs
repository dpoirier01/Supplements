using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supplements.Web.Models
{
    public class DosesViewModel
    {
        public int Id { get; set; }
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
        public DateTime StartDate {get;set;}
        public DateTime EndDate { get; set; }
        public int DoseResultDescription { get; set; }
    }
}