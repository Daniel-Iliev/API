using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.AppDBContext.Migrations
{
    public partial class Initialplus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearReleased = table.Column<int>(type: "int", nullable: false),
                    PerformerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Performers_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Performers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlbumGenres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AlbumId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlbumGenres_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlbumGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PerformerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Songs_Performers_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Performers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SongId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Favourites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "db9aba26-0d2c-4fcf-92a8-78a81bad748c", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(7532), null, null, "Metal" },
                    { "905f4e81-d987-4191-83a3-058de3c625df", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(7590), null, null, "Nu-Metal" },
                    { "d4b0affc-615a-4ca1-8933-6d04584019ce", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(7600), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "3b785329-f8f5-4a34-a92a-7f7c22d6bfa9", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(4272), null, null, "Metallica" },
                    { "666ca2a8-87db-488b-8432-05a748353866", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(4337), null, null, "Iron Maiden" },
                    { "878d9df9-1f37-4c6e-9a6a-fc8ac94a91ce", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(4347), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "ModifiedAt", "Password", "Username" },
                values: new object[,]
                {
                    { "af0a8556-16d5-4507-a9a2-34fe0143baec", new DateTime(2020, 12, 20, 14, 58, 10, 544, DateTimeKind.Local).AddTicks(5577), null, "george@123.bg", null, "123", "George" },
                    { "9ae35ab3-9f1c-40fa-beb6-20b85a99e604", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(2832), null, "martin@123.bg", null, "123", "Martin" },
                    { "aabbc4a5-bf07-4024-b419-6c3fee7f5b02", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(3033), null, "jake@123.bg", null, "123", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "cf06aabe-df44-4c17-8de4-f87368733656", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(5730), null, null, "Ride The Lightning", "3b785329-f8f5-4a34-a92a-7f7c22d6bfa9", 1984 },
                    { "7e5f4498-51a7-4653-85ae-39ba39d449e1", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(5818), null, null, "Master Of Puppets", "3b785329-f8f5-4a34-a92a-7f7c22d6bfa9", 1986 },
                    { "7a63fdb1-fa1c-4dce-a683-002b5da32997", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(5829), null, null, "Fear Of The Dark", "666ca2a8-87db-488b-8432-05a748353866", 1992 },
                    { "13e5d71d-5d4d-4f8c-8181-afba15f9ff60", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(5835), null, null, "Meteora", "878d9df9-1f37-4c6e-9a6a-fc8ac94a91ce", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { "7a5bbdde-adb9-487c-bb3e-af54826bb752", "cf06aabe-df44-4c17-8de4-f87368733656", "db9aba26-0d2c-4fcf-92a8-78a81bad748c" },
                    { "747c6dcd-9882-45f9-ac92-fc24d334c91d", "7e5f4498-51a7-4653-85ae-39ba39d449e1", "d4b0affc-615a-4ca1-8933-6d04584019ce" },
                    { "f9049eab-121b-4828-998a-5dc47df6c2f4", "7a63fdb1-fa1c-4dce-a683-002b5da32997", "db9aba26-0d2c-4fcf-92a8-78a81bad748c" },
                    { "515206fb-d9a8-44a0-a21a-fbb6d28bf966", "13e5d71d-5d4d-4f8c-8181-afba15f9ff60", "905f4e81-d987-4191-83a3-058de3c625df" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId" },
                values: new object[,]
                {
                    { "dbac09c9-282f-46a9-a5d9-3d8c31c93014", "cf06aabe-df44-4c17-8de4-f87368733656", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(6941), null, null, "For Whom The Bell Tolls", "3b785329-f8f5-4a34-a92a-7f7c22d6bfa9" },
                    { "3ac613a3-0f5a-4db0-9189-ac1c3abfa233", "7e5f4498-51a7-4653-85ae-39ba39d449e1", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(6853), null, null, "Master Of Puppets", "3b785329-f8f5-4a34-a92a-7f7c22d6bfa9" },
                    { "35389162-504a-4e81-81bc-50b4a0351693", "7e5f4498-51a7-4653-85ae-39ba39d449e1", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(6955), null, null, "Battery", "3b785329-f8f5-4a34-a92a-7f7c22d6bfa9" },
                    { "60067218-4fd7-487a-b082-3cbcf4f3be42", "7a63fdb1-fa1c-4dce-a683-002b5da32997", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(6935), null, null, "Fear Of The Dark", "666ca2a8-87db-488b-8432-05a748353866" },
                    { "f534b3d2-f7fc-44dc-9d39-79c021aca648", "13e5d71d-5d4d-4f8c-8181-afba15f9ff60", new DateTime(2020, 12, 20, 14, 58, 10, 546, DateTimeKind.Local).AddTicks(6924), null, null, "Numb", "878d9df9-1f37-4c6e-9a6a-fc8ac94a91ce" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "6818cef8-16f7-4aa5-a027-ae1956fcb882", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(187), null, null, "dbac09c9-282f-46a9-a5d9-3d8c31c93014", "af0a8556-16d5-4507-a9a2-34fe0143baec" },
                    { "b44b9d7e-83ab-4d49-8d0c-61f920aeb85b", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(194), null, null, "dbac09c9-282f-46a9-a5d9-3d8c31c93014", "9ae35ab3-9f1c-40fa-beb6-20b85a99e604" },
                    { "4398d8e7-9942-4d82-bfb7-a0fbf219ab50", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(198), null, null, "dbac09c9-282f-46a9-a5d9-3d8c31c93014", "aabbc4a5-bf07-4024-b419-6c3fee7f5b02" },
                    { "00cbc946-d767-4ca1-9709-fd71167d4e27", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(68), null, null, "3ac613a3-0f5a-4db0-9189-ac1c3abfa233", "af0a8556-16d5-4507-a9a2-34fe0143baec" },
                    { "2ee10990-88a9-448f-b664-526682fee45c", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(129), null, null, "3ac613a3-0f5a-4db0-9189-ac1c3abfa233", "9ae35ab3-9f1c-40fa-beb6-20b85a99e604" },
                    { "0ca61a4b-bd0d-4e53-be32-03b160d16bfa", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(174), null, null, "60067218-4fd7-487a-b082-3cbcf4f3be42", "9ae35ab3-9f1c-40fa-beb6-20b85a99e604" },
                    { "2cf07b27-434b-4c7d-9950-525951c70c71", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(136), null, null, "f534b3d2-f7fc-44dc-9d39-79c021aca648", "af0a8556-16d5-4507-a9a2-34fe0143baec" },
                    { "3a68141a-c949-418b-bb73-8e797fc3ab32", new DateTime(2020, 12, 20, 14, 58, 10, 547, DateTimeKind.Local).AddTicks(143), null, null, "f534b3d2-f7fc-44dc-9d39-79c021aca648", "aabbc4a5-bf07-4024-b419-6c3fee7f5b02" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenres_AlbumId",
                table: "AlbumGenres",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenres_GenreId",
                table: "AlbumGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_PerformerId",
                table: "Albums",
                column: "PerformerId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_SongId",
                table: "Favourites",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PerformerId",
                table: "Songs",
                column: "PerformerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumGenres");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Performers");
        }
    }
}
