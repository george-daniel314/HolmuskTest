using System.IO;
using System.Net;

namespace Holmusk.DeveloperChallenge.Services
{
    /// <summary>
    /// Service to consume data from FHIR server
    /// </summary>
    public class FHIRService : IService
    {
        #region Variables
        private const string fhirURL = @"http://fhir-dstu1-nprogram.azurewebsites.net/Patient/?_format=json";
        private const string fhirURLForSearchByName = @"http://fhir-dstu1-nprogram.azurewebsites.net/Patient/search?name={0}&_format=json";

        #endregion

        #region IService Members
        /// <summary>
        /// Get response from FHIR server
        /// </summary>
        /// <returns>Response string from server</returns>
        public string GetResponse(string name = null)
        {
            string response = "";
            if (string.IsNullOrEmpty(name))
            {
                response = GetFHIRResponseBasedOnURL(fhirURL);
            }
            else
            {
                response = GetFHIRResponseBasedOnURL(string.Format(fhirURLForSearchByName, name));
            }
            return response;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Fetch data from FHIR server based on url.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string GetFHIRResponseBasedOnURL(string url)
        {
            //code for json Response consumption from REST based service.
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = @"application/json; charset=utf-8";
            string jsonResponse = string.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    jsonResponse = sr.ReadToEnd();
                }
            }
            return jsonResponse;
        }
        #endregion
    }
}