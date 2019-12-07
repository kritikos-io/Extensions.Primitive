namespace Kritikos.Extensions.Primitive
{
	public static class UnsignedIntegerExtensions
	{
		/// <summary>
		/// Reverses the order bytes in a <see cref="short"/> number, changing endianness.
		/// </summary>
		/// <param name="value">The current number.</param>
		/// <returns><paramref name="value"/> with the order of bytes reversed.</returns>
		public static ushort ReverseBytes(this ushort value)
			=> (ushort)((value & 0xFFU) << 8 | (value & 0xFF00U) >> 8);

		/// <summary>
		/// Reverses the order bytes in a <see cref="int"/> number, changing endianness.
		/// </summary>
		/// <param name="value">The current number.</param>
		/// <returns><paramref name="value"/> with the order of bytes reversed.</returns>
		public static uint ReverseBytes(this uint value)
		{
			// swap adjacent 16-bit blocks
			value = (value >> 16) | (value << 16);

			// swap adjacent 8-bit blocks
			return ((value & 0xFF00FF00) >> 8) | ((value & 0x00FF00FF) << 8);
		}

		/// <summary>
		/// Reverses the order bytes in a <see cref="long"/> number, changing endianness.
		/// </summary>
		/// <param name="value">The current number.</param>
		/// <returns><paramref name="value"/> with the order of bytes reversed.</returns>
		public static ulong ReverseBytes(this ulong value)
		{
			// swap adjacent 32-bit blocks
			value = (value >> 32) | (value << 32);

			// swap adjacent 16-bit blocks
			value = ((value & 0xFFFF0000FFFF0000) >> 16) | ((value & 0x0000FFFF0000FFFF) << 16);

			// swap adjacent 8-bit blocks
			return ((value & 0xFF00FF00FF00FF00) >> 8) | ((value & 0x00FF00FF00FF00FF) << 8);
		}
	}
}
