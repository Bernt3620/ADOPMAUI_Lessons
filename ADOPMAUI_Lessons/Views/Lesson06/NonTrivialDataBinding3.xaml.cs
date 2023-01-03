using ADOPMAUI_Lessons.ViewModels;          //Need to use ViewModel namespace as ItemC i there

namespace ADOPMAUI_Lessons.Views.Lesson06;

public partial class NonTrivialDataBinding3 : ContentPage
{

    ItemC item;  //ItemC is ItemB with INotifyChange in inherited BaseViewModel
    Random rnd;

    public NonTrivialDataBinding3()
	{
		InitializeComponent();

        item = new ItemC();
        rnd = new Random();

        this.BindingContext = item;
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        //Routing of this page
        Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
    }
    public async void ButtonClicked(object sender, EventArgs args)
    {
        await DisplayAlert("Values of Item", $"Message: {item.Message}\nCreation: {item.Creation:F}", "OK");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        item.Message = $"A message set in C# code with a random number: {rnd.Next(1000)}";
        item.Creation = item.Creation + new TimeSpan(10, 10, 10, 0); // add 10 days, 10 hours, 10 minutes 
    }
}