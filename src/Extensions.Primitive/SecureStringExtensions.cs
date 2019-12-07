namespace Kritikos.Extensions.Primitive
{
	using System;
	using System.Runtime.InteropServices;
	using System.Security;

	public static class SecureStringExtensions
	{
		/// <summary>
		/// Unprotects a <see cref="SecureString"/> into a plain <see cref="string"/>.
		/// </summary>
		/// <param name="value">The <see cref="SecureString"/> to decrypt.</param>
		/// <returns>The string encrypted in the <paramref name="value"/> parameter.</returns>
		public static string UnsecureString(this SecureString value)
		{
			if (value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}

			var unmanaged = IntPtr.Zero;
			try
			{
				unmanaged = Marshal.SecureStringToGlobalAllocUnicode(value);
				return Marshal.PtrToStringUni(unmanaged);
			}
			finally
			{
				Marshal.ZeroFreeGlobalAllocUnicode(unmanaged);
			}
		}
	}
}
