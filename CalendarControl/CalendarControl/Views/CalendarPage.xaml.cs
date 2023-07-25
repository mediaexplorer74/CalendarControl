using System;
using System.Collections.Generic;
using CalendarControl.ViewModels;
using Xamarin.Forms;

namespace CalendarControl.Views
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
            BindingContext = new CalendarViewModel();
        }
    }
}
