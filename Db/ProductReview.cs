﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class ProductReview
    {
        public ProductReview()
        {
            ProductReviewHelpfulnesses = new HashSet<ProductReviewHelpfulness>();
            ProductReviewReviewTypeMappings = new HashSet<ProductReviewReviewTypeMapping>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public bool IsApproved { get; set; }
        public string Title { get; set; }
        public string ReviewText { get; set; }
        public string ReplyText { get; set; }
        public bool CustomerNotifiedOfReply { get; set; }
        public int Rating { get; set; }
        public int HelpfulYesTotal { get; set; }
        public int HelpfulNoTotal { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual ICollection<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }
    }
}
