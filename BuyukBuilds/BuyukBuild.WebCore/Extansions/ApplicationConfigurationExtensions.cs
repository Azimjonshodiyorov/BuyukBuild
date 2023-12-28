using Microsoft.EntityFrameworkCore;
using Serilog;

namespace BuyukBuild.WebCore.Extansions
{
    public static class ApplicationConfigurationExtensions
    {
        public static async Task ApplyMigrationsAsync<T>(this WebApplication application ) where T : DbContext
        {
            Log.Information("Migration ....... to Databse");
            var scope = application.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetService<T>();

            if(dbContext is null)
            {
                Log.Error("Data Context not found");

                Environment.Exit(1);
            }

           
        }
    }
}
