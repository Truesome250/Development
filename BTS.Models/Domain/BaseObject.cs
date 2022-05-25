using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Models.Domain
{
    public class BaseObject
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
