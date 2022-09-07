

using Product.Api.Data;
using Product.Api.RabitMQ;
using Product.Api.Services;

namespace Product.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            // Add services to the container.
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<DbContextClass>();
            services.AddScoped<IRabitMQProducer, RabitMQProducer>();
            services.AddControllers();

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
