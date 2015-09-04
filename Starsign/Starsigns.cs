using System;

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
		public static Starsign GetSign(DateTime d) 
		{
			throw new NotImplementedException ();
		}
	}
}

