namespace ADOPMAUI_Lessons.Views.Lesson05;

public partial class ContentPage3 : ContentPage
{
	public ContentPage3()
	{
		InitializeComponent();
	}
    async void OnQuestion1ButtonClicked(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Question 1", "What's your name?", initialValue: string.Empty);
        if (!string.IsNullOrWhiteSpace(result))
        {
            lblAnswer.Text = $"Hello {result}.";
        }
    }

    async void OnQuestion2ButtonClicked(object sender, EventArgs e)
    {
        string result = await DisplayPromptAsync("Question 2", "What's 5 + 5?", initialValue: "10",
            maxLength: 2, keyboard: Keyboard.Numeric);
        if (!string.IsNullOrWhiteSpace(result))
        {
            int number = Convert.ToInt32(result);
            lblAnswer.Text = number == 10 ? "Correct." : "Incorrect.";
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("../alerts");
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}