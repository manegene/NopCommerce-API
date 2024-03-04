﻿using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class OrderNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public int OrderId { get; set; }
        public int DownloadId { get; set; }
        public bool DisplayToCustomer { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Order Order { get; set; }
    }
}
