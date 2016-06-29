using Holmusk.DeveloperChallenge.Common.Enums;

namespace Holmusk.DeveloperChallenge.DataAccess
{
    public class DALFactory
    {
        /// <summary>
        /// Get instance of DataAccess by passing context
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static IPatientDataAccess CreateInstance(CallingContext context)
        {
            IPatientDataAccess instance = null;

            if (context == CallingContext.ContextTypeA)
            {
                instance = new PatientDataAccess();
            }
            return instance;
        }
    }
}