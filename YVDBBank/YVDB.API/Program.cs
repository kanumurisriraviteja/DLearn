using Microsoft.EntityFrameworkCore;
using System.Configuration;
using YVDB.Repos;
using YVDB.Repos.IRepos;

namespace YVDB.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //builder.Services.AddDbContext<DbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddSingleton<ICustomerRepoRBI, CustomerRepo>();
            builder.Services.AddSingleton<IEmployeeRepo, EmployeeRepo>();
            //builder.Services.AddSingleton<IEmployeeRepo, EmployeeRepoDapper>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}