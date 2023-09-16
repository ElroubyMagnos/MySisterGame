using Plugin.Maui.Audio;

namespace KarmaV2;

public partial class BSGame : ContentPage
{
	string[] SmallOrBig = new string[] { "big.mp3", "small.mp3" };
    bool Big = true;
    IAudioManager I = new AudioManager();
    int FirstNumber = 10;
    int SecondNumber = 10;
    public BSGame()
	{
		InitializeComponent();

        Load();
	}

	void Load()
	{
		string BS = "";
		Random R = new Random();
		if (R.Next(2) == 0)
		{
			BS = SmallOrBig[0];
            Big = true;
		}
		else
		{
			BS = SmallOrBig[1];
            Big = false;
		}

        IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync(BS).Result);
        Player.Play();

		FirstNumber = R.Next(9);
		SecondNumber = R.Next(9);

        if (FirstNumber == SecondNumber)
            FirstNumber = R.Next(9);

        ExecuteNumber(First, FirstNumber);  
        ExecuteNumber(Second, SecondNumber);  

        void ExecuteNumber(Image FS, int Number)
        {
            switch (Number)
            {
                case 0:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "zero.png";
                    }
                    else
                    {
                        FS.Source = "zero_ar.png";
                    }
                    break;
                case 1:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "one.png";
                    }
                    else
                    {
                        FS.Source = "one_ar.png";
                    }
                    break;
                case 2:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "two.png";
                    }
                    else
                    {
                        FS.Source = "two_ar.png";
                    }
                    break;
                case 3:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "three.png";
                    }
                    else
                    {
                        FS.Source = "three_ar.png";
                    }
                    break;
                case 4:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "four.png";
                    }
                    else
                    {
                        FS.Source = "four_ar.png";
                    }
                    break;
                case 5:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "five.png";
                    }
                    else
                    {
                        FS.Source = "five_ar.png";
                    }
                    break;
                case 6:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "six.png";
                    }
                    else
                    {
                        FS.Source = "six_ar.png";
                    }
                    break;
                case 7:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "seven.png";
                    }
                    else
                    {
                        FS.Source = "seven_ar.png";
                    }
                    break;
                case 8:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "eight.png";
                    }
                    else
                    {
                        FS.Source = "eight_ar.png";
                    }
                    break;
                case 9:
                    if (R.Next(5) > 3)
                    {
                        FS.Source = "nine.png";
                    }
                    else
                    {
                        FS.Source = "nine_ar.png";
                    }
                    break;
            }
        }
    }

    private void First_Clicked(object sender, EventArgs e)
    {
        int F = GetNumber(First.Source.ToString());
        int S = GetNumber(Second.Source.ToString());

        if (Big)
        {
            if (F > S)
            {
                Load();
            }
            else
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("again.mp3").Result);
                Player.Play();
            }
        }
        else
        {
            if (F < S)
            {
                Load();
            }
            else
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("again.mp3").Result);
                Player.Play();
            }
        }
    }

    private void Second_Clicked(object sender, EventArgs e)
    {
        int F = GetNumber(First.Source.ToString());
        int S = GetNumber(Second.Source.ToString());

        if (Big)
        {
            if (S > F)
            {
                Load();
            }
            else
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("again.mp3").Result);
                Player.Play();
            }
        }
        else
        {
            if (S < F)
            {
                Load();
            }
            else
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("again.mp3").Result);
                Player.Play();
            }
        }
    }

    int GetNumber(string SI)
    {
        SI = SI.Replace("File: ", "");
        switch (SI)
        {
            case "zero.png":
            case "zero_ar.png":
                return 0;

            case "one.png":
            case "one_ar.png":
                return 1;

            case "two.png":
            case "two_ar.png":
                return 2;

            case "three.png":
            case "three_ar.png":
                return 3;

            case "four.png":
            case "four_ar.png":
                return 4;

            case "five.png":
            case "five_ar.png":
                return 5;

            case "six.png":
            case "six_ar.png":
                return 6;

            case "seven.png":
            case "seven_ar.png":
                return 7;

            case "eight.png":
            case "eight_ar.png":
                return 8;

            case "nine.png":
            case "nine_ar.png":
                return 9;
        }

        return 0;
    }

    private void Next_Clicked(object sender, EventArgs e)
    {
        if (Big)
        {
            if (FirstNumber > SecondNumber && FirstNumber.ToString() == Space.Text)
            {
                Load();

                Coins.AddCoins(0.01);
            }
            else if (SecondNumber > FirstNumber && SecondNumber.ToString() == Space.Text)
            {
                Load();

                Coins.AddCoins(0.01);
            }
            else
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("again.mp3").Result);
                Player.Play();
            }
        }
        else
        {
            if (FirstNumber < SecondNumber && FirstNumber.ToString() == Space.Text)
            {
                Load();

                Coins.AddCoins(0.01);
            }
            else if (SecondNumber < FirstNumber && SecondNumber.ToString() == Space.Text)
            {
                Load();

                Coins.AddCoins(0.01);
            }
            else
            {
                IAudioPlayer Player = I.CreatePlayer(FileSystem.OpenAppPackageFileAsync("again.mp3").Result);
                Player.Play();
            }
        }

        Space.Text = "";
    }
}