using System.Security.Cryptography;
using System.Text;

namespace Echelon.Api.Utilities;

public static class CryptographyUtilities
{
    /// <summary>
    /// Computes the hash value for the specified byte array.
    /// </summary>
    /// <param name="input">The input to compute the hash code for.</param>
    /// <returns>The computed hash code.</returns>
    public static string ComputeHashMD5(string input)
    {
        MD5 md5Hash = MD5.Create();

        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

        StringBuilder sBuilder = new StringBuilder();

        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }

        return sBuilder.ToString();
    }
}
