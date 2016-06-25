namespace Holmusk.DeveloperChallenge.UI
{
    partial class frmPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFHIRPatients = new System.Windows.Forms.TabControl();
            this.tabFHIR = new System.Windows.Forms.TabPage();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gridPatientsFHIR = new System.Windows.Forms.DataGridView();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabLocal = new System.Windows.Forms.TabPage();
            this.pnlAddOrEdit = new System.Windows.Forms.Panel();
            this.txtIdForEdit = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.grdPatientsHolmusk = new System.Windows.Forms.DataGridView();
            this.H_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabFHIRPatients.SuspendLayout();
            this.tabFHIR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatientsFHIR)).BeginInit();
            this.tabLocal.SuspendLayout();
            this.pnlAddOrEdit.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientsHolmusk)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFHIRPatients
            // 
            this.tabFHIRPatients.Controls.Add(this.tabFHIR);
            this.tabFHIRPatients.Controls.Add(this.tabLocal);
            this.tabFHIRPatients.Location = new System.Drawing.Point(12, 23);
            this.tabFHIRPatients.Name = "tabFHIRPatients";
            this.tabFHIRPatients.SelectedIndex = 0;
            this.tabFHIRPatients.Size = new System.Drawing.Size(1117, 395);
            this.tabFHIRPatients.TabIndex = 0;
            // 
            // tabFHIR
            // 
            this.tabFHIR.Controls.Add(this.btnImport);
            this.tabFHIR.Controls.Add(this.btnSearch);
            this.tabFHIR.Controls.Add(this.lblSearch);
            this.tabFHIR.Controls.Add(this.txtSearch);
            this.tabFHIR.Controls.Add(this.gridPatientsFHIR);
            this.tabFHIR.Location = new System.Drawing.Point(4, 22);
            this.tabFHIR.Name = "tabFHIR";
            this.tabFHIR.Padding = new System.Windows.Forms.Padding(3);
            this.tabFHIR.Size = new System.Drawing.Size(1109, 369);
            this.tabFHIR.TabIndex = 0;
            this.tabFHIR.Text = "Patients-FHIR";
            this.tabFHIR.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(622, 11);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(318, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Patient Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(215, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // gridPatientsFHIR
            // 
            this.gridPatientsFHIR.AllowUserToAddRows = false;
            this.gridPatientsFHIR.AllowUserToDeleteRows = false;
            this.gridPatientsFHIR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPatientsFHIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPatientsFHIR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSelected,
            this.Id,
            this.PatientName,
            this.ContactNumber,
            this.Address,
            this.DateOfBirth,
            this.Gender,
            this.IsActive});
            this.gridPatientsFHIR.Location = new System.Drawing.Point(0, 37);
            this.gridPatientsFHIR.Name = "gridPatientsFHIR";
            this.gridPatientsFHIR.Size = new System.Drawing.Size(697, 128);
            this.gridPatientsFHIR.TabIndex = 1;
            // 
            // IsSelected
            // 
            this.IsSelected.HeaderText = "";
            this.IsSelected.Name = "IsSelected";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "FHIRId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "Name";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "BirthDate";
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabLocal
            // 
            this.tabLocal.Controls.Add(this.pnlAddOrEdit);
            this.tabLocal.Controls.Add(this.grdPatientsHolmusk);
            this.tabLocal.Location = new System.Drawing.Point(4, 22);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocal.Size = new System.Drawing.Size(1109, 369);
            this.tabLocal.TabIndex = 1;
            this.tabLocal.Text = "Patients-Holmusk";
            this.tabLocal.UseVisualStyleBackColor = true;
            // 
            // pnlAddOrEdit
            // 
            this.pnlAddOrEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddOrEdit.Controls.Add(this.txtIdForEdit);
            this.pnlAddOrEdit.Controls.Add(this.btnClear);
            this.pnlAddOrEdit.Controls.Add(this.btnSave);
            this.pnlAddOrEdit.Controls.Add(this.chkIsActive);
            this.pnlAddOrEdit.Controls.Add(this.grpGender);
            this.pnlAddOrEdit.Controls.Add(this.dtpBirthDate);
            this.pnlAddOrEdit.Controls.Add(this.txtAddress);
            this.pnlAddOrEdit.Controls.Add(this.txtContactNumber);
            this.pnlAddOrEdit.Controls.Add(this.lblGender);
            this.pnlAddOrEdit.Controls.Add(this.lblIsActive);
            this.pnlAddOrEdit.Controls.Add(this.lblContactNumber);
            this.pnlAddOrEdit.Controls.Add(this.lblDOB);
            this.pnlAddOrEdit.Controls.Add(this.lblAddress);
            this.pnlAddOrEdit.Controls.Add(this.txtPatientName);
            this.pnlAddOrEdit.Controls.Add(this.lblPatientName);
            this.pnlAddOrEdit.Location = new System.Drawing.Point(6, 189);
            this.pnlAddOrEdit.Name = "pnlAddOrEdit";
            this.pnlAddOrEdit.Size = new System.Drawing.Size(888, 174);
            this.pnlAddOrEdit.TabIndex = 2;
            // 
            // txtIdForEdit
            // 
            this.txtIdForEdit.Location = new System.Drawing.Point(82, 137);
            this.txtIdForEdit.Name = "txtIdForEdit";
            this.txtIdForEdit.Size = new System.Drawing.Size(100, 20);
            this.txtIdForEdit.TabIndex = 18;
            this.txtIdForEdit.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(557, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(466, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(557, 104);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(64, 17);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Text = "IsActive";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rbnMale);
            this.grpGender.Controls.Add(this.rbnFemale);
            this.grpGender.Location = new System.Drawing.Point(82, 84);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(152, 47);
            this.grpGender.TabIndex = 14;
            this.grpGender.TabStop = false;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Checked = true;
            this.rbnMale.Location = new System.Drawing.Point(16, 19);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(48, 17);
            this.rbnMale.TabIndex = 12;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(70, 19);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbnFemale.TabIndex = 13;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(557, 50);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(82, 37);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(152, 47);
            this.txtAddress.TabIndex = 10;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(557, 14);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(200, 20);
            this.txtContactNumber.TabIndex = 8;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(3, 103);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(463, 103);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(48, 13);
            this.lblIsActive.TabIndex = 6;
            this.lblIsActive.Text = "Is Active";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(463, 14);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 5;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(463, 57);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 57);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(82, 11);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(152, 20);
            this.txtPatientName.TabIndex = 2;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(3, 14);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 13);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name";
            // 
            // grdPatientsHolmusk
            // 
            this.grdPatientsHolmusk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatientsHolmusk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.H_Id,
            this.H_PatientName,
            this.H_ContactNumber,
            this.H_Address,
            this.H_DateOfBirth,
            this.H_Gender,
            this.H_IsActive,
            this.Edit,
            this.Delete});
            this.grdPatientsHolmusk.Location = new System.Drawing.Point(6, 16);
            this.grdPatientsHolmusk.Name = "grdPatientsHolmusk";
            this.grdPatientsHolmusk.Size = new System.Drawing.Size(888, 150);
            this.grdPatientsHolmusk.TabIndex = 0;
            this.grdPatientsHolmusk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatientsHolmusk_CellContentClick);
            // 
            // H_Id
            // 
            this.H_Id.DataPropertyName = "Id";
            this.H_Id.HeaderText = "Id";
            this.H_Id.Name = "H_Id";
            this.H_Id.ReadOnly = true;
            this.H_Id.Visible = false;
            // 
            // H_PatientName
            // 
            this.H_PatientName.DataPropertyName = "Name";
            this.H_PatientName.HeaderText = "Patient Name";
            this.H_PatientName.Name = "H_PatientName";
            this.H_PatientName.ReadOnly = true;
            // 
            // H_ContactNumber
            // 
            this.H_ContactNumber.DataPropertyName = "ContactNumber";
            this.H_ContactNumber.HeaderText = "Contact Number";
            this.H_ContactNumber.Name = "H_ContactNumber";
            this.H_ContactNumber.ReadOnly = true;
            // 
            // H_Address
            // 
            this.H_Address.DataPropertyName = "Address";
            this.H_Address.HeaderText = "Address";
            this.H_Address.Name = "H_Address";
            this.H_Address.ReadOnly = true;
            // 
            // H_DateOfBirth
            // 
            this.H_DateOfBirth.DataPropertyName = "BirthDate";
            this.H_DateOfBirth.HeaderText = "Date Of Birth";
            this.H_DateOfBirth.Name = "H_DateOfBirth";
            this.H_DateOfBirth.ReadOnly = true;
            // 
            // H_Gender
            // 
            this.H_Gender.DataPropertyName = "Gender";
            this.H_Gender.HeaderText = "Gender";
            this.H_Gender.Name = "H_Gender";
            this.H_Gender.ReadOnly = true;
            // 
            // H_IsActive
            // 
            this.H_IsActive.DataPropertyName = "IsActive";
            this.H_IsActive.HeaderText = "IsActive";
            this.H_IsActive.Name = "H_IsActive";
            this.H_IsActive.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 486);
            this.Controls.Add(this.tabFHIRPatients);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.tabFHIRPatients.ResumeLayout(false);
            this.tabFHIR.ResumeLayout(false);
            this.tabFHIR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatientsFHIR)).EndInit();
            this.tabLocal.ResumeLayout(false);
            this.pnlAddOrEdit.ResumeLayout(false);
            this.pnlAddOrEdit.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientsHolmusk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFHIRPatients;
        private System.Windows.Forms.TabPage tabFHIR;
        private System.Windows.Forms.TabPage tabLocal;
        private System.Windows.Forms.DataGridView gridPatientsFHIR;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView grdPatientsHolmusk;
        private System.Windows.Forms.Panel pnlAddOrEdit;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtIdForEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_IsActive;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

