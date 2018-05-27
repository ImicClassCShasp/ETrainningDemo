using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.VALUEOBJECTS
{
    public class StudentClasses
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string sSex { get; set; }
        public int Sex { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DateStart { get; set; }
        public int TotalPrice { get; set; }
        public int Price1 { get; set; }
        public int Price2 { get; set; }
        public int Price3 { get; set; }
        public int MustPay { get; set; }
    }
}
