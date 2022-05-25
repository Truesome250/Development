using Microsoft.AspNetCore.Identity;
using System;

namespace BTS.Models.Domain.Auth
{
    public class BtRole : IdentityRole
    {
        public BtRole()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string PermissionsInRole { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsSuperUser { get; set; }
        public string RoleDesc { get; set; }
        public bool IsActive { get; set; }
        public long HospitalId { get; set; }
    }
}
