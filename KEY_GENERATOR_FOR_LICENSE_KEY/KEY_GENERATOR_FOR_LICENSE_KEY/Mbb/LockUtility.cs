namespace Mbb
{
	internal static class LockUtility
	{
		internal static string GetLicenseKeyBySQLServer(string sqlKey)
		{
			if (string.IsNullOrWhiteSpace(sqlKey))
			{
				return null;
			}
			else
			{
				string licenseKey =
				Hashing.GetSHA1(sqlKey);

				licenseKey =
					licenseKey.Substring(startIndex: 0, length: 30);


				licenseKey =
					Hashing.GetMD5(licenseKey);

				licenseKey =
					licenseKey.Substring(startIndex: 0, length: 30);

				return licenseKey.ToString();
			}
		}

	}
}
