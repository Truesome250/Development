using System;

namespace BTS.Models.Domain.Employee
{
    public partial class BtEmployee : BaseObject
    {
        public long EmpId { get; set; }
        public string AppUserId { get; set; }
        public string StaffCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Passport { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public int? StateOfOrgin { get; set; }
        public int? Lga { get; set; }
        public long? CurrentDeptId { get; set; }
    }
}
