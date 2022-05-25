using System.ComponentModel.DataAnnotations;

namespace BTS.Data
{
    public class tbluser
    {

        [Key]
        public string Id { get; set; }

        public string StaffName { get; set; }

        public string StaffNumber { get; set; }

        public string GuarantorName { get; set; }

        public string AddressofStaff { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}