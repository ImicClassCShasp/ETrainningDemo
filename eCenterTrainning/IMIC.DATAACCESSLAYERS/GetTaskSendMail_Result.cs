//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMIC.DATAACCESSLAYERS
{
    using System;
    
    public partial class GetTaskSendMail_Result
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string CreateBy { get; set; }
        public Nullable<int> CreateByUserId { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<bool> IsSendMail { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> Importance { get; set; }
        public string LinkSource { get; set; }
        public Nullable<int> CategoryId { get; set; }
    }
}