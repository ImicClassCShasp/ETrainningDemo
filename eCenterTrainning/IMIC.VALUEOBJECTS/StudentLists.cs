using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.VALUEOBJECTS
{
    public class StudentLists
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string SexString { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<System.DateTime> DateBirthday { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateCreate { get; set; }
        public string Description { get; set; }               
        public Nullable<int> CourseId { get; set; }        
        public Nullable<int> StatusId { get; set; }        
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public string CourseName { get; set; }
        public string StatusName { get; set; }        
    }
}
