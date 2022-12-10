using Microsoft.Maui.Controls;
using ADOPMAUI_Lessons.Globals;

namespace ADOPMAUI_Lessons.Views.Lesson05;

public partial class ContentPage1 : ContentPage
{
    (DateTime time, string message) somePageData; 

    public ContentPage1()
	{
		InitializeComponent();

        //example of accessing global data set in App.xaml.cs
        somePageData.message = Global.Data.Message;
        somePageData.time = Global.Data.Time;
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
        //Pass data with QueryString.
        var queryParams = new Dictionary<string, object>();
        queryParams.Add("greetings", somePageData.message);
        queryParams.Add("time", somePageData.time.ToString());

        await Shell.Current.GoToAsync("../alerts", queryParams);
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}