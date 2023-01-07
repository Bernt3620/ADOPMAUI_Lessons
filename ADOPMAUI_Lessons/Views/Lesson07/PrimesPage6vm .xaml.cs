using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ADOPMAUI_Lessons.Models;
using ADOPMAUI_Lessons.Services;
using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views.Lesson07
{
    public partial class PrimesPage6vm : ContentPage
    {
        PrimePageViewModel viewmodel => BindingContext as PrimePageViewModel;
        public PrimesPage6vm()
        {
            
            InitializeComponent();
            BindingContext = new PrimePageViewModel(DependencyService.Get<IPrimeNumerService>());
        }
        public PrimesPage6vm(int NrOfBatches):this()
        {
            viewmodel.NrOfBatches = NrOfBatches;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await viewmodel.LoadPrimes();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainThread.BeginInvokeOnMainThread(async () => { await viewmodel.LoadPrimes(); });
        }
    }
}