using JobDex.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobDex.Server.Configurations.Entities
{
    public class UserDetailSeedConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserDetails> builder)
        {
            builder.HasData(
                new UserDetails
                {
                    Id = 1,
                    UserName = "Jake",
                    UserEmail = "Jake@gmail.com",
                    UserNo = 97814201,
                    UserAddress = "punggol",
                    UserCStatus = "PR",
                    UserEStatus = "employed",
                    UserPwd = "Jake01",
                    UserDOB = new DateTime(2004, 11, 1),
                    DateCreated = DateTime.Now


                });


        }
    }
}
