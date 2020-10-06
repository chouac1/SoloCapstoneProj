﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoloCapstoneProject.Data;

namespace SoloCapstoneProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c2bd7c56-44fc-4428-9761-7c4a046c84e1",
                            ConcurrencyStamp = "031cbcf2-b0c6-49d9-9c27-43dad23f5206",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c9f26a01-0c92-4141-844d-a852e4bba47a",
                            ConcurrencyStamp = "aa96bafb-b331-4f3e-9ffa-815215a27242",
                            Name = "Consumer",
                            NormalizedName = "CONSUMER"
                        },
                        new
                        {
                            Id = "7c108608-97ee-4366-9b88-b59c0fd72e00",
                            ConcurrencyStamp = "f71017c9-571c-4ce5-ae7d-2b59e1296268",
                            Name = "Provider",
                            NormalizedName = "PROVIDER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "78e5203f-174a-4dca-96cb-40dd2a868205",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fd2c3120-eb11-454d-8e13-dcef3c2c65ec",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELetqK1tdDcQ1tCJVKaPqBZg9tX1yB03jaIS2odXHCLn4HlHF0uWKN28EdyOf5yb9w==",
                            PhoneNumber = "000-000-0000",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "OIAXG7WPVGDGGHI43DKZEH2E76IJ5UJG",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "5e1c8b30-314c-44ed-b52d-98df6549b8d8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2fc1dd2e-4196-4b84-b33e-6a2704ac5ba3",
                            Email = "consumer1@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CONSUMER1@TEST.COM",
                            NormalizedUserName = "CONSUMER1@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAWQL9XdogA3L8VqBRDO0jZZXkMdtM22Pg01cpQwu4oZOUN1/wYYRxwIi8ivpJGSUg==",
                            PhoneNumber = "111-111-1111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "HZ3FAHIT2KUMEC7PUCWUR6I5KY36DZFR",
                            TwoFactorEnabled = false,
                            UserName = "consumer1@test.com"
                        },
                        new
                        {
                            Id = "67ce75b3-f188-44f1-975f-a650b9c8ad52",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6bb19bbd-2d15-4abc-83fc-b7f95032ea39",
                            Email = "consumer2@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CONSUMER2@TEST.COM",
                            NormalizedUserName = "CONSUMER2@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK1dB/PVqfTC8DcFiupV/HKn/GGdcvoA3MBoJ2tN9YiZvtn9xwzWAUKSm6WIxUkoSg==",
                            PhoneNumber = "222-222-2222",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "YC2OKQG2JDEXUIP6Q6K2XZSR7RYY5Q2Y",
                            TwoFactorEnabled = false,
                            UserName = "consumer2@test.com"
                        },
                        new
                        {
                            Id = "6bd1cc7f-eaa6-4f78-9599-a99f6b1b7593",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ef57594-2a66-496d-8c65-fb07bacb25a7",
                            Email = "consumer3@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "CONSUMER3@TEST.COM",
                            NormalizedUserName = "CONSUMER3@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELLdplS8GfW7zKac+FaD1NfioKkuybbyqEPt2WG8oI7KLloFLkRZhpmcNQhHOE3JJQ==",
                            PhoneNumber = "333-333-3333",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "BJXEHOICZWFFMDNRV7AGI2RVZ67ZM3Z3",
                            TwoFactorEnabled = false,
                            UserName = "consumer3@test.com"
                        },
                        new
                        {
                            Id = "2be63164-b8af-4596-9796-93ff8cec4bf3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "14dbbc88-fd6c-46f7-9ef8-5a5da478afee",
                            Email = "provider1@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "PROVIDER1@TEST.COM",
                            NormalizedUserName = "PROVIDER1@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMFLDcxEh+gWl+lnKQOtLBvzvYODU/liVtSTNnj/p5ITsxmajBe6/azXMeUCYwKVkA==",
                            PhoneNumber = "444-444-4444",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "HTIXEQVI3JYR65ZTUZTL7AQ57REKRJCK",
                            TwoFactorEnabled = false,
                            UserName = "provider1@test.com"
                        },
                        new
                        {
                            Id = "eef8a61c-1139-4a74-98f1-e06da7dce470",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "125170f7-525a-4ce3-ad00-2e207d739924",
                            Email = "provider2@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "PROVIDER2@TEST.COM",
                            NormalizedUserName = "PROVIDER2@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPxi84PKc/Sg0cogUGqscB2/U8KQEv9FJCQ8IaCeewrgVa1BZegLI1Wia/v1qSuwGA==",
                            PhoneNumber = "555-555-5555",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "JH53TNUXDPNYNVQPH7ISKAIJIZN32ZGF",
                            TwoFactorEnabled = false,
                            UserName = "provider2@test.com"
                        },
                        new
                        {
                            Id = "efaef2cb-19ca-4141-9f1b-23f8ca48d99b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ebc8172e-ad24-43d7-8833-f790bb180d88",
                            Email = "provider3@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "PROVIDER3@TEST.COM",
                            NormalizedUserName = "PROVIDER3@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFDWf0ud4BpCDSyizTthtta/CRBm+5vYGv0UNuJ3LbrNakXq23qgzhBWVquC4PR/pg==",
                            PhoneNumber = "666-666-6666",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "EJ6OCU5B4QALLAHLLIL3LFSZVCS3BJB7",
                            TwoFactorEnabled = false,
                            UserName = "provider3@test.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Consumer", b =>
                {
                    b.Property<int>("ConsumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConsumerId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Consumers");

                    b.HasData(
                        new
                        {
                            ConsumerId = 1,
                            Address = "7814 W Silver Spring Drive",
                            City = "Milwaukee",
                            FirstName = "Jacob",
                            IdentityUserId = "5e1c8b30-314c-44ed-b52d-98df6549b8d8",
                            LastName = "Townsend",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            State = "Wisconsin",
                            Zipcode = "53218"
                        },
                        new
                        {
                            ConsumerId = 2,
                            Address = "8848 N 95th Street",
                            City = "Milwaukee",
                            FirstName = "Eli",
                            IdentityUserId = "67ce75b3-f188-44f1-975f-a650b9c8ad52",
                            LastName = "Manny",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            State = "Wisconsin",
                            Zipcode = "53224"
                        },
                        new
                        {
                            ConsumerId = 3,
                            Address = "9100 W Oklahoma Ave",
                            City = "Milwaukee",
                            FirstName = "Steve",
                            IdentityUserId = "6bd1cc7f-eaa6-4f78-9599-a99f6b1b7593",
                            LastName = "Rogers",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            State = "Wisconsin",
                            Zipcode = "53227"
                        });
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsumerComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsumerId")
                        .HasColumnType("int");

                    b.Property<string>("ProviderComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("ServiceDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAppointConfirmed")
                        .HasColumnType("bit");

                    b.HasKey("OrderId");

                    b.HasIndex("ConsumerId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Provider", b =>
                {
                    b.Property<int>("ProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Services")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProviderId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Providers");

                    b.HasData(
                        new
                        {
                            ProviderId = 1,
                            Address = "5339 W Radcliffe Drive",
                            City = "Brown Deer",
                            FirstName = "Peter",
                            IdentityUserId = "2be63164-b8af-4596-9796-93ff8cec4bf3",
                            LastName = "Parker",
                            Rating = 0.0,
                            State = "Wisconsin",
                            Zipcode = "53223"
                        },
                        new
                        {
                            ProviderId = 2,
                            Address = "5391 W Radcliffe Drive",
                            City = "Brown Deer",
                            FirstName = "Clark",
                            IdentityUserId = "eef8a61c-1139-4a74-98f1-e06da7dce470",
                            LastName = "Kent",
                            Rating = 0.0,
                            State = "Wisconsin",
                            Zipcode = "53223"
                        },
                        new
                        {
                            ProviderId = 3,
                            Address = "5305 W Radcliffe Drive",
                            City = "Brown Deer",
                            FirstName = "Barry",
                            IdentityUserId = "efaef2cb-19ca-4141-9f1b-23f8ca48d99b",
                            LastName = "Allen",
                            Rating = 0.0,
                            State = "Wisconsin",
                            Zipcode = "53223"
                        });
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.ProviderSchedule", b =>
                {
                    b.Property<int>("ProviderScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("WeekDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("isBooked")
                        .HasColumnType("bit");

                    b.HasKey("ProviderScheduleId");

                    b.HasIndex("ProviderId");

                    b.ToTable("ProviderSchedule");
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfService")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Consumer", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Order", b =>
                {
                    b.HasOne("SoloCapstoneProject.Models.Consumer", "Consumers")
                        .WithMany()
                        .HasForeignKey("ConsumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoloCapstoneProject.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Provider", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.ProviderSchedule", b =>
                {
                    b.HasOne("SoloCapstoneProject.Models.Provider", "Providers")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoloCapstoneProject.Models.Service", b =>
                {
                    b.HasOne("SoloCapstoneProject.Models.Provider", "Providers")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
