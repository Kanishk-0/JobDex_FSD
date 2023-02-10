using IdentityServer4.EntityFramework.Options;
using JobDex.Server.Configurations.Entities;
using JobDex.Server.Models;
using JobDex.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobDex.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }


        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<StaffDetails> StaffDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserDetailSeedConfiguration());
            builder.ApplyConfiguration(new StaffDetailSeedConfiguration());
        }
    }
}
