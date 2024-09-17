using Microsoft.AspNetCore.Hosting.Server;
using System.Reflection;
using DataAccess.Models;
using DataAccess.Wrapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using BusinessLogic.Services;

namespace Api_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            

            builder.Services.AddDbContext<HealthTrackerDBContext>(
           optionsAction:     options => options.UseSqlServer(connectionString: "Server = DESKTOP - VDS4CF5; Database = HealthTrackerDB; Integrated Security = True;"));

            builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            builder.Services.AddScoped<UserService, UserService>();
        }
    }
}

