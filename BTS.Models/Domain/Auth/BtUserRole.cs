using Microsoft.AspNetCore.Identity;
using System;

namespace BTS.Models.Domain.Auth
{
    public class ApplicationUserClaim : IdentityUserClaim<string> { }
    public class ApplicationUserLogin : IdentityUserLogin<string> { }
    public class ApplicationRoleClaim : IdentityRoleClaim<string> { }
    public class BtUserRole : IdentityUserRole<string>
    {
        public BtUserRole()
            : base()
        { }

        public DateTime? LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "System";
    }
}
