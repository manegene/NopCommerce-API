﻿using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class TaxTransactionLog
    {
        public int Id { get; set; }
        public int StatusCode { get; set; }
        public string Url { get; set; }
        public string RequestMessage { get; set; }
        public string ResponseMessage { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedDateUtc { get; set; }
    }
}
