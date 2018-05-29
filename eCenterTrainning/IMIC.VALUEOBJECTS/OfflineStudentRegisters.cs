using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.VALUEOBJECTS
{
    public class OfflineStudentRegisters
    {
        public Guid RegisterDetailId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Message { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool isDeleted { get; set; }
        public bool isSeen { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string UserName { get; set; }
    }
}
