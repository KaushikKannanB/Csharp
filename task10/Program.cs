using Microsoft.EntityFrameworkCore;
using task10.Data;
using task10.Models;
using task10.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Movie_db_context>(options =>
    options.UseInMemoryDatabase("MoviesDb"));
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Minimal API Endpoints

app.MapGet("/movies", async (IMovieService service) =>
{
    return Results.Ok(await service.GetAll());
});

app.MapGet("/movies/{id}", async (int id, IMovieService service) =>
{
    var movie = await service.GetById(id);
    return movie is not null ? Results.Ok(movie) : Results.NotFound();
});

app.MapPost("/movies", async (Movie movie, IMovieService service) =>
{
    var createdMovie = await service.Create(movie);
    return Results.Created($"/movies/{createdMovie.Id}", createdMovie);
});

app.MapPut("/movies/{id}", async (int id, Movie updatedMovie, IMovieService service) =>
{
    var existingMovie = await service.GetById(id);
    if (existingMovie is null) return Results.NotFound();

    existingMovie.Title = updatedMovie.Title;
    existingMovie.Cast = updatedMovie.Cast;
    existingMovie.Year_of_release = updatedMovie.Year_of_release;
    // existingMovie.Genre = updatedMovie.Genre;

    await service.Update(existingMovie);
    return Results.NoContent();
});

app.MapDelete("/movies/{id}", async (int id, IMovieService service) =>
{
    await service.Delete(id);
    return Results.NoContent();
});

app.Run();
