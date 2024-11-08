using Microsoft.EntityFrameworkCore;
namespace VeterinaryCampaign.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

public class ModelBuilderExtensions
{
    public static void UseSnakeCaseNamingConvention(ModelBuilder builder)
    {
        foreach (var entity in builder.Model.GetEntityTypes())
        {
            var tableName= entity.GetTableName();
            if(!string.IsNullOrEmpty(tableName)) entity.SetTableName(tableName.ToP
            
        }
    }
}