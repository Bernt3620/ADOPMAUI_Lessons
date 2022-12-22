using Microsoft.Maui.Controls;
using ADOPMAUI_Lessons.Globals;

namespace ADOPMAUI_Lessons.Views.Lesson05;

public partial class ContentPage1 : ContentPage
{
    public DateTime time { get; set; }
    public string message { get; set; }

    public ContentPage1()
	{
		InitializeComponent();

        //example of accessing global data set in App.xaml.cs
        //Will be presented using Binding
        message = Global.Data.Message;
        time = Global.Data.Time;

        this.BindingContext = this;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

    async void OnActionSheetSimpleClicked(object sender, EventArgs e)
    {
        var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        lblAnswer.Text = $"Action: {action}";
    }

    async void OnActionSheetCancelDeleteClicked(object sender, EventArgs e)
    {
        var action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
        lblAnswer.Text = $"Action: {action}";
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //Pass data with QueryString to ContentPage1
        //Example using Dictionary to generate a querystring
        var queryParams = new Dictionary<string, object>();
        queryParams.Add("message", $"{message}. Hello from {nameof(ContentPage1)}");
        queryParams.Add("time", $"{time}. Hello from {nameof(ContentPage1)}");

        await Shell.Current.GoToAsync("../alerts", queryParams);
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}