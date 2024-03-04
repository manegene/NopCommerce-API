using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class CustomerRole
    {
        public CustomerRole()
        {
            AclRecords = new HashSet<AclRecord>();
            CustomerCustomerRoleMappings = new HashSet<CustomerCustomerRoleMapping>();
            PermissionRecordRoleMappings = new HashSet<PermissionRecordRoleMapping>();
            TierPrices = new HashSet<TierPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public bool FreeShipping { get; set; }
        public bool TaxExempt { get; set; }
        public bool Active { get; set; }
        public bool IsSystemRole { get; set; }
        public bool EnablePasswordLifetime { get; set; }
        public bool OverrideTaxDisplayType { get; set; }
        public int DefaultTaxDisplayTypeId { get; set; }
        public int PurchasedWithProductId { get; set; }

        public virtual ICollection<AclRecord> AclRecords { get; set; }
        public virtual ICollection<CustomerCustomerRoleMapping> CustomerCustomerRoleMappings { get; set; }
        public virtual ICollection<PermissionRecordRoleMapping> PermissionRecordRoleMappings { get; set; }
        public virtual ICollection<TierPrice> TierPrices { get; set; }
    }
}
