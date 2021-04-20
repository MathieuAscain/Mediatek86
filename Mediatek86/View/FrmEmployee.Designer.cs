
namespace Mediatek86.View
{
    partial class FrmEmployee
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
            this.grpBoxEmployee = new System.Windows.Forms.GroupBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnAccessAbsence = new System.Windows.Forms.Button();
            this.lblTitleEmployee = new System.Windows.Forms.Label();
            this.lblShowButtonClicked = new System.Windows.Forms.Label();
            this.grpBoxEmployeeData = new System.Windows.Forms.GroupBox();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.textBoxFamilyName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnCancelEmployee = new System.Windows.Forms.Button();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.panelEmployeeData = new System.Windows.Forms.Panel();
            this.grpBoxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.grpBoxEmployeeData.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            this.panelEmployeeData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxEmployee
            // 
            this.grpBoxEmployee.Controls.Add(this.panelEmployee);
            this.grpBoxEmployee.Controls.Add(this.dataGridViewEmployee);
            this.grpBoxEmployee.Location = new System.Drawing.Point(12, 52);
            this.grpBoxEmployee.Name = "grpBoxEmployee";
            this.grpBoxEmployee.Size = new System.Drawing.Size(460, 434);
            this.grpBoxEmployee.TabIndex = 0;
            this.grpBoxEmployee.TabStop = false;
            this.grpBoxEmployee.Text = "Employees management";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(18, 31);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(426, 320);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(48, 14);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(109, 42);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(278, 14);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(109, 42);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModifyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyEmployee.Location = new System.Drawing.Point(163, 14);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(109, 42);
            this.btnModifyEmployee.TabIndex = 3;
            this.btnModifyEmployee.Text = "Modify";
            this.btnModifyEmployee.UseVisualStyleBackColor = false;
            // 
            // btnAccessAbsence
            // 
            this.btnAccessAbsence.AutoEllipsis = true;
            this.btnAccessAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAccessAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessAbsence.Location = new System.Drawing.Point(624, 424);
            this.btnAccessAbsence.Name = "btnAccessAbsence";
            this.btnAccessAbsence.Size = new System.Drawing.Size(269, 42);
            this.btnAccessAbsence.TabIndex = 1;
            this.btnAccessAbsence.Text = "Access to absences";
            this.btnAccessAbsence.UseVisualStyleBackColor = false;
            // 
            // lblTitleEmployee
            // 
            this.lblTitleEmployee.AutoSize = true;
            this.lblTitleEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEmployee.Location = new System.Drawing.Point(228, 13);
            this.lblTitleEmployee.Name = "lblTitleEmployee";
            this.lblTitleEmployee.Size = new System.Drawing.Size(424, 36);
            this.lblTitleEmployee.TabIndex = 2;
            this.lblTitleEmployee.Text = "EMPLOYEES MANAGEMENT";
            // 
            // lblShowButtonClicked
            // 
            this.lblShowButtonClicked.AutoSize = true;
            this.lblShowButtonClicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowButtonClicked.Location = new System.Drawing.Point(226, 18);
            this.lblShowButtonClicked.Name = "lblShowButtonClicked";
            this.lblShowButtonClicked.Size = new System.Drawing.Size(122, 24);
            this.lblShowButtonClicked.TabIndex = 3;
            this.lblShowButtonClicked.Text = "Modification";
            // 
            // grpBoxEmployeeData
            // 
            this.grpBoxEmployeeData.Controls.Add(this.panelEmployeeData);
            this.grpBoxEmployeeData.Controls.Add(this.comboBoxDepartment);
            this.grpBoxEmployeeData.Controls.Add(this.textBoxMail);
            this.grpBoxEmployeeData.Controls.Add(this.textBoxPhone);
            this.grpBoxEmployeeData.Controls.Add(this.textBoxFirstName);
            this.grpBoxEmployeeData.Controls.Add(this.textBoxFamilyName);
            this.grpBoxEmployeeData.Controls.Add(this.lblAssignment);
            this.grpBoxEmployeeData.Controls.Add(this.lblMail);
            this.grpBoxEmployeeData.Controls.Add(this.lblPhone);
            this.grpBoxEmployeeData.Controls.Add(this.lblFirstName);
            this.grpBoxEmployeeData.Controls.Add(this.lblFamilyName);
            this.grpBoxEmployeeData.Controls.Add(this.lblShowButtonClicked);
            this.grpBoxEmployeeData.Location = new System.Drawing.Point(478, 53);
            this.grpBoxEmployeeData.Name = "grpBoxEmployeeData";
            this.grpBoxEmployeeData.Size = new System.Drawing.Size(421, 358);
            this.grpBoxEmployeeData.TabIndex = 4;
            this.grpBoxEmployeeData.TabStop = false;
            this.grpBoxEmployeeData.Text = "Data management";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyName.Location = new System.Drawing.Point(22, 48);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(118, 24);
            this.lblFamilyName.TabIndex = 4;
            this.lblFamilyName.Text = "Family name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(42, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(98, 24);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(74, 140);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 24);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(96, 190);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(44, 24);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // lblAssignment
            // 
            this.lblAssignment.AutoSize = true;
            this.lblAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignment.Location = new System.Drawing.Point(31, 234);
            this.lblAssignment.Name = "lblAssignment";
            this.lblAssignment.Size = new System.Drawing.Size(107, 24);
            this.lblAssignment.TabIndex = 8;
            this.lblAssignment.Text = "Department";
            // 
            // textBoxFamilyName
            // 
            this.textBoxFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFamilyName.Location = new System.Drawing.Point(146, 45);
            this.textBoxFamilyName.Name = "textBoxFamilyName";
            this.textBoxFamilyName.Size = new System.Drawing.Size(269, 28);
            this.textBoxFamilyName.TabIndex = 9;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(146, 89);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(269, 28);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(146, 137);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(269, 28);
            this.textBoxPhone.TabIndex = 11;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(146, 187);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(269, 28);
            this.textBoxMail.TabIndex = 12;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(146, 231);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(269, 30);
            this.comboBoxDepartment.TabIndex = 13;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployee.Location = new System.Drawing.Point(24, 9);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(109, 42);
            this.btnSaveEmployee.TabIndex = 5;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            // 
            // btnCancelEmployee
            // 
            this.btnCancelEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEmployee.Location = new System.Drawing.Point(139, 9);
            this.btnCancelEmployee.Name = "btnCancelEmployee";
            this.btnCancelEmployee.Size = new System.Drawing.Size(109, 42);
            this.btnCancelEmployee.TabIndex = 5;
            this.btnCancelEmployee.Text = "Cancel";
            this.btnCancelEmployee.UseVisualStyleBackColor = false;
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.btnAddEmployee);
            this.panelEmployee.Controls.Add(this.btnRemoveEmployee);
            this.panelEmployee.Controls.Add(this.btnModifyEmployee);
            this.panelEmployee.Location = new System.Drawing.Point(18, 358);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(426, 65);
            this.panelEmployee.TabIndex = 5;
            // 
            // panelEmployeeData
            // 
            this.panelEmployeeData.Controls.Add(this.btnCancelEmployee);
            this.panelEmployeeData.Controls.Add(this.btnSaveEmployee);
            this.panelEmployeeData.Location = new System.Drawing.Point(146, 277);
            this.panelEmployeeData.Name = "panelEmployeeData";
            this.panelEmployeeData.Size = new System.Drawing.Size(269, 63);
            this.panelEmployeeData.TabIndex = 14;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 484);
            this.Controls.Add(this.grpBoxEmployeeData);
            this.Controls.Add(this.lblTitleEmployee);
            this.Controls.Add(this.btnAccessAbsence);
            this.Controls.Add(this.grpBoxEmployee);
            this.Name = "FrmEmployee";
            this.Text = "Employees";
            this.grpBoxEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.grpBoxEmployeeData.ResumeLayout(false);
            this.grpBoxEmployeeData.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployeeData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAccessAbsence;
        private System.Windows.Forms.Label lblTitleEmployee;
        private System.Windows.Forms.Label lblShowButtonClicked;
        private System.Windows.Forms.GroupBox grpBoxEmployeeData;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxFamilyName;
        private System.Windows.Forms.Label lblAssignment;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Button btnCancelEmployee;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Panel panelEmployeeData;
    }
}