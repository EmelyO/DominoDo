using DominoDO.Pages;

namespace DominoDO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new SplashPage();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}