using System;
using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class RewardPointsHistory
    {
        public RewardPointsHistory()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int Points { get; set; }
        public int? PointsBalance { get; set; }
        public decimal UsedAmount { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public int? ValidPoints { get; set; }
        public Guid? UsedWithOrder { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
