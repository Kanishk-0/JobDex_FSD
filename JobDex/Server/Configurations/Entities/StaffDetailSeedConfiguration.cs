using JobDex.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobDex.Server.Configurations.Entities
{
    public class StaffDetailSeedConfiguration : IEntityTypeConfiguration<StaffDetails>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<StaffDetails> builder)
        {
            builder.HasData(
                new StaffDetails
                {
                    Id = 1,
                    StaffName = "Jaake",
                    StaffEmail = "Jaake@gmail.com",
                    StaffNo = 97814201,
                    StaffPwd = "Jake01",
                    DateCreated = DateTime.Now


                });


        }
    }
}
