using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.Views.Lesson05;

//Data that is passed from ContentPage1 as querystring
//Example of using QueryProperty attributes to map to public properties in ContentPage2
[QueryProperty(nameof(time), "time")]
[QueryProperty(nameof(message), "message")]
public partial class ContentPage2 : ContentPage
{
    //Data that is passed from ContentPage1 as querystring
    //Properties mapped from query parameters using QueryProperty above 
    public string time { get; set; }
    public string message { get; set; }


    public ContentPage2()
	{
		InitializeComponent();
    }
    protected override void OnAppearing()
    {
        //This is a safe time to initialize the page, e.g. use the data passed as a querystring
        lblMessage.Text = message;
        lblTime.Text = time;

        base.OnAppearing();
    }

    async void OnAlertSimpleClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Alert", $"You have been alerted", "OK");
    }

    async void OnAlertYesNoClicked(object sender, EventArgs e)
    {
        var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
        lblAnswer.Text = $"Action: {answer}";
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //Pass data with QueryString to ContentPage2
        //Example using Dictionary to generate a querystring
        var queryParams = new Dictionary<string, object>();

        queryParams.Add("message", $"{message}. Hello from {nameof(ContentPage2)}");
        queryParams.Add("time", DateTime.Now);  //Note that I pass this as a DateTime not a string 

        await Shell.Current.GoToAsync("../prompts", queryParams);
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