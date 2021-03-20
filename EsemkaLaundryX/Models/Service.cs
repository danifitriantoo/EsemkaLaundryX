using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemkaLaundryX.Models
{
    public class Service
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IdCategory { get; set; }
        public string IdUnit { get; set; }
        public string PriceUnit { get; set; }
        public string EstimationDuration { get; set; }
    }
}
