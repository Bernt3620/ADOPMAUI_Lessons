using System;
using ADOPMAUI_Lessons.Models;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.Views.Lesson04
{
    public partial class PickerDemoPage : ContentPage
    {
        public PickerDemoPage()
        {
            InitializeComponent();

            picColor.ItemsSource = NamedColor.All.ToList();
        }

        private void picColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This is to ensure only valid selections in the Picker is handled
            if (picColor.SelectedIndex == -1) return;

            string sColor = picColor?.SelectedItem?.ToString();
            string sDate = picDate?.Date.ToShortDateString();
            string sTime = picTime?.Time.ToString();

            DisplayAlert("Color changed", $"{sColor}, {sDate}, {sTime}", "Got it!");
        }

        private void picDate_DateSelected(object sender, DateChangedEventArgs e)
        {
            string sColor = picColor?.SelectedItem?.ToString();
            string sDate = picDate?.Date.ToShortDateString();
            string sTime = picTime?.Time.ToString();

            DisplayAlert("Date changed", $"{sColor}, {sDate}, {sTime}", "Got it!");
        }

        private void picTime_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //As the event is PropertyChanged, I have to make sure to respond only if Time has changed
            if (e.PropertyName != nameof(picTime.Time)) return;

            string sColor = picColor?.SelectedItem?.ToString();
            string sDate = picDate?.Date.ToShortDateString();
            string sTime = picTime?.Time.ToString();

            DisplayAlert("Time changed", $"{sColor}, {sDate}, {sTime}", "Got it!");
        }
    }
}