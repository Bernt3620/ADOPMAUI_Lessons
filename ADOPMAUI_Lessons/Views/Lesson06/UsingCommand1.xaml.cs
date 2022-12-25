using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views.Lesson06;

public partial class UsingCommand1 : ContentPage
{
	UsingCommand1ViewModel _viewmodel;

	public UsingCommand1()
	{
		InitializeComponent();

        _viewmodel = new UsingCommand1ViewModel();
        this.BindingContext = _viewmodel;
    }

    public async void ButtonClicked(object sender, EventArgs args)
    {
        await DisplayAlert("Values of Item", $"Message: {_viewmodel.Message}\nCreation: {_viewmodel.Creation:F}", "OK");
    }
}