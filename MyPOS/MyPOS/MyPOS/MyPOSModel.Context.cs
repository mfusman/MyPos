﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPOS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyPOSContext : DbContext
    {
        public MyPOSContext()
            : base("name=MyPOSContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<ListType> ListTypes { get; set; }
        public virtual DbSet<ListTypesData> ListTypesDatas { get; set; }
        public virtual DbSet<LoginUser> LoginUsers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSize> ProductSizes { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
    
        public virtual ObjectResult<ups_Products_LoadAllProductsByProductName_Result> ups_Products_LoadAllProductsByProductName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ups_Products_LoadAllProductsByProductName_Result>("ups_Products_LoadAllProductsByProductName", nameParameter);
        }
    
        public virtual ObjectResult<ups_Products_LoadAllProductsForDataGridView_Result> ups_Products_LoadAllProductsForDataGridView()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ups_Products_LoadAllProductsForDataGridView_Result>("ups_Products_LoadAllProductsForDataGridView");
        }
    
        public virtual ObjectResult<usp_ListTypesData_LoadDataIntoComboBox_Result> usp_ListTypesData_LoadDataIntoComboBox(Nullable<int> listTypeID)
        {
            var listTypeIDParameter = listTypeID.HasValue ?
                new ObjectParameter("ListTypeID", listTypeID) :
                new ObjectParameter("ListTypeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListTypesData_LoadDataIntoComboBox_Result>("usp_ListTypesData_LoadDataIntoComboBox", listTypeIDParameter);
        }
    
        public virtual ObjectResult<string> usp_Login_verifyLoginDetails(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_Login_verifyLoginDetails", userNameParameter, passwordParameter);
        }
    
        public virtual int usp_Products_DeleteProductAndSizes(Nullable<int> productID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Products_DeleteProductAndSizes", productIDParameter);
        }
    
        public virtual int usp_Products_InsertCustomerInfo(string name, string mobile, string address)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Products_InsertCustomerInfo", nameParameter, mobileParameter, addressParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> usp_Products_InsertNewProductt(string name, Nullable<int> categoryID, Nullable<int> supplierID, Nullable<decimal> purchasePrice, Nullable<decimal> salesPrice)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(int));
    
            var supplierIDParameter = supplierID.HasValue ?
                new ObjectParameter("SupplierID", supplierID) :
                new ObjectParameter("SupplierID", typeof(int));
    
            var purchasePriceParameter = purchasePrice.HasValue ?
                new ObjectParameter("PurchasePrice", purchasePrice) :
                new ObjectParameter("PurchasePrice", typeof(decimal));
    
            var salesPriceParameter = salesPrice.HasValue ?
                new ObjectParameter("SalesPrice", salesPrice) :
                new ObjectParameter("SalesPrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("usp_Products_InsertNewProductt", nameParameter, categoryIDParameter, supplierIDParameter, purchasePriceParameter, salesPriceParameter);
        }
    
        public virtual int usp_Products_InsertProductSizes(Nullable<int> productID, Nullable<int> sizeID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            var sizeIDParameter = sizeID.HasValue ?
                new ObjectParameter("SizeID", sizeID) :
                new ObjectParameter("SizeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Products_InsertProductSizes", productIDParameter, sizeIDParameter);
        }
    
        public virtual ObjectResult<usp_Sizes_LoadAllSizes_Result> usp_Sizes_LoadAllSizes(Nullable<int> listTypeID)
        {
            var listTypeIDParameter = listTypeID.HasValue ?
                new ObjectParameter("ListTypeID", listTypeID) :
                new ObjectParameter("ListTypeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Sizes_LoadAllSizes_Result>("usp_Sizes_LoadAllSizes", listTypeIDParameter);
        }
    }
}