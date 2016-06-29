using Holmusk.DeveloperChallenge.Common.Enums;

namespace Holmusk.DeveloperChallenge.BusinessLogic
{
    public class BLFactory
    {
        /// <summary>
        /// Get instance of manager class by passing context
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static IPatientManager CreateInstance(CallingContext context)
        {
            IPatientManager instance = null;

            if (context == CallingContext.ContextTypeA)
            {
                instance = new PatientManager();
            }
            return instance;
        }
    }
}