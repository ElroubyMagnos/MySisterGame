using Plugin.Maui.Audio;

namespace KarmaV2;

public partial class ARNumbers : ContentPage
{
    IAudioManager I = new AudioManager();
    public ARNumbers()
	{
		InitializeComponent();
	}

    private async void Zero_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Zero-ar.mp3"));
        Player.Play();
    }

    private async void One_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("One-ar.mp3"));
        Player.Play();
    }

    private async void Two_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Two-ar.mp3"));
        Player.Play();
    }

    private async void Three_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Three-ar.mp3"));
        Player.Play();
    }

    private async void Four_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Four-ar.mp3"));
        Player.Play();
    }

    private async void Five_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Five-ar.mp3"));
        Player.Play();
    }

    private async void Six_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Six-ar.mp3"));
        Player.Play();
    }

    private async void Seven_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Seven-ar.mp3"));
        Player.Play();
    }

    private async void Eight_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Eight-ar.mp3"));
        Player.Play();
    }

    private async void Nine_Clicked(object sender, EventArgs e)
    {
        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Nine-ar.mp3"));
        Player.Play();
    }
}