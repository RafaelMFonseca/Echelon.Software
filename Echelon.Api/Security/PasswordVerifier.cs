using Echelon.Api.Abstractions.Security;
using Echelon.Api.Utilities;

namespace Echelon.Api.Security;

public class PasswordVerifier : IPasswordVerifier
{
    /// <inheritdoc />
    bool IPasswordVerifier.Verify(string passwordLeft, string passwordRight)
    {
        return CryptographyUtilities.ComputeHashMD5(passwordLeft).Equals(passwordRight, StringComparison.OrdinalIgnoreCase);
    }
}
