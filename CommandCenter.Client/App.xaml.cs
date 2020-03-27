using System.Windows;
using CommandCenter.Client.Views;
using CommandCenter.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prism.Ioc;
using Prism.Unity;

namespace CommandCenter.Client
{
    public partial class App : PrismApplication
    {
        private readonly CommandService _commandService = new CommandService();
        private IHost _host;
        
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry registry)
        {
            registry.RegisterInstance<CommandService>(_commandService);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host = Host.CreateDefaultBuilder(e.Args)
                .ConfigureWebHostDefaults(webHostBuilder =>
                {
                    webHostBuilder.UseStartup<CommandCenter.Server.Startup>();
                })
                .ConfigureServices(services =>
                {
                    services.AddSingleton<CommandService>(_commandService);
                })
                .Build();

            _host.Start();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.Dispose();

            base.OnExit(e);
        }
    }
}