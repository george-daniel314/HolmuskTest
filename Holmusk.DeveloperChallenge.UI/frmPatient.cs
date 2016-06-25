using Holmusk.DeveloperChallenge.BusinessLogic;
using Holmusk.DeveloperChallenge.Common.Enums;
using Holmusk.DeveloperChallenge.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Holmusk.DeveloperChallenge.UI
{
    public partial class frmPatient : Form
    {
        #region Constructor
        public frmPatient()
        {
            InitializeComponent();
        }
        #endregion

        #region Page Events
        private void Patient_Load(object sender, EventArgs e)
        {
            string urlFHIR = @"http://fhir-dstu1-nprogram.azurewebsites.net/Patient/?_format=json";
            dynamic deserializedJsonResponse = GetFHIRResponseBasedOnURL(urlFHIR);

            IEnumerable<PatientEntity> patients = ConvertFHIRResponseToCustom(deserializedJsonResponse);
            gridPatientsFHIR.AutoGenerateColumns = false;
            gridPatientsFHIR.DataSource = patients;

            BindPatientsGrid();
        }
        #endregion

        #region Control Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                string urlFHIR = string.Format(@"http://fhir-dstu1-nprogram.azurewebsites.net/Patient/search?name={0}&_format=json", txtSearch.Text);
                dynamic deserializedJsonResponse = GetFHIRResponseBasedOnURL(urlFHIR);

                List<PatientEntity> patients = ConvertFHIRResponseToCustom(deserializedJsonResponse);
                gridPatientsFHIR.AutoGenerateColumns = false;
                gridPatientsFHIR.DataSource = patients;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridPatientsFHIR.Rows)
            {
                if (row.Cells["IsSelected"].Value != null && row.Cells["IsSelected"].Value.Equals(true))
                {
                    PatientEntity patient = new PatientEntity
                    {
                        Address = row.Cells["Address"].Value.ToString(),
                        BirthDate = Convert.ToDateTime(row.Cells["DateOfBirth"].Value),
                        ContactNumber = row.Cells["ContactNumber"].Value.ToString(),
                        Gender = row.Cells["Gender"].Value.ToString(),
                        IsActive = Convert.ToBoolean(row.Cells["IsActive"].Value),
                        Name = row.Cells["PatientName"].Value.ToString()
                    };
                    PatientManager patientManager = new PatientManager();
                    patientManager.AddPatient(patient);
                    row.Cells["IsSelected"].Value = false;
                }
            }
            BindPatientsGrid();
            MessageBox.Show("Data imported successfully (Duplicate data will be ignored).");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientEntity patient = null;
            if (CheckIsValid())
            {
                if (btnSave.Text == "Save")
                {
                    patient = SavePatient(patient);
                    if (patient.Id > 0)
                    {
                        MessageBox.Show("Patient details saved successfully.");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("OOPs!! Something went wrong. Please contact administrator.");
                    }
                }
                else
                {
                    patient = UpdatePatient(patient);
                    ClearFields();
                    MessageBox.Show("Patient details updated successfully.");
                }
                BindPatientsGrid();
            }
            else
            {
                MessageBox.Show("All fields are mandatory. Please fill missing data.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
                
        private void grdPatientsHolmusk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdPatientsHolmusk.Columns[e.ColumnIndex].Name == "Edit")
            {
                PopulateDataForEdit(e);
            }
            else if (grdPatientsHolmusk.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeletePatient(e);
                BindPatientsGrid();
            }
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Add Patient object to database
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        private PatientEntity SavePatient(PatientEntity patient)
        {
            patient = new PatientEntity()
            {
                Address = txtAddress.Text,
                BirthDate = Convert.ToDateTime(dtpBirthDate.Text),
                ContactNumber = txtContactNumber.Text,
                Name = txtPatientName.Text,
                Gender = rbnMale.Checked == true ? EnumGender.Male.ToString() : EnumGender.Female.ToString(),
                IsActive = chkIsActive.Checked
            };
            PatientManager patientManager = new PatientManager();
            patient = patientManager.AddPatient(patient);
            return patient;
        }

        /// <summary>
        /// Update patient object.
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        private PatientEntity UpdatePatient(PatientEntity patient)
        {
            patient = new PatientEntity()
            {
                Id = Convert.ToInt32(txtIdForEdit.Text),
                Address = txtAddress.Text,
                BirthDate = Convert.ToDateTime(dtpBirthDate.Text),
                ContactNumber = txtContactNumber.Text,
                Name = txtPatientName.Text,
                Gender = rbnMale.Checked == true ? EnumGender.Male.ToString() : EnumGender.Female.ToString(),
                IsActive = chkIsActive.Checked
            };
            PatientManager patientManager = new PatientManager();
            patient = patientManager.UpdatePatient(patient);
            return patient;
        }

        /// <summary>
        /// Delete patient detils by changing status to inactive.
        /// </summary>
        /// <param name="e"></param>
        private void DeletePatient(DataGridViewCellEventArgs e)
        {
            PatientManager patientManager = new PatientManager();
            patientManager.DeletePatient(new PatientEntity() { Id = Convert.ToInt32(grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_Id"].Value) });
        }

        /// <summary>
        /// Populate data from grid for edit.
        /// </summary>
        /// <param name="e"></param>
        private void PopulateDataForEdit(DataGridViewCellEventArgs e)
        {
            txtIdForEdit.Text = grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_Id"].Value.ToString();
            txtPatientName.Text = grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_PatientName"].Value.ToString();
            txtContactNumber.Text = grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_ContactNumber"].Value.ToString();
            txtAddress.Text = grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_Address"].Value.ToString();
            dtpBirthDate.Text = Convert.ToDateTime(grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_DateOfBirth"].Value).ToString();
            if (grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_Gender"].Value.ToString() == EnumGender.Male.ToString())
            {
                rbnMale.Checked = true;
            }
            else
            {
                rbnFemale.Checked = true;
            }
            chkIsActive.Checked = Convert.ToBoolean(grdPatientsHolmusk.Rows[e.RowIndex].Cells["H_IsActive"].Value);
            txtPatientName.Focus();
            btnSave.Text = "Update";
        }

        /// <summary>
        /// Convert FHIR response object to custom enity PatientEntity
        /// </summary>
        /// <param name="deserializedJsonResponse"></param>
        /// <returns></returns>
        private static IEnumerable<PatientEntity> ConvertFHIRResponseToCustom(dynamic deserializedJsonResponse)
        {
            List<PatientEntity> patients = new List<PatientEntity>();
            if (deserializedJsonResponse != null)
            {
                foreach (var item in deserializedJsonResponse.entry)
                {
                    PatientEntity patient = new PatientEntity();
                    patient.BirthDate = Convert.ToDateTime(item.content.birthDate);
                    patient.IsActive = Convert.ToBoolean(item.content.active);
                    patient.Name = item.content.name[0].family;
                    patient.ContactNumber = item.content.telecom[0].value;
                    patient.Address = item.content.address[0].text;
                    if (item.content.gender.coding[0].code == "male")
                    {
                        patient.Gender = EnumGender.Male.ToString();
                    }
                    else if (item.content.gender.coding[0].code == "female")
                    {
                        patient.Gender = EnumGender.Female.ToString();
                    }
                    patients.Add(patient);
                }
            }
            return patients;
        }

        /// <summary>
        /// Fetch data from FHIR server based on url.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static dynamic GetFHIRResponseBasedOnURL(string url)
        {
            dynamic deserializedJsonResponse = null;
            try
            {
                //code for json Response consumption from REST based service.
                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = @"application/json; charset=utf-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string jsonResponse = string.Empty;
                //anonymus type to parse response object to custom format.
                var responseJsonType =
                    new
                    {
                        entry = new[] { new {
                        content = new {
                                birthDate = "", 
                                active=true, 
                                name = new []{ new { family = ""} }, 
                                telecom = new [] { new {value = ""}},
                                address = new [] {new {text = ""}},
                                gender = new 
                                {
                                coding = new [] {new { code = ""}   }
                                }
                            }
                        }
                    }
                    };
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    jsonResponse = sr.ReadToEnd();
                }
                JsonSerializer jsonSerializer = new JsonSerializer();
                deserializedJsonResponse = jsonSerializer.Deserialize(new StringReader(jsonResponse), responseJsonType.GetType());
            }
            catch (WebException)
            {
                MessageBox.Show("FHIR server not responding.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred. Please contact administrator");
            }
            return deserializedJsonResponse;
        }

        /// <summary>
        /// Bind grid that populates local data.
        /// </summary>
        private void BindPatientsGrid()
        {
            IEnumerable<PatientEntity> patients = new PatientManager().GetPatients();
            grdPatientsHolmusk.AutoGenerateColumns = false;
            grdPatientsHolmusk.DataSource = patients;
        }

        /// <summary>
        /// Validates patient details before save or update.
        /// </summary>
        /// <returns></returns>
        private bool CheckIsValid()
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(txtPatientName.Text) || string.IsNullOrEmpty(txtContactNumber.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(dtpBirthDate.Text))
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }

        /// <summary>
        /// Clear UI fields to Add/Edit Patient.
        /// </summary>
        private void ClearFields()
        {
            txtPatientName.Text = "";
            txtContactNumber.Text = "";
            txtAddress.Text = "";
            dtpBirthDate.Text = DateTime.Now.ToString();
            rbnMale.Checked = true;
            chkIsActive.Checked = false;
            btnSave.Text = "Save";
        }
        #endregion
    }
}