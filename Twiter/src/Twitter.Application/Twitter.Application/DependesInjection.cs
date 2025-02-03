using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Application.Service.lmpl;
using Twitter.Application.Service;
using Twitters.Shared;

namespace Twitter.Application
{
    public static class DependesInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IWebHostEnvironment env)
        {
            services.AddServices(env);
            services.RegisterCaching();
            return services;
        }

        private static void AddServices(this IServiceCollection services, IWebHostEnvironment env)
        {
            // Регистрация зависимостей сервисов
            services.AddScoped<IClaimService, ClaimService>();
            services.AddScoped<ICreatePostService, CreatePostService>();
            services.AddScoped<IPostLikeService, PostLikeService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ISavesService, SavesService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWriteCommonService, WriteCommentService>();
            services.AddScoped<TokenService, TokenService>();



        }

        private static void RegisterCaching(this IServiceCollection services)
        {
            // Регистрация кэша в памяти
            services.AddMemoryCache();
        }

    }
}

