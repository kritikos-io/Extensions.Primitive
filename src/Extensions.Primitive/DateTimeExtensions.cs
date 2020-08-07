namespace Kritikos.Extensions.Primitive
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Linq;

	public static class DateTimeExtensions
	{
		public static readonly DateTimeOffset GregorianCalendarStart
			= new DateTimeOffset(1582, 10, 15, 0, 0, 0, TimeSpan.Zero);

		[Pure]
		public static bool IsWeekend(this DateTime date)
			=> date.DayOfWeek == DayOfWeek.Saturday
				|| date.DayOfWeek == DayOfWeek.Sunday;

		[Pure]
		public static bool IsWeekend(this DateTimeOffset date)
			=> date.DayOfWeek == DayOfWeek.Saturday
				|| date.DayOfWeek == DayOfWeek.Sunday;

		[Pure]
		public static bool IsLeapYear(this DateTime date)
			=> DateTime.DaysInMonth(date.Year, 2) == 29;

		[Pure]
		public static bool IsLeapYear(this DateTimeOffset date)
			=> DateTime.DaysInMonth(date.Year, 2) == 29;

		[Pure]
		public static bool Between(this DateTime dateTime, DateTime from, DateTime to)
			=> dateTime >= from && dateTime <= to;

		[Pure]
		public static bool Between(this DateTimeOffset dateTime, DateTimeOffset from, DateTimeOffset to)
			=> dateTime >= from && dateTime <= to;
	}
}
