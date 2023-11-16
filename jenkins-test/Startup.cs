
namespace Nayax.Progx.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod();
                    });
            });
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseCors("AllowLocalhost");
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
