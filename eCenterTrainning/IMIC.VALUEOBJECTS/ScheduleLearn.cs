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
    public class ScheduleLearn
    {
        public int Id { get; set; }
        public string ScheduleName { get; set; }
        public string Lecturer1 { get; set; }
        public string Lecturer2 { get; set; }
        public string Address { get; set; }
        public Nullable<System.TimeSpan> TimeLearn { get; set; }
        public string DaysLearn { get; set; }
        public string Notes { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> ExpertId { get; set; }
        public Nullable<int> RoomId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<int> Priority { get; set; }
    }
}
