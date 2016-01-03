using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplements.Model
{
    public class SupplementType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distributer { get; set; }
        public bool IsThirdPartyTesting { get; set; }

        public IEnumerable<Doses> Doses { get; set; }
    }
}
