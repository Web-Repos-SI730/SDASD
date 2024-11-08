using Microsoft.EntityFrameworkCore;

namespace VeterinaryCampaign.Shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options):DbContext(options)
{
    protected override void OnConfiguring(DbContexOptionsBuilder builder)
    {
        builder.AddCreatedUpdateInterceptor();
        base.OnConfiguring(builder);
        
    }
}