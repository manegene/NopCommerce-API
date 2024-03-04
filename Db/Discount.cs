using System;
using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class Discount
    {
        public Discount()
        {
            DiscountAppliedToCategories = new HashSet<DiscountAppliedToCategory>();
            DiscountAppliedToManufacturers = new HashSet<DiscountAppliedToManufacturer>();
            DiscountAppliedToProducts = new HashSet<DiscountAppliedToProduct>();
            DiscountRequirements = new HashSet<DiscountRequirement>();
            DiscountUsageHistories = new HashSet<DiscountUsageHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CouponCode { get; set; }
        public string AdminComment { get; set; }
        public int DiscountTypeId { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? MaximumDiscountAmount { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
        public bool RequiresCouponCode { get; set; }
        public bool IsCumulative { get; set; }
        public int DiscountLimitationId { get; set; }
        public int LimitationTimes { get; set; }
        public int? MaximumDiscountedQuantity { get; set; }
        public bool AppliedToSubCategories { get; set; }

        public virtual ICollection<DiscountAppliedToCategory> DiscountAppliedToCategories { get; set; }
        public virtual ICollection<DiscountAppliedToManufacturer> DiscountAppliedToManufacturers { get; set; }
        public virtual ICollection<DiscountAppliedToProduct> DiscountAppliedToProducts { get; set; }
        public virtual ICollection<DiscountRequirement> DiscountRequirements { get; set; }
        public virtual ICollection<DiscountUsageHistory> DiscountUsageHistories { get; set; }
    }
}
