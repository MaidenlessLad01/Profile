using Microsoft.Extensions.Logging;

namespace Profile
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
                    fonts.AddFont("Cattie-Regular.ttf", "car");
                    fonts.AddFont("04B_30__.ttf", "aaa");
                    fonts.AddFont("Pixels.ttf","pixel");
                    fonts.AddFont("fontello.ttf", "man");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
