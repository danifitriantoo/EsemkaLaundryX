using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemkaLaundryX.Models
{
    public class PrepaidPackage
    {
        public string Id { get; set; }
        public string IdCustomer { get; set; }
        public string IdPackage { get; set; }
        public string Price { get; set; }
        public string StartDatetime { get; set; }
        public string CompletedDatetime { get; set; }

    }
}
