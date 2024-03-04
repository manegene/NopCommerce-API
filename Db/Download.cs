﻿using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class Download
    {
        public int Id { get; set; }
        public Guid DownloadGuid { get; set; }
        public bool UseDownloadUrl { get; set; }
        public string DownloadUrl { get; set; }
        public byte[] DownloadBinary { get; set; }
        public string ContentType { get; set; }
        public string Filename { get; set; }
        public string Extension { get; set; }
        public bool IsNew { get; set; }
    }
}
