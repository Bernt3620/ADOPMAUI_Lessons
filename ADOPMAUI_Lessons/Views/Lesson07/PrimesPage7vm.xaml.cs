
using ADOPMAUI_Lessons.Services;
using ADOPMAUI_Lessons.ViewModels;


namespace ADOPMAUI_Lessons.Views.Lesson07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrimesPage7vm : ContentPage
    {
        PrimePageViewModel viewmodel => BindingContext as PrimePageViewModel;
        public PrimesPage7vm()
        {
            InitializeComponent();
            BindingContext = new PrimePageViewModel(DependencyService.Get<IPrimeNumerService>());
        }
        public PrimesPage7vm(int NrOfBatches) : this()
        {
            viewmodel.NrOfBatches = NrOfBatches;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainThread.BeginInvokeOnMainThread(async () => { await viewmodel.LoadPrimes(); });
        }
    }
}