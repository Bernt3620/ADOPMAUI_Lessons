namespace ADOPMAUI_Lessons.Views.Lesson02
{
    public partial class SliderBindingsPage : ContentPage
    {
        public SliderBindingsPage()
        {
            InitializeComponent();

            //C# Binding using BindingContext
            lblRotation.BindingContext = slider2;
            lblRotation.SetBinding(Label.RotationProperty, "Value");

            lblDegree1.BindingContext = slider2;
            lblDegree1.SetBinding(targetProperty:Label.TextProperty, path:"Value", stringFormat: "The angle is {0:F0} degrees");

            //C# Binding alternative not using Binding Context
            lblDegree2.SetBinding(Label.TextProperty, new Binding(path:"Value", source:slider2, stringFormat: "The angle is {0:F0} degrees"));
        }
    }
}