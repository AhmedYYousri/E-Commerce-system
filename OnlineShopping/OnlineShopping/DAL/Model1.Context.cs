﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbMyOnilineShoppingEntities1 : DbContext
    {
        public dbMyOnilineShoppingEntities1()
            : base("name=dbMyOnilineShoppingEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SlideImage> SlideImages { get; set; }
        public virtual DbSet<Tbl_MemberRole> Tbl_MemberRole { get; set; }
        public virtual DbSet<Tbl_Members> Tbl_Members { get; set; }
        public virtual DbSet<Tbl_Roles> Tbl_Roles { get; set; }
        public virtual DbSet<Tbl_ShoppingDetails> Tbl_ShoppingDetails { get; set; }
        public virtual DbSet<Tble_Cart> Tble_Cart { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_CartStatus> Tbl_CartStatus { get; set; }
        public virtual DbSet<Tbl_Product> Tbl_Product { get; set; }
    }
}
