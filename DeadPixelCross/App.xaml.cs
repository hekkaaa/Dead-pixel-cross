using Microsoft.Maui;

namespace DeadPixelCross;

public partial class App : Application
{
    public App()
	{
        InitializeComponent();

#if WINDOWS
	MainPage = new AppShell();
#endif

#if ANDROID
        MainPage = new AppAndroidShell();
#endif


    }

#if WINDOWS
    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int newWidth = 400;
        const int newHeight = 600;

        window.X = 550;
        window.Y = 100;

        window.MinimumWidth = newWidth;
        window.MinimumHeight = newHeight;

        window.Width = newWidth;
        window.Height = newHeight;

        return window;
    }
#endif

}
