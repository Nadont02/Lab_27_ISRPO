var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-233! Автор: Дунюшкин Н.С");

app.Run();
