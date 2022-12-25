using ADOPMAUI_Lessons.Models;
using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views.Lesson06;

public partial class NonTrivialDataBinding5 : ContentPage
{
    NonTrivialDataBinding5ViewModel _viewmodel;
    public NonTrivialDataBinding5()
	{
        InitializeComponent();
        _viewmodel = new NonTrivialDataBinding5ViewModel();
        this.BindingContext = _viewmodel;
    }
    private async void lvFriends_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //Check that the selected item is not null
        if (e.SelectedItem == null) return;

        await DisplayAlert("Selected", ((Friend)e.SelectedItem).ToString(), "Got it!");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        var item = ((Friend)button.CommandParameter);

        await DisplayAlert("Button Clicked", $"Hello {item.FirstName}!\n{item}", "Got it!");
    }
}