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
