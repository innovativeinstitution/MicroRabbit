using MicroRabbit.Infra.IoC.Upgrade;

namespace MicroRabbit.Transfer.Api.Upgrade.Extensions
{
    public static class Extensions
    {
        public static void RegisterServices(this IHostApplicationBuilder builder)
        {
            DependencyContainer.RegisterServices(builder.Services);
        }
    }
}
