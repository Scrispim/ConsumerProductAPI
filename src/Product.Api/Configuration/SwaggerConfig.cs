using Microsoft.OpenApi.Models;

namespace Product.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SC Store Enterprise Identity Api",
                    Description = "This app it is a study about distribuid application.",
                    Contact = new OpenApiContact() { Name = "Sander Crispim", Email = "contato@contato.com" },
                    License = new OpenApiLicense() { Name = "Mit", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            return app;
        }
    }
}
