# MusicAPI

MusicAPI is a Entity Framework .NET Core 3.1 Project, the purpose of which is to contain an accessible library of songs, genres, albums, performers and users.

## Setup

The connection string needed to connect with the database is located in a secret file, the path to which is located at 

```c#
Data.AppDBContext/DBContext.cs
```
```c#
protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            configurationRoot = new ConfigurationBuilder().SetBasePath(Path.Combine(@"PATH")).AddJsonFile("secrets.json").Build();
            dbContextOptionsBuilder.UseSqlServer(configurationRoot.GetSection("DefaultConnection:ConnectionString").Value);
        }
```
## Capabilities

For list of all methods start the index page of the project :
```http
/swagger/index.html
```
### Use :
1. GET
    * getall - All getall methods are identical - They return all records from the current object from the database.
    Getall methods have 2 properties - order and decending
        * order : type = string, this is the name of the attribute by which the results are ordered. The default value is "Name".
        * decending : type = bool, if set to true results will be ordered by decending, if false - by ascending. The default value is "false".
    * songs/getsongsofbyyear - returns a list of songs of a chosen performer from a chosen year. It has 2 properties:
        * perfName : type = string, the name of the performer, whose songs you want to see.
        * year : type = int, the year of the songs.
    * getfavourites - returns the songs favourited by the current user.
2. POST
    * add : album, albumgenre, genre, performer, song. These metods are used to add new records in the database. They accept as parameters their corresponding post schemas, outlayed in the swagger index page.
    * users/addfavourite - adds a song to the current user's favourites.
        * songName - the name of the song to be added.
    * update : album, genre, performer, song. These methods are used to update existing records in the database. They accept as parameters their corresponding post schemas, outlayed in the swagger index page and :
        * name : type = string, the name attribute of the record that is to be updated.
    * users/updateuserrole - Updates the role of a user.
        * username : type = string, the name of the user whose role is to be updated.
        * role : type = string, the new role for the user.
    * identity/register - adds new user to the database. As parameter it uses RegisterModel schema. Returns a token generated for the new user.
    * identity/login - adds new user to the database. As parameter it uses LoginModel schema. Returns a token generated for the user.
     * identity/changepassword - changes the password of the current user. As parameter it uses ChangePassword schema.
      * identity/changeusername - changes the username of the current user. Returns a token generated for the user with the new username.
        * newUsername : type = string, the new username to which the current username is to be changed.
3. DELETE
    * delete : album, genre, performer, song. Deletes a record from the corresponding table from the database. A record can not be deleted if it is being referenced by another record.
        * name : type = string, the name attribute of the record that is to be deleted.
    * albums/deletealbumgenre - deletes a record from the AlbumGenre table (deletes a genre from an album).
        * albumName : type = string, the name of the album, whose genre is to be removed.
        * genreName : type = string, the name of the genre that is to be removed from the album.
    * identity/deleteaccount - Deletes the current user from the database.
        * password : type = string, the password of the current user.
    * users/deletefavourite - Deletes a record from the Favourites table from the database(removes a song from the current user's favourites).
        * songName : type = string, the name of the song that is to be removed.
    * users/deleteuser - deletes a user fromthe database.
        * username : type = string, the username of the user that is to be deleted.

## Roles

There are 3 roles for users :
1. User - Has access to :
    * Albums/getall
    * Genres/getall
    * Performers/getall
    * Songs/
        * getall
        * getsongsofbyyear
    * Users/
        * getfavourites
        * addfavourites
        * deletefavourite
    * Identity/
        * changepassword
        * changeusername
        * deleteacc
2. Moderator - Has User access plus :
    * Albums/
        * addalbum
        * addalbumgenre
        * updatealbum
        * deletealbum
    * Genres/
        * addgenre
        * updategenre
        * deletegenre
    * Performers/
        * addperformer
        * updateperformer
        * deleteperformer
    * Songs/
        * addsong
        * updatesong
        * deletesong
3. Admin - Has Moderator access plus :
    * Users/
        * getall
        * updateuserrole
        * deleteuser

Identity/register and Identity/login are accessible without authorization.
## License
[MIT](https://choosealicense.com/licenses/mit/)