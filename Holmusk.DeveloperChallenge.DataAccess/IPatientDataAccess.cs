using System.Collections.Generic;

namespace Holmusk.DeveloperChallenge.DataAccess
{
    public interface IPatientDataAccess
    {
        /// <summary>
        /// Adds an object to database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        Patient AddPatient(Patient patient);

        /// <summary>
        /// Get an object from database based on the property Id.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        Patient GetPatientById(int id);

        /// <summary>
        /// Get list of object from database.
        /// </summary>
        /// <returns>An enumerable collection of object having type as Patient.</returns>
        IEnumerable<Patient> GetPatients();

        /// <summary>
        /// Modify an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        Patient UpdatePatient(Patient patient);

        /// <summary>
        /// Delete an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        Patient DeletePatient(Patient patient);
    }
}