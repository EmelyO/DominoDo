using Microsoft.Extensions.Logging;

namespace DominoDO
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
                   fonts.AddFont("MontserratAlternates-ExtraBold.ttf", "MontserratAlternates-ExtraBold");
                   fonts.AddFont("MontserratAlternates-Regular.ttf", "Montserrat-Regular");
               });
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
