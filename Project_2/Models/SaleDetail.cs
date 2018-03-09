//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class SaleDetail
    {
        public int SaleDetailKey { get; set; }
        [DisplayName("Sale No.")]
        public Nullable<int> SaleKey { get; set; }
        public Nullable<int> ProductKey { get; set; }
        [DisplayName("Price")]
        public decimal SaleDetailPriceCharged { get; set; }
        [DisplayName("Quantity")]
        public int SaleDetailQuantity { get; set; }
        [DisplayName("Discount")]
        public Nullable<decimal> SaleDetailDiscount { get; set; }
        [DisplayName("Tax Percent")]
        public Nullable<decimal> SaleDetailSaleTaxPercent { get; set; }
        [DisplayName("Eat In Tax")]
        public Nullable<decimal> SaleDetailEatInTax { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
