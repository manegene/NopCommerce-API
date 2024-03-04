using Microsoft.EntityFrameworkCore;
using Nop.RestApi.Service.Db;

namespace Nop.RestApi.Service.Models.core
{
    public partial class ApiContext : DbContext
    {
        public ApiContext()
        {
        }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AclRecord> AclRecords { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }
        public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }
        public virtual DbSet<Affiliate> Affiliates { get; set; }
        public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }
        public virtual DbSet<BlogComment> BlogComments { get; set; }
        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }
        public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }
        public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }
        public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }
        public virtual DbSet<CustomerCustomerRoleMapping> CustomerCustomerRoleMappings { get; set; }
        public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }
        public virtual DbSet<CustomerRole> CustomerRoles { get; set; }
        public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountAppliedToCategory> DiscountAppliedToCategories { get; set; }
        public virtual DbSet<DiscountAppliedToManufacturer> DiscountAppliedToManufacturers { get; set; }
        public virtual DbSet<DiscountAppliedToProduct> DiscountAppliedToProducts { get; set; }
        public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }
        public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<EasyPostBatch> EasyPostBatches { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }
        public virtual DbSet<FacebookPixelConfiguration> FacebookPixelConfigurations { get; set; }
        public virtual DbSet<ForumsForum> ForumsForums { get; set; }
        public virtual DbSet<ForumsGroup> ForumsGroups { get; set; }
        public virtual DbSet<ForumsPost> ForumsPosts { get; set; }
        public virtual DbSet<ForumsPostVote> ForumsPostVotes { get; set; }
        public virtual DbSet<ForumsPrivateMessage> ForumsPrivateMessages { get; set; }
        public virtual DbSet<ForumsSubscription> ForumsSubscriptions { get; set; }
        public virtual DbSet<ForumsTopic> ForumsTopics { get; set; }
        public virtual DbSet<GdprConsent> GdprConsents { get; set; }
        public virtual DbSet<GdprLog> GdprLogs { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }
        public virtual DbSet<GiftCard> GiftCards { get; set; }
        public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }
        public virtual DbSet<GoogleAuthenticatorRecord> GoogleAuthenticatorRecords { get; set; }
        public virtual DbSet<GoogleProductRecord> GoogleProductRecords { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }
        public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }
        public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<MigrationVersionInfo> MigrationVersionInfos { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComments { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderNote> OrderNotes { get; set; }
        public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }
        public virtual DbSet<PermissionRecordRoleMapping> PermissionRecordRoleMappings { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<PictureBinary> PictureBinaries { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<PollAnswer> PollAnswers { get; set; }
        public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }
        public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeCombination> ProductAttributeCombinations { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductAvailabilityRange> ProductAvailabilityRanges { get; set; }
        public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
        public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }
        public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
        public virtual DbSet<ProductProductTagMapping> ProductProductTagMappings { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual DbSet<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }
        public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }
        public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }
        public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }
        public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }
        public virtual DbSet<ReturnRequestAction> ReturnRequestActions { get; set; }
        public virtual DbSet<ReturnRequestReason> ReturnRequestReasons { get; set; }
        public virtual DbSet<ReviewType> ReviewTypes { get; set; }
        public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }
        public virtual DbSet<SearchTerm> SearchTerms { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }
        public virtual DbSet<ShippingByWeightByTotalRecord> ShippingByWeightByTotalRecords { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }
        public virtual DbSet<ShippingMethodRestriction> ShippingMethodRestrictions { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }
        public virtual DbSet<SpecificationAttributeGroup> SpecificationAttributeGroups { get; set; }
        public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<StockQuantityHistory> StockQuantityHistories { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreMapping> StoreMappings { get; set; }
        public virtual DbSet<StorePickupPoint> StorePickupPoints { get; set; }
        public virtual DbSet<SwiperSlide> SwiperSlides { get; set; }
        public virtual DbSet<TaxCategory> TaxCategories { get; set; }
        public virtual DbSet<TaxRate> TaxRates { get; set; }
        public virtual DbSet<TaxTransactionLog> TaxTransactionLogs { get; set; }
        public virtual DbSet<TierPrice> TierPrices { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }
        public virtual DbSet<UrlRecord> UrlRecords { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorAttribute> VendorAttributes { get; set; }
        public virtual DbSet<VendorAttributeValue> VendorAttributeValues { get; set; }
        public virtual DbSet<VendorNote> VendorNotes { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             if (!optionsBuilder.IsConfigured)
             {
 #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                 optionsBuilder.UseSqlServer("Server=habahabamall.com,1435;Initial Catalog=habahab1_dev;MultipleActiveResultSets=true;User ID=habahab1_dev;Password=slA8_Koi44byEwja");
             }
         }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.HasDefaultSchema("habahab1_dev")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            _ = modelBuilder.Entity<AclRecord>(entity =>
            {
                _ = entity.ToTable("AclRecord", "dbo");

                _ = entity.HasIndex(e => e.CustomerRoleId, "IX_AclRecord_CustomerRoleId");

                _ = entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_AclRecord_EntityId_EntityName");

                _ = entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.AclRecords)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_AclRecord_CustomerRoleId_CustomerRole_Id");
            });

            _ = modelBuilder.Entity<ActivityLog>(entity =>
            {
                _ = entity.ToTable("ActivityLog", "dbo");

                _ = entity.HasIndex(e => e.ActivityLogTypeId, "IX_ActivityLog_ActivityLogTypeId");

                _ = entity.HasIndex(e => e.CreatedOnUtc, "IX_ActivityLog_CreatedOnUtc");

                _ = entity.HasIndex(e => e.CustomerId, "IX_ActivityLog_CustomerId");

                _ = entity.Property(e => e.Comment).IsRequired();

                _ = entity.Property(e => e.EntityName).HasMaxLength(400);

                _ = entity.Property(e => e.IpAddress).HasMaxLength(200);

                _ = entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.ActivityLogTypeId)
                    .HasConstraintName("FK_ActivityLog_ActivityLogTypeId_ActivityLogType_Id");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ActivityLog_CustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<ActivityLogType>(entity =>
            {
                _ = entity.ToTable("ActivityLogType", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                _ = entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            _ = modelBuilder.Entity<Address>(entity =>
            {
                _ = entity.ToTable("Address", "dbo");

                _ = entity.HasIndex(e => e.CountryId, "IX_Address_CountryId");

                _ = entity.HasIndex(e => e.StateProvinceId, "IX_Address_StateProvinceId");

                _ = entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address_CountryId_Country_Id");

                _ = entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateProvinceId)
                    .HasConstraintName("FK_Address_StateProvinceId_StateProvince_Id");
            });

            _ = modelBuilder.Entity<AddressAttribute>(entity =>
            {
                _ = entity.ToTable("AddressAttribute", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<AddressAttributeValue>(entity =>
            {
                _ = entity.ToTable("AddressAttributeValue", "dbo");

                _ = entity.HasIndex(e => e.AddressAttributeId, "IX_AddressAttributeValue_AddressAttributeId");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.HasOne(d => d.AddressAttribute)
                    .WithMany(p => p.AddressAttributeValues)
                    .HasForeignKey(d => d.AddressAttributeId)
                    .HasConstraintName("FK_AddressAttributeValue_AddressAttributeId_AddressAttribute_Id");
            });

            _ = modelBuilder.Entity<Affiliate>(entity =>
            {
                _ = entity.ToTable("Affiliate", "dbo");

                _ = entity.HasIndex(e => e.AddressId, "IX_Affiliate_AddressId");

                _ = entity.HasOne(d => d.Address)
                    .WithMany(p => p.Affiliates)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliate_AddressId_Address_Id");
            });

            _ = modelBuilder.Entity<BackInStockSubscription>(entity =>
            {
                _ = entity.ToTable("BackInStockSubscription", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_BackInStockSubscription_CustomerId");

                _ = entity.HasIndex(e => e.ProductId, "IX_BackInStockSubscription_ProductId");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BackInStockSubscriptions)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_BackInStockSubscription_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.BackInStockSubscriptions)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_BackInStockSubscription_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<BlogComment>(entity =>
            {
                _ = entity.ToTable("BlogComment", "dbo");

                _ = entity.HasIndex(e => e.BlogPostId, "IX_BlogComment_BlogPostId");

                _ = entity.HasIndex(e => e.CustomerId, "IX_BlogComment_CustomerId");

                _ = entity.HasIndex(e => e.StoreId, "IX_BlogComment_StoreId");

                _ = entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.BlogPostId)
                    .HasConstraintName("FK_BlogComment_BlogPostId_BlogPost_Id");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_BlogComment_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.Store)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_BlogComment_StoreId_Store_Id");
            });

            _ = modelBuilder.Entity<BlogPost>(entity =>
            {
                _ = entity.ToTable("BlogPost", "dbo");

                _ = entity.HasIndex(e => e.LanguageId, "IX_BlogPost_LanguageId");

                _ = entity.Property(e => e.Body).IsRequired();

                _ = entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                _ = entity.Property(e => e.MetaTitle).HasMaxLength(400);

                _ = entity.Property(e => e.Title).IsRequired();

                _ = entity.HasOne(d => d.Language)
                    .WithMany(p => p.BlogPosts)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_BlogPost_LanguageId_Language_Id");
            });

            _ = modelBuilder.Entity<Campaign>(entity =>
            {
                _ = entity.ToTable("Campaign", "dbo");

                _ = entity.Property(e => e.Body).IsRequired();

                _ = entity.Property(e => e.Name).IsRequired();

                _ = entity.Property(e => e.Subject).IsRequired();
            });

            _ = modelBuilder.Entity<Category>(entity =>
            {
                _ = entity.ToTable("Category", "dbo");

                _ = entity.HasIndex(e => e.Deleted, "IX_Category_Deleted_Extended");

                _ = entity.HasIndex(e => e.DisplayOrder, "IX_Category_DisplayOrder");

                _ = entity.HasIndex(e => e.LimitedToStores, "IX_Category_LimitedToStores");

                _ = entity.HasIndex(e => e.ParentCategoryId, "IX_Category_ParentCategoryId");

                _ = entity.HasIndex(e => e.SubjectToAcl, "IX_Category_SubjectToAcl");

                _ = entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                _ = entity.Property(e => e.MetaTitle).HasMaxLength(400);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                _ = entity.Property(e => e.PriceFrom).HasColumnType("decimal(19, 5)");

                _ = entity.Property(e => e.PriceTo).HasColumnType("decimal(19, 5)");
            });

            _ = modelBuilder.Entity<CategoryTemplate>(entity =>
            {
                _ = entity.ToTable("CategoryTemplate", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<CheckoutAttribute>(entity =>
            {
                _ = entity.ToTable("CheckoutAttribute", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<CheckoutAttributeValue>(entity =>
            {
                _ = entity.ToTable("CheckoutAttributeValue", "dbo");

                _ = entity.HasIndex(e => e.CheckoutAttributeId, "IX_CheckoutAttributeValue_CheckoutAttributeId");

                _ = entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.CheckoutAttribute)
                    .WithMany(p => p.CheckoutAttributeValues)
                    .HasForeignKey(d => d.CheckoutAttributeId)
                    .HasConstraintName("FK_CheckoutAttributeValue_CheckoutAttributeId_CheckoutAttribute_Id");
            });

            _ = modelBuilder.Entity<Country>(entity =>
            {
                _ = entity.ToTable("Country", "dbo");

                _ = entity.HasIndex(e => e.DisplayOrder, "IX_Country_DisplayOrder");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                _ = entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);

                _ = entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
            });

            _ = modelBuilder.Entity<CrossSellProduct>(entity =>
            {
                _ = entity.ToTable("CrossSellProduct", "dbo");
            });

            _ = modelBuilder.Entity<Currency>(entity =>
            {
                _ = entity.ToTable("Currency", "dbo");

                _ = entity.HasIndex(e => e.DisplayOrder, "IX_Currency_DisplayOrder");

                _ = entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                _ = entity.Property(e => e.CustomFormatting).HasMaxLength(50);

                _ = entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                _ = entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");
            });

            _ = modelBuilder.Entity<Customer>(entity =>
            {
                _ = entity.ToTable("Customer", "dbo");

                _ = entity.HasIndex(e => e.BillingAddressId, "IX_Customer_BillingAddress_Id");

                _ = entity.HasIndex(e => e.CreatedOnUtc, "IX_Customer_CreatedOnUtc");

                _ = entity.HasIndex(e => e.CustomerGuid, "IX_Customer_CustomerGuid");

                _ = entity.HasIndex(e => e.Email, "IX_Customer_Email");

                _ = entity.HasIndex(e => e.ShippingAddressId, "IX_Customer_ShippingAddress_Id");

                _ = entity.HasIndex(e => e.SystemName, "IX_Customer_SystemName");

                _ = entity.HasIndex(e => e.Username, "IX_Customer_Username");

                _ = entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");

                _ = entity.Property(e => e.Email).HasMaxLength(1000);

                _ = entity.Property(e => e.EmailToRevalidate).HasMaxLength(1000);

                _ = entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");

                _ = entity.Property(e => e.SystemName).HasMaxLength(400);

                _ = entity.Property(e => e.Username).HasMaxLength(1000);

                _ = entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.CustomerBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("FK_Customer_BillingAddress_Id_Address_Id");

                _ = entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.CustomerShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("FK_Customer_ShippingAddress_Id_Address_Id");
            });

            _ = modelBuilder.Entity<CustomerAddress>(entity =>
            {
                _ = entity.HasKey(e => new { e.AddressId, e.CustomerId });

                _ = entity.ToTable("CustomerAddresses", "dbo");

                _ = entity.HasIndex(e => e.AddressId, "IX_CustomerAddresses_Address_Id");

                _ = entity.HasIndex(e => e.CustomerId, "IX_CustomerAddresses_Customer_Id");

                _ = entity.Property(e => e.AddressId).HasColumnName("Address_Id");

                _ = entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                _ = entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_CustomerAddresses_Address_Id_Address_Id");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerAddresses_Customer_Id_Customer_Id");
            });

            _ = modelBuilder.Entity<CustomerAttribute>(entity =>
            {
                _ = entity.ToTable("CustomerAttribute", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<CustomerAttributeValue>(entity =>
            {
                _ = entity.ToTable("CustomerAttributeValue", "dbo");

                _ = entity.HasIndex(e => e.CustomerAttributeId, "IX_CustomerAttributeValue_CustomerAttributeId");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.CustomerAttributeValues)
                    .HasForeignKey(d => d.CustomerAttributeId)
                    .HasConstraintName("FK_CustomerAttributeValue_CustomerAttributeId_CustomerAttribute_Id");
            });

            _ = modelBuilder.Entity<CustomerCustomerRoleMapping>(entity =>
            {
                _ = entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId });

                _ = entity.ToTable("Customer_CustomerRole_Mapping", "dbo");

                _ = entity.HasIndex(e => e.CustomerRoleId, "IX_Customer_CustomerRole_Mapping_CustomerRole_Id");

                _ = entity.HasIndex(e => e.CustomerId, "IX_Customer_CustomerRole_Mapping_Customer_Id");

                _ = entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                _ = entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Customer_CustomerRole_Mapping_Customer_Id_Customer_Id");

                _ = entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_Customer_CustomerRole_Mapping_CustomerRole_Id_CustomerRole_Id");
            });

            _ = modelBuilder.Entity<CustomerPassword>(entity =>
            {
                _ = entity.ToTable("CustomerPassword", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_CustomerPassword_CustomerId");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPasswords)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomerPassword_CustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<CustomerRole>(entity =>
            {
                _ = entity.ToTable("CustomerRole", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                _ = entity.Property(e => e.SystemName).HasMaxLength(255);
            });

            _ = modelBuilder.Entity<DeliveryDate>(entity =>
            {
                _ = entity.ToTable("DeliveryDate", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<Discount>(entity =>
            {
                _ = entity.ToTable("Discount", "dbo");

                _ = entity.Property(e => e.CouponCode).HasMaxLength(100);

                _ = entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.MaximumDiscountAmount).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            _ = modelBuilder.Entity<DiscountAppliedToCategory>(entity =>
            {
                _ = entity.HasKey(e => new { e.DiscountId, e.CategoryId });

                _ = entity.ToTable("Discount_AppliedToCategories", "dbo");

                _ = entity.HasIndex(e => e.CategoryId, "IX_Discount_AppliedToCategories_Category_Id");

                _ = entity.HasIndex(e => e.DiscountId, "IX_Discount_AppliedToCategories_Discount_Id");

                _ = entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                _ = entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                _ = entity.HasOne(d => d.Category)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Discount_AppliedToCategories_Category_Id_Category_Id");

                _ = entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Discount_AppliedToCategories_Discount_Id_Discount_Id");
            });

            _ = modelBuilder.Entity<DiscountAppliedToManufacturer>(entity =>
            {
                _ = entity.HasKey(e => new { e.DiscountId, e.ManufacturerId });

                _ = entity.ToTable("Discount_AppliedToManufacturers", "dbo");

                _ = entity.HasIndex(e => e.DiscountId, "IX_Discount_AppliedToManufacturers_Discount_Id");

                _ = entity.HasIndex(e => e.ManufacturerId, "IX_Discount_AppliedToManufacturers_Manufacturer_Id");

                _ = entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                _ = entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_Id");

                _ = entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Discount_AppliedToManufacturers_Discount_Id_Discount_Id");

                _ = entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_Discount_AppliedToManufacturers_Manufacturer_Id_Manufacturer_Id");
            });

            _ = modelBuilder.Entity<DiscountAppliedToProduct>(entity =>
            {
                _ = entity.HasKey(e => new { e.DiscountId, e.ProductId });

                _ = entity.ToTable("Discount_AppliedToProducts", "dbo");

                _ = entity.HasIndex(e => e.DiscountId, "IX_Discount_AppliedToProducts_Discount_Id");

                _ = entity.HasIndex(e => e.ProductId, "IX_Discount_AppliedToProducts_Product_Id");

                _ = entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                _ = entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                _ = entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Discount_AppliedToProducts_Discount_Id_Discount_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Discount_AppliedToProducts_Product_Id_Product_Id");
            });

            _ = modelBuilder.Entity<DiscountRequirement>(entity =>
            {
                _ = entity.ToTable("DiscountRequirement", "dbo");

                _ = entity.HasIndex(e => e.DiscountId, "IX_DiscountRequirement_DiscountId");

                _ = entity.HasIndex(e => e.ParentId, "IX_DiscountRequirement_ParentId");

                _ = entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountRequirements)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_DiscountRequirement_DiscountId_Discount_Id");

                _ = entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_DiscountRequirement_ParentId_DiscountRequirement_Id");
            });

            _ = modelBuilder.Entity<DiscountUsageHistory>(entity =>
            {
                _ = entity.ToTable("DiscountUsageHistory", "dbo");

                _ = entity.HasIndex(e => e.DiscountId, "IX_DiscountUsageHistory_DiscountId");

                _ = entity.HasIndex(e => e.OrderId, "IX_DiscountUsageHistory_OrderId");

                _ = entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountUsageHistories)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_DiscountUsageHistory_DiscountId_Discount_Id");

                _ = entity.HasOne(d => d.Order)
                    .WithMany(p => p.DiscountUsageHistories)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DiscountUsageHistory_OrderId_Order_Id");
            });

            _ = modelBuilder.Entity<Download>(entity =>
            {
                _ = entity.ToTable("Download", "dbo");
            });

            _ = modelBuilder.Entity<EasyPostBatch>(entity =>
            {
                _ = entity.ToTable("EasyPostBatch", "dbo");
            });

            _ = modelBuilder.Entity<EmailAccount>(entity =>
            {
                _ = entity.ToTable("EmailAccount", "dbo");

                _ = entity.Property(e => e.DisplayName).HasMaxLength(255);

                _ = entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                _ = entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                _ = entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                _ = entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            _ = modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
            {
                _ = entity.ToTable("ExternalAuthenticationRecord", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_ExternalAuthenticationRecord_CustomerId");

                _ = entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");

                _ = entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ExternalAuthenticationRecords)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ExternalAuthenticationRecord_CustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<FacebookPixelConfiguration>(entity =>
            {
                _ = entity.ToTable("FacebookPixelConfiguration", "dbo");
            });

            _ = modelBuilder.Entity<ForumsForum>(entity =>
            {
                _ = entity.ToTable("Forums_Forum", "dbo");

                _ = entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Forum_DisplayOrder");

                _ = entity.HasIndex(e => e.ForumGroupId, "IX_Forums_Forum_ForumGroupId");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                _ = entity.HasOne(d => d.ForumGroup)
                    .WithMany(p => p.ForumsForums)
                    .HasForeignKey(d => d.ForumGroupId)
                    .HasConstraintName("FK_Forums_Forum_ForumGroupId_Forums_Group_Id");
            });

            _ = modelBuilder.Entity<ForumsGroup>(entity =>
            {
                _ = entity.ToTable("Forums_Group", "dbo");

                _ = entity.HasIndex(e => e.DisplayOrder, "IX_Forums_Group_DisplayOrder");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            _ = modelBuilder.Entity<ForumsPost>(entity =>
            {
                _ = entity.ToTable("Forums_Post", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_Forums_Post_CustomerId");

                _ = entity.HasIndex(e => e.TopicId, "IX_Forums_Post_TopicId");

                _ = entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress");

                _ = entity.Property(e => e.Text).IsRequired();

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsPosts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_Post_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.Topic)
                    .WithMany(p => p.ForumsPosts)
                    .HasForeignKey(d => d.TopicId)
                    .HasConstraintName("FK_Forums_Post_TopicId_Forums_Topic_Id");
            });

            _ = modelBuilder.Entity<ForumsPostVote>(entity =>
            {
                _ = entity.ToTable("Forums_PostVote", "dbo");

                _ = entity.HasIndex(e => e.ForumPostId, "IX_Forums_PostVote_ForumPostId");

                _ = entity.HasOne(d => d.ForumPost)
                    .WithMany(p => p.ForumsPostVotes)
                    .HasForeignKey(d => d.ForumPostId)
                    .HasConstraintName("FK_Forums_PostVote_ForumPostId_Forums_Post_Id");
            });

            _ = modelBuilder.Entity<ForumsPrivateMessage>(entity =>
            {
                _ = entity.ToTable("Forums_PrivateMessage", "dbo");

                _ = entity.HasIndex(e => e.FromCustomerId, "IX_Forums_PrivateMessage_FromCustomerId");

                _ = entity.HasIndex(e => e.ToCustomerId, "IX_Forums_PrivateMessage_ToCustomerId");

                _ = entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                _ = entity.Property(e => e.Text).IsRequired();

                _ = entity.HasOne(d => d.FromCustomer)
                    .WithMany(p => p.ForumsPrivateMessageFromCustomers)
                    .HasForeignKey(d => d.FromCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_PrivateMessage_FromCustomerId_Customer_Id");

                _ = entity.HasOne(d => d.ToCustomer)
                    .WithMany(p => p.ForumsPrivateMessageToCustomers)
                    .HasForeignKey(d => d.ToCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_PrivateMessage_ToCustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<ForumsSubscription>(entity =>
            {
                _ = entity.ToTable("Forums_Subscription", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_Forums_Subscription_CustomerId");

                _ = entity.HasIndex(e => e.ForumId, "IX_Forums_Subscription_ForumId");

                _ = entity.HasIndex(e => e.TopicId, "IX_Forums_Subscription_TopicId");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsSubscriptions)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_Subscription_CustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<ForumsTopic>(entity =>
            {
                _ = entity.ToTable("Forums_Topic", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_Forums_Topic_CustomerId");

                _ = entity.HasIndex(e => e.ForumId, "IX_Forums_Topic_ForumId");

                _ = entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(450);

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ForumsTopics)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_Topic_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsTopics)
                    .HasForeignKey(d => d.ForumId)
                    .HasConstraintName("FK_Forums_Topic_ForumId_Forums_Forum_Id");
            });

            _ = modelBuilder.Entity<GdprConsent>(entity =>
            {
                _ = entity.ToTable("GdprConsent", "dbo");

                _ = entity.Property(e => e.Message).IsRequired();
            });

            _ = modelBuilder.Entity<GdprLog>(entity =>
            {
                _ = entity.ToTable("GdprLog", "dbo");
            });

            _ = modelBuilder.Entity<GenericAttribute>(entity =>
            {
                _ = entity.ToTable("GenericAttribute", "dbo");

                _ = entity.HasIndex(e => new { e.EntityId, e.KeyGroup }, "IX_GenericAttribute_EntityId_and_KeyGroup");

                _ = entity.Property(e => e.CreatedOrUpdatedDateUtc).HasColumnName("CreatedOrUpdatedDateUTC");

                _ = entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.Value).IsRequired();
            });

            _ = modelBuilder.Entity<GiftCard>(entity =>
            {
                _ = entity.ToTable("GiftCard", "dbo");

                _ = entity.HasIndex(e => e.PurchasedWithOrderItemId, "IX_GiftCard_PurchasedWithOrderItemId");

                _ = entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.PurchasedWithOrderItem)
                    .WithMany(p => p.GiftCards)
                    .HasForeignKey(d => d.PurchasedWithOrderItemId)
                    .HasConstraintName("FK_GiftCard_PurchasedWithOrderItemId_OrderItem_Id");
            });

            _ = modelBuilder.Entity<GiftCardUsageHistory>(entity =>
            {
                _ = entity.ToTable("GiftCardUsageHistory", "dbo");

                _ = entity.HasIndex(e => e.GiftCardId, "IX_GiftCardUsageHistory_GiftCardId");

                _ = entity.HasIndex(e => e.UsedWithOrderId, "IX_GiftCardUsageHistory_UsedWithOrderId");

                _ = entity.Property(e => e.UsedValue).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.GiftCard)
                    .WithMany(p => p.GiftCardUsageHistories)
                    .HasForeignKey(d => d.GiftCardId)
                    .HasConstraintName("FK_GiftCardUsageHistory_GiftCardId_GiftCard_Id");

                _ = entity.HasOne(d => d.UsedWithOrder)
                    .WithMany(p => p.GiftCardUsageHistories)
                    .HasForeignKey(d => d.UsedWithOrderId)
                    .HasConstraintName("FK_GiftCardUsageHistory_UsedWithOrderId_Order_Id");
            });

            _ = modelBuilder.Entity<GoogleAuthenticatorRecord>(entity =>
            {
                _ = entity.ToTable("GoogleAuthenticatorRecord", "dbo");
            });

            _ = modelBuilder.Entity<GoogleProductRecord>(entity =>
            {
                _ = entity.ToTable("GoogleProductRecord", "dbo");
            });

            _ = modelBuilder.Entity<Language>(entity =>
            {
                _ = entity.ToTable("Language", "dbo");

                _ = entity.HasIndex(e => e.DisplayOrder, "IX_Language_DisplayOrder");

                _ = entity.Property(e => e.FlagImageFileName).HasMaxLength(50);

                _ = entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(20);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                _ = entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            _ = modelBuilder.Entity<LocaleStringResource>(entity =>
            {
                _ = entity.ToTable("LocaleStringResource", "dbo");

                _ = entity.HasIndex(e => new { e.ResourceName, e.LanguageId }, "IX_LocaleStringResource");

                _ = entity.HasIndex(e => e.LanguageId, "IX_LocaleStringResource_LanguageId");

                _ = entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                _ = entity.Property(e => e.ResourceValue).IsRequired();

                _ = entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocaleStringResources)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LocaleStringResource_LanguageId_Language_Id");
            });

            _ = modelBuilder.Entity<LocalizedProperty>(entity =>
            {
                _ = entity.ToTable("LocalizedProperty", "dbo");

                _ = entity.HasIndex(e => e.LanguageId, "IX_LocalizedProperty_LanguageId");

                _ = entity.Property(e => e.LocaleKey)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.LocaleKeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.LocaleValue).IsRequired();

                _ = entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocalizedProperties)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LocalizedProperty_LanguageId_Language_Id");
            });

            _ = modelBuilder.Entity<Log>(entity =>
            {
                _ = entity.ToTable("Log", "dbo");

                _ = entity.HasIndex(e => e.CreatedOnUtc, "IX_Log_CreatedOnUtc");

                _ = entity.HasIndex(e => e.CustomerId, "IX_Log_CustomerId");

                _ = entity.Property(e => e.IpAddress).HasMaxLength(200);

                _ = entity.Property(e => e.ShortMessage).IsRequired();

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Log_CustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<Manufacturer>(entity =>
            {
                _ = entity.ToTable("Manufacturer", "dbo");

                _ = entity.HasIndex(e => e.DisplayOrder, "IX_Manufacturer_DisplayOrder");

                _ = entity.HasIndex(e => e.LimitedToStores, "IX_Manufacturer_LimitedToStores");

                _ = entity.HasIndex(e => e.SubjectToAcl, "IX_Manufacturer_SubjectToAcl");

                _ = entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                _ = entity.Property(e => e.MetaTitle).HasMaxLength(400);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                _ = entity.Property(e => e.PriceFrom).HasColumnType("decimal(19, 5)");

                _ = entity.Property(e => e.PriceTo).HasColumnType("decimal(19, 5)");
            });

            _ = modelBuilder.Entity<ManufacturerTemplate>(entity =>
            {
                _ = entity.ToTable("ManufacturerTemplate", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<MeasureDimension>(entity =>
            {
                _ = entity.ToTable("MeasureDimension", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                _ = entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                _ = entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            _ = modelBuilder.Entity<MeasureWeight>(entity =>
            {
                _ = entity.ToTable("MeasureWeight", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                _ = entity.Property(e => e.Ratio).HasColumnType("decimal(18, 8)");

                _ = entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            _ = modelBuilder.Entity<MessageTemplate>(entity =>
            {
                _ = entity.ToTable("MessageTemplate", "dbo");

                _ = entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                _ = entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            _ = modelBuilder.Entity<MigrationVersionInfo>(entity =>
            {
                _ = entity.HasNoKey();

                _ = entity.ToTable("MigrationVersionInfo", "dbo");

                _ = entity.HasIndex(e => e.Version, "UC_Version")
                    .IsUnique()
                    .IsClustered();

                _ = entity.Property(e => e.AppliedOn).HasColumnType("datetime");

                _ = entity.Property(e => e.Description).HasMaxLength(1024);
            });

            _ = modelBuilder.Entity<News>(entity =>
            {
                _ = entity.ToTable("News", "dbo");

                _ = entity.HasIndex(e => e.LanguageId, "IX_News_LanguageId");

                _ = entity.Property(e => e.Full).IsRequired();

                _ = entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                _ = entity.Property(e => e.MetaTitle).HasMaxLength(400);

                _ = entity.Property(e => e.Short).IsRequired();

                _ = entity.Property(e => e.Title).IsRequired();

                _ = entity.HasOne(d => d.Language)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_News_LanguageId_Language_Id");
            });

            _ = modelBuilder.Entity<NewsComment>(entity =>
            {
                _ = entity.ToTable("NewsComment", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_NewsComment_CustomerId");

                _ = entity.HasIndex(e => e.NewsItemId, "IX_NewsComment_NewsItemId");

                _ = entity.HasIndex(e => e.StoreId, "IX_NewsComment_StoreId");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_NewsComment_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.NewsItem)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.NewsItemId)
                    .HasConstraintName("FK_NewsComment_NewsItemId_News_Id");

                _ = entity.HasOne(d => d.Store)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_NewsComment_StoreId_Store_Id");
            });

            _ = modelBuilder.Entity<NewsLetterSubscription>(entity =>
            {
                _ = entity.ToTable("NewsLetterSubscription", "dbo");

                _ = entity.HasIndex(e => new { e.Email, e.StoreId }, "IX_NewsletterSubscription_Email_StoreId");

                _ = entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            _ = modelBuilder.Entity<Order>(entity =>
            {
                _ = entity.ToTable("Order", "dbo");

                _ = entity.HasIndex(e => e.BillingAddressId, "IX_Order_BillingAddressId");

                _ = entity.HasIndex(e => e.CreatedOnUtc, "IX_Order_CreatedOnUtc");

                _ = entity.HasIndex(e => e.CustomerId, "IX_Order_CustomerId");

                _ = entity.HasIndex(e => e.PickupAddressId, "IX_Order_PickupAddressId");

                _ = entity.HasIndex(e => e.ShippingAddressId, "IX_Order_ShippingAddressId");

                _ = entity.Property(e => e.CurrencyRate).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.CustomOrderNumber).IsRequired();

                _ = entity.Property(e => e.OrderDiscount).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderShippingExclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderShippingInclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderSubTotalDiscountExclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderSubTotalDiscountInclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderSubtotalExclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderSubtotalInclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.PaymentMethodAdditionalFeeExclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.PaymentMethodAdditionalFeeInclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.RefundedAmount).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrderBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_BillingAddressId_Address_Id");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.PickupAddress)
                    .WithMany(p => p.OrderPickupAddresses)
                    .HasForeignKey(d => d.PickupAddressId)
                    .HasConstraintName("FK_Order_PickupAddressId_Address_Id");

                _ = entity.HasOne(d => d.RewardPointsHistoryEntry)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RewardPointsHistoryEntryId)
                    .HasConstraintName("FK_Order_RewardPointsHistoryEntryId_RewardPointsHistory_Id");

                _ = entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrderShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("FK_Order_ShippingAddressId_Address_Id");
            });

            _ = modelBuilder.Entity<OrderItem>(entity =>
            {
                _ = entity.ToTable("OrderItem", "dbo");

                _ = entity.HasIndex(e => e.OrderId, "IX_OrderItem_OrderId");

                _ = entity.HasIndex(e => e.ProductId, "IX_OrderItem_ProductId");

                _ = entity.Property(e => e.DiscountAmountExclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.DiscountAmountInclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.ItemWeight).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OriginalProductCost).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.PriceExclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.PriceInclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.UnitPriceExclTax).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderItem_OrderId_Order_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderItem_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<OrderNote>(entity =>
            {
                _ = entity.ToTable("OrderNote", "dbo");

                _ = entity.HasIndex(e => e.OrderId, "IX_OrderNote_OrderId");

                _ = entity.Property(e => e.Note).IsRequired();

                _ = entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderNotes)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderNote_OrderId_Order_Id");
            });

            _ = modelBuilder.Entity<PermissionRecord>(entity =>
            {
                _ = entity.ToTable("PermissionRecord", "dbo");

                _ = entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);

                _ = entity.Property(e => e.Name).IsRequired();

                _ = entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            _ = modelBuilder.Entity<PermissionRecordRoleMapping>(entity =>
            {
                _ = entity.HasKey(e => new { e.PermissionRecordId, e.CustomerRoleId });

                _ = entity.ToTable("PermissionRecord_Role_Mapping", "dbo");

                _ = entity.HasIndex(e => e.CustomerRoleId, "IX_PermissionRecord_Role_Mapping_CustomerRole_Id");

                _ = entity.HasIndex(e => e.PermissionRecordId, "IX_PermissionRecord_Role_Mapping_PermissionRecord_Id");

                _ = entity.Property(e => e.PermissionRecordId).HasColumnName("PermissionRecord_Id");

                _ = entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                _ = entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_PermissionRecord_Role_Mapping_CustomerRole_Id_CustomerRole_Id");

                _ = entity.HasOne(d => d.PermissionRecord)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.PermissionRecordId)
                    .HasConstraintName("FK_PermissionRecord_Role_Mapping_PermissionRecord_Id_PermissionRecord_Id");
            });

            _ = modelBuilder.Entity<Picture>(entity =>
            {
                _ = entity.ToTable("Picture", "dbo");

                _ = entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                _ = entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            _ = modelBuilder.Entity<PictureBinary>(entity =>
            {
                _ = entity.ToTable("PictureBinary", "dbo");

                _ = entity.HasIndex(e => e.PictureId, "IX_PictureBinary_PictureId");

                _ = entity.HasOne(d => d.Picture)
                    .WithMany(p => p.PictureBinaries)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("FK_PictureBinary_PictureId_Picture_Id");
            });

            _ = modelBuilder.Entity<Poll>(entity =>
            {
                _ = entity.ToTable("Poll", "dbo");

                _ = entity.HasIndex(e => e.LanguageId, "IX_Poll_LanguageId");

                _ = entity.Property(e => e.Name).IsRequired();

                _ = entity.HasOne(d => d.Language)
                    .WithMany(p => p.Polls)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_Poll_LanguageId_Language_Id");
            });

            _ = modelBuilder.Entity<PollAnswer>(entity =>
            {
                _ = entity.ToTable("PollAnswer", "dbo");

                _ = entity.HasIndex(e => e.PollId, "IX_PollAnswer_PollId");

                _ = entity.Property(e => e.Name).IsRequired();

                _ = entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollAnswers)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("FK_PollAnswer_PollId_Poll_Id");
            });

            _ = modelBuilder.Entity<PollVotingRecord>(entity =>
            {
                _ = entity.ToTable("PollVotingRecord", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_PollVotingRecord_CustomerId");

                _ = entity.HasIndex(e => e.PollAnswerId, "IX_PollVotingRecord_PollAnswerId");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PollVotingRecords)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_PollVotingRecord_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.PollAnswer)
                    .WithMany(p => p.PollVotingRecords)
                    .HasForeignKey(d => d.PollAnswerId)
                    .HasConstraintName("FK_PollVotingRecord_PollAnswerId_PollAnswer_Id");
            });

            _ = modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
            {
                _ = entity.ToTable("PredefinedProductAttributeValue", "dbo");

                _ = entity.HasIndex(e => e.ProductAttributeId, "IX_PredefinedProductAttributeValue_ProductAttributeId");

                _ = entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.PredefinedProductAttributeValues)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("FK_PredefinedProductAttributeValue_ProductAttributeId_ProductAttribute_Id");
            });

            _ = modelBuilder.Entity<Product>(entity =>
            {
                _ = entity.ToTable("Product", "dbo");

                _ = entity.HasIndex(e => new { e.Deleted, e.VendorId, e.ProductTypeId, e.ManageInventoryMethodId, e.MinStockQuantity, e.UseMultipleWarehouses }, "IX_GetLowStockProducts");

                _ = entity.HasIndex(e => new { e.Deleted, e.Id }, "IX_Product_Delete_Id");

                _ = entity.HasIndex(e => new { e.Published, e.Deleted }, "IX_Product_Deleted_and_Published");

                _ = entity.HasIndex(e => e.LimitedToStores, "IX_Product_LimitedToStores");

                _ = entity.HasIndex(e => e.ParentGroupedProductId, "IX_Product_ParentGroupedProductId");

                _ = entity.HasIndex(e => new { e.Price, e.AvailableStartDateTimeUtc, e.AvailableEndDateTimeUtc, e.Published, e.Deleted }, "IX_Product_PriceDatesEtc");

                _ = entity.HasIndex(e => e.Published, "IX_Product_Published");

                _ = entity.HasIndex(e => e.ShowOnHomepage, "IX_Product_ShowOnHomepage");

                _ = entity.HasIndex(e => e.SubjectToAcl, "IX_Product_SubjectToAcl");

                _ = entity.HasIndex(e => e.VisibleIndividually, "IX_Product_VisibleIndividually");

                _ = entity.HasIndex(e => new { e.VisibleIndividually, e.Published, e.Deleted }, "IX_Product_VisibleIndividually_Published_Deleted_Extended");

                _ = entity.Property(e => e.AdditionalShippingCharge).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);

                _ = entity.Property(e => e.BasepriceAmount).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.BasepriceBaseAmount).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Gtin).HasMaxLength(400);

                _ = entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                _ = entity.Property(e => e.MaximumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                _ = entity.Property(e => e.MetaTitle).HasMaxLength(400);

                _ = entity.Property(e => e.MinimumCustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.OverriddenGiftCardAmount).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.ProductCost).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);

                _ = entity.Property(e => e.Sku).HasMaxLength(400);

                _ = entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
            });

            _ = modelBuilder.Entity<ProductAttribute>(entity =>
            {
                _ = entity.ToTable("ProductAttribute", "dbo");

                _ = entity.Property(e => e.Name).IsRequired();
            });

            _ = modelBuilder.Entity<ProductAttributeCombination>(entity =>
            {
                _ = entity.ToTable("ProductAttributeCombination", "dbo");

                _ = entity.HasIndex(e => e.ProductId, "IX_ProductAttributeCombination_ProductId");

                _ = entity.Property(e => e.Gtin).HasMaxLength(400);

                _ = entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                _ = entity.Property(e => e.OverriddenPrice).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Sku).HasMaxLength(400);

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributeCombinations)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductAttributeCombination_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                _ = entity.ToTable("ProductAttributeValue", "dbo");

                _ = entity.HasIndex(e => e.ProductAttributeMappingId, "IX_ProductAttributeValue_ProductAttributeMappingId");

                _ = entity.HasIndex(e => new { e.ProductAttributeMappingId, e.DisplayOrder }, "IX_ProductAttributeValue_ProductAttributeMappingId_DisplayOrder");

                _ = entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                _ = entity.Property(e => e.Cost).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.ProductAttributeMapping)
                    .WithMany(p => p.ProductAttributeValues)
                    .HasForeignKey(d => d.ProductAttributeMappingId)
                    .HasConstraintName("FK_ProductAttributeValue_ProductAttributeMappingId_Product_ProductAttribute_Mapping_Id");
            });

            _ = modelBuilder.Entity<ProductAvailabilityRange>(entity =>
            {
                _ = entity.ToTable("ProductAvailabilityRange", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<ProductCategoryMapping>(entity =>
            {
                _ = entity.ToTable("Product_Category_Mapping", "dbo");

                _ = entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PCM_ProductId_Extended");

                _ = entity.HasIndex(e => new { e.CategoryId, e.ProductId }, "IX_PCM_Product_and_Category");

                _ = entity.HasIndex(e => e.CategoryId, "IX_Product_Category_Mapping_CategoryId");

                _ = entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Category_Mapping_IsFeaturedProduct");

                _ = entity.HasIndex(e => e.ProductId, "IX_Product_Category_Mapping_ProductId");

                _ = entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_Category_Mapping_CategoryId_Category_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_Category_Mapping_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<ProductManufacturerMapping>(entity =>
            {
                _ = entity.ToTable("Product_Manufacturer_Mapping", "dbo");

                _ = entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PMM_ProductId_Extended");

                _ = entity.HasIndex(e => new { e.ManufacturerId, e.ProductId }, "IX_PMM_Product_and_Manufacturer");

                _ = entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Manufacturer_Mapping_IsFeaturedProduct");

                _ = entity.HasIndex(e => e.ManufacturerId, "IX_Product_Manufacturer_Mapping_ManufacturerId");

                _ = entity.HasIndex(e => e.ProductId, "IX_Product_Manufacturer_Mapping_ProductId");

                _ = entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_Product_Manufacturer_Mapping_ManufacturerId_Manufacturer_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_Manufacturer_Mapping_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<ProductPictureMapping>(entity =>
            {
                _ = entity.ToTable("Product_Picture_Mapping", "dbo");

                _ = entity.HasIndex(e => e.PictureId, "IX_Product_Picture_Mapping_PictureId");

                _ = entity.HasIndex(e => e.ProductId, "IX_Product_Picture_Mapping_ProductId");

                _ = entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("FK_Product_Picture_Mapping_PictureId_Picture_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_Picture_Mapping_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
            {
                _ = entity.ToTable("Product_ProductAttribute_Mapping", "dbo");

                _ = entity.HasIndex(e => e.ProductAttributeId, "IX_Product_ProductAttribute_Mapping_ProductAttributeId");

                _ = entity.HasIndex(e => e.ProductId, "IX_Product_ProductAttribute_Mapping_ProductId");

                _ = entity.HasIndex(e => new { e.ProductId, e.DisplayOrder }, "IX_Product_ProductAttribute_Mapping_ProductId_DisplayOrder");

                _ = entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductProductAttributeMappings)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductAttributeId_ProductAttribute_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductAttributeMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<ProductProductTagMapping>(entity =>
            {
                _ = entity.HasKey(e => new { e.ProductId, e.ProductTagId });

                _ = entity.ToTable("Product_ProductTag_Mapping", "dbo");

                _ = entity.HasIndex(e => e.ProductTagId, "IX_Product_ProductTag_Mapping_ProductTag_Id");

                _ = entity.HasIndex(e => e.ProductId, "IX_Product_ProductTag_Mapping_Product_Id");

                _ = entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                _ = entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_ProductTag_Mapping_Product_Id_Product_Id");

                _ = entity.HasOne(d => d.ProductTag)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductTagId)
                    .HasConstraintName("FK_Product_ProductTag_Mapping_ProductTag_Id_ProductTag_Id");
            });

            _ = modelBuilder.Entity<ProductReview>(entity =>
            {
                _ = entity.ToTable("ProductReview", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_ProductReview_CustomerId");

                _ = entity.HasIndex(e => e.ProductId, "IX_ProductReview_ProductId");

                _ = entity.HasIndex(e => e.StoreId, "IX_ProductReview_StoreId");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ProductReview_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductReview_ProductId_Product_Id");

                _ = entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_ProductReview_StoreId_Store_Id");
            });

            _ = modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
            {
                _ = entity.ToTable("ProductReviewHelpfulness", "dbo");

                _ = entity.HasIndex(e => e.ProductReviewId, "IX_ProductReviewHelpfulness_ProductReviewId");

                _ = entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewHelpfulnesses)
                    .HasForeignKey(d => d.ProductReviewId)
                    .HasConstraintName("FK_ProductReviewHelpfulness_ProductReviewId_ProductReview_Id");
            });

            _ = modelBuilder.Entity<ProductReviewReviewTypeMapping>(entity =>
            {
                _ = entity.ToTable("ProductReview_ReviewType_Mapping", "dbo");

                _ = entity.HasIndex(e => e.ProductReviewId, "IX_ProductReview_ReviewType_Mapping_ProductReviewId");

                _ = entity.HasIndex(e => e.ReviewTypeId, "IX_ProductReview_ReviewType_Mapping_ReviewTypeId");

                _ = entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewReviewTypeMappings)
                    .HasForeignKey(d => d.ProductReviewId)
                    .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ProductReviewId_ProductReview_Id");

                _ = entity.HasOne(d => d.ReviewType)
                    .WithMany(p => p.ProductReviewReviewTypeMappings)
                    .HasForeignKey(d => d.ReviewTypeId)
                    .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ReviewTypeId_ReviewType_Id");
            });

            _ = modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
            {
                _ = entity.ToTable("Product_SpecificationAttribute_Mapping", "dbo");

                _ = entity.HasIndex(e => e.AllowFiltering, "IX_PSAM_AllowFiltering");

                _ = entity.HasIndex(e => new { e.SpecificationAttributeOptionId, e.AllowFiltering }, "IX_PSAM_SpecificationAttributeOptionId_AllowFiltering");

                _ = entity.HasIndex(e => e.ProductId, "IX_Product_SpecificationAttribute_Mapping_ProductId");

                _ = entity.HasIndex(e => e.SpecificationAttributeOptionId, "IX_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId");

                _ = entity.Property(e => e.CustomValue).HasMaxLength(4000);

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_ProductId_Product_Id");

                _ = entity.HasOne(d => d.SpecificationAttributeOption)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.SpecificationAttributeOptionId)
                    .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId_SpecificationAttributeOption_Id");
            });

            _ = modelBuilder.Entity<ProductTag>(entity =>
            {
                _ = entity.ToTable("ProductTag", "dbo");

                _ = entity.HasIndex(e => e.Name, "IX_ProductTag_Name");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<ProductTemplate>(entity =>
            {
                _ = entity.ToTable("ProductTemplate", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<ProductWarehouseInventory>(entity =>
            {
                _ = entity.ToTable("ProductWarehouseInventory", "dbo");

                _ = entity.HasIndex(e => e.ProductId, "IX_ProductWarehouseInventory_ProductId");

                _ = entity.HasIndex(e => e.WarehouseId, "IX_ProductWarehouseInventory_WarehouseId");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductWarehouseInventories)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductWarehouseInventory_ProductId_Product_Id");

                _ = entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ProductWarehouseInventories)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_ProductWarehouseInventory_WarehouseId_Warehouse_Id");
            });

            _ = modelBuilder.Entity<QueuedEmail>(entity =>
            {
                _ = entity.ToTable("QueuedEmail", "dbo");

                _ = entity.HasIndex(e => e.CreatedOnUtc, "IX_QueuedEmail_CreatedOnUtc");

                _ = entity.HasIndex(e => e.EmailAccountId, "IX_QueuedEmail_EmailAccountId");

                _ = entity.HasIndex(e => new { e.SentOnUtc, e.DontSendBeforeDateUtc }, "IX_QueuedEmail_SentOnUtc_DontSendBeforeDateUtc_Extended");

                _ = entity.Property(e => e.Bcc).HasMaxLength(500);

                _ = entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .HasColumnName("CC");

                _ = entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(500);

                _ = entity.Property(e => e.FromName).HasMaxLength(500);

                _ = entity.Property(e => e.ReplyTo).HasMaxLength(500);

                _ = entity.Property(e => e.ReplyToName).HasMaxLength(500);

                _ = entity.Property(e => e.Subject).HasMaxLength(1000);

                _ = entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(500);

                _ = entity.Property(e => e.ToName).HasMaxLength(500);

                _ = entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.QueuedEmails)
                    .HasForeignKey(d => d.EmailAccountId)
                    .HasConstraintName("FK_QueuedEmail_EmailAccountId_EmailAccount_Id");
            });

            _ = modelBuilder.Entity<RecurringPayment>(entity =>
            {
                _ = entity.ToTable("RecurringPayment", "dbo");

                _ = entity.HasIndex(e => e.InitialOrderId, "IX_RecurringPayment_InitialOrderId");

                _ = entity.HasOne(d => d.InitialOrder)
                    .WithMany(p => p.RecurringPayments)
                    .HasForeignKey(d => d.InitialOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurringPayment_InitialOrderId_Order_Id");
            });

            _ = modelBuilder.Entity<RecurringPaymentHistory>(entity =>
            {
                _ = entity.ToTable("RecurringPaymentHistory", "dbo");

                _ = entity.HasIndex(e => e.RecurringPaymentId, "IX_RecurringPaymentHistory_RecurringPaymentId");

                _ = entity.HasOne(d => d.RecurringPayment)
                    .WithMany(p => p.RecurringPaymentHistories)
                    .HasForeignKey(d => d.RecurringPaymentId)
                    .HasConstraintName("FK_RecurringPaymentHistory_RecurringPaymentId_RecurringPayment_Id");
            });

            _ = modelBuilder.Entity<RelatedProduct>(entity =>
            {
                _ = entity.ToTable("RelatedProduct", "dbo");

                _ = entity.HasIndex(e => e.ProductId1, "IX_RelatedProduct_ProductId1");
            });

            _ = modelBuilder.Entity<ReturnRequest>(entity =>
            {
                _ = entity.ToTable("ReturnRequest", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_ReturnRequest_CustomerId");

                _ = entity.Property(e => e.ReasonForReturn).IsRequired();

                _ = entity.Property(e => e.RequestedAction).IsRequired();

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ReturnRequests)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ReturnRequest_CustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<ReturnRequestAction>(entity =>
            {
                _ = entity.ToTable("ReturnRequestAction", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<ReturnRequestReason>(entity =>
            {
                _ = entity.ToTable("ReturnRequestReason", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<ReviewType>(entity =>
            {
                _ = entity.ToTable("ReviewType", "dbo");

                _ = entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<RewardPointsHistory>(entity =>
            {
                _ = entity.ToTable("RewardPointsHistory", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_RewardPointsHistory_CustomerId");

                _ = entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RewardPointsHistories)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_RewardPointsHistory_CustomerId_Customer_Id");
            });

            _ = modelBuilder.Entity<ScheduleTask>(entity =>
            {
                _ = entity.ToTable("ScheduleTask", "dbo");

                _ = entity.Property(e => e.Name).IsRequired();

                _ = entity.Property(e => e.Type).IsRequired();
            });

            _ = modelBuilder.Entity<SearchTerm>(entity =>
            {
                _ = entity.ToTable("SearchTerm", "dbo");
            });

            _ = modelBuilder.Entity<Setting>(entity =>
            {
                _ = entity.ToTable("Setting", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                _ = entity.Property(e => e.Value).IsRequired();
            });

            _ = modelBuilder.Entity<Shipment>(entity =>
            {
                _ = entity.ToTable("Shipment", "dbo");

                _ = entity.HasIndex(e => e.OrderId, "IX_Shipment_OrderId");

                _ = entity.Property(e => e.TotalWeight).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Shipment_OrderId_Order_Id");
            });

            _ = modelBuilder.Entity<ShipmentItem>(entity =>
            {
                _ = entity.ToTable("ShipmentItem", "dbo");

                _ = entity.HasIndex(e => e.ShipmentId, "IX_ShipmentItem_ShipmentId");

                _ = entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_ShipmentItem_ShipmentId_Shipment_Id");
            });

            _ = modelBuilder.Entity<ShippingByWeightByTotalRecord>(entity =>
            {
                _ = entity.ToTable("ShippingByWeightByTotalRecord", "dbo");

                _ = entity.Property(e => e.AdditionalFixedCost).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.LowerWeightLimit).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.OrderSubtotalFrom).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.OrderSubtotalTo).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.PercentageRateOfSubtotal).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.RatePerWeightUnit).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.WeightFrom).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.WeightTo).HasColumnType("decimal(18, 2)");

                _ = entity.Property(e => e.Zip).HasMaxLength(400);
            });

            _ = modelBuilder.Entity<ShippingMethod>(entity =>
            {
                _ = entity.ToTable("ShippingMethod", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<ShippingMethodRestriction>(entity =>
            {
                _ = entity.HasKey(e => new { e.ShippingMethodId, e.CountryId });

                _ = entity.ToTable("ShippingMethodRestrictions", "dbo");

                _ = entity.HasIndex(e => e.CountryId, "IX_ShippingMethodRestrictions_Country_Id");

                _ = entity.HasIndex(e => e.ShippingMethodId, "IX_ShippingMethodRestrictions_ShippingMethod_Id");

                _ = entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethod_Id");

                _ = entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                _ = entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ShippingMethodRestrictions_Country_Id_Country_Id");

                _ = entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .HasConstraintName("FK_ShippingMethodRestrictions_ShippingMethod_Id_ShippingMethod_Id");
            });

            _ = modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                _ = entity.ToTable("ShoppingCartItem", "dbo");

                _ = entity.HasIndex(e => e.CustomerId, "IX_ShoppingCartItem_CustomerId");

                _ = entity.HasIndex(e => e.ProductId, "IX_ShoppingCartItem_ProductId");

                _ = entity.HasIndex(e => new { e.ShoppingCartTypeId, e.CustomerId }, "IX_ShoppingCartItem_ShoppingCartTypeId_CustomerId");

                _ = entity.Property(e => e.CustomerEnteredPrice).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ShoppingCartItem_CustomerId_Customer_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ShoppingCartItem_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<SpecificationAttribute>(entity =>
            {
                _ = entity.ToTable("SpecificationAttribute", "dbo");

                _ = entity.HasIndex(e => e.SpecificationAttributeGroupId, "IX_SpecificationAttribute_SpecificationAttributeGroupId");

                _ = entity.Property(e => e.Name).IsRequired();

                _ = entity.HasOne(d => d.SpecificationAttributeGroup)
                    .WithMany(p => p.SpecificationAttributes)
                    .HasForeignKey(d => d.SpecificationAttributeGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SpecificationAttribute_SpecificationAttributeGroupId_SpecificationAttributeGroup_Id");
            });

            _ = modelBuilder.Entity<SpecificationAttributeGroup>(entity =>
            {
                _ = entity.ToTable("SpecificationAttributeGroup", "dbo");

                _ = entity.Property(e => e.Name).IsRequired();
            });

            _ = modelBuilder.Entity<SpecificationAttributeOption>(entity =>
            {
                _ = entity.ToTable("SpecificationAttributeOption", "dbo");

                _ = entity.HasIndex(e => e.SpecificationAttributeId, "IX_SpecificationAttributeOption_SpecificationAttributeId");

                _ = entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                _ = entity.Property(e => e.Name).IsRequired();

                _ = entity.HasOne(d => d.SpecificationAttribute)
                    .WithMany(p => p.SpecificationAttributeOptions)
                    .HasForeignKey(d => d.SpecificationAttributeId)
                    .HasConstraintName("FK_SpecificationAttributeOption_SpecificationAttributeId_SpecificationAttribute_Id");
            });

            _ = modelBuilder.Entity<StateProvince>(entity =>
            {
                _ = entity.ToTable("StateProvince", "dbo");

                _ = entity.HasIndex(e => e.CountryId, "IX_StateProvince_CountryId");

                _ = entity.Property(e => e.Abbreviation).HasMaxLength(100);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                _ = entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateProvince_CountryId_Country_Id");
            });

            _ = modelBuilder.Entity<StockQuantityHistory>(entity =>
            {
                _ = entity.ToTable("StockQuantityHistory", "dbo");

                _ = entity.HasIndex(e => e.ProductId, "IX_StockQuantityHistory_ProductId");

                _ = entity.HasIndex(e => e.WarehouseId, "IX_StockQuantityHistory_WarehouseId");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockQuantityHistories)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_StockQuantityHistory_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<Store>(entity =>
            {
                _ = entity.ToTable("Store", "dbo");

                _ = entity.Property(e => e.CompanyAddress).HasMaxLength(1000);

                _ = entity.Property(e => e.CompanyName).HasMaxLength(1000);

                _ = entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);

                _ = entity.Property(e => e.CompanyVat).HasMaxLength(1000);

                _ = entity.Property(e => e.Hosts).HasMaxLength(1000);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<StoreMapping>(entity =>
            {
                _ = entity.ToTable("StoreMapping", "dbo");

                _ = entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_StoreMapping_EntityId_EntityName");

                _ = entity.HasIndex(e => e.StoreId, "IX_StoreMapping_StoreId");

                _ = entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreMappings)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_StoreMapping_StoreId_Store_Id");
            });

            _ = modelBuilder.Entity<StorePickupPoint>(entity =>
            {
                _ = entity.ToTable("StorePickupPoint", "dbo");

                _ = entity.Property(e => e.Latitude).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.Longitude).HasColumnType("decimal(18, 4)");

                _ = entity.Property(e => e.PickupFee).HasColumnType("decimal(18, 4)");
            });

            _ = modelBuilder.Entity<SwiperSlide>(entity =>
            {
                _ = entity.ToTable("SwiperSlide", "dbo");
            });

            _ = modelBuilder.Entity<TaxCategory>(entity =>
            {
                _ = entity.ToTable("TaxCategory", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<TaxRate>(entity =>
            {
                _ = entity.ToTable("TaxRate", "dbo");

                _ = entity.Property(e => e.Percentage).HasColumnType("decimal(18, 4)");
            });

            _ = modelBuilder.Entity<TaxTransactionLog>(entity =>
            {
                _ = entity.ToTable("TaxTransactionLog", "dbo");
            });

            _ = modelBuilder.Entity<TierPrice>(entity =>
            {
                _ = entity.ToTable("TierPrice", "dbo");

                _ = entity.HasIndex(e => e.CustomerRoleId, "IX_TierPrice_CustomerRoleId");

                _ = entity.HasIndex(e => e.ProductId, "IX_TierPrice_ProductId");

                _ = entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                _ = entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.TierPrices)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TierPrice_CustomerRoleId_CustomerRole_Id");

                _ = entity.HasOne(d => d.Product)
                    .WithMany(p => p.TierPrices)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TierPrice_ProductId_Product_Id");
            });

            _ = modelBuilder.Entity<Topic>(entity =>
            {
                _ = entity.ToTable("Topic", "dbo");

                _ = entity.HasIndex(e => e.TopicTemplateId, "IX_Topic_TopicTemplateId");
            });

            _ = modelBuilder.Entity<TopicTemplate>(entity =>
            {
                _ = entity.ToTable("TopicTemplate", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<UrlRecord>(entity =>
            {
                _ = entity.ToTable("UrlRecord", "dbo");

                _ = entity.HasIndex(e => new { e.EntityId, e.EntityName, e.LanguageId, e.IsActive }, "IX_UrlRecord_Custom_1");

                _ = entity.HasIndex(e => e.Slug, "IX_UrlRecord_Slug");

                _ = entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<Vendor>(entity =>
            {
                _ = entity.ToTable("Vendor", "dbo");

                _ = entity.Property(e => e.Email).HasMaxLength(400);

                _ = entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                _ = entity.Property(e => e.MetaTitle).HasMaxLength(400);

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                _ = entity.Property(e => e.PriceFrom).HasColumnType("decimal(19, 5)");

                _ = entity.Property(e => e.PriceTo).HasColumnType("decimal(19, 5)");
            });

            _ = modelBuilder.Entity<VendorAttribute>(entity =>
            {
                _ = entity.ToTable("VendorAttribute", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            _ = modelBuilder.Entity<VendorAttributeValue>(entity =>
            {
                _ = entity.ToTable("VendorAttributeValue", "dbo");

                _ = entity.HasIndex(e => e.VendorAttributeId, "IX_VendorAttributeValue_VendorAttributeId");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                _ = entity.HasOne(d => d.VendorAttribute)
                    .WithMany(p => p.VendorAttributeValues)
                    .HasForeignKey(d => d.VendorAttributeId)
                    .HasConstraintName("FK_VendorAttributeValue_VendorAttributeId_VendorAttribute_Id");
            });

            _ = modelBuilder.Entity<VendorNote>(entity =>
            {
                _ = entity.ToTable("VendorNote", "dbo");

                _ = entity.HasIndex(e => e.VendorId, "IX_VendorNote_VendorId");

                _ = entity.Property(e => e.Note).IsRequired();

                _ = entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorNotes)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorNote_VendorId_Vendor_Id");
            });

            _ = modelBuilder.Entity<Warehouse>(entity =>
            {
                _ = entity.ToTable("Warehouse", "dbo");

                _ = entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
