using Plugin.Maui.Audio;

namespace KarmaV2;

public partial class GameTest : ContentPage
{
    Dictionary<int, string> All = new Dictionary<int, string>();
    int EN = 10;
    int EnteredNumber 
    {
        get => EN; 
        set
        {
            EN = value;

            if (EN == Current)
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("good.mp3").Result);
                Player.Play();
                LoadGame();

                Coins.AddCoins(100);
            }
            else
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("again.mp3").Result);
                Player.Play();
            }
        }
    }
    int Current = 10;
    IAudioManager I = new AudioManager();
    public GameTest()
	{
		InitializeComponent();

        All.Add(0, "zero.png");
        All.Add(1, "one.png");
        All.Add(2, "two.png");
        All.Add(3, "three.png");
        All.Add(4, "four.png");
        All.Add(5, "five.png");
        All.Add(6, "six.png");
        All.Add(7, "seven.png");
        All.Add(8, "eight.png");
        All.Add(9, "nine.png");

        LoadGame();

    }

    void LoadGame()
    {
        Current = new Random().Next(9);
    }

    private async void Voice_Clicked(object sender, EventArgs e)
    {
        string Audio = "";

        switch(Current)
        {
            case 0:
                Audio = "Zero.mp3";
                break;
            case 1:
                Audio = "One.mp3";
                break;
            case 2:
                Audio = "Two.mp3";
                break;
            case 3:
                Audio = "Three.mp3";
                break;
            case 4:
                Audio = "Four.mp3";
                break;
            case 5:
                Audio = "Five.mp3";
                break;
            case 6:
                Audio = "Six.mp3";
                break;
            case 7:
                Audio = "Seven.mp3";
                break;
            case 8:
                Audio = "Eight.mp3";
                break;
            case 9:
                Audio = "Nine.mp3";
                break;
        }

        IAudioPlayer Player = I.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(Audio));
        Player.Play();
    }

    private void Zero_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 0;
    }

    private void One_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 1;
    }

    private void Two_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 2;
    }

    private void Three_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 3;
    }

    private void Four_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 4;
    }

    private void Five_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 5;
    }

    private void Six_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 6;
    }

    private void Seven_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 7;
    }

    private void Eight_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 8;
    }

    private void Nine_Clicked(object sender, EventArgs e)
    {
        EnteredNumber = 9;
    }
}