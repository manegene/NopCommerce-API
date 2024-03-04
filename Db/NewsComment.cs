﻿using System;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class NewsComment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int NewsItemId { get; set; }
        public int StoreId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual News NewsItem { get; set; }
        public virtual Store Store { get; set; }
    }
}
