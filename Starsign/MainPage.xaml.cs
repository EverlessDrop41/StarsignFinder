using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace Starsign
{
	public partial class MainPage : ContentPage
	{
		DatePicker BirthDate;

		public MainPage ()
		{
			InitializeComponent ();
			BirthDate = BirthDatePicker;
		}

		public void OnBirthDateChanged(object sender, DateChangedEventArgs dcea) 
		{
			if (dcea.NewDate.ToString("M") != dcea.OldDate.ToString("M")) {
				DisplayAlert ("Date Changed", dcea.NewDate.ToString("M") , "OK");
				BirthDate.Date = dcea.NewDate;
			}
		}
	}
}

