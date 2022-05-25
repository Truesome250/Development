using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTS.Models.Domain.Employee
{
    public partial class BtDepartment :BaseObject
    {
        [Key]
        public long DeptId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
