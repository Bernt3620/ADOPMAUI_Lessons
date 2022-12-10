using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views.Lesson02
{
    public partial class MultiBindingStringFormatPage : ContentPage
    {
        public MultiBindingStringFormatPage()
        {
            InitializeComponent();

            BindingContext = new GroupViewModel();
        }
    }
}
