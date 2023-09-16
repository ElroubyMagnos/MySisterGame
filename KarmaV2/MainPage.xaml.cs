using Plugin.Maui.Audio;
using System.Reflection;

namespace KarmaV2;

public partial class MainPage : ContentPage
{
    IAudioManager I = new AudioManager();
	public MainPage()
	{
		InitializeComponent();

        var ass = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
        Stream s = ass.GetManifestResourceStream("KarmaV2.karma.db");
        MemoryStream ms = new MemoryStream();
        s.CopyTo(ms);
        File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\karma.db", ms.ToArray());
        Coins.con.Open();

        Welcome();
    }

    async void Welcome()
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("wk.mp3"));
        Player.Play();
    }

    private async void Zero_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Zero.mp3"));
        Player.Play();
    }

    private async void One_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("One.mp3"));
        Player.Play();
    }

    private async void Two_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Two.mp3"));
        Player.Play();
    }

    private async void Three_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Three.mp3"));
        Player.Play();
    }

    private async void Four_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Four.mp3"));
        Player.Play();
    }

    private async void Five_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Five.mp3"));
        Player.Play();
    }

    private async void Six_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Six.mp3"));
        Player.Play();
    }

    private async void Seven_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Seven.mp3"));
        Player.Play();
    }

    private async void Eight_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Eight.mp3"));
        Player.Play();
    }

    private async void Nine_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Nine.mp3"));
        Player.Play();
    }
}

