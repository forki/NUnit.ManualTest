namespace NUnit.ManualTest
{
  /// <summary>
  /// Interface to be implemented by all user presenters.
  /// </summary>
  public interface IUserPresenter
  {
    /// <summary>
    /// Queries for testers feedback (success or failure).
    /// </summary>
    /// <param name="message">The message to be displayed.</param>
    /// <returns><c>true</c> for success; otherwise <c>false</c>.</returns>
    bool Query(string message);
  }
}