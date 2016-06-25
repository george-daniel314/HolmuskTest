
namespace Holmusk.DeveloperChallenge.Services
{
    /// <summary>
    /// Client class to consume services.
    /// </summary>
    public class Client
    {
        #region Variables
        private IService service;
        #endregion

        #region Constructors
        public Client(IService service)
        {
            this.service = service;
        }
        #endregion

        #region Methods
        /// <summary>
        /// /// <summary>
        /// Get response from server
        /// </summary>
        /// <returns>Response string from server</returns>
        public string GetResponse(string name = null)
        {
            return this.service.GetResponse(name);
        }
        #endregion
    }
}