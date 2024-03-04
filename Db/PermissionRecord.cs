using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class PermissionRecord
    {
        public PermissionRecord()
        {
            PermissionRecordRoleMappings = new HashSet<PermissionRecordRoleMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Category { get; set; }

        public virtual ICollection<PermissionRecordRoleMapping> PermissionRecordRoleMappings { get; set; }
    }
}
