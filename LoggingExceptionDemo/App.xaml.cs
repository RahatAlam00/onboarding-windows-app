using System.Configuration;
using System.Data;
using System.Windows;
using Serilog;

namespace LoggingExceptionDemo;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(
                "logs/app-log.txt",
                rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Information("Application started");

        base.OnStartup(e);
    }

    protected override void OnExit(ExitEventArgs e)
    {
        Log.Information("Application closing");
        Log.CloseAndFlush();

        base.OnExit(e);
    }
}

