using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.VALUEOBJECTS
{
    public class AmountStudentClass
    {
        public int id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public string ClassName { get; set; }
        public float TotalPrice { get; set; }
        public float Price1 { get; set; }
        public float Price2 { get; set; }
        public float Price3 { get; set; }
        public float MustPay { get; set; }
        public string Status { get; set; }
        public int UserIdConfirm { get; set; }
        public string TrangThaiTT { get; set; }
        public string Description { get; set; }

    }
}
