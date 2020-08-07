namespace Kritikos.Extensions.Primitive
{
	using System;

	public static class RandomExtensions
	{
		/// <summary>
		/// Returns a random long from min (inclusive) to max (exclusive).
		/// </summary>
		/// <param name="random">The given random instance.</param>
		/// <param name="min">The inclusive minimum bound.</param>
		/// <param name="max">The exclusive maximum bound.  Must be greater than min..</param>
		/// <returns>A new random <see cref="long"/> between <paramref name="min"/> and <paramref name="max"/>.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="min"/> is not less than <paramref name="max"/>.</exception>
		/// <exception cref="ArgumentNullException"><paramref name="random"/> is null.</exception>
		public static long NextLong(this Random random, long min, long max)
		{
			if (random == null)
			{
				throw new ArgumentNullException(nameof(random));
			}

			if (max < min)
			{
				throw new ArgumentOutOfRangeException(
					nameof(max),
					$"{nameof(max)} should be greater than {nameof(min)}!");
			}

			var uRange = (ulong)(max - min);

			ulong ulongRand;
			do
			{
				var buffer = new byte[8];
				random.NextBytes(buffer);
				ulongRand = (ulong)BitConverter.ToInt64(buffer, 0);
			} while (ulongRand > ulong.MaxValue - (((ulong.MaxValue % uRange) + 1) % uRange));

			return (long)(ulongRand % uRange) + min;
		}

		/// <summary>
		/// Returns a random long from 0 (inclusive) to max (exclusive).
		/// </summary>
		/// <param name="random">The given random instance</param>
		/// <param name="max">The exclusive maximum bound.  Must be greater than 0</param>
		/// <returns>A new random <see cref="long"/> between 0 and <paramref name="max"/>.</returns>
		public static long NextLong(this Random random, long max)
			=> random.NextLong(0, max);

		/// <summary>
		/// Returns a random long over all possible values of long (except long.MaxValue, similar to random.Next()).
		/// </summary>
		/// <param name="random">The given random instance.</param>
		/// <returns>A new random <see cref="long"/> between <see cref="long.MinValue"/> and <see cref="long.MaxValue"/>.</returns>
		public static long NextLong(this Random random)
			=> random.NextLong(long.MinValue, long.MaxValue);
	}
}
