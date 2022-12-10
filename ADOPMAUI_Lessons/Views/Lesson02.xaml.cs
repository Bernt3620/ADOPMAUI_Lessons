using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views
{

    public partial class Lesson02a : ContentPage
    {
        public Lesson02a()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson02ViewModel pageData = args.SelectedItem as Lesson02ViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Navigation.PushAsync(page);
            }
        }
    }
}