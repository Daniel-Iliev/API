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
                    { "795cf21a-6ec8-4c15-8218-31c9e230c647", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(8265), null, null, "Metal" },
                    { "0cc0c7e8-d52b-420d-b696-ab37420fd240", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(8323), null, null, "Nu-Metal" },
                    { "82f737f7-278e-4636-bbd2-348285e35135", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(8334), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "2c4b7719-39fd-4678-b6fa-f69fccc28bd7", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(4791), null, null, "Metallica" },
                    { "5af70935-d539-4e07-b4e8-62f84fc49f9d", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(4862), null, null, "Iron Maiden" },
                    { "97411613-3bb9-4613-9117-77bb2adbd916", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(4873), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { "84500a25-599f-4afb-a71a-5784b29f3c30", new DateTime(2021, 1, 16, 17, 45, 51, 12, DateTimeKind.Local).AddTicks(5116), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "User", "George" },
                    { "ca1d8f57-ce7b-432f-90f0-5890638981ba", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(3831), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "Admin", "Admin" },
                    { "e8243ba1-6073-4e76-9417-d3bfaeb2a866", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(3876), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "User", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "8f93a65e-860f-4100-aa11-a1cb8ef31bc6", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(6320), null, null, "Ride The Lightning", "2c4b7719-39fd-4678-b6fa-f69fccc28bd7", 1984 },
                    { "d5b721e0-1bf1-4d89-a51a-ae5d02600a06", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(6419), null, null, "Master Of Puppets", "2c4b7719-39fd-4678-b6fa-f69fccc28bd7", 1986 },
                    { "12d2535b-9d95-438a-83f2-8fc72df23e50", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(6429), null, null, "Fear Of The Dark", "5af70935-d539-4e07-b4e8-62f84fc49f9d", 1992 },
                    { "22ab32bc-9bfe-48ac-96cb-fb97ba516053", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(6439), null, null, "Meteora", "97411613-3bb9-4613-9117-77bb2adbd916", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { "a2dbda4d-9ea9-4e2a-b084-a751dd3b193d", "8f93a65e-860f-4100-aa11-a1cb8ef31bc6", "795cf21a-6ec8-4c15-8218-31c9e230c647" },
                    { "b161891c-0261-4f1f-99f3-1b5bd5ccfc7e", "d5b721e0-1bf1-4d89-a51a-ae5d02600a06", "82f737f7-278e-4636-bbd2-348285e35135" },
                    { "c5273603-9a54-45cf-8fea-3fd4229871d1", "12d2535b-9d95-438a-83f2-8fc72df23e50", "795cf21a-6ec8-4c15-8218-31c9e230c647" },
                    { "c8fa76df-941e-4c1f-845a-f68c66df274e", "22ab32bc-9bfe-48ac-96cb-fb97ba516053", "0cc0c7e8-d52b-420d-b696-ab37420fd240" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId" },
                values: new object[,]
                {
                    { "d7448f8d-2b63-427c-a4da-66f5ee464019", "8f93a65e-860f-4100-aa11-a1cb8ef31bc6", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(7634), null, null, "For Whom The Bell Tolls", "2c4b7719-39fd-4678-b6fa-f69fccc28bd7" },
                    { "42681a67-ebe1-4160-9b66-db5b941f9c08", "d5b721e0-1bf1-4d89-a51a-ae5d02600a06", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(7504), null, null, "Master Of Puppets", "2c4b7719-39fd-4678-b6fa-f69fccc28bd7" },
                    { "e4a667f9-1a3f-4bec-a8d1-032531a7f4b9", "d5b721e0-1bf1-4d89-a51a-ae5d02600a06", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(7644), null, null, "Battery", "2c4b7719-39fd-4678-b6fa-f69fccc28bd7" },
                    { "81533d2f-5321-4b2b-9d35-2c927ab7bfdd", "12d2535b-9d95-438a-83f2-8fc72df23e50", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(7596), null, null, "Fear Of The Dark", "5af70935-d539-4e07-b4e8-62f84fc49f9d" },
                    { "3677d298-0471-406f-8d88-9d2772f32d63", "22ab32bc-9bfe-48ac-96cb-fb97ba516053", new DateTime(2021, 1, 16, 17, 45, 51, 14, DateTimeKind.Local).AddTicks(7586), null, null, "Numb", "97411613-3bb9-4613-9117-77bb2adbd916" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "e3455abc-a921-4abd-a2c2-377c83497b5a", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(1003), null, null, "d7448f8d-2b63-427c-a4da-66f5ee464019", "84500a25-599f-4afb-a71a-5784b29f3c30" },
                    { "3ad4f78a-4d50-47cc-a553-485629a285b7", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(1013), null, null, "d7448f8d-2b63-427c-a4da-66f5ee464019", "ca1d8f57-ce7b-432f-90f0-5890638981ba" },
                    { "9a51f68f-eba4-4abf-96b0-bfbaacdfcf50", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(1020), null, null, "d7448f8d-2b63-427c-a4da-66f5ee464019", "e8243ba1-6073-4e76-9417-d3bfaeb2a866" },
                    { "a1e5113c-695e-4947-9943-99b098aadbda", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(911), null, null, "42681a67-ebe1-4160-9b66-db5b941f9c08", "84500a25-599f-4afb-a71a-5784b29f3c30" },
                    { "9b6c2c5d-69b5-40f0-80b2-bc74a8f611c1", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(976), null, null, "42681a67-ebe1-4160-9b66-db5b941f9c08", "ca1d8f57-ce7b-432f-90f0-5890638981ba" },
                    { "4e201662-0c72-4982-b9e7-af0d25238efd", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(993), null, null, "81533d2f-5321-4b2b-9d35-2c927ab7bfdd", "ca1d8f57-ce7b-432f-90f0-5890638981ba" },
                    { "f6352dd8-72ed-4ca3-9d99-e2a6ff8a150e", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(982), null, null, "3677d298-0471-406f-8d88-9d2772f32d63", "84500a25-599f-4afb-a71a-5784b29f3c30" },
                    { "e241ffed-0a6b-425c-aeeb-5797dde11960", new DateTime(2021, 1, 16, 17, 45, 51, 15, DateTimeKind.Local).AddTicks(989), null, null, "3677d298-0471-406f-8d88-9d2772f32d63", "e8243ba1-6073-4e76-9417-d3bfaeb2a866" }
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
