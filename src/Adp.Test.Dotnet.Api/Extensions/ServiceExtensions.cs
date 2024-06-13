using Adp.Test.Dotnet.Core.Interfaces;
using Adp.Test.Dotnet.Core.Services;

namespace Adp.Test.Dotnet.Api.Extensions;
public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IItemService, ItemService>();
        return services;
    }
}
