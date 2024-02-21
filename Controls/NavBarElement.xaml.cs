using System.Diagnostics;

namespace Flashcards_.Controls;

public partial class NavBarElement : ContentView
{
	public NavBarElement()
	{
		InitializeComponent();
	}
    public void SearchButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the SearchPage
        Debug.WriteLine("Search button clicked");
    }

    public void AddButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the AddPage
        Debug.WriteLine("Add button clicked");
    }

    public void SettingsButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to the SettingsPage
        Debug.WriteLine("Settings button clicked");
    }
}