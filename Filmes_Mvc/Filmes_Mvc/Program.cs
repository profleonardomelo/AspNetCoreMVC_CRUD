using Microsoft.EntityFrameworkCore;
using Filmes_Mvc.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Filmes_Mvc.Seeds;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ContextoBD>
    (options => options.UseMySql(
        builder.Configuration.GetConnectionString("ConexaoMySqlLocal"),
        ServerVersion.Parse("8.0.34=mysql")));

var app = builder.Build();

var cultureInfo = new CultureInfo("pt-BR");
app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture(cultureInfo),
    SupportedCultures = new List<CultureInfo> { cultureInfo },
    SupportedUICultures = new List<CultureInfo> { cultureInfo }
});

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    Filmes.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
