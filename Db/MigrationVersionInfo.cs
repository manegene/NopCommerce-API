using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class MigrationVersionInfo
    {
        public DateTime? AppliedOn { get; set; }
        public string Description { get; set; }
        public long Version { get; set; }
    }
}
