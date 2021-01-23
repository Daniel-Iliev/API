using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.AppDBContext.Migrations
{
    public partial class again : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3dbaf9f0-3fec-42a4-81a8-fd30ea99b09f", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(8746), null, null, "Metal" },
                    { "5e022174-faa4-4623-88de-a8d8ead139b5", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(8811), null, null, "Nu-Metal" },
                    { "e187793f-e7aa-43f8-bfab-47a8b7185b85", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(8821), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "4bf462ad-9d49-4247-ac1a-f1ec96a09236", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(3599), null, null, "Metallica" },
                    { "7134acb2-a5b9-4f7b-8777-369ec68ce9b8", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(3681), null, null, "Iron Maiden" },
                    { "1b30d878-2502-43cf-8b83-70043cd580e9", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(3691), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { "27c9ffab-70c7-4536-8812-188c6e31522a", new DateTime(2021, 1, 19, 18, 7, 12, 762, DateTimeKind.Local).AddTicks(4983), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "User", "George" },
                    { "3d98586a-b3c5-45df-91d9-32d5f284b037", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(2473), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "Admin", "Admin" },
                    { "2062d3eb-df76-461e-896e-28b4edbee221", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(2517), null, null, "havHcBwB/HJMHdkrqDZJPUixI7JqFX5DBzeLyfR2GPkRAlTb0oZ6WffOhY9S4L2LtK7a+C6LJ4Ry6ErSS7f2vw==", "User", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "bcac5c44-8ee8-445a-a20e-7ca019f5fc09", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(6081), null, null, "Ride The Lightning", "4bf462ad-9d49-4247-ac1a-f1ec96a09236", 1984 },
                    { "c1555908-4197-45d4-878c-890821680fbf", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(6173), null, null, "Master Of Puppets", "4bf462ad-9d49-4247-ac1a-f1ec96a09236", 1986 },
                    { "428e0beb-a2e4-4da8-8804-4c94f65f8fd1", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(6217), null, null, "Fear Of The Dark", "7134acb2-a5b9-4f7b-8777-369ec68ce9b8", 1992 },
                    { "5119d494-5a39-4935-a2c5-4b97cecedb05", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(6224), null, null, "Meteora", "1b30d878-2502-43cf-8b83-70043cd580e9", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "GenreId" },
                values: new object[,]
                {
                    { "19bb32f2-a84a-4ff0-babb-a87b53758d6e", "bcac5c44-8ee8-445a-a20e-7ca019f5fc09", "3dbaf9f0-3fec-42a4-81a8-fd30ea99b09f" },
                    { "940f161e-bc4a-4e2c-8fb9-6c2403bc35f8", "c1555908-4197-45d4-878c-890821680fbf", "e187793f-e7aa-43f8-bfab-47a8b7185b85" },
                    { "9fc98e6c-e8d2-4270-8e5e-495d8cee773a", "428e0beb-a2e4-4da8-8804-4c94f65f8fd1", "3dbaf9f0-3fec-42a4-81a8-fd30ea99b09f" },
                    { "564d3eaa-a410-4753-89be-acac5b6bfd93", "5119d494-5a39-4935-a2c5-4b97cecedb05", "5e022174-faa4-4623-88de-a8d8ead139b5" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId" },
                values: new object[,]
                {
                    { "0f420d41-9ea2-4446-b369-3d05eb6c06e4", "bcac5c44-8ee8-445a-a20e-7ca019f5fc09", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(7907), null, null, "For Whom The Bell Tolls", "4bf462ad-9d49-4247-ac1a-f1ec96a09236" },
                    { "444eb861-26bc-465a-83cb-5cdb97c70d58", "c1555908-4197-45d4-878c-890821680fbf", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(7808), null, null, "Master Of Puppets", "4bf462ad-9d49-4247-ac1a-f1ec96a09236" },
                    { "2505c808-85d3-4179-9b11-34b378824317", "c1555908-4197-45d4-878c-890821680fbf", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(7914), null, null, "Battery", "4bf462ad-9d49-4247-ac1a-f1ec96a09236" },
                    { "f5875bf1-3e1c-42c3-8fbe-9689e7907779", "428e0beb-a2e4-4da8-8804-4c94f65f8fd1", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(7896), null, null, "Fear Of The Dark", "7134acb2-a5b9-4f7b-8777-369ec68ce9b8" },
                    { "66fc1ffd-0809-46c6-a2f2-a346997a6aa6", "5119d494-5a39-4935-a2c5-4b97cecedb05", new DateTime(2021, 1, 19, 18, 7, 12, 764, DateTimeKind.Local).AddTicks(7883), null, null, "Numb", "1b30d878-2502-43cf-8b83-70043cd580e9" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "eb4a8ebe-050c-465f-b677-4a44cf3f9770", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2464), null, null, "0f420d41-9ea2-4446-b369-3d05eb6c06e4", "27c9ffab-70c7-4536-8812-188c6e31522a" },
                    { "36445957-16f3-44c3-b188-fadda5b0e9db", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2467), null, null, "0f420d41-9ea2-4446-b369-3d05eb6c06e4", "3d98586a-b3c5-45df-91d9-32d5f284b037" },
                    { "ecb5ceb2-6c9e-4dfa-bb3c-4a0f2a509448", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2474), null, null, "0f420d41-9ea2-4446-b369-3d05eb6c06e4", "2062d3eb-df76-461e-896e-28b4edbee221" },
                    { "a2008f3a-a249-42c5-bfc5-22f0db868e76", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2371), null, null, "444eb861-26bc-465a-83cb-5cdb97c70d58", "27c9ffab-70c7-4536-8812-188c6e31522a" },
                    { "1df25e66-7308-4739-9a69-aecd065c6500", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2436), null, null, "444eb861-26bc-465a-83cb-5cdb97c70d58", "3d98586a-b3c5-45df-91d9-32d5f284b037" },
                    { "215e5761-0fcb-4c3e-9336-32c15dd18ebd", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2453), null, null, "f5875bf1-3e1c-42c3-8fbe-9689e7907779", "3d98586a-b3c5-45df-91d9-32d5f284b037" },
                    { "fcb368e7-5a54-418b-b15f-c1e6335d4c16", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2443), null, null, "66fc1ffd-0809-46c6-a2f2-a346997a6aa6", "27c9ffab-70c7-4536-8812-188c6e31522a" },
                    { "5771e95a-ef00-4b53-8155-f7ab5bb18d01", new DateTime(2021, 1, 19, 18, 7, 12, 765, DateTimeKind.Local).AddTicks(2450), null, null, "66fc1ffd-0809-46c6-a2f2-a346997a6aa6", "2062d3eb-df76-461e-896e-28b4edbee221" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "19bb32f2-a84a-4ff0-babb-a87b53758d6e");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "564d3eaa-a410-4753-89be-acac5b6bfd93");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "940f161e-bc4a-4e2c-8fb9-6c2403bc35f8");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "9fc98e6c-e8d2-4270-8e5e-495d8cee773a");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "1df25e66-7308-4739-9a69-aecd065c6500");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "215e5761-0fcb-4c3e-9336-32c15dd18ebd");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "36445957-16f3-44c3-b188-fadda5b0e9db");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "5771e95a-ef00-4b53-8155-f7ab5bb18d01");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "a2008f3a-a249-42c5-bfc5-22f0db868e76");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "eb4a8ebe-050c-465f-b677-4a44cf3f9770");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "ecb5ceb2-6c9e-4dfa-bb3c-4a0f2a509448");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "fcb368e7-5a54-418b-b15f-c1e6335d4c16");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "2505c808-85d3-4179-9b11-34b378824317");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "3dbaf9f0-3fec-42a4-81a8-fd30ea99b09f");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "5e022174-faa4-4623-88de-a8d8ead139b5");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "e187793f-e7aa-43f8-bfab-47a8b7185b85");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "0f420d41-9ea2-4446-b369-3d05eb6c06e4");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "444eb861-26bc-465a-83cb-5cdb97c70d58");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "66fc1ffd-0809-46c6-a2f2-a346997a6aa6");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "f5875bf1-3e1c-42c3-8fbe-9689e7907779");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2062d3eb-df76-461e-896e-28b4edbee221");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27c9ffab-70c7-4536-8812-188c6e31522a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3d98586a-b3c5-45df-91d9-32d5f284b037");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "428e0beb-a2e4-4da8-8804-4c94f65f8fd1");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "5119d494-5a39-4935-a2c5-4b97cecedb05");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "bcac5c44-8ee8-445a-a20e-7ca019f5fc09");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c1555908-4197-45d4-878c-890821680fbf");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "1b30d878-2502-43cf-8b83-70043cd580e9");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "4bf462ad-9d49-4247-ac1a-f1ec96a09236");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "7134acb2-a5b9-4f7b-8777-369ec68ce9b8");

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
    }
}
