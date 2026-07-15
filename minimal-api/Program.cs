using MinimalApi.dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "12345")
    {
        return Results.Ok("Login successful");
    }
    else
        return Results.Unauthorized();
});


app.Run();



