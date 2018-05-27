using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMIC.SyncModule.EntityObject
{
    public class StudentObject
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Nullable<bool> HVTiemNang { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<System.DateTime> DateBirthday { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> DateRegister { get; set; }
        public Nullable<System.DateTime> DateLastUpdate { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsTested { get; set; }
        public string MarkTest { get; set; }
        public Nullable<bool> IsRegistered { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string IdentityNumber { get; set; }
        public Nullable<System.DateTime> DateIssue { get; set; }
        public string PlaceIssue { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<double> Bonus { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> IdPolicyStudent { get; set; }
        public Nullable<double> Price { get; set; }

        public StudentObject(int id, string firstName, string lastName, string fullName, Nullable<int> sex,
            Nullable<System.DateTime> dateBirthday, string mobile, string email, string address,
            Nullable<System.DateTime> dateCreate, Nullable<System.DateTime> dateLastUpdate, string description,
            Nullable<int> courseId, Nullable<int> statusId, Nullable<int> userId)
        {
            this.Id = id; this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.Sex = sex;
            this.DateBirthday = dateBirthday;
            this.Mobile = mobile;
            this.Email = email;
            this.Address = address;
            this.DateCreate = dateCreate;
            this.DateLastUpdate = dateLastUpdate;
            this.Description = description;
            this.CourseId = courseId;
            this.StatusId = statusId;
            this.UserId = userId;
        }
    }
}
