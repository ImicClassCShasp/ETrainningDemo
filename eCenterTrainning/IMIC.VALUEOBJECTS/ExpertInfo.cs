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
    public class ExpertInfo
    {
        public int Id { get; set; }
        public string ExpertName { get; set; }
        public Nullable<System.DateTime> DateBirthday { get; set; }
        public Nullable<int> Sex { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public Nullable<int> YearsExperience { get; set; }
        public string UniversityDegree { get; set; }
        public Nullable<int> CenterId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string ExpertCV { get; set; }
        /// <summary>
        /// Author          Date        Comment
        /// TungVP          31-05-2018  Add 2 field iFlag, CenterName & sSex
        /// </summary>
        public string CenterName { get; set; }
        public string sSex { get; set; }
        public int iFlag { get; set; }
    }
}