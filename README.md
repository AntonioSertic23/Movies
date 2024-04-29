# Movies

## Desktop application for managing a movie catalog

The Movies application originated as a project during college for the construction exercises in the **Programming in .NET environment** course.

The application is designed to keep track of movies, enabling users to manage their favorite watched films.

The project was developed using Visual Studio within the **Windows Forms (.NET)** framework, using **C#**, and **Microsoft SQL Server** for database management.

[![My Skills](https://skillicons.dev/icons?i=dotnet,cs,sqlite)](https://skillicons.dev)

The application includes user registration and login with necessary parameter validations. For previously saved movies, there is an option to update the IMDb rating by clicking the "Refresh" button.

To fetch movie data, the application uses the [OMDb API](https://www.omdbapi.com/).

---

### Upon successful login, users can:

- Search for movies by title and year
- View details of individual movies
- Add movies to their watchlist and assign personal ratings
- View their list of movies
- Search their watchlist by title, year, and genre
- Update assigned ratings
- Remove movies from their watchlist

---

### Project Setup

To run the project, you need to create your own _api key_ on the official [OMDb API-a](https://www.omdbapi.com/) website and then paste the obtained _api key_ into `Form1.cs` under:

```sh
const string ApiKey = "";
```

You need to create a database with the following tables: _sertic_Movies_ based on the `Movie.cs` model and _sertic_Users_ based on the `Users.cs` model.

Table names can be arbitrary, but in that case, you need to modify the queries within `MoviesRepository.cs` and `RegForma.cs` accordingly.

Then, add the database path in `MoviesRepository.cs` and `RegForma.cs` under:

```sh
readonly string ConnectionString = @"";
```
