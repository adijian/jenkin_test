//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
namespace Nayax.Progx.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await GetHostBuilder().Build().RunAsync();
        }
        public static IHostBuilder GetHostBuilder()
        {
            return Host.CreateDefaultBuilder().
                ConfigureWebHostDefaults(webHost => 
                    webHost.UseStartup<Startup>());
        }
    }
}
