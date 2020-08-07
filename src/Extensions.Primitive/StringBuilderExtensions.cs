namespace Kritikos.Extensions.Primitive
{
	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Text;

	[ExcludeFromCodeCoverage]
	public static class StringBuilderExtensions
	{
		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, ushort value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, uint value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, ulong value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, short value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, int value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, long value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, double value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, string value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;

		/// <summary>
		/// Appends the string representation of a specified object to this instance.
		/// </summary>
		/// <param name="sb">The given <see cref="StringBuilder"/> instance.</param>
		/// <param name="condition">The condition that decides whether to append or not.</param>
		/// <param name="value">The value to append.</param>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="sb"/> is null.</exception>
		/// <exception cref="ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="StringBuilder.MaxCapacity"/>.</exception>
		public static StringBuilder AppendIf(this StringBuilder sb, bool condition, char value)
			=> condition
				? sb?.Append(value) ?? throw new ArgumentNullException(nameof(sb))
				: sb;
	}
}
