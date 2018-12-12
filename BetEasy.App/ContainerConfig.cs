using System;
using Autofac;
using BetEasy.Core.Interfaces;
using BetEasy.Core.Services;
using BetEasy.DataAccess.Repositories;
using Serilog;

namespace BetEasy.App
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<HorseService>().As<IHorseService>();
            builder.RegisterType<CaulfieldRepository>().As<ICaulfieldRepository>();
            builder.RegisterType<WolferhamptonRepository>().As<IWolferhamptonRepository>();
            builder.Register<ILogger>((c, p) => new LoggerConfiguration()
                .WriteTo.RollingFile(
                    AppDomain.CurrentDomain.BaseDirectory.ToString() + "/Log-{Date}.txt")
                .CreateLogger()).SingleInstance();

            return builder.Build();
        }
    }
}
