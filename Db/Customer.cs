using System;
using System.Collections.Generic;

#nullable disable

namespace Nop.RestApi.Service.Db
{
    public partial class Customer
    {
        public Customer()
        {
            ActivityLogs = new HashSet<ActivityLog>();
            BackInStockSubscriptions = new HashSet<BackInStockSubscription>();
            BlogComments = new HashSet<BlogComment>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerCustomerRoleMappings = new HashSet<CustomerCustomerRoleMapping>();
            CustomerPasswords = new HashSet<CustomerPassword>();
            ExternalAuthenticationRecords = new HashSet<ExternalAuthenticationRecord>();
            ForumsPosts = new HashSet<ForumsPost>();
            ForumsPrivateMessageFromCustomers = new HashSet<ForumsPrivateMessage>();
            ForumsPrivateMessageToCustomers = new HashSet<ForumsPrivateMessage>();
            ForumsSubscriptions = new HashSet<ForumsSubscription>();
            ForumsTopics = new HashSet<ForumsTopic>();
            Logs = new HashSet<Log>();
            NewsComments = new HashSet<NewsComment>();
            Orders = new HashSet<Order>();
            PollVotingRecords = new HashSet<PollVotingRecord>();
            ProductReviews = new HashSet<ProductReview>();
            ReturnRequests = new HashSet<ReturnRequest>();
            RewardPointsHistories = new HashSet<RewardPointsHistory>();
            ShoppingCartItems = new HashSet<ShoppingCartItem>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string EmailToRevalidate { get; set; }
        public string SystemName { get; set; }
        public int? BillingAddressId { get; set; }
        public int? ShippingAddressId { get; set; }
        public Guid CustomerGuid { get; set; }
        public string AdminComment { get; set; }
        public bool IsTaxExempt { get; set; }
        public int AffiliateId { get; set; }
        public int VendorId { get; set; }
        public bool HasShoppingCartItems { get; set; }
        public bool RequireReLogin { get; set; }
        public int FailedLoginAttempts { get; set; }
        public DateTime? CannotLoginUntilDateUtc { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool IsSystemAccount { get; set; }
        public string LastIpAddress { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? LastLoginDateUtc { get; set; }
        public DateTime LastActivityDateUtc { get; set; }
        public int RegisteredInStoreId { get; set; }

        public virtual Address BillingAddress { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
        public virtual ICollection<BackInStockSubscription> BackInStockSubscriptions { get; set; }
        public virtual ICollection<BlogComment> BlogComments { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerCustomerRoleMapping> CustomerCustomerRoleMappings { get; set; }
        public virtual ICollection<CustomerPassword> CustomerPasswords { get; set; }
        public virtual ICollection<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }
        public virtual ICollection<ForumsPost> ForumsPosts { get; set; }
        public virtual ICollection<ForumsPrivateMessage> ForumsPrivateMessageFromCustomers { get; set; }
        public virtual ICollection<ForumsPrivateMessage> ForumsPrivateMessageToCustomers { get; set; }
        public virtual ICollection<ForumsSubscription> ForumsSubscriptions { get; set; }
        public virtual ICollection<ForumsTopic> ForumsTopics { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PollVotingRecord> PollVotingRecords { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<ReturnRequest> ReturnRequests { get; set; }
        public virtual ICollection<RewardPointsHistory> RewardPointsHistories { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
