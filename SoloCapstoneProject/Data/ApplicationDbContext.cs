using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoloCapstoneProject.Models;

namespace SoloCapstoneProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = "c2bd7c56-44fc-4428-9761-7c4a046c84e1",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "031cbcf2-b0c6-49d9-9c27-43dad23f5206"
            }
            );

            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = "c9f26a01-0c92-4141-844d-a852e4bba47a",
                Name = "Consumer",
                NormalizedName = "CONSUMER",
                ConcurrencyStamp = "aa96bafb-b331-4f3e-9ffa-815215a27242"
            }
            );

            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = "7c108608-97ee-4366-9b88-b59c0fd72e00",
                Name = "Provider",
                NormalizedName = "PROVIDER",
                ConcurrencyStamp = "f71017c9-571c-4ce5-ae7d-2b59e1296268"
            }
            );

            builder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = "78e5203f-174a-4dca-96cb-40dd2a868205",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAELetqK1tdDcQ1tCJVKaPqBZg9tX1yB03jaIS2odXHCLn4HlHF0uWKN28EdyOf5yb9w==",
                SecurityStamp = "OIAXG7WPVGDGGHI43DKZEH2E76IJ5UJG",
                ConcurrencyStamp = "fd2c3120-eb11-454d-8e13-dcef3c2c65ec",
                PhoneNumber = "000-000-0000",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            },

            new IdentityUser
            {
                Id = "5e1c8b30-314c-44ed-b52d-98df6549b8d8",
                UserName = "consumer1@test.com",
                NormalizedUserName = "CONSUMER1@TEST.COM",
                Email = "consumer1@test.com",
                NormalizedEmail = "CONSUMER1@TEST.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEAWQL9XdogA3L8VqBRDO0jZZXkMdtM22Pg01cpQwu4oZOUN1/wYYRxwIi8ivpJGSUg==",
                SecurityStamp = "HZ3FAHIT2KUMEC7PUCWUR6I5KY36DZFR",
                ConcurrencyStamp = "2fc1dd2e-4196-4b84-b33e-6a2704ac5ba3",
                PhoneNumber = "111-111-1111",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            },

            new IdentityUser
            {
                Id = "67ce75b3-f188-44f1-975f-a650b9c8ad52",
                UserName = "consumer2@test.com",
                NormalizedUserName = "CONSUMER2@TEST.COM",
                Email = "consumer2@test.com",
                NormalizedEmail = "CONSUMER2@TEST.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEK1dB/PVqfTC8DcFiupV/HKn/GGdcvoA3MBoJ2tN9YiZvtn9xwzWAUKSm6WIxUkoSg==",
                SecurityStamp = "YC2OKQG2JDEXUIP6Q6K2XZSR7RYY5Q2Y",
                ConcurrencyStamp = "6bb19bbd-2d15-4abc-83fc-b7f95032ea39",
                PhoneNumber = "222-222-2222",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            },

            new IdentityUser
            {
                Id = "6bd1cc7f-eaa6-4f78-9599-a99f6b1b7593",
                UserName = "consumer3@test.com",
                NormalizedUserName = "CONSUMER3@TEST.COM",
                Email = "consumer3@test.com",
                NormalizedEmail = "CONSUMER3@TEST.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAELLdplS8GfW7zKac+FaD1NfioKkuybbyqEPt2WG8oI7KLloFLkRZhpmcNQhHOE3JJQ==",
                SecurityStamp = "BJXEHOICZWFFMDNRV7AGI2RVZ67ZM3Z3",
                ConcurrencyStamp = "4ef57594-2a66-496d-8c65-fb07bacb25a7",
                PhoneNumber = "333-333-3333",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            },

            new IdentityUser
            {
                Id = "2be63164-b8af-4596-9796-93ff8cec4bf3",
                UserName = "provider1@test.com",
                NormalizedUserName = "PROVIDER1@TEST.COM",
                Email = "provider1@test.com",
                NormalizedEmail = "PROVIDER1@TEST.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEMFLDcxEh+gWl+lnKQOtLBvzvYODU/liVtSTNnj/p5ITsxmajBe6/azXMeUCYwKVkA==",
                SecurityStamp = "HTIXEQVI3JYR65ZTUZTL7AQ57REKRJCK",
                ConcurrencyStamp = "14dbbc88-fd6c-46f7-9ef8-5a5da478afee",
                PhoneNumber = "444-444-4444",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            },

            new IdentityUser
            {
                Id = "eef8a61c-1139-4a74-98f1-e06da7dce470",
                UserName = "provider2@test.com",
                NormalizedUserName = "PROVIDER2@TEST.COM",
                Email = "provider2@test.com",
                NormalizedEmail = "PROVIDER2@TEST.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEPxi84PKc/Sg0cogUGqscB2/U8KQEv9FJCQ8IaCeewrgVa1BZegLI1Wia/v1qSuwGA==",
                SecurityStamp = "JH53TNUXDPNYNVQPH7ISKAIJIZN32ZGF",
                ConcurrencyStamp = "125170f7-525a-4ce3-ad00-2e207d739924",
                PhoneNumber = "555-555-5555",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            },

            new IdentityUser
            {
                Id = "efaef2cb-19ca-4141-9f1b-23f8ca48d99b",
                UserName = "provider3@test.com",
                NormalizedUserName = "PROVIDER3@TEST.COM",
                Email = "provider3@test.com",
                NormalizedEmail = "PROVIDER3@TEST.COM",
                EmailConfirmed = false,
                PasswordHash = "AQAAAAEAACcQAAAAEFDWf0ud4BpCDSyizTthtta/CRBm+5vYGv0UNuJ3LbrNakXq23qgzhBWVquC4PR/pg==",
                SecurityStamp = "EJ6OCU5B4QALLAHLLIL3LFSZVCS3BJB7",
                ConcurrencyStamp = "ebc8172e-ad24-43d7-8833-f790bb180d88",
                PhoneNumber = "666-666-6666",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
            }





        );

            builder.Entity<Consumer>().HasData(
                new Consumer { ConsumerId = 1, Address = "7814 W Silver Spring Drive", City = "Milwaukee", FirstName = "Jacob", LastName = "Townsend", State = "Wisconsin", Zipcode = "53218", IdentityUserId= "5e1c8b30-314c-44ed-b52d-98df6549b8d8" },
                new Consumer { ConsumerId = 2, Address = "8848 N 95th Street", City = "Milwaukee", FirstName = "Eli", LastName = "Manny", State = "Wisconsin", Zipcode = "53224", IdentityUserId= "67ce75b3-f188-44f1-975f-a650b9c8ad52" },
                new Consumer { ConsumerId = 3, Address = "9100 W Oklahoma Ave", City = "Milwaukee", FirstName = "Steve", LastName = "Rogers", State = "Wisconsin", Zipcode = "53227", IdentityUserId= "6bd1cc7f-eaa6-4f78-9599-a99f6b1b7593" });

            builder.Entity<Provider>().HasData(
                new Provider { ProviderId = 1, FirstName = "Peter", LastName = "Parker", Address = "5339 W Radcliffe Drive", City = "Brown Deer", State = "Wisconsin", Zipcode = "53223", IdentityUserId = "2be63164-b8af-4596-9796-93ff8cec4bf3" },
                new Provider { ProviderId = 2, FirstName = "Clark", LastName = "Kent", Address = "5391 W Radcliffe Drive", City = "Brown Deer", State = "Wisconsin", Zipcode = "53223", IdentityUserId = "eef8a61c-1139-4a74-98f1-e06da7dce470" },
                new Provider { ProviderId = 3, FirstName = "Barry", LastName = "Allen", Address = "5305 W Radcliffe Drive", City = "Brown Deer", State = "Wisconsin", Zipcode = "53223", IdentityUserId = "efaef2cb-19ca-4141-9f1b-23f8ca48d99b" }
                );


        }


        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProviderSchedule> ProviderAvailabilities { get; set; }

    }
}
