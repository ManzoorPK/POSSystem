//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS_System.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceV
    {
        public int InvoiceId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string AccountCode { get; set; }
        public string AccountType { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<int> PaymentMethodId { get; set; }
        public string Email { get; set; }
        public string CellNo { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> OpenBalance { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<decimal> TotalPayment { get; set; }
        public Nullable<decimal> Paid { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<decimal> Additional { get; set; }
        public Nullable<decimal> AdditionalAmount { get; set; }
        public Nullable<decimal> FinalTotal { get; set; }
        public string InvoiceType { get; set; }
    }
}
