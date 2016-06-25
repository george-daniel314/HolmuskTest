using System.Collections.Generic;
using System.Linq;

namespace Holmusk.DeveloperChallenge.DataAccess
{
    /// <summary>
    /// Handles all database transaction related functionality for Patient object.
    /// </summary>
    public class PatientDataAccess
    {
        #region Methods
        /// <summary>
        /// Adds an object to database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        public Patient AddPatient(Patient patient)
        {
            using (HolmuskHealthCareEntities context = new HolmuskHealthCareEntities())
            {
                var existingPatient = context.Patients.Where(p => p.Name == patient.Name && patient.ContactNumber == patient.ContactNumber && p.BirthDate == patient.BirthDate).FirstOrDefault<Patient>();
                if (existingPatient == null)
                {
                    context.Patients.Add(patient);
                    context.SaveChanges();
                }
                return patient;
            }
        }

        /// <summary>
        /// Get an object from database based on the property Id.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        public Patient GetPatientById(int id)
        {
            Patient patient = null;
            using (HolmuskHealthCareEntities context = new HolmuskHealthCareEntities())
            {
                patient = context.Patients.FirstOrDefault<Patient>();
            }
            return patient;
        }

        /// <summary>
        /// Get list of object from database.
        /// </summary>
        /// <returns>An enumerable collection of object having type as Patient.</returns>
        public List<Patient> GetPatients()
        {
            List<Patient> patients = null;
            using (HolmuskHealthCareEntities context = new HolmuskHealthCareEntities())
            {
                patients = context.Patients.ToList();
            }
            return patients;
        }

        /// <summary>
        /// Modify an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        public Patient UpdatePatient(Patient patient)
        {
            using (HolmuskHealthCareEntities context = new HolmuskHealthCareEntities())
            {
                var existingPatient = context.Patients.Where(p => p.Id == patient.Id).FirstOrDefault<Patient>();
                if (existingPatient != null)
                {
                    existingPatient.Name = patient.Name;
                    existingPatient.Address = patient.Address;
                    existingPatient.BirthDate = patient.BirthDate;
                    existingPatient.ContactNumber = patient.ContactNumber;
                    existingPatient.Gender = patient.Gender;
                    existingPatient.IsActive = patient.IsActive;
                }
                context.SaveChanges();
                return patient;
            }
        }

        /// <summary>
        /// Delete an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type Patient.</returns>
        public Patient DeletePatient(Patient patient)
        {
            using (HolmuskHealthCareEntities context = new HolmuskHealthCareEntities())
            {
                var existingPatient = context.Patients.Where(p => p.Id == patient.Id).FirstOrDefault<Patient>();
                if (existingPatient != null)
                {
                    existingPatient.IsActive = patient.IsActive;
                }
                context.SaveChanges();
                return patient;
            }
        } 
        #endregion
    }
}