namespace DeadPixelCross;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();

#if WINDOWS
	MainPage = new AppShell();
#endif

#if ANDROID
	MainPage = new AppAndroidShell();
#endif
    }
}
