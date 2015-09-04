using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace Starsign
{
	public partial class MainPage : ContentPage
	{
		DatePicker BirthDate;
		String StarSign = "";

		public MainPage ()
		{
			InitializeComponent ();
			BirthDate = BirthDatePicker;
		}

		public void OnBirthDateChanged(object sender, DateChangedEventArgs dcea) 
		{
			if (dcea.NewDate.ToString("M") != dcea.OldDate.ToString("M")) {
				StarSign = Starsigns.GetSign (dcea.NewDate).ToString ();
				//DisplayAlert ("Date Changed", StarSign, "OK");
				StarsignOutput.Text = StarSign;
				BirthDate.Date = dcea.NewDate;
				EffectButton.IsEnabled = true;
			}
		}

		public void EffectOnLifeClicked(object sender, EventArgs args) 
		{
			DisplayAlert ("Your starsign does: ", "Absolutely nothing", "Thanks!");
		}
	}
}

