using BTS.Models.Domain.Auth;
using BTS.Models.Domain.Employee;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Infrastructure
{
    //Here we are linking the DataContext with the Authentication Context
    //Read about Identity COntext
    public class BtsDbContext : IdentityDbContext<BtUser, BtRole, string>
    {
        public BtsDbContext(DbContextOptions<BtsDbContext> options) : base(options)
        {

        }

        #region Auth
        public virtual DbSet<BtPermission> BtPermissions { get; set; }
        public virtual DbSet<BtUserLoginHistory> BtUserLoginHistory { get; set; }
        public virtual DbSet<BtUsersPasswordHist> BtUsersPasswordHist { get; set; }
        public virtual DbSet<BtUserRole> BtUserRole { get; set; }
        public virtual DbSet<BtEmployee> BtEmployee { get; set; }
        public virtual DbSet<BtDepartment> BtDepartments { get; set; }
        #endregion
    }
}
