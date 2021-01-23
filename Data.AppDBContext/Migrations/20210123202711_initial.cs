using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.AppDBContext.Migrations
{
    public partial class initial : Migration
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { "30637db2-d514-49f8-828a-ce614c64ccb2", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(4373), null, null, "Metal" },
                    { "0223bfad-b92d-43f5-bf95-435e52673d81", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(4434), null, null, "Nu-Metal" },
                    { "ee1a6b6a-f129-440f-a4d9-e6c5bd57546a", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(4448), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "93907019-2005-43c1-9286-d5c8fbb7546c", new DateTime(2021, 1, 23, 22, 27, 10, 645, DateTimeKind.Local).AddTicks(9614), null, null, "Metallica" },
                    { "c2b6dfd2-bc17-40a4-826a-9a99940e95f6", new DateTime(2021, 1, 23, 22, 27, 10, 645, DateTimeKind.Local).AddTicks(9683), null, null, "Iron Maiden" },
                    { "c0ecc8df-c356-4989-87ac-5f9c4fa3380f", new DateTime(2021, 1, 23, 22, 27, 10, 645, DateTimeKind.Local).AddTicks(9696), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { "b5b87537-d4d2-4728-a593-8a3d5032ee6a", new DateTime(2021, 1, 23, 22, 27, 10, 644, DateTimeKind.Local).AddTicks(575), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "Moderator", "George" },
                    { "dc8f489d-bd9a-4c51-8b9a-610350696793", new DateTime(2021, 1, 23, 22, 27, 10, 645, DateTimeKind.Local).AddTicks(8447), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "Admin", "Admin" },
                    { "712a1c13-8c17-4ef1-9e41-f718bbd1c513", new DateTime(2021, 1, 23, 22, 27, 10, 645, DateTimeKind.Local).AddTicks(8495), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "User", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "cbf927f1-c476-4b62-b1eb-c082244431cd", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(1724), null, null, "Ride The Lightning", "93907019-2005-43c1-9286-d5c8fbb7546c", 1984 },
                    { "4bc2b41a-6144-4b41-aa47-2784927edf02", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(1816), null, null, "Master Of Puppets", "93907019-2005-43c1-9286-d5c8fbb7546c", 1986 },
                    { "fc405a55-110f-4431-bbdf-cc4c94217138", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(1826), null, null, "Fear Of The Dark", "c2b6dfd2-bc17-40a4-826a-9a99940e95f6", 1992 },
                    { "55cb80a3-fdb7-4ec9-b232-15942ef1c18f", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(1840), null, null, "Meteora", "c0ecc8df-c356-4989-87ac-5f9c4fa3380f", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { "b2a88fdd-3b42-4182-b7b8-820b0edf06ea", "cbf927f1-c476-4b62-b1eb-c082244431cd", "30637db2-d514-49f8-828a-ce614c64ccb2" },
                    { "678e673b-00bb-44f3-9701-575c964d4daa", "4bc2b41a-6144-4b41-aa47-2784927edf02", "ee1a6b6a-f129-440f-a4d9-e6c5bd57546a" },
                    { "7e5223cc-f29b-4796-9051-0da80b186a58", "fc405a55-110f-4431-bbdf-cc4c94217138", "30637db2-d514-49f8-828a-ce614c64ccb2" },
                    { "5531fde8-1548-470c-a703-9cffbcd4f1ce", "55cb80a3-fdb7-4ec9-b232-15942ef1c18f", "0223bfad-b92d-43f5-bf95-435e52673d81" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId" },
                values: new object[,]
                {
                    { "5c936eb3-4d40-4cb3-a2f4-5ebb27fadbb3", "cbf927f1-c476-4b62-b1eb-c082244431cd", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(3509), null, null, "For Whom The Bell Tolls", "93907019-2005-43c1-9286-d5c8fbb7546c" },
                    { "c618f7ea-0b9a-40cc-9c2e-d0784c1e55bb", "4bc2b41a-6144-4b41-aa47-2784927edf02", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(3410), null, null, "Master Of Puppets", "93907019-2005-43c1-9286-d5c8fbb7546c" },
                    { "4ec69faa-9825-44dd-9990-0b7fa4de99ed", "4bc2b41a-6144-4b41-aa47-2784927edf02", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(3519), null, null, "Battery", "93907019-2005-43c1-9286-d5c8fbb7546c" },
                    { "561a6f9b-6733-49e5-92c4-5e5d7501839b", "fc405a55-110f-4431-bbdf-cc4c94217138", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(3499), null, null, "Fear Of The Dark", "c2b6dfd2-bc17-40a4-826a-9a99940e95f6" },
                    { "6f1cbaef-d77d-45ff-a155-bd19379abb26", "55cb80a3-fdb7-4ec9-b232-15942ef1c18f", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(3485), null, null, "Numb", "c0ecc8df-c356-4989-87ac-5f9c4fa3380f" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "c1f12015-eedf-4354-973b-bff138e09cc1", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(8094), null, null, "5c936eb3-4d40-4cb3-a2f4-5ebb27fadbb3", "b5b87537-d4d2-4728-a593-8a3d5032ee6a" },
                    { "90b2b690-dd31-4c82-ba57-7d3316d111af", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(8097), null, null, "5c936eb3-4d40-4cb3-a2f4-5ebb27fadbb3", "dc8f489d-bd9a-4c51-8b9a-610350696793" },
                    { "ae64a577-ca2e-4320-b8b2-b30f53c1c31d", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(8104), null, null, "5c936eb3-4d40-4cb3-a2f4-5ebb27fadbb3", "712a1c13-8c17-4ef1-9e41-f718bbd1c513" },
                    { "b92cd0f6-54d9-4dae-bec6-42e46c47714a", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(7988), null, null, "c618f7ea-0b9a-40cc-9c2e-d0784c1e55bb", "b5b87537-d4d2-4728-a593-8a3d5032ee6a" },
                    { "de3785e5-5257-4ac1-bfeb-156391012522", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(8059), null, null, "c618f7ea-0b9a-40cc-9c2e-d0784c1e55bb", "dc8f489d-bd9a-4c51-8b9a-610350696793" },
                    { "a5b64033-fb17-4f39-90b9-6512dc2d7a17", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(8087), null, null, "561a6f9b-6733-49e5-92c4-5e5d7501839b", "dc8f489d-bd9a-4c51-8b9a-610350696793" },
                    { "c13c1fdb-0ab1-4da9-86ad-78e615f03873", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(8070), null, null, "6f1cbaef-d77d-45ff-a155-bd19379abb26", "b5b87537-d4d2-4728-a593-8a3d5032ee6a" },
                    { "2e64a42c-a02b-4024-918d-605c638db296", new DateTime(2021, 1, 23, 22, 27, 10, 646, DateTimeKind.Local).AddTicks(8080), null, null, "6f1cbaef-d77d-45ff-a155-bd19379abb26", "712a1c13-8c17-4ef1-9e41-f718bbd1c513" }
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
