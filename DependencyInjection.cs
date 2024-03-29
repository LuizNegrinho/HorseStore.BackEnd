﻿using HorseStore.BackEnd.Application;
using HorseStore.BackEnd.Repositories;

namespace HorseStore.BackEnd
{
    public static class DependencyInjection
    {
        public static void Injection(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductApplication, ProductApplication>();
            services.AddScoped<ILoginApplication, LoginApplication>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ICommonService, CommonService>();
        }
    }
}
