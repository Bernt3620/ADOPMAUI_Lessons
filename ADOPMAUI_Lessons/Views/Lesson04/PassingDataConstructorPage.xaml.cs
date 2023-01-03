using System;
using Microsoft.Maui.Controls;
using ADOPMAUI_Lessons.Models;

namespace ADOPMAUI_Lessons.Views.Lesson04
{

	public partial class PassingDataConstructorPage : ContentPage
	{
		int count = 0;

		public PassingDataConstructorPage()
		{
			InitializeComponent();
		}
        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            //Routing of this page
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
        }
        public PassingDataConstructorPage(DateTime date, string greeting) : this()
		{
			lblHello.Text = greeting;
			lblDetails.Text = date.ToString();

		}

        private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;

			if (count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";
		}
	}
}

