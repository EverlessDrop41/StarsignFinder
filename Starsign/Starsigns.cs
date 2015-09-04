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

	public static class Starsigns
	{
		public static Starsign GetSign(DateTime d) 
		{
			throw new NotImplementedException ();
		}
	}
}

