<<<<<<< HEAD
ï»¿using EmprestimoLivros.Data;
=======
using EmprestimoLivros.Data;
>>>>>>> 25b43c8a1cdcea57305af8b31dc0c8156aebed46
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

<<<<<<< HEAD
//Service de conexao com o banco de dados
=======
//Service de conexão com o banco de dados
>>>>>>> 25b43c8a1cdcea57305af8b31dc0c8156aebed46
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); //DB Config do appsettings
});

var app = builder.Build();

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
