//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace IMIC.VALUEOBJECTS
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public string Address { get; set; }
        public string Contents { get; set; }
        public string LinkName { get; set; }
        public string Avatar { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public string Notes { get; set; }
        public Nullable<int> CenterId { get; set; }
        public Nullable<int> OrderNumber { get; set; }
    }
}
