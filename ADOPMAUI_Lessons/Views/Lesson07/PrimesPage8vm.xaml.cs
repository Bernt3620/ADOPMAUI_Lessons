using System;

using ADOPMAUI_Lessons.Models;
using ADOPMAUI_Lessons.Services;
using ADOPMAUI_Lessons.ViewModels;


namespace ADOPMAUI_Lessons.Views.Lesson07
{
    public partial class PrimesPage8vm : ContentPage
    {
        PrimePageViewModel viewmodel => BindingContext as PrimePageViewModel;
        public PrimesPage8vm()
        {
            InitializeComponent();
            BindingContext = new PrimePageViewModel(DependencyService.Get<IPrimeNumerService>());
        }
        public PrimesPage8vm(int NrOfBatches) : this()
        {
            viewmodel.NrOfBatches = NrOfBatches;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainThread.BeginInvokeOnMainThread(async () => { await viewmodel.LoadPrimes(); });
        }

        private async void lvPrimes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (PrimeBatch)e.Item;
            var answer = await DisplayAlert("Write to disk?",
                $"Would you like to write the {item.NrPrimes} prime numbers to disk", "Yes", "No");
            if (answer)
            {
                string userMessage = null, path = null;
                try
                {
                    path = await viewmodel.WriteAsync(item, $"Primes_from_{item.BatchStart}_to_{item.BatchEnd}.txt");
                    userMessage = "Write Completed";
                }
                catch (Exception ex)
                {
                    userMessage = $"Cannot write: {ex.Message}";
                }
                finally
                {
                    await DisplayAlert(userMessage, $"Filename: {path}", "OK");
                }
            }
        }

    }
}