using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCenterTrainning.Objects
{
    public class StudentForClassObject
    {
       public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime? DateBirthday { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Sex { get; set; }

        public double? TotalPrice { get; set; }
        public double? MustPay { get; set; }
        public double? Price1 { get; set; }
        public double? Price2 { get; set; }
        public double? Price3 { get; set; }
    }
}
