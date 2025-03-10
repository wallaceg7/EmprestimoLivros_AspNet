using EmprestimoLivros.Data;
using EmprestimoLivros.Services.LoginService;
using EmprestimoLivros.Services.SenhaService;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Adiciona o servi�o de banco de dados
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                // Passa como op��o a configura��o de conex�o do banco de dados
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<ILoginInterface, LoginService>();
            builder.Services.AddScoped<ISenhaInterface, SenhaService>();

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
        }
    }
}