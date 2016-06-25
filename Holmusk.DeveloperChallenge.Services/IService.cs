
namespace Holmusk.DeveloperChallenge.Services
{
    /// <summary>
    /// Exposes functions that service supports.
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// /// <summary>
        /// Get response from server
        /// Optional parameter name for search particular name in server.
        /// </summary>
        /// <returns>Response string from server</returns>
        string GetResponse(string name = null);
    }
}