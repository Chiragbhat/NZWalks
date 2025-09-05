using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContexts : IdentityDbContext
    {
        public NZWalksAuthDbContexts(DbContextOptions<NZWalksAuthDbContexts> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "44b90b5c-dfb1-4ff9-9259-226e6697372b";
            var writerRoleID = "cf9c7621-9416-4ab4-baaf-00cfc07f7bb2";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleID,
                    ConcurrencyStamp = writerRoleID,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
