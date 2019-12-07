namespace Kritikos.Extensions.Primitive.Tests
{
	using Xunit;

	public class UnsignedIntegerTests
	{
		[Fact]
		public void UShortTests()
		{
			const ushort number = (ushort)(short.MaxValue + 1);
			var swappedEndianess = number.ReverseBytes();
			var doublySwapped = swappedEndianess.ReverseBytes();

			Assert.Equal(number, doublySwapped);
		}

		[Fact]
		public void UIntTests()
		{
			var number = (uint)int.MaxValue + 1;
			var swappedEndianess = number.ReverseBytes();
			var doublySwapped = swappedEndianess.ReverseBytes();

			Assert.Equal(number, doublySwapped);
		}

		[Fact]
		public void ULongTests()
		{
			var number = (ulong)long.MaxValue + 1;
			var swappedEndianess = number.ReverseBytes();
			var doublySwapped = swappedEndianess.ReverseBytes();

			Assert.Equal(number, doublySwapped);
		}
	}
}
