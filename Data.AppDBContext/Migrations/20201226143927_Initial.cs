using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.AppDBContext.Migrations
{
    public partial class Initial : Migration
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
                    { "65d327d2-1000-4eb7-ab02-c49a46ab9bf3", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7685), null, null, "Metal" },
                    { "3e8cf2b8-9b38-442d-b7ff-7c55d5bb5566", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7740), null, null, "Nu-Metal" },
                    { "d50ac7da-d01e-48c3-8c67-f94ccf002dfa", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7747), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "aabba9e8-db4d-47bc-80e5-fff06f00c43e", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(4340), null, null, "Metallica" },
                    { "3a243c08-4037-4904-b165-6162b567a7e1", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(4443), null, null, "Iron Maiden" },
                    { "fef9ca57-3365-487a-833f-b9bd531bacc7", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(4453), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Password", "Username" },
                values: new object[,]
                {
                    { "90d129ce-a34f-4e54-a633-2c9ef2ca854c", new DateTime(2020, 12, 26, 16, 39, 27, 181, DateTimeKind.Local).AddTicks(6810), null, null, "123", "George" },
                    { "746e9d54-e785-458c-9186-1d54ee25f4e6", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(3477), null, null, "123", "Martin" },
                    { "7a91cf78-ce5a-430f-891e-70d41a8dd7fa", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(3525), null, null, "123", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "a2e1df8c-fc91-4a02-b0da-a9d031366d3a", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(5852), null, null, "Ride The Lightning", "aabba9e8-db4d-47bc-80e5-fff06f00c43e", 1984 },
                    { "1cd73e58-0699-49e4-b099-3f9e8af10d58", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(5944), null, null, "Master Of Puppets", "aabba9e8-db4d-47bc-80e5-fff06f00c43e", 1986 },
                    { "38c254e4-b1d7-4fa5-a1ad-ad67983b88fe", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(5955), null, null, "Fear Of The Dark", "3a243c08-4037-4904-b165-6162b567a7e1", 1992 },
                    { "81a0da61-dc69-49ab-a57f-e282808523de", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(5962), null, null, "Meteora", "fef9ca57-3365-487a-833f-b9bd531bacc7", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { "0f0afbc1-1997-45c4-ad5c-a1ee4671e70c", "a2e1df8c-fc91-4a02-b0da-a9d031366d3a", "65d327d2-1000-4eb7-ab02-c49a46ab9bf3" },
                    { "c1cc0b3d-eedc-400d-92ad-85105ff4876c", "1cd73e58-0699-49e4-b099-3f9e8af10d58", "d50ac7da-d01e-48c3-8c67-f94ccf002dfa" },
                    { "890a3ae9-feb5-4762-8c6a-52ffa81e914e", "38c254e4-b1d7-4fa5-a1ad-ad67983b88fe", "65d327d2-1000-4eb7-ab02-c49a46ab9bf3" },
                    { "92dde1b2-9e38-4a6f-88ad-3b0f16750578", "81a0da61-dc69-49ab-a57f-e282808523de", "3e8cf2b8-9b38-442d-b7ff-7c55d5bb5566" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId" },
                values: new object[,]
                {
                    { "4455a272-e6c3-4a8f-8081-85dba06d154a", "a2e1df8c-fc91-4a02-b0da-a9d031366d3a", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7091), null, null, "For Whom The Bell Tolls", "aabba9e8-db4d-47bc-80e5-fff06f00c43e" },
                    { "e882b460-af7a-4368-8649-8c2af2441550", "1cd73e58-0699-49e4-b099-3f9e8af10d58", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7006), null, null, "Master Of Puppets", "aabba9e8-db4d-47bc-80e5-fff06f00c43e" },
                    { "fc9e59e9-df78-44a8-9d66-6ea43efddd47", "1cd73e58-0699-49e4-b099-3f9e8af10d58", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7102), null, null, "Battery", "aabba9e8-db4d-47bc-80e5-fff06f00c43e" },
                    { "b8b2e246-d63c-41cb-9b8b-3bd41fde1f2a", "38c254e4-b1d7-4fa5-a1ad-ad67983b88fe", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7085), null, null, "Fear Of The Dark", "3a243c08-4037-4904-b165-6162b567a7e1" },
                    { "3accaa17-c7f3-4684-8c93-009f56f995ff", "81a0da61-dc69-49ab-a57f-e282808523de", new DateTime(2020, 12, 26, 16, 39, 27, 183, DateTimeKind.Local).AddTicks(7074), null, null, "Numb", "fef9ca57-3365-487a-833f-b9bd531bacc7" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "9f6bade5-a04c-4ece-8391-0be10abd98eb", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(341), null, null, "4455a272-e6c3-4a8f-8081-85dba06d154a", "90d129ce-a34f-4e54-a633-2c9ef2ca854c" },
                    { "24bafa8b-fdb8-4c77-8478-8d527602934f", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(344), null, null, "4455a272-e6c3-4a8f-8081-85dba06d154a", "746e9d54-e785-458c-9186-1d54ee25f4e6" },
                    { "b00a7ada-9b31-4c85-b050-33ad61f076f3", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(351), null, null, "4455a272-e6c3-4a8f-8081-85dba06d154a", "7a91cf78-ce5a-430f-891e-70d41a8dd7fa" },
                    { "3c0f2273-7341-4ea6-b260-f4c52e5e68ad", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(249), null, null, "e882b460-af7a-4368-8649-8c2af2441550", "90d129ce-a34f-4e54-a633-2c9ef2ca854c" },
                    { "e0d150c3-c82d-4c46-996c-3226805fb6ba", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(307), null, null, "e882b460-af7a-4368-8649-8c2af2441550", "746e9d54-e785-458c-9186-1d54ee25f4e6" },
                    { "1849e22a-0e6d-4e5d-ab5b-e2f73f74abac", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(324), null, null, "b8b2e246-d63c-41cb-9b8b-3bd41fde1f2a", "746e9d54-e785-458c-9186-1d54ee25f4e6" },
                    { "bfbee3bd-9f31-405b-a64a-4dfb426002cf", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(314), null, null, "3accaa17-c7f3-4684-8c93-009f56f995ff", "90d129ce-a34f-4e54-a633-2c9ef2ca854c" },
                    { "14aeaaaa-4214-4ce7-9de1-33e2eb3ecc84", new DateTime(2020, 12, 26, 16, 39, 27, 184, DateTimeKind.Local).AddTicks(320), null, null, "3accaa17-c7f3-4684-8c93-009f56f995ff", "7a91cf78-ce5a-430f-891e-70d41a8dd7fa" }
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
