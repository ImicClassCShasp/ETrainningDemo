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
    public class PolicyStudent
    {
        public int Id { get; set; }
        public string PolicyName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> DateLastUpdate { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<System.DateTime> DateApproved { get; set; }
        public string Contents { get; set; }
        public string Avatar { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> CenterId { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public Nullable<double> Bonus { get; set; }
    }
}
