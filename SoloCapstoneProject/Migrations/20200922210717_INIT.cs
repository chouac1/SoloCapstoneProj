using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoloCapstoneProject.Migrations
{
    public partial class INIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    ConsumerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.ConsumerId);
                    table.ForeignKey(
                        name: "FK_Consumers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderId);
                    table.ForeignKey(
                        name: "FK_Providers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderAvailabilities",
                columns: table => new
                {
                    ProviderAvailablityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<string>(nullable: true),
                    OpeningHour = table.Column<string>(nullable: true),
                    ClosingHour = table.Column<string>(nullable: true),
                    ProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAvailabilities", x => x.ProviderAvailablityId);
                    table.ForeignKey(
                        name: "FK_ProviderAvailabilities_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfService = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceDate = table.Column<string>(nullable: true),
                    ProviderEstimate = table.Column<double>(nullable: true),
                    ConsumerId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Consumers_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "Consumers",
                        principalColumn: "ConsumerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2bd7c56-44fc-4428-9761-7c4a046c84e1", "031cbcf2-b0c6-49d9-9c27-43dad23f5206", "Admin", "ADMIN" },
                    { "c9f26a01-0c92-4141-844d-a852e4bba47a", "aa96bafb-b331-4f3e-9ffa-815215a27242", "Consumer", "CONSUMER" },
                    { "7c108608-97ee-4366-9b88-b59c0fd72e00", "f71017c9-571c-4ce5-ae7d-2b59e1296268", "Provider", "PROVIDER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78e5203f-174a-4dca-96cb-40dd2a868205", 0, "fd2c3120-eb11-454d-8e13-dcef3c2c65ec", "admin@admin.com", false, true, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELetqK1tdDcQ1tCJVKaPqBZg9tX1yB03jaIS2odXHCLn4HlHF0uWKN28EdyOf5yb9w==", "000-000-0000", false, "OIAXG7WPVGDGGHI43DKZEH2E76IJ5UJG", false, "admin@admin.com" },
                    { "5e1c8b30-314c-44ed-b52d-98df6549b8d8", 0, "2fc1dd2e-4196-4b84-b33e-6a2704ac5ba3", "consumer1@test.com", false, true, null, "CONSUMER1@TEST.COM", "CONSUMER1@TEST.COM", "AQAAAAEAACcQAAAAEAWQL9XdogA3L8VqBRDO0jZZXkMdtM22Pg01cpQwu4oZOUN1/wYYRxwIi8ivpJGSUg==", "111-111-1111", false, "HZ3FAHIT2KUMEC7PUCWUR6I5KY36DZFR", false, "consumer1@test.com" },
                    { "67ce75b3-f188-44f1-975f-a650b9c8ad52", 0, "6bb19bbd-2d15-4abc-83fc-b7f95032ea39", "consumer2@test.com", false, true, null, "CONSUMER2@TEST.COM", "CONSUMER2@TEST.COM", "AQAAAAEAACcQAAAAEK1dB/PVqfTC8DcFiupV/HKn/GGdcvoA3MBoJ2tN9YiZvtn9xwzWAUKSm6WIxUkoSg==", "222-222-2222", false, "YC2OKQG2JDEXUIP6Q6K2XZSR7RYY5Q2Y", false, "consumer2@test.com" },
                    { "6bd1cc7f-eaa6-4f78-9599-a99f6b1b7593", 0, "4ef57594-2a66-496d-8c65-fb07bacb25a7", "consumer3@test.com", false, true, null, "CONSUMER3@TEST.COM", "CONSUMER3@TEST.COM", "AQAAAAEAACcQAAAAELLdplS8GfW7zKac+FaD1NfioKkuybbyqEPt2WG8oI7KLloFLkRZhpmcNQhHOE3JJQ==", "333-333-3333", false, "BJXEHOICZWFFMDNRV7AGI2RVZ67ZM3Z3", false, "consumer3@test.com" },
                    { "2be63164-b8af-4596-9796-93ff8cec4bf3", 0, "14dbbc88-fd6c-46f7-9ef8-5a5da478afee", "provider1@test.com", false, true, null, "PROVIDER1@TEST.COM", "PROVIDER1@TEST.COM", "AQAAAAEAACcQAAAAEMFLDcxEh+gWl+lnKQOtLBvzvYODU/liVtSTNnj/p5ITsxmajBe6/azXMeUCYwKVkA==", "444-444-4444", false, "HTIXEQVI3JYR65ZTUZTL7AQ57REKRJCK", false, "provider1@test.com" },
                    { "eef8a61c-1139-4a74-98f1-e06da7dce470", 0, "125170f7-525a-4ce3-ad00-2e207d739924", "provider2@test.com", false, true, null, "PROVIDER2@TEST.COM", "PROVIDER2@TEST.COM", "AQAAAAEAACcQAAAAEPxi84PKc/Sg0cogUGqscB2/U8KQEv9FJCQ8IaCeewrgVa1BZegLI1Wia/v1qSuwGA==", "555-555-5555", false, "JH53TNUXDPNYNVQPH7ISKAIJIZN32ZGF", false, "provider2@test.com" },
                    { "efaef2cb-19ca-4141-9f1b-23f8ca48d99b", 0, "ebc8172e-ad24-43d7-8833-f790bb180d88", "provider3@test.com", false, true, null, "PROVIDER3@TEST.COM", "PROVIDER3@TEST.COM", "AQAAAAEAACcQAAAAEFDWf0ud4BpCDSyizTthtta/CRBm+5vYGv0UNuJ3LbrNakXq23qgzhBWVquC4PR/pg==", "666-666-6666", false, "EJ6OCU5B4QALLAHLLIL3LFSZVCS3BJB7", false, "provider3@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Consumers",
                columns: new[] { "ConsumerId", "Address", "City", "FirstName", "IdentityUserId", "LastName", "State", "Zipcode" },
                values: new object[,]
                {
                    { 1, "7814 W Silver Spring Drive", "Milwaukee", "Jacob", "5e1c8b30-314c-44ed-b52d-98df6549b8d8", "Townsend", "Wisconsin", "53218" },
                    { 2, "7830 W Silver Spring Drive", "Milwaukee", "Eli", "67ce75b3-f188-44f1-975f-a650b9c8ad52", "Manny", "Wisconsin", "53218" },
                    { 3, "7818 W Silver Spring Drive", "Milwaukee", "Steve", "6bd1cc7f-eaa6-4f78-9599-a99f6b1b7593", "Rogers", "Wisconsin", "53218" }
                });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "ProviderId", "Address", "City", "FirstName", "IdentityUserId", "LastName", "State", "Zipcode" },
                values: new object[,]
                {
                    { 1, "5339 W Radcliffe Drive", "Brown Deer", "Peter", "2be63164-b8af-4596-9796-93ff8cec4bf3", "Parker", "Wisconsin", "53223" },
                    { 2, "5391 W Radcliffe Drive", "Brown Deer", "Clark", "eef8a61c-1139-4a74-98f1-e06da7dce470", "Kent", "Wisconsin", "53223" },
                    { 3, "5305 W Radcliffe Drive", "Brown Deer", "Barry", "efaef2cb-19ca-4141-9f1b-23f8ca48d99b", "Allen", "Wisconsin", "53223" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_IdentityUserId",
                table: "Consumers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ServiceId",
                table: "Orders",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAvailabilities_ProviderId",
                table: "ProviderAvailabilities",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_IdentityUserId",
                table: "Providers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ProviderId",
                table: "Services",
                column: "ProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProviderAvailabilities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
