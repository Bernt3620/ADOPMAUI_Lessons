using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.Views.Lesson05;

[QueryProperty(nameof(time), "time")]
[QueryProperty(nameof(greetings), "greetings")]
public partial class ContentPage2 : ContentPage
{
    //Data that is passed from ConmtentPage1 as query parameters
    public string time { get; set; }
    public string greetings { get; set; }

    public ContentPage2()
	{
		InitializeComponent();
	}
    async void OnAlertSimpleClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Alert", $"You have been alerted\n{greetings}\n{time}", "OK");
    }

    async void OnAlertYesNoClicked(object sender, EventArgs e)
    {
        var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        lblAnswer.Text = $"Action: {answer}";
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("../prompts");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("../actions");
    }
    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}