using Microsoft.AspNetCore.Mvc;

var app = WebApplication.Create();

app.MapGet("/", () => "Hello World!");

app.MapPost("/todos", async ([FromServices] TodoDbContext db, Todo todo) =>
{
    await db.Todos.AddAsync(todo);
    await db.SaveChangesAsync();

    return new StatusCodeResult(204);
});



await app.RunAsync();
