namespace ADOPMAUI_Lessons.Views.Lesson02
{
    public partial class SliderBindingsPage2 : ContentPage
    {
        public SliderBindingsPage2()
        {
            InitializeComponent();

            label2.SetBinding(Label.RotationProperty, new Binding("Value", source: slider2a));
            label2.SetBinding(Label.ScaleProperty, new Binding("Value", source: slider2b));
            label2.SetBinding(Label.OpacityProperty, new Binding("Value", source: slider2c));
        }
    }
}