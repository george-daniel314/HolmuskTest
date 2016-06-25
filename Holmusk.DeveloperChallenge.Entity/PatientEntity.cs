using System;

namespace Holmusk.DeveloperChallenge.Entity
{
    /// <summary>
    /// Entity class for Patient object.
    /// Use this object to expose Patient details publically.
    /// </summary>
    public class PatientEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets Id of patient.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of patient.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets birth date of patient.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets contact number of patient.
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or sets address of patient.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets gender of patient.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// True for active and flase for inactive.
        /// </summary>
        public bool IsActive { get; set; } 
        #endregion
    }
}
