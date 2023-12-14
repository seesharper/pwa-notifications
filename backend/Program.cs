using Webfaggruppe.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSpaStaticFiles(config => config.RootPath = "wwwroot");
builder.Services.AddSignalR();

var app = builder.Build();

app.MapGet("/", () => "Hello World!"); 
app.UseStaticFiles();
app.UseSpaStaticFiles();
app.UseSpa(config => config.Options.SourcePath = "wwwroot");

app.MapHub<MyFirstHub>("/myFirsthub");


app.Run();
