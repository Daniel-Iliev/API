using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.AppDBContext.Migrations
{
    public partial class Filldatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "1f869b14-9d24-4262-ad99-ba83272bb2e7");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "7088f56b-c756-4222-acd1-1b1082fc8053");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "930c864d-3405-4b6f-a90d-c4bf80c3a79f");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "e3a7467a-7470-4bf3-acc8-5d10d469522b");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "07ce6534-a901-4ad8-b648-2408605b99bf");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "0d7cf98e-d379-4fa8-8c24-c435b4a74524");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "c8acac73-8a45-463e-9b1f-c084ed88cefd");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "cc0a2ea6-0c46-4aaf-b73c-6c7c0423b46e");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "cee3fa8d-16fb-44b3-ba42-a47565b5d95d");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "cf158dcd-d856-4553-8c52-bd0d6ca3bd86");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "dce6c7c2-c129-4494-8b71-656c31224572");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "efb08ba0-3fed-4db5-a115-6ad5fba1e33b");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "35b5ecc5-5562-4e56-abf8-9908e97479eb");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "4b970e7c-66b7-4486-9541-f110c3162e9e");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "8c50acec-a20a-4234-bc09-dec2aba48f1c");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "b43103e1-4e84-489f-aec7-6a9744eaab4d");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "0ece1862-5637-49ff-8c8f-d9537d32b97f");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "7b3db283-c820-4676-827b-336813806fa0");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "9158e409-12c8-44db-9869-7443f9f8dbc6");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "08db0f33-8539-45f2-9338-2444b7187f48");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "2461af5a-706f-4739-9f9b-8a9d9dcb068d");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "b4c1f7de-d3ef-4e2c-8ab1-d9bc72d48078");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "c95f51f6-8cd5-4a7c-bc5e-7e2f6e42394d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3cf0b1bb-2b3f-43e0-857f-5d3130a5e2d0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "53aab963-a235-491e-a55a-7132c65ffe4c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "99a68ca2-f335-4c17-af59-7e349ae65e38");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "7077f612-af75-48d3-981a-98c620ba4d36");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "7f43bd44-fa9a-4a82-b39c-0bbc0cbc2727");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "8155d4b2-f2f1-4675-a0fe-826733f525f3");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c2ceaf88-f91d-490a-bbd3-49d5ca572f4b");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "5265a577-36f8-4853-a05a-292f05730e70");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "8e9b94b1-b18a-41a8-bb03-a5d250b3f9d0");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "e5227f6f-2936-41cb-911c-8df77727806f");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "41809a39-4915-4d18-93f2-72be8bf47dd4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Metal" },
                    { "604556e9-f41c-4e28-889c-b63493e55d80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nu-Metal" },
                    { "e7408c1a-07d3-45c7-a24a-efb0aae76fe1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "fad20c72-cb3c-4ac8-88c6-66d14768830d", new DateTime(2020, 12, 16, 9, 57, 7, 407, DateTimeKind.Local).AddTicks(357), null, null, "Metallica" },
                    { "f8829c40-1269-4354-af8a-5c4a9dc485f6", new DateTime(2020, 12, 16, 9, 57, 7, 408, DateTimeKind.Local).AddTicks(8665), null, null, "Iron Maiden" },
                    { "3c141ed5-dd3b-482f-afa2-cf43d24f21a3", new DateTime(2020, 12, 16, 9, 57, 7, 408, DateTimeKind.Local).AddTicks(8713), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "ModifiedAt", "Password", "Username" },
                values: new object[,]
                {
                    { "b8a74375-8ca5-4966-b44d-f31fe3117211", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "george@123.bg", null, "123", "George" },
                    { "0dfe5c1b-646a-4d73-a467-365318003bab", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "martin@123.bg", null, "123", "Martin" },
                    { "2c543e1e-20aa-4a7f-bafd-226c3d627728", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jake@123.bg", null, "123", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "eb4e9469-92dd-4ee5-9090-8461befe87e6", new DateTime(2020, 12, 16, 9, 57, 7, 409, DateTimeKind.Local).AddTicks(942), null, null, "Ride The Lightning", "fad20c72-cb3c-4ac8-88c6-66d14768830d", 1984 },
                    { "026c4bfe-14e3-4415-a4f7-47006bc03dc4", new DateTime(2020, 12, 16, 9, 57, 7, 409, DateTimeKind.Local).AddTicks(1034), null, null, "Master Of Puppets", "fad20c72-cb3c-4ac8-88c6-66d14768830d", 1986 },
                    { "f1270228-d5de-4268-bdd0-cf5116ca8dea", new DateTime(2020, 12, 16, 9, 57, 7, 409, DateTimeKind.Local).AddTicks(1045), null, null, "Fear Of The Dark", "f8829c40-1269-4354-af8a-5c4a9dc485f6", 1992 },
                    { "a671573d-5720-4675-8b7d-5ac49cdb73ae", new DateTime(2020, 12, 16, 9, 57, 7, 409, DateTimeKind.Local).AddTicks(1051), null, null, "Meteora", "3c141ed5-dd3b-482f-afa2-cf43d24f21a3", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "GenreId", "ModifiedAt" },
                values: new object[,]
                {
                    { "5058c802-2e65-4df2-8935-08c1c49f90dd", "eb4e9469-92dd-4ee5-9090-8461befe87e6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41809a39-4915-4d18-93f2-72be8bf47dd4", null },
                    { "51ae8d68-ca16-41f5-9c5f-5af8943a8379", "026c4bfe-14e3-4415-a4f7-47006bc03dc4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "e7408c1a-07d3-45c7-a24a-efb0aae76fe1", null },
                    { "030c10b4-1161-436c-bb75-36abff240ca7", "f1270228-d5de-4268-bdd0-cf5116ca8dea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "41809a39-4915-4d18-93f2-72be8bf47dd4", null },
                    { "16bcac2f-2082-494e-a172-e9512fd5a301", "a671573d-5720-4675-8b7d-5ac49cdb73ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "604556e9-f41c-4e28-889c-b63493e55d80", null }
                });

            migrationBuilder.InsertData(
                table: "PerformerAlbums",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "PerformerId" },
                values: new object[,]
                {
                    { "b764b07b-d9b5-4f5a-8b6b-be5fb4c07800", "eb4e9469-92dd-4ee5-9090-8461befe87e6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "fad20c72-cb3c-4ac8-88c6-66d14768830d" },
                    { "9a88f07f-6160-44e6-937c-b0009f9af5e2", "026c4bfe-14e3-4415-a4f7-47006bc03dc4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "fad20c72-cb3c-4ac8-88c6-66d14768830d" },
                    { "63fa7978-28d5-4e10-b7d2-c343ce0c81ab", "f1270228-d5de-4268-bdd0-cf5116ca8dea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "f8829c40-1269-4354-af8a-5c4a9dc485f6" },
                    { "9fac3faa-ed07-448b-babe-952c123a7557", "a671573d-5720-4675-8b7d-5ac49cdb73ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "3c141ed5-dd3b-482f-afa2-cf43d24f21a3" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "e7d41fbc-dbac-406f-826d-cfa2546b510d", "eb4e9469-92dd-4ee5-9090-8461befe87e6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "For Whom The Bell Tolls" },
                    { "b5765be5-ef00-4355-9167-3d15e689d8f1", "026c4bfe-14e3-4415-a4f7-47006bc03dc4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Master Of Puppets" },
                    { "24457118-19da-4e5a-be61-db60d2554cb9", "026c4bfe-14e3-4415-a4f7-47006bc03dc4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Battery" },
                    { "a9c1b8f9-70bc-4a6f-ab72-795a6fa03098", "f1270228-d5de-4268-bdd0-cf5116ca8dea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fear Of The Dark" },
                    { "2cdbf016-e622-4d9b-94cf-994f506df8e1", "a671573d-5720-4675-8b7d-5ac49cdb73ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Numb" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "78fb05c0-a6b8-4e94-945d-f50782dcd57c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "e7d41fbc-dbac-406f-826d-cfa2546b510d", "b8a74375-8ca5-4966-b44d-f31fe3117211" },
                    { "2c5863e8-f200-4864-9119-06c28031ca1f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "e7d41fbc-dbac-406f-826d-cfa2546b510d", "0dfe5c1b-646a-4d73-a467-365318003bab" },
                    { "72aefee2-a0b1-434f-9588-48d2d38567e6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "e7d41fbc-dbac-406f-826d-cfa2546b510d", "2c543e1e-20aa-4a7f-bafd-226c3d627728" },
                    { "29e2aff8-b677-4f41-9fe4-0480f529279c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "b5765be5-ef00-4355-9167-3d15e689d8f1", "b8a74375-8ca5-4966-b44d-f31fe3117211" },
                    { "24f4e295-78a2-4b34-9ae5-ce8a2050d8cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "b5765be5-ef00-4355-9167-3d15e689d8f1", "0dfe5c1b-646a-4d73-a467-365318003bab" },
                    { "812d14fc-126c-44e7-8cad-53f0ee9efe7a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "a9c1b8f9-70bc-4a6f-ab72-795a6fa03098", "0dfe5c1b-646a-4d73-a467-365318003bab" },
                    { "dbf82772-4406-48a7-85a1-6083eecafb71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2cdbf016-e622-4d9b-94cf-994f506df8e1", "b8a74375-8ca5-4966-b44d-f31fe3117211" },
                    { "e1afbd79-a138-4644-af2a-6269cde8469f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2cdbf016-e622-4d9b-94cf-994f506df8e1", "2c543e1e-20aa-4a7f-bafd-226c3d627728" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "030c10b4-1161-436c-bb75-36abff240ca7");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "16bcac2f-2082-494e-a172-e9512fd5a301");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "5058c802-2e65-4df2-8935-08c1c49f90dd");

            migrationBuilder.DeleteData(
                table: "AlbumGenres",
                keyColumn: "Id",
                keyValue: "51ae8d68-ca16-41f5-9c5f-5af8943a8379");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "24f4e295-78a2-4b34-9ae5-ce8a2050d8cf");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "29e2aff8-b677-4f41-9fe4-0480f529279c");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "2c5863e8-f200-4864-9119-06c28031ca1f");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "72aefee2-a0b1-434f-9588-48d2d38567e6");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "78fb05c0-a6b8-4e94-945d-f50782dcd57c");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "812d14fc-126c-44e7-8cad-53f0ee9efe7a");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "dbf82772-4406-48a7-85a1-6083eecafb71");

            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: "e1afbd79-a138-4644-af2a-6269cde8469f");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "63fa7978-28d5-4e10-b7d2-c343ce0c81ab");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "9a88f07f-6160-44e6-937c-b0009f9af5e2");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "9fac3faa-ed07-448b-babe-952c123a7557");

            migrationBuilder.DeleteData(
                table: "PerformerAlbums",
                keyColumn: "Id",
                keyValue: "b764b07b-d9b5-4f5a-8b6b-be5fb4c07800");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "24457118-19da-4e5a-be61-db60d2554cb9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "41809a39-4915-4d18-93f2-72be8bf47dd4");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "604556e9-f41c-4e28-889c-b63493e55d80");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "e7408c1a-07d3-45c7-a24a-efb0aae76fe1");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "2cdbf016-e622-4d9b-94cf-994f506df8e1");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "a9c1b8f9-70bc-4a6f-ab72-795a6fa03098");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "b5765be5-ef00-4355-9167-3d15e689d8f1");

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: "e7d41fbc-dbac-406f-826d-cfa2546b510d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0dfe5c1b-646a-4d73-a467-365318003bab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2c543e1e-20aa-4a7f-bafd-226c3d627728");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b8a74375-8ca5-4966-b44d-f31fe3117211");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "026c4bfe-14e3-4415-a4f7-47006bc03dc4");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "a671573d-5720-4675-8b7d-5ac49cdb73ae");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "eb4e9469-92dd-4ee5-9090-8461befe87e6");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f1270228-d5de-4268-bdd0-cf5116ca8dea");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "3c141ed5-dd3b-482f-afa2-cf43d24f21a3");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "f8829c40-1269-4354-af8a-5c4a9dc485f6");

            migrationBuilder.DeleteData(
                table: "Performers",
                keyColumn: "Id",
                keyValue: "fad20c72-cb3c-4ac8-88c6-66d14768830d");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "9158e409-12c8-44db-9869-7443f9f8dbc6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Metal" },
                    { "7b3db283-c820-4676-827b-336813806fa0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nu-Metal" },
                    { "0ece1862-5637-49ff-8c8f-d9537d32b97f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Performers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "5265a577-36f8-4853-a05a-292f05730e70", new DateTime(2020, 12, 11, 22, 36, 3, 129, DateTimeKind.Local).AddTicks(3531), null, null, "Metallica" },
                    { "8e9b94b1-b18a-41a8-bb03-a5d250b3f9d0", new DateTime(2020, 12, 11, 22, 36, 3, 131, DateTimeKind.Local).AddTicks(7999), null, null, "Iron Maiden" },
                    { "e5227f6f-2936-41cb-911c-8df77727806f", new DateTime(2020, 12, 11, 22, 36, 3, 131, DateTimeKind.Local).AddTicks(8053), null, null, "Linkin Park" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "ModifiedAt", "Password", "Username" },
                values: new object[,]
                {
                    { "53aab963-a235-491e-a55a-7132c65ffe4c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "george@123.bg", null, "123", "George" },
                    { "3cf0b1bb-2b3f-43e0-857f-5d3130a5e2d0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "martin@123.bg", null, "123", "Martin" },
                    { "99a68ca2-f335-4c17-af59-7e349ae65e38", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jake@123.bg", null, "123", "Jake" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "PerformerId", "YearReleased" },
                values: new object[,]
                {
                    { "7077f612-af75-48d3-981a-98c620ba4d36", new DateTime(2020, 12, 11, 22, 36, 3, 132, DateTimeKind.Local).AddTicks(900), null, null, "Ride The Lightning", "5265a577-36f8-4853-a05a-292f05730e70", 1984 },
                    { "c2ceaf88-f91d-490a-bbd3-49d5ca572f4b", new DateTime(2020, 12, 11, 22, 36, 3, 132, DateTimeKind.Local).AddTicks(1026), null, null, "Master Of Puppets", "5265a577-36f8-4853-a05a-292f05730e70", 1986 },
                    { "7f43bd44-fa9a-4a82-b39c-0bbc0cbc2727", new DateTime(2020, 12, 11, 22, 36, 3, 132, DateTimeKind.Local).AddTicks(1108), null, null, "Fear Of The Dark", "8e9b94b1-b18a-41a8-bb03-a5d250b3f9d0", 1992 },
                    { "8155d4b2-f2f1-4675-a0fe-826733f525f3", new DateTime(2020, 12, 11, 22, 36, 3, 132, DateTimeKind.Local).AddTicks(1125), null, null, "Meteora", "e5227f6f-2936-41cb-911c-8df77727806f", 2003 }
                });

            migrationBuilder.InsertData(
                table: "AlbumGenres",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "GenreId", "ModifiedAt" },
                values: new object[,]
                {
                    { "e3a7467a-7470-4bf3-acc8-5d10d469522b", "7077f612-af75-48d3-981a-98c620ba4d36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "9158e409-12c8-44db-9869-7443f9f8dbc6", null },
                    { "7088f56b-c756-4222-acd1-1b1082fc8053", "c2ceaf88-f91d-490a-bbd3-49d5ca572f4b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0ece1862-5637-49ff-8c8f-d9537d32b97f", null },
                    { "1f869b14-9d24-4262-ad99-ba83272bb2e7", "7f43bd44-fa9a-4a82-b39c-0bbc0cbc2727", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "9158e409-12c8-44db-9869-7443f9f8dbc6", null },
                    { "930c864d-3405-4b6f-a90d-c4bf80c3a79f", "8155d4b2-f2f1-4675-a0fe-826733f525f3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7b3db283-c820-4676-827b-336813806fa0", null }
                });

            migrationBuilder.InsertData(
                table: "PerformerAlbums",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "PerformerId" },
                values: new object[,]
                {
                    { "8c50acec-a20a-4234-bc09-dec2aba48f1c", "7077f612-af75-48d3-981a-98c620ba4d36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "5265a577-36f8-4853-a05a-292f05730e70" },
                    { "b43103e1-4e84-489f-aec7-6a9744eaab4d", "c2ceaf88-f91d-490a-bbd3-49d5ca572f4b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "5265a577-36f8-4853-a05a-292f05730e70" },
                    { "4b970e7c-66b7-4486-9541-f110c3162e9e", "7f43bd44-fa9a-4a82-b39c-0bbc0cbc2727", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "8e9b94b1-b18a-41a8-bb03-a5d250b3f9d0" },
                    { "35b5ecc5-5562-4e56-abf8-9908e97479eb", "8155d4b2-f2f1-4675-a0fe-826733f525f3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "e5227f6f-2936-41cb-911c-8df77727806f" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "CreatedAt", "DeletedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "c95f51f6-8cd5-4a7c-bc5e-7e2f6e42394d", "7077f612-af75-48d3-981a-98c620ba4d36", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "For Whom The Bell Tolls" },
                    { "08db0f33-8539-45f2-9338-2444b7187f48", "c2ceaf88-f91d-490a-bbd3-49d5ca572f4b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Master Of Puppets" },
                    { "2461af5a-706f-4739-9f9b-8a9d9dcb068d", "7f43bd44-fa9a-4a82-b39c-0bbc0cbc2727", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fear Of The Dark" },
                    { "b4c1f7de-d3ef-4e2c-8ab1-d9bc72d48078", "8155d4b2-f2f1-4675-a0fe-826733f525f3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Numb" }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "SongId", "UserId" },
                values: new object[,]
                {
                    { "cee3fa8d-16fb-44b3-ba42-a47565b5d95d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "c95f51f6-8cd5-4a7c-bc5e-7e2f6e42394d", "53aab963-a235-491e-a55a-7132c65ffe4c" },
                    { "0d7cf98e-d379-4fa8-8c24-c435b4a74524", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "c95f51f6-8cd5-4a7c-bc5e-7e2f6e42394d", "3cf0b1bb-2b3f-43e0-857f-5d3130a5e2d0" },
                    { "cf158dcd-d856-4553-8c52-bd0d6ca3bd86", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "c95f51f6-8cd5-4a7c-bc5e-7e2f6e42394d", "99a68ca2-f335-4c17-af59-7e349ae65e38" },
                    { "efb08ba0-3fed-4db5-a115-6ad5fba1e33b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "08db0f33-8539-45f2-9338-2444b7187f48", "53aab963-a235-491e-a55a-7132c65ffe4c" },
                    { "c8acac73-8a45-463e-9b1f-c084ed88cefd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "08db0f33-8539-45f2-9338-2444b7187f48", "3cf0b1bb-2b3f-43e0-857f-5d3130a5e2d0" },
                    { "cc0a2ea6-0c46-4aaf-b73c-6c7c0423b46e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2461af5a-706f-4739-9f9b-8a9d9dcb068d", "3cf0b1bb-2b3f-43e0-857f-5d3130a5e2d0" },
                    { "dce6c7c2-c129-4494-8b71-656c31224572", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "b4c1f7de-d3ef-4e2c-8ab1-d9bc72d48078", "53aab963-a235-491e-a55a-7132c65ffe4c" },
                    { "07ce6534-a901-4ad8-b648-2408605b99bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "b4c1f7de-d3ef-4e2c-8ab1-d9bc72d48078", "99a68ca2-f335-4c17-af59-7e349ae65e38" }
                });
        }
    }
}
