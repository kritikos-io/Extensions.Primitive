namespace Kritikos.Extensions.Primitive.Tests
{
	using System;

	using Xunit;

	public class DateTimeTests
	{
		private static readonly DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		[Fact]
		public void DateTimeEpochTests()
		{
			Assert.Equal(0, origin.ToEpochTime());

			var estimate = 3000000000L.FromEpochTime();
			var expected = new DateTime(2065, 01, 24, 5, 20, 0, DateTimeKind.Utc);

			Assert.Equal(expected, estimate);
		}

		[Fact]
		public void DateTimeOffsetEpochTests()
		{
			Assert.Equal(0, new DateTimeOffset(origin).ToEpochTime());

			var expected = new DateTime(2065, 01, 24, 5, 20, 0, DateTimeKind.Utc);

			var estimateOffset = 3000000000L.FromEpochTimeOffset();
			Assert.Equal(estimateOffset.DateTime, expected);
		}
	}
}
