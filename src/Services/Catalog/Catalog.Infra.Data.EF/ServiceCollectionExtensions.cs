using Catalog.Application.Common.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infra.Data.EF;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfraData(this IServiceCollection services) =>
        services.AddTransient<IUnitOfWork, UnitOfWork>();
}