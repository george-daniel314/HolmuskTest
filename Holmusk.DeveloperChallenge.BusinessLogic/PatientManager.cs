using Holmusk.DeveloperChallenge.Common.Enums;
using Holmusk.DeveloperChallenge.DataAccess;
using Holmusk.DeveloperChallenge.Entity;
using System.Collections.Generic;

namespace Holmusk.DeveloperChallenge.BusinessLogic
{
    /// <summary>
    /// For managing all business related functionality for Patient object.
    /// </summary>
    public class PatientManager : IPatientManager
    {
        #region Public Methods
        /// <summary>
        /// Adds an object to database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        public PatientEntity AddPatient(PatientEntity patient)
        {
            IPatientDataAccess dataAccess = DALFactory.CreateInstance(CallingContext.ContextTypeA);
            Patient patientDBEntity = ConvertEntityToDBEntity(patient);
            patientDBEntity = dataAccess.AddPatient(patientDBEntity);
            patient = ConvertDBEntityToEntity(patient, patientDBEntity);
            return patient;
        }

        /// <summary>
        /// Get an object from database based on the property Id.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        public PatientEntity GetPatientById(int id)
        {
            IPatientDataAccess dataAccess = DALFactory.CreateInstance(CallingContext.ContextTypeA);
            Patient patientDBEntity = dataAccess.GetPatientById(id);
            PatientEntity patient = null;
            patient = ConvertDBEntityToEntity(patient, patientDBEntity);
            return patient;
        }

        /// <summary>
        /// Get list of object from database.
        /// </summary>
        /// <returns>An enumerable collection of object having type as PatientEntity.</returns>
        public IEnumerable<PatientEntity> GetPatients()
        {
            IPatientDataAccess dataAccess = DALFactory.CreateInstance(CallingContext.ContextTypeA);
            IEnumerable<Patient> patientsDBEntity = dataAccess.GetPatients();
            List<PatientEntity> patients = new List<PatientEntity>();
            foreach (var item in patientsDBEntity)
            {
                PatientEntity patient = new PatientEntity
                {
                    Id = item.Id,
                    Address = item.Address,
                    BirthDate = item.BirthDate,
                    ContactNumber = item.ContactNumber,
                    Gender = item.Gender == 0 ? "Male" : "Female",
                    Name = item.Name,
                    IsActive = item.IsActive
                };
                patients.Add(patient);
            }
            return patients;
        }

        /// <summary>
        /// Modify an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        public PatientEntity UpdatePatient(PatientEntity patient)
        {
            IPatientDataAccess dataAccess = DALFactory.CreateInstance(CallingContext.ContextTypeA);
            Patient patientDBEntity = ConvertEntityToDBEntity(patient);
            patientDBEntity = dataAccess.UpdatePatient(patientDBEntity);
            patient = ConvertDBEntityToEntity(patient, patientDBEntity);
            return patient;
        }

        /// <summary>
        /// Delete an object in database.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>An object of type PatientEntity.</returns>
        public PatientEntity DeletePatient(PatientEntity patient)
        {
            IPatientDataAccess dataAccess = DALFactory.CreateInstance(CallingContext.ContextTypeA);
            Patient patientDBEntity = ConvertEntityToDBEntity(patient);
            patientDBEntity = dataAccess.DeletePatient(patientDBEntity);
            patient = ConvertDBEntityToEntity(patient, patientDBEntity);
            return patient;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Convert database entity to publically exposed type.
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="patientDBEntity"></param>
        /// <returns>An object of type PatientEntity.</returns>
        private static PatientEntity ConvertDBEntityToEntity(PatientEntity patient, Patient patientDBEntity)
        {
            patient = new PatientEntity
            {
                Address = patientDBEntity.Address,
                BirthDate = patientDBEntity.BirthDate,
                ContactNumber = patientDBEntity.ContactNumber,
                Gender = patientDBEntity.Gender == 0 ? EnumGender.Male.ToString() : EnumGender.Female.ToString(),
                Id = patientDBEntity.Id,
                IsActive = patientDBEntity.IsActive,
                Name = patientDBEntity.Name
            };
            return patient;
        }

        /// <summary>
        /// Convert publically exposed entity type to database type.
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="patientDBEntity"></param>
        /// <returns>An object of type Patient, which is database type.</returns>
        private static Patient ConvertEntityToDBEntity(PatientEntity patient)
        {
            Patient patientDBEntity = new Patient
            {
                Id = patient.Id,
                Address = patient.Address,
                BirthDate = patient.BirthDate,
                Name = patient.Name,
                ContactNumber = patient.ContactNumber,
                Gender = patient.Gender == EnumGender.Male.ToString() ? (byte)0 : (byte)1,
                IsActive = patient.IsActive
            };
            return patientDBEntity;
        }
        #endregion
    }
}