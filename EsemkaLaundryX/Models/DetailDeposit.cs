
namespace EsemkaLaundryX.Models
{
    public class DetailDeposit
    {
        public string Id { get; set; }
        public string IdDeposit { get; set; }
        public string IdService { get; set; }
        public string IdPrepaidPackage { get; set; }
        public string PriceUnit { get; set; }
        public string TotalUnit { get; set; }
        public string CompletedDatetime { get; set; }
    }
}
