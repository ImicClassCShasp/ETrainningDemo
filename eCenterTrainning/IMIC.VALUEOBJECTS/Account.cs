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
    public class Account
    {
        public int UserId { get; set; }
        public string UserName { get; set; }       
        public Nullable<bool> IsSuperUser { get; set; }        
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }        
        public Nullable<bool> IsDeleted { get; set; }       
        public Nullable<int> Sex { get; set; }      
        public bool isSuccess { get; set; }

        /* isOnline = True | isOnline = False */
        public bool isOnline { get; set; }

        /* sLocation = "HaNoi | sLocation = "HoChiMinh" */
        public string sLocation { get; set; }

        /* isClose = true: Exit login */
        public bool isClose { get; set; }
        public string DisplaySex { get; set; }
        public int? isAdmin { get; set; }
        public List<stanfTabPermission> ListTabPermissions { get; set; }
    }
}



