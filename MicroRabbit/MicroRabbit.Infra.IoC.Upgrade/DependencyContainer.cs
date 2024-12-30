using MediatR;
using MicroRabbit.Banking.Application.Upgrade.Interfaces;
using MicroRabbit.Banking.Application.Upgrade.Services;
using MicroRabbit.Banking.Data.Upgrade.Context;
using MicroRabbit.Banking.Data.Upgrade.Repository;
using MicroRabbit.Banking.Domain.Upgrade.CommandHandlers;
using MicroRabbit.Banking.Domain.Upgrade.Commands;
using MicroRabbit.Banking.Domain.Upgrade.Interfaces;
using MicroRabbit.Domain.Core.Upgrade.Bus;
using MicroRabbit.Infra.Bus.Upgrade;
using MicroRabbit.Transfer.Application.Upgrade.Interfaces;
using MicroRabbit.Transfer.Application.Upgrade.Services;
using MicroRabbit.Transfer.Data.Upgrade.Context;
using MicroRabbit.Transfer.Data.Upgrade.Repository;
using MicroRabbit.Transfer.Domain.Upgrade.EventHandlers;
using MicroRabbit.Transfer.Domain.Upgrade.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC.Upgrade
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<TransferEventHandler>();

            //Domain Events
            services.AddTransient<IEventHandler<Transfer.Domain.Upgrade.Events.TransferCreatedEvent>, TransferEventHandler>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
