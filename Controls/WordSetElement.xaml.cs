using Flashcards_.Pages;

namespace Flashcards_.Controls;

public partial class WordSetElement : ContentView
{
    public WordSetElement()
    {
        InitializeComponent();
    }

    public void OnTapped(object sender, EventArgs e)
    {
        // Navigate to the
        Navigation.PushAsync(new WordSetPage());
    }
}