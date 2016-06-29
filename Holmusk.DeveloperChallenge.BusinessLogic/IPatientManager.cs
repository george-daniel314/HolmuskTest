using Holmusk.DeveloperChallenge.Entity;
using System.Collections.Generic;

namespace Holmusk.DeveloperChallenge.BusinessLogic
{
    public interface IPatientManager
    {
        /// <summary>
        /// Adds an object to database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        PatientEntity AddPatient(PatientEntity patient);

        /// <summary>
        /// Get an object from database based on the property Id.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        PatientEntity GetPatientById(int id);

        /// <summary>
        /// Get list of object from database.
        /// </summary>
        /// <returns>An enumerable collection of object having type as PatientEntity.</returns>
        IEnumerable<PatientEntity> GetPatients();

        /// <summary>
        /// Modify an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        PatientEntity UpdatePatient(PatientEntity patient);

        /// <summary>
        /// Delete an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        PatientEntity DeletePatient(PatientEntity patient);
    }
}