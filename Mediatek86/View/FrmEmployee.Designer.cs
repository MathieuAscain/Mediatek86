
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
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.BtnRemoveEmployee = new System.Windows.Forms.Button();
            this.BtnModifyEmployee = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.BtnAccessAbsence = new System.Windows.Forms.Button();
            this.lblTitleEmployee = new System.Windows.Forms.Label();
            this.lblShowButtonClicked = new System.Windows.Forms.Label();
            this.grpBoxEmployeeData = new System.Windows.Forms.GroupBox();
            this.panelEmployeeData = new System.Windows.Forms.Panel();
            this.BtnCancelEmployee = new System.Windows.Forms.Button();
            this.BtnSaveEmployee = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxFamilyName = new System.Windows.Forms.TextBox();
            this.lblAssignment = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.grpBoxEmployee.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.grpBoxEmployeeData.SuspendLayout();
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
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.BtnAddEmployee);
            this.panelEmployee.Controls.Add(this.BtnRemoveEmployee);
            this.panelEmployee.Controls.Add(this.BtnModifyEmployee);
            this.panelEmployee.Location = new System.Drawing.Point(18, 358);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(426, 65);
            this.panelEmployee.TabIndex = 5;
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEmployee.Location = new System.Drawing.Point(48, 14);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(109, 42);
            this.BtnAddEmployee.TabIndex = 1;
            this.BtnAddEmployee.Text = "Add";
            this.BtnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // BtnRemoveEmployee
            // 
            this.BtnRemoveEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveEmployee.Location = new System.Drawing.Point(278, 14);
            this.BtnRemoveEmployee.Name = "BtnRemoveEmployee";
            this.BtnRemoveEmployee.Size = new System.Drawing.Size(109, 42);
            this.BtnRemoveEmployee.TabIndex = 2;
            this.BtnRemoveEmployee.Text = "Remove";
            this.BtnRemoveEmployee.UseVisualStyleBackColor = false;
            // 
            // BtnModifyEmployee
            // 
            this.BtnModifyEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnModifyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyEmployee.Location = new System.Drawing.Point(163, 14);
            this.BtnModifyEmployee.Name = "BtnModifyEmployee";
            this.BtnModifyEmployee.Size = new System.Drawing.Size(109, 42);
            this.BtnModifyEmployee.TabIndex = 3;
            this.BtnModifyEmployee.Text = "Modify";
            this.BtnModifyEmployee.UseVisualStyleBackColor = false;
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
            // BtnAccessAbsence
            // 
            this.BtnAccessAbsence.AutoEllipsis = true;
            this.BtnAccessAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAccessAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccessAbsence.Location = new System.Drawing.Point(624, 424);
            this.BtnAccessAbsence.Name = "BtnAccessAbsence";
            this.BtnAccessAbsence.Size = new System.Drawing.Size(269, 42);
            this.BtnAccessAbsence.TabIndex = 1;
            this.BtnAccessAbsence.Text = "Access to absences";
            this.BtnAccessAbsence.UseVisualStyleBackColor = false;
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
            // panelEmployeeData
            // 
            this.panelEmployeeData.Controls.Add(this.BtnCancelEmployee);
            this.panelEmployeeData.Controls.Add(this.BtnSaveEmployee);
            this.panelEmployeeData.Location = new System.Drawing.Point(146, 277);
            this.panelEmployeeData.Name = "panelEmployeeData";
            this.panelEmployeeData.Size = new System.Drawing.Size(269, 63);
            this.panelEmployeeData.TabIndex = 14;
            // 
            // BtnCancelEmployee
            // 
            this.BtnCancelEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCancelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelEmployee.Location = new System.Drawing.Point(139, 9);
            this.BtnCancelEmployee.Name = "BtnCancelEmployee";
            this.BtnCancelEmployee.Size = new System.Drawing.Size(109, 42);
            this.BtnCancelEmployee.TabIndex = 5;
            this.BtnCancelEmployee.Text = "Cancel";
            this.BtnCancelEmployee.UseVisualStyleBackColor = false;
            // 
            // BtnSaveEmployee
            // 
            this.BtnSaveEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveEmployee.Location = new System.Drawing.Point(24, 9);
            this.BtnSaveEmployee.Name = "BtnSaveEmployee";
            this.BtnSaveEmployee.Size = new System.Drawing.Size(109, 42);
            this.BtnSaveEmployee.TabIndex = 5;
            this.BtnSaveEmployee.Text = "Save";
            this.BtnSaveEmployee.UseVisualStyleBackColor = false;
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
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(146, 187);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(269, 28);
            this.textBoxMail.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(146, 137);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(269, 28);
            this.textBoxPhone.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(146, 89);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(269, 28);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // textBoxFamilyName
            // 
            this.textBoxFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFamilyName.Location = new System.Drawing.Point(146, 45);
            this.textBoxFamilyName.Name = "textBoxFamilyName";
            this.textBoxFamilyName.Size = new System.Drawing.Size(269, 28);
            this.textBoxFamilyName.TabIndex = 9;
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
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 484);
            this.Controls.Add(this.grpBoxEmployeeData);
            this.Controls.Add(this.lblTitleEmployee);
            this.Controls.Add(this.BtnAccessAbsence);
            this.Controls.Add(this.grpBoxEmployee);
            this.Name = "FrmEmployee";
            this.Text = "Employees";
            this.grpBoxEmployee.ResumeLayout(false);
            this.panelEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.grpBoxEmployeeData.ResumeLayout(false);
            this.grpBoxEmployeeData.PerformLayout();
            this.panelEmployeeData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button BtnModifyEmployee;
        private System.Windows.Forms.Button BtnRemoveEmployee;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.Button BtnAccessAbsence;
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
        private System.Windows.Forms.Button BtnCancelEmployee;
        private System.Windows.Forms.Button BtnSaveEmployee;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Panel panelEmployeeData;
    }
}