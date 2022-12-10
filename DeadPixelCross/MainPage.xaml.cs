using DeadPixelCross.Resources.Language;
using DeadPixelCross.View;
using Microsoft.Maui;
using Thread = System.Threading.Thread;

namespace DeadPixelCross;

public partial class MainPage : ContentPage
{
	int count = 0;
    string lang = string.Empty;


    public MainPage()
	{	
		InitializeComponent();
        lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new ColorTestWindows());
	}

    void PickerSelectedIndexChanged(object sender, EventArgs e)
    {
        header.Text = $"Вы выбрали: {languagePicker.SelectedItem}";
    }
    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //    if (lang == "ru")
    //    {
    //        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
    //        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
    //    }
    //    else
    //    {
    //        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    //        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
    //    }

    //    //get translated title
    //    //using MauiApp1.Resources;
    //    string title = Lang_en.Platform_for;
    //}

    //private void Button_Clicked_1(object sender, EventArgs e)
    //{
    //    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
    //    (App.Current as App).MainPage = new AppShell();
    //}
}

