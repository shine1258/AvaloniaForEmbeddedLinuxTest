using System;
using System.Linq;
using Avalonia;

namespace AvaloniaForEmbeddedLinuxTest;

internal static class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args)
    {
        var appBuilder = BuildAvaloniaApp();

        if (args.Contains("--fbdev"))
        {
            appBuilder.StartLinuxFbDev(args, "/dev/fb0");
        }
        else
        {
            appBuilder.StartWithClassicDesktopLifetime(args);
        }
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    private static AppBuilder BuildAvaloniaApp() =>
        AppBuilder.Configure<App>().UsePlatformDetect().WithInterFont().LogToTrace();
}
