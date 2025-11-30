using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;
using Personal.Pages;
using Personal.Pages.MainMenu;
using Personal.Pages.Tools;
using Personal.Pages.System;


namespace Personal
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureSyncfusionToolkit()                
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("SegoeUI-Semibold.ttf", "SegoeSemibold");
                    fonts.AddFont("FluentSystemIcons-Regular.ttf", FluentUI.FontFamily);
                });

#if DEBUG
    		builder.Logging.AddDebug();
    		builder.Services.AddLogging(configure => configure.AddDebug());
#endif

            builder.Services.AddSingleton<ProjectRepository>();
            builder.Services.AddSingleton<TaskRepository>();
            builder.Services.AddSingleton<CategoryRepository>();
            builder.Services.AddSingleton<TagRepository>();
            builder.Services.AddSingleton<SeedDataService>();

            // Core Fundamental Pages
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginPageModel>();
            builder.Services.AddSingleton<SidebarPage>();
            builder.Services.AddSingleton<SidebarPageModel>();

            // Main Menu Pages
            builder.Services.AddTransient<DashboardPage>();
            builder.Services.AddTransient<OverviewPage>();

            // Tools Pages
            builder.Services.AddTransient<Tools1Page>();
            builder.Services.AddTransient<Tools2Page>();
            builder.Services.AddTransient<Tools3Page>();
            builder.Services.AddTransient<Tools4Page>();
            builder.Services.AddTransient<Tools5Page>();
            builder.Services.AddTransient<Tools6Page>();
            builder.Services.AddTransient<Tools7Page>();

            // Main Menu Pages            
            builder.Services.AddTransient<UsersPage>();
            builder.Services.AddTransient<SettingsPage>();






            return builder.Build();
        }
    }
}
