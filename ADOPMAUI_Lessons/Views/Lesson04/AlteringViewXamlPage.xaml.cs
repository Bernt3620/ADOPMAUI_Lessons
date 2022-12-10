namespace ADOPMAUI_Lessons.Views.Lesson04
{
    public partial class AlteringViewXamlPage : ContentPage
    {
        public AlteringViewXamlPage()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;

            //This is to ensure enabledLabel is created. It is not in the init RadioButton set
            if (enabledLabel != null)
            {
                enabledLabel.Text = $"{button.Content}";
                label.IsEnabled = (enabledLabel.Text== "Enabled");
            }

        }
    }
}