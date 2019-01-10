using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Market.Model;
namespace PostgreSQL
{
    public class EntityContext : DbContext 
    {
        //------------Products-------------------
        public DbSet<Comment> Brands { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Nation> Nations { get; set; }
        public DbSet<MultiMedia> MultiMedias { get; set; }
        public DbSet<MultiMediaType> MultiMediaTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductMultiMedia> ProductMultiMedias { get; set; }
        public DbSet<ProductScore> ProductScores { get; set; }
        public DbSet<ProductSeller> ProductSellers { get; set; }
        public DbSet<ProductSimilar> ProductSimilars { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Similar> Similars { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        //--------------Users----------------
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartRecord> CartRecords { get; set; }
        public DbSet<ChatRecord> ChatRecords { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCart> UserCarts { get; set; }
        public DbSet<UserCartRecord> UserCartRecords { get; set; }
        public DbSet<UserChatRecord> UserChatRecords { get; set; }
        public DbSet<UserContact> UserContacts { get; set; }
        public DbSet<UserRecord> UserRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Market;Userid=pourya;");
    }
}