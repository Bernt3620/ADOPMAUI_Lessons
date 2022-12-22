using ADOPMAUI_Lessons.Models;

namespace ADOPMAUI_Lessons.Views.Lesson05;

public partial class TabbedColorPage : ContentPage
{
	public TabbedColorPage()
	{
		InitializeComponent();
	}

	//Constructor invoked from the Shell menu passing data through a constructor
	public TabbedColorPage(NamedColor color):this()
	{
		this.BindingContext= color;
	}
}