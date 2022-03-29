namespace Echelon.Api.Abstractions.Security;

public interface IPasswordVerifier
{
    /// <summary>
    /// Verifies if two passwords are the same.
    /// </summary>
    /// <param name="passwordLeft">The left-side password to compare.</param>
    /// <param name="passwordRight">The right-side password to compare.</param>
    /// <returns>True if both are the same.</returns>
    bool Verify(string passwordLeft, string passwordRight);
}
