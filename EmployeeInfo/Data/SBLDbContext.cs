using EmployeeInfo.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Data
{
    public class SBLDbContext:IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public SBLDbContext(DbContextOptions<SBLDbContext> options, IHttpContextAccessor httpContextAccessor):base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public DbSet<CustomerRequsition> CustomerRequsitions { get; set; }
    }
}
