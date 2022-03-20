namespace Genaralinsuranceapp.BusinessLayer
{
    public class claimhistory
    {
        public partial class Claimhistory
        {
            public int ClaimNo { get; set; }
            public int? PolicyNumber { get; set; }
            public bool? IsApproved { get; set; }
            public decimal? Amount { get; set; }
            public int? ClaimId { get; set; }

            public virtual Claimreasons Claim { get; set; }
            public virtual Policydetails PolicyNumberNavigation { get; set; }
        }
    }
}
