namespace Kritikos.Extensions.Primitive
{
	using System;

	public static class DateTimeExtensions
	{
		/// <summary>
		/// Ticks representation of the Unix Epoch time: 00:00:00 UTC Thursday, 1 January 1970.
		/// </summary>
		private const long EpochTicks = 621355968000000000;

		/// <summary>
		/// Converts a <see cref="DateTime"/> object to UNIX epoch format.
		/// </summary>
		/// <param name="date">The <see cref="DateTime"/> to convert.</param>
		/// <returns>The number of seconds that have ellapsed since Unix epoch.</returns>
		public static long ToEpochTime(this DateTime date)
			=> Convert.ToInt64((date.ToUniversalTime().Ticks - EpochTicks) / TimeSpan.TicksPerSecond);

		/// <summary>
		/// Converts epoch time to a proper <see cref="DateTime"/> object.
		/// </summary>
		/// <param name="secondsSinceEpoch">The number of seconds that have ellapsed since Unix epoch.</param>
		/// <returns><see cref="DateTime"/> representation of <paramref name="secondsSinceEpoch"/>.</returns>
		public static DateTime FromEpochTime(this long secondsSinceEpoch)
			=> new DateTime(EpochTicks + (secondsSinceEpoch * TimeSpan.TicksPerSecond));

		/// <summary>
		/// Converts a <see cref="DateTimeOffset"/> object to UNIX epoch format.
		/// </summary>
		/// <param name="date">The <see cref="DateTimeOffset"/> to convert.</param>
		/// <returns>The number of seconds that have ellapsed since Unix epoch.</returns>
		public static long ToEpochTime(this DateTimeOffset date)
			=> Convert.ToInt64((date.ToUniversalTime().Ticks - EpochTicks) / TimeSpan.TicksPerSecond);

		/// <summary>
		/// Converts epoch time to a proper <see cref="DateTimeOffset"/> object.
		/// </summary>
		/// <param name="secondsSinceEpoch">The number of seconds that have ellapsed since Unix epoch.</param>
		/// <returns><see cref="DateTimeOffset"/> representation of <paramref name="secondsSinceEpoch"/>.</returns>
		public static DateTimeOffset FromEpochTimeOffset(this long secondsSinceEpoch)
			=> new DateTime(EpochTicks + (secondsSinceEpoch * TimeSpan.TicksPerSecond), DateTimeKind.Utc);
	}
}
