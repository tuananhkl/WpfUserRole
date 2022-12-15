using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using WpfUser.Common.Const;

namespace WpfUser
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, service) =>
                {
                    service.AddSingleton<MainWindow>();
                    //service.AddSingleton<LoginWindow>();

                    //service.AddDbContext<AppDbContext>(options =>
                    //    options.UseSqlServer(DatabaseConfiguration.DEFAULT_CONNECTION_STRING));

                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();

            base.OnExit(e);
        }
    }
}
