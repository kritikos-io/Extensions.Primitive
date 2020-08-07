#nullable disable
namespace Kritikos.Extensions.Primitive.Tests
{
	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Security;

	using Xunit;

	[ExcludeFromCodeCoverage]
	public class StringTests
	{
		private const string EmptyString = "";
		private const string NullString = null;

		[Fact]
		public void SecureStringTests()
		{
			SecureString secure = null;

			Assert.Throws<ArgumentNullException>(() => NullString.AsSecureString());
			Assert.Throws<ArgumentNullException>(() => secure.UnsecureString());

			Assert.Equal(0, EmptyString.AsSecureString().Length);

			var randomInput = Guid.NewGuid().ToString();
			var secureInput = randomInput.AsSecureString();
			Assert.Equal(randomInput, secureInput.UnsecureString());
		}
	}
}
