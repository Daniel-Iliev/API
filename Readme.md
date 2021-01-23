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
## Endpoints

For documentation of the endpoints of the project start the project with the default index page :

```http
/swagger/index.html
```
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