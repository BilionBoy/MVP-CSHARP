using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeuMVP.Data; // Se o contexto estiver na pasta Data

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MeuMVPContext>(options =>
    options.UseSqlite("Data Source=meumvp.db"));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Evento}/{action=Index}/{id?}");

app.Run();
