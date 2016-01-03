using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supplements.ServiceAPI.Models.DTO
{
    public class SupplementTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distributer { get; set; }
        public bool IsThirdPartyTesting { get; set; }

        //public IEnumerable<DosesDTO> Doses { get; set; }
    }
}