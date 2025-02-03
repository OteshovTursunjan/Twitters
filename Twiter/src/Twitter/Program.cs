
using Microsoft.Extensions.Configuration;
using Twitter.Application;
using Twitter.DataAccess;
using Twitter.DataAccess.Authentication;

namespace Twitter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var configuration = builder.Configuration;
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDataAccess(builder.Configuration).AddApplication(builder.Environment);

            builder.Services.AddDataAccess(builder.Configuration)
                .AddApplication(builder.Environment);

            builder.Services.Configure<JwtOption>(builder.Configuration.GetSection("JwtOptions"));

            builder.Services.AddJwt(builder.Configuration);
            builder.Services.AddHttpContextAccessor();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
