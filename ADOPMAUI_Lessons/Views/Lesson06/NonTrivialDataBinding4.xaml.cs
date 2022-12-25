using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views.Lesson06;

public partial class NonTrivialDataBinding4 : ContentPage
{
	NonTrivialDataBinding4ViewModel _viewmodel;

	public NonTrivialDataBinding4()
	{
		InitializeComponent();

        _viewmodel = new NonTrivialDataBinding4ViewModel();
        this.BindingContext = _viewmodel;
    }

    public async void ButtonClicked(object sender, EventArgs args)
    {
        await DisplayAlert("Values of Item", $"Message: {_viewmodel.Message}\nCreation: {_viewmodel.Creation:F}", "OK");
    }
}