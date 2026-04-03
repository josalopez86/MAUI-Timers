using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using WorkoutTimers.App.Views;
using WorkoutTimers.lib.Services;
using WorkoutTimers.Lib.Services;
using WorkoutTimers.Lib.ViewModels;

namespace WorkoutTimers.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureEssentials((ess) =>
                {
                    ess.UseVersionTracking();
                })
                .Services.AddSingleton<IIntervalService, InMemoryIntervalService>()
                .AddSingleton<RegularIntervalsModel>()
                //.AddTransient<NewRegularIntervalModel>()
                //.AddSingleton<StaggeredIntervalModel>()
                .AddSingleton<StaggeredIntervalsModel>()
                .AddTransient<NewStaggeredIntervalModel>()
                .AddSingleton<SettingsModel>()
                .AddSingleton<StaggeredIntervals>()
                .AddSingleton<RegularIntervals>()
                .AddTransient<NewStaggeredInterval>()
                .AddTransient<NewRegularInterval>()
                .AddSingleton<Settings>()
                .AddSingleton<NewContentPage>()
                .AddSingleton<IVersionInfo, WorkoutTimers.lib.VersionInfo>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
