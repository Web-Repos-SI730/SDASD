using VeterinaryCampaign.Shared.Domain.Repositories;
using VeterinaryCampaign.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace VeterinaryCampaign.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork(AppDbContext context): IUnitOfWork
{
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}