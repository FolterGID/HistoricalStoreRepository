using HistoricalStore.Data.DatabaseContext;
using HistoricalStore.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace HistoricalStore.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<StoreContext>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddControllers();
            builder.Services.AddScoped(typeof(ICrudService<>), typeof(CrudService<>));

            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowBlazorClient", policy => 
                    policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            var app = builder.Build();

            app.UseCors("AllowBlazorClient");

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.MapControllers();

            app.Run();
        }
    }
}
