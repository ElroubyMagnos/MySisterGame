using Microsoft.Data.Sqlite;

namespace KarmaV2;

public partial class Coins : ContentPage
{
	public static SqliteConnection con = new SqliteConnection($"Data Source={AppDomain.CurrentDomain.BaseDirectory}\\karma.db");
	public static void AddCoins(double Add)
	{
		double Get = double.Parse(new SqliteCommand("Select * From main", con).ExecuteScalar().ToString());

		double sum = Get + Add;

		new SqliteCommand($@"UPDATE main SET coins = '{sum}'", con).ExecuteNonQuery();

		if (Com != null)
			Com.Text = sum.ToString();
	}
	static Label Com = null;
	public Coins()
	{
		InitializeComponent();
		Com = m;
		AddCoins(0);
	}

    private void wd_Clicked(object sender, EventArgs e)
    {
        new SqliteCommand("UPDATE main SET coins = '0'", con).ExecuteNonQuery();

		AddCoins(0);
    }
}