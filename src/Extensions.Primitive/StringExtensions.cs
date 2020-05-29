namespace Kritikos.Extensions.Primitive
{
	using System;
	using System.Security;

	public static class StringExtensions
	{
		/// <summary>
		/// Indicates whether a specified string is null, empty, or consists only of white-space characters.
		/// </summary>
		/// <param name="value">The string to test.</param>
		/// <returns>true if the <paramref name="value">value</paramref> parameter is null or <see cref="string.Empty"></see>, or if <paramref name="value">value</paramref> consists exclusively of white-space characters.</returns>
		public static bool IsNullOrWhiteSpace(this string value)
			=> string.IsNullOrWhiteSpace(value);

		/// <summary>Indicates whether the specified string is null or an <see cref="string.Empty"></see> string.</summary>
		/// <param name="value">The string to test.</param>
		/// <returns>true if the <paramref name="value">value</paramref> parameter is null or an empty string (""); otherwise, false.</returns>
		[Obsolete("Prefer IsNullOrWhiteSpace instead")]
		public static bool IsNullOrEmpty(this string value)
			=> string.IsNullOrEmpty(value);

		/// <summary>
		/// Transforms a <see cref="string"/> to a new <see cref="SecureString"/> instance.
		/// </summary>
		/// <param name="value">The string that will be encrypted.</param>
		/// <returns><see cref="SecureString"/> representation of <paramref name="value"/>.</returns>
		public static SecureString AsSecureString(this string value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			var secure = new SecureString();

			foreach (var c in value)
			{
				secure.AppendChar(c);
			}

			secure.MakeReadOnly();
			return secure;
		}
	}
}
