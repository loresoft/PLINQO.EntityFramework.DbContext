﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Data.Entities
{
    public partial class Product
    {
        public Product()
        {
            MakeFlag = true;
            FinishedGoodsFlag = true;
            ModifiedDate = DateTime.Now;
            ComponentBillOfMaterials = new List<BillOfMaterials>();
            AssemblyBillOfMaterials = new List<BillOfMaterials>();
            ProductCostHistories = new List<ProductCostHistory>();
            Documents = new List<Document>();
            ProductInventories = new List<ProductInventory>();
            ProductListPriceHistories = new List<ProductListPriceHistory>();
            ProductPhotos = new List<ProductPhoto>();
            ProductReviews = new List<ProductReview>();
            TransactionHistories = new List<TransactionHistory>();
            WorkOrders = new List<WorkOrder>();
            ProductVendors = new List<ProductVendor>();
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            ShoppingCartItems = new List<ShoppingCartItem>();
            SpecialOffers = new List<SpecialOffer>();
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int? ProductSubcategoryID { get; set; }
        public int? ProductModelID { get; set; }
        public System.DateTime SellStartDate { get; set; }
        public System.DateTime? SellEndDate { get; set; }
        public System.DateTime? DiscontinuedDate { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual ICollection<BillOfMaterials> ComponentBillOfMaterials { get; set; }
        public virtual ICollection<BillOfMaterials> AssemblyBillOfMaterials { get; set; }
        public virtual ProductModel ProductModel { get; set; }
        public virtual ProductSubcategory ProductSubcategory { get; set; }
        public virtual UnitMeasure SizeUnitMeasure { get; set; }
        public virtual UnitMeasure WeightUnitMeasure { get; set; }
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<ProductInventory> ProductInventories { get; set; }
        public virtual ICollection<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
        public virtual ICollection<ProductReview> ProductReviews { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<ProductVendor> ProductVendors { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual ICollection<SpecialOffer> SpecialOffers { get; set; }
    }
}