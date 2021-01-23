using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.AppDBContext.Migrations
{
    public partial class cascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "a2dbda4d-9ea9-4e2a-b084-a751dd3b193d");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "b161891c-0261-4f1f-99f3-1b5bd5ccfc7e");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "c5273603-9a54-45cf-8fea-3fd4229871d1");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "c8fa76df-941e-4c1f-845a-f68c66df274e");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "3ad4f78a-4d50-47cc-a553-485629a285b7");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "4e201662-0c72-4982-b9e7-af0d25238efd");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "9a51f68f-eba4-4abf-96b0-bfbaacdfcf50");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "9b6c2c5d-69b5-40f0-80b2-bc74a8f611c1");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "a1e5113c-695e-4947-9943-99b098aadbda");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "e241ffed-0a6b-425c-aeeb-5797dde11960");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "e3455abc-a921-4abd-a2c2-377c83497b5a");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "f6352dd8-72ed-4ca3-9d99-e2a6ff8a150e");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "e4a667f9-1a3f-4bec-a8d1-032531a7f4b9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "0cc0c7e8-d52b-420d-b696-ab37420fd240");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "795cf21a-6ec8-4c15-8218-31c9e230c647");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "82f737f7-278e-4636-bbd2-348285e35135");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "3677d298-0471-406f-8d88-9d2772f32d63");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "42681a67-ebe1-4160-9b66-db5b941f9c08");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "81533d2f-5321-4b2b-9d35-2c927ab7bfdd");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "d7448f8d-2b63-427c-a4da-66f5ee464019");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "84500a25-599f-4afb-a71a-5784b29f3c30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ca1d8f57-ce7b-432f-90f0-5890638981ba");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e8243ba1-6073-4e76-9417-d3bfaeb2a866");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "12d2535b-9d95-438a-83f2-8fc72df23e50");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "22ab32bc-9bfe-48ac-96cb-fb97ba516053");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "8f93a65e-860f-4100-aa11-a1cb8ef31bc6");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d5b721e0-1bf1-4d89-a51a-ae5d02600a06");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "2c4b7719-39fd-4678-b6fa-f69fccc28bd7");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "5af70935-d539-4e07-b4e8-62f84fc49f9d");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "97411613-3bb9-4613-9117-77bb2adbd916");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "c81e6581-6f6e-476e-8088-5b2a57eececc", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(8907), null, null, "Metal" },
                    { "48d4618a-b0a0-47d5-ba5b-bdd3931092e9", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(8965), null, null, "Nu-Metal" },
                    { "91918961-9245-4390-9b7a-9b5d80fd52d8", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(8972), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "3e907d79-377f-409a-b831-7d6608c07ef9", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(4105), null, null, "Metallica" },
                    { "41ddea7e-9910-424d-baa9-5cc9226e5935", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(4177), null, null, "Iron Maiden" },
                    { "5fb8e066-519d-4c54-a995-8d50455572aa", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(4183), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { "31913a80-843e-48a3-9bf1-1c55b4289fca", new DateTime(2021, 1, 19, 17, 51, 39, 157, DateTimeKind.Local).AddTicks(5714), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "User", "George" },
                    { "7340472b-b13b-4d2e-8103-12ea6fe8838d", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(2985), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "Admin", "Admin" },
                    { "6b3d7129-4209-4a74-871e-2d603db08084", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(3030), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "User", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "f2d8ab8e-aa95-4b03-a985-f7380aae16a5", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(6300), null, null, "Ride The Lightning", "3e907d79-377f-409a-b831-7d6608c07ef9", 1984 },
                    { "f287f5fe-9007-4176-b1b9-8a98208d5d27", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(6395), null, null, "Master Of Puppets", "3e907d79-377f-409a-b831-7d6608c07ef9", 1986 },
                    { "a9633e1c-35ce-4cde-aa8e-0eda34bad3c5", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(6405), null, null, "Fear Of The Dark", "41ddea7e-9910-424d-baa9-5cc9226e5935", 1992 },
                    { "0be27510-fb8b-4213-b0da-c3bd59a1e72b", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(6412), null, null, "Meteora", "5fb8e066-519d-4c54-a995-8d50455572aa", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { "1c3c2fbe-932a-4b6f-a410-d3f1304d17af", "f2d8ab8e-aa95-4b03-a985-f7380aae16a5", "c81e6581-6f6e-476e-8088-5b2a57eececc" },
                    { "d4aac9e2-952c-48b2-a31e-bc2be42b7762", "f287f5fe-9007-4176-b1b9-8a98208d5d27", "91918961-9245-4390-9b7a-9b5d80fd52d8" },
                    { "aa46286e-a55c-4a24-a4dc-3831a5429a8a", "a9633e1c-35ce-4cde-aa8e-0eda34bad3c5", "c81e6581-6f6e-476e-8088-5b2a57eececc" },
                    { "4775241d-0ef6-40e4-892e-bdeec1d62fb1", "0be27510-fb8b-4213-b0da-c3bd59a1e72b", "48d4618a-b0a0-47d5-ba5b-bdd3931092e9" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId" },
                values: new object[,]
                {
                    { "40b3b061-186f-44ad-9edd-7e11360b0838", "f2d8ab8e-aa95-4b03-a985-f7380aae16a5", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(8057), null, null, "For Whom The Bell Tolls", "3e907d79-377f-409a-b831-7d6608c07ef9" },
                    { "ac7c531e-8248-4c73-8f68-9d57f8aa65e5", "f287f5fe-9007-4176-b1b9-8a98208d5d27", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(7911), null, null, "Master Of Puppets", "3e907d79-377f-409a-b831-7d6608c07ef9" },
                    { "45426e64-4005-48f3-a771-afeaa0c75f81", "f287f5fe-9007-4176-b1b9-8a98208d5d27", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(8064), null, null, "Battery", "3e907d79-377f-409a-b831-7d6608c07ef9" },
                    { "46edded6-9172-4b81-b2c1-b965abf587cc", "a9633e1c-35ce-4cde-aa8e-0eda34bad3c5", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(8047), null, null, "Fear Of The Dark", "41ddea7e-9910-424d-baa9-5cc9226e5935" },
                    { "41957082-ec23-4eb3-863d-ad0e93d484b2", "0be27510-fb8b-4213-b0da-c3bd59a1e72b", new DateTime(2021, 1, 19, 17, 51, 39, 159, DateTimeKind.Local).AddTicks(7993), null, null, "Numb", "5fb8e066-519d-4c54-a995-8d50455572aa" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "e7e64571-8cc8-41d1-8ea7-9979eeeac743", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2775), null, null, "40b3b061-186f-44ad-9edd-7e11360b0838", "31913a80-843e-48a3-9bf1-1c55b4289fca" },
                    { "1681c14b-7ac9-4e4c-9647-2497b1219a11", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2785), null, null, "40b3b061-186f-44ad-9edd-7e11360b0838", "7340472b-b13b-4d2e-8103-12ea6fe8838d" },
                    { "cee2b070-9ecd-4ce7-9758-505158d4e787", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2789), null, null, "40b3b061-186f-44ad-9edd-7e11360b0838", "6b3d7129-4209-4a74-871e-2d603db08084" },
                    { "a025357f-586d-4625-9e9e-989a0d942bb5", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2683), null, null, "ac7c531e-8248-4c73-8f68-9d57f8aa65e5", "31913a80-843e-48a3-9bf1-1c55b4289fca" },
                    { "b0f4cdb4-890f-4706-9e97-2804114dd496", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2748), null, null, "ac7c531e-8248-4c73-8f68-9d57f8aa65e5", "7340472b-b13b-4d2e-8103-12ea6fe8838d" },
                    { "d72dad24-a187-4a4d-a1bc-45353d5e11f3", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2765), null, null, "46edded6-9172-4b81-b2c1-b965abf587cc", "7340472b-b13b-4d2e-8103-12ea6fe8838d" },
                    { "660705c0-8692-4b83-8c5a-36155daf7164", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2754), null, null, "41957082-ec23-4eb3-863d-ad0e93d484b2", "31913a80-843e-48a3-9bf1-1c55b4289fca" },
                    { "1076d79b-a0a8-457c-a6c0-d1ac43b97fc7", new DateTime(2021, 1, 19, 17, 51, 39, 160, DateTimeKind.Local).AddTicks(2761), null, null, "41957082-ec23-4eb3-863d-ad0e93d484b2", "6b3d7129-4209-4a74-871e-2d603db08084" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "1c3c2fbe-932a-4b6f-a410-d3f1304d17af");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "4775241d-0ef6-40e4-892e-bdeec1d62fb1");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "aa46286e-a55c-4a24-a4dc-3831a5429a8a");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "d4aac9e2-952c-48b2-a31e-bc2be42b7762");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "1076d79b-a0a8-457c-a6c0-d1ac43b97fc7");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "1681c14b-7ac9-4e4c-9647-2497b1219a11");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "660705c0-8692-4b83-8c5a-36155daf7164");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "a025357f-586d-4625-9e9e-989a0d942bb5");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "b0f4cdb4-890f-4706-9e97-2804114dd496");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "cee2b070-9ecd-4ce7-9758-505158d4e787");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "d72dad24-a187-4a4d-a1bc-45353d5e11f3");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "e7e64571-8cc8-41d1-8ea7-9979eeeac743");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "45426e64-4005-48f3-a771-afeaa0c75f81");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "48d4618a-b0a0-47d5-ba5b-bdd3931092e9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "91918961-9245-4390-9b7a-9b5d80fd52d8");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "c81e6581-6f6e-476e-8088-5b2a57eececc");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "40b3b061-186f-44ad-9edd-7e11360b0838");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "41957082-ec23-4eb3-863d-ad0e93d484b2");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "46edded6-9172-4b81-b2c1-b965abf587cc");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "ac7c531e-8248-4c73-8f68-9d57f8aa65e5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31913a80-843e-48a3-9bf1-1c55b4289fca");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6b3d7129-4209-4a74-871e-2d603db08084");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7340472b-b13b-4d2e-8103-12ea6fe8838d");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "0be27510-fb8b-4213-b0da-c3bd59a1e72b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "a9633e1c-35ce-4cde-aa8e-0eda34bad3c5");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f287f5fe-9007-4176-b1b9-8a98208d5d27");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f2d8ab8e-aa95-4b03-a985-f7380aae16a5");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "3e907d79-377f-409a-b831-7d6608c07ef9");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "41ddea7e-9910-424d-baa9-5cc9226e5935");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "5fb8e066-519d-4c54-a995-8d50455572aa");

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
        }
    }
}
