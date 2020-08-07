namespace Kritikos.Extensions.Primitive
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Diagnostics.Contracts;
	using System.Security;
	using System.Text;

	public static class StringExtensions
	{
		/// <summary>
		/// Transliterations based on the ELOT 743 standard for romanization of Greek characters.
		/// </summary>
		public static readonly Dictionary<string, string[]> GreekTransliterations = new Dictionary<string, string[]>
		{
			{ "gx", new[] { "γξ", "γΞ", "Γξ", "ΓΞ" } },
			{ "a", new[] { "α", "ά", "Α", "Ά" } },
			{ "v", new[] { "β", "Β" } },
			{ "g", new[] { "γ", "Γ" } },
			{ "d", new[] { "δ", "Δ" } },
			{ "e", new[] { "ε", "έ", "Ε", "Έ" } },
			{ "z", new[] { "ζ", "Ζ" } },
			{ "i", new[] { "η", "ή", "Η", "Ή", "ι", "ί", "ϊ", "ΐ", "Ι", "Ί", "Ϊ" } },
			{ "th", new[] { "θ", "Θ" } },
			{ "k", new[] { "κ", "Κ" } },
			{ "l", new[] { "λ", "Λ" } },
			{ "m", new[] { "μ", "Μ" } },
			{ "n", new[] { "ν", "Ν" } },
			{ "ks", new[] { "ξ", "Ξ" } },
			{ "o", new[] { "ο", "Ο", "ω", "ώ", "Ω", "Ώ" } },
			{ "p", new[] { "π", "Π" } },
			{ "r", new[] { "ρ", "Ρ" } },
			{ "s", new[] { "σ", "ς", "Σ" } },
			{ "t", new[] { "τ", "Τ" } },
			{ "y", new[] { "υ", "ύ", "ϋ", "ΰ", "Υ", "Ύ", "Ϋ" } },
			{ "f", new[] { "φ", "Φ" } },
			{ "ch", new[] { "χ", "Χ" } },
			{ "ps", new[] { "ψ", "Ψ" } },
		};

		/// <summary>
		/// Indicates whether a specified string is null, empty, or consists only of white-space characters.
		/// </summary>
		/// <param name="value">The string to test.</param>
		/// <returns>true if the <paramref name="value">value</paramref> parameter is null or <see cref="string.Empty"></see>, or if <paramref name="value">value</paramref> consists exclusively of white-space characters.</returns>
		[ExcludeFromCodeCoverage]
		[Pure]
		public static bool IsNullOrWhiteSpace(this string value)
			=> string.IsNullOrWhiteSpace(value);

		/// <summary>Indicates whether the specified string is null or an <see cref="string.Empty"></see> string.</summary>
		/// <param name="value">The string to test.</param>
		/// <returns>true if the <paramref name="value">value</paramref> parameter is null or an empty string (""); otherwise, false.</returns>
		[Obsolete("Prefer IsNullOrWhiteSpace instead")]
		[ExcludeFromCodeCoverage]
		[Pure]
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

		/// <summary>
		/// Transliterates greek characters, normalizes a string to Unicode NFC, trims whitespace and turns to uppercase.
		/// <para>Mainly intended for use in normalized fields for loookups, autocompletes and searches.</para>
		/// </summary>
		/// <param name="value">The string to normalize.</param>
		/// <returns>Normalized, transliterated uppercase text without leading or trailing whitespace.</returns>
		/// <remarks>Not suitable for large bodies of text.</remarks>
		public static string NormalizedTransliteration(this string value)
		{
			if (value.IsNullOrWhiteSpace())
			{
				return value;
			}

			var builder = new StringBuilder(value, value.Length);
			builder.ReplaceGreek();

			return builder.ToString()
				.Normalize(NormalizationForm.FormC)
				.Trim()
				.ToUpperInvariant();
		}

		/// <summary>
		/// Replaces all Greek characters with their ELOT 743 romanized equivalent.
		/// </summary>
		/// <param name="builder">The <see cref="StringBuilder"/> to work on.</param>
		/// <remarks>Not suitable for large bodies of text.
		/// <para>See also <seealso cref="GreekTransliterations"/>.</para></remarks>
		public static void ReplaceGreek(this StringBuilder builder)
		{
			foreach (var transliteration in GreekTransliterations)
			{
				foreach (var character in transliteration.Value)
				{
					builder?.Replace(character, transliteration.Key);
				}
			}
		}
	}
}
