﻿using System;

namespace Starsign
{
	public enum Starsign {
		Aquarius,
		Pisces,
		Aries,
		Taurus,
		Gemini,
		Cancer,
		Leo,
		Virgo,
		Libra,
		Scorpio,
		Sagittarius,
		Capricorn,
		Error
	}

	public class DateRange {
		public DateTime Min;
		public DateTime Max;

		public DateRange (DateTime _Min, DateTime _Max) {
			Min = _Min;
			Max = _Max;
		}

		public bool isInRange (DateTime day) {
			return (Min <= day) && (day <= Max);
		}
	}

	public static class Starsigns
	{
		private const int YEAR = 2015;

		#region StarsignRanges
		public static DateRange AquariusRange = new DateRange(new DateTime(YEAR, 1, 21), new DateTime(YEAR, 2, 19));
		public static DateRange PiscesRange = new DateRange(new DateTime(YEAR, 2, 20), new DateTime(YEAR, 3, 20));
		public static DateRange AriesRange = new DateRange(new DateTime(YEAR, 3, 21), new DateTime(YEAR, 4, 20));
		public static DateRange TaurusTange = new DateRange(new DateTime(YEAR, 4, 21), new DateTime(YEAR, 5, 21));
		public static DateRange GeminiRange = new DateRange(new DateTime(YEAR, 5, 22), new DateTime(YEAR, 6, 21));
		public static DateRange CancerRange = new DateRange(new DateTime(YEAR, 6, 22), new DateTime(YEAR, 7, 23));
		public static DateRange LeoRange = new DateRange(new DateTime(YEAR, 7, 24), new DateTime(YEAR, 8, 23));
		public static DateRange VirgoRange = new DateRange(new DateTime(YEAR, 8, 24), new DateTime(YEAR, 9, 23));
		public static DateRange LibraRange = new DateRange(new DateTime(YEAR, 9, 24), new DateTime(YEAR, 10, 23));
		public static DateRange ScorpioRange = new DateRange(new DateTime(YEAR, 10, 24), new DateTime(YEAR, 11, 22));
		public static DateRange SagittariusRange = new DateRange(new DateTime(YEAR, 11, 23), new DateTime(YEAR, 12, 21));
		public static DateRange CapricornRange = new DateRange(new DateTime(YEAR, 12, 22), new DateTime(YEAR + 1, 1, 20));
		#endregion

		public static Starsign GetSign(DateTime d) 
		{
			d = new DateTime(YEAR, d.Month, d.Day);

			if (d.Month == 1 && d.Day < 21) {
				return Starsign.Capricorn;
			}

			if (AquariusRange.isInRange (d)) {
				return Starsign.Aquarius;
			} else if (PiscesRange.isInRange (d)) {
				return Starsign.Pisces;
			} else if (AriesRange.isInRange (d)) {
				return Starsign.Aries;
			} else if (TaurusTange.isInRange (d)) {
				return Starsign.Taurus;
			} else if (GeminiRange.isInRange (d)) {
				return Starsign.Gemini;
			} else if (CancerRange.isInRange (d)) {
				return Starsign.Cancer;
			} else if (LeoRange.isInRange (d)) {
				return Starsign.Leo;
			} else if (VirgoRange.isInRange (d)) {
				return Starsign.Virgo;
			} else if (LibraRange.isInRange (d)) {
				return Starsign.Libra;
			} else if (ScorpioRange.isInRange (d)) {
				return Starsign.Scorpio;
			} else if (SagittariusRange.isInRange (d)) {
				return Starsign.Sagittarius;
			} else if (CapricornRange.isInRange (d)) {
				return Starsign.Capricorn;
			} else {
				return Starsign.Error;
			}
		}
	}
}

