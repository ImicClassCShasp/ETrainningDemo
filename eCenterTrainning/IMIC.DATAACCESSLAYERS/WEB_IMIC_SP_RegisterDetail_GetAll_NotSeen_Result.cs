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
    
    public partial class WEB_IMIC_SP_RegisterDetail_GetAll_NotSeen_Result
    {
        public System.Guid RegisterDetailId { get; set; }
        public Nullable<System.Guid> ClassId { get; set; }
        public Nullable<System.Guid> RegisterPersonId { get; set; }
        public string Message { get; set; }
        public string Comment { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<bool> IsSeen { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> CourseId { get; set; }
    }
}
