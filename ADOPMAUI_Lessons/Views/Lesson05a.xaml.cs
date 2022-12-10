using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views
{

    public partial class Lesson05a : ContentPage
    {
        public Lesson05a()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson05ViewModel pageData = args.SelectedItem as Lesson05ViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }
    }
}