using Microsoft.EntityFrameworkCore;

namespace House_API
{
    public class MigrationService
    {
        public static void InitializeMigration(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            serviceScope.ServiceProvider.GetService<ProductDBContext>()!.Database.Migrate();
        }
    }
}
