using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Riversand.Common.SFTP;
using Riversand.Common.SFTP.Abstract;

namespace Riversand.Desktop;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();

        Application.Run(host.Services.GetRequiredService<Form1>());
    }

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services
                    .AddSingleton<ISftpManager, SftpManager>()
                    .AddSingleton<Form1>();
            });
    }
}