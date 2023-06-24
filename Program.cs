using Avalonia;
using System;

namespace Dual;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace()
            .With(new FontManagerOptions
            {
                DefaultFamilyName = "avares://Dual/Assets/Fonts#Alibaba PuHuiTi 3.0",

                FontFallbacks = new FontFallback[]
                {
                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-35-Thin.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-45-Light.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-55-Regular.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-65-Medium.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-75-SemiBold.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-85-Bold.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-95-ExtraBold.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-105-Heavy.otf#Alibaba PuHuiTi 3.0"
                    },

                    new()
                    {
                        FontFamily = "avares://Dual/Assets/Fonts/AlibabaPuHuiTi-3-115-Black.otf#Alibaba PuHuiTi 3.0"
                    }
                }
            });
}
