using System;
using Microsoft.Maui.Controls;
using ADOPMAUI_Lessons.Models;

namespace ADOPMAUI_Lessons.Views.Lesson05
{
    [QueryProperty(nameof(date), "date")]
    [QueryProperty(nameof(greeting), "greeting")]
    public partial class PassingDataQueryParamPage : ContentPage, IQueryAttributable
	{
		public DateTime? date { get; set; }
        public string greeting { get; set; }
        
		int count = 0;

		public PassingDataQueryParamPage()
		{
			InitializeComponent();
            BindingContext = this;
        }
		public void ApplyQueryAttributes(IDictionary<string, object> query)
		{
			var q = query;
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

