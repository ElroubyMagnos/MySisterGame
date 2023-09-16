using Plugin.Maui.Audio;

namespace KarmaV2;

public partial class NumberBetween : ContentPage
{
	Dictionary<int, string> Numbers = new Dictionary<int, string>();
    Random R = new Random();
    public NumberBetween()
	{
		InitializeComponent();

		Numbers.Add(0, "zero.png,zero_ar.png");
		Numbers.Add(1, "one.png,one_ar.png");
		Numbers.Add(2, "two.png,two_ar.png");
		Numbers.Add(3, "three.png,three_ar.png");
		Numbers.Add(4, "four.png,four_ar.png");
		Numbers.Add(5, "five.png,five_ar.png");
		Numbers.Add(6, "six.png,six_ar.png");
		Numbers.Add(7, "seven.png,seven_ar.png");
		Numbers.Add(8, "eight.png,eight_ar.png");
		Numbers.Add(9, "nine.png,nine_ar.png");

		Load();
	}
    IAudioManager I = new AudioManager();
    string GetString(int num)
	{
        string Data = Numbers[num].Split(',')[R.Next(2)];
        return Data;
	}
    int RightAnswer = 10;
    void Load()
	{
		int F = R.Next(7);
		int S = F + 2;
		string Fstring = GetString(F);
		string Sstring = GetString(S);

		Minus.Source = Fstring;
		Plus.Source = Sstring;

		RightAnswer = F + 1;

        IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("middle.mp3").Result);
        Player.Play();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		if (RightAnswer.ToString() == String.Text)
		{
			Coins.AddCoins(0.01);
			Load();
		}
		else
		{
            IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("wrong.mp3").Result);
            Player.Play();
        }

        String.Text = "";
    }
}