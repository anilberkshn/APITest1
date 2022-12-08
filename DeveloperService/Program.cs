Console.WriteLine("Hello from Anil");

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () => "Test endpoint");

app.MapGet("/anil", () =>
{
    string anil = string.Empty;
    for (int i = 0; i < 6; i++)
    {
        anil += i + " ";
    }
    return anil;
});
app.Run();