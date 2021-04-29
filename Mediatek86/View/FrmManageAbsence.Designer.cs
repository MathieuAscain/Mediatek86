
namespace Mediatek86.View
{
    partial class FrmManageAbsence
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
            this.lblTitleAbsence = new System.Windows.Forms.Label();
            this.grpBoxAbsence = new System.Windows.Forms.GroupBox();
            this.lblPersonConcerned = new System.Windows.Forms.Label();
            this.panelAbsence = new System.Windows.Forms.Panel();
            this.BtnAddAbsence = new System.Windows.Forms.Button();
            this.BtnRemoveAbsence = new System.Windows.Forms.Button();
            this.BtnModifyAbsence = new System.Windows.Forms.Button();
            this.dataGridViewAbsence = new System.Windows.Forms.DataGridView();
            this.grpBoxAbsenceData = new System.Windows.Forms.GroupBox();
            this.panelAbsenceData = new System.Windows.Forms.Panel();
            this.BtnCancelAbsence = new System.Windows.Forms.Button();
            this.BtnSaveAbsence = new System.Windows.Forms.Button();
            this.comboBoxReason = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.lblLastDay = new System.Windows.Forms.Label();
            this.grpBoxAbsence.SuspendLayout();
            this.panelAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).BeginInit();
            this.grpBoxAbsenceData.SuspendLayout();
            this.panelAbsenceData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleAbsence
            // 
            this.lblTitleAbsence.AutoSize = true;
            this.lblTitleAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAbsence.Location = new System.Drawing.Point(214, 9);
            this.lblTitleAbsence.Name = "lblTitleAbsence";
            this.lblTitleAbsence.Size = new System.Drawing.Size(404, 36);
            this.lblTitleAbsence.TabIndex = 3;
            this.lblTitleAbsence.Text = "ABSENCES MANAGEMENT";
            // 
            // grpBoxAbsence
            // 
            this.grpBoxAbsence.Controls.Add(this.lblPersonConcerned);
            this.grpBoxAbsence.Controls.Add(this.panelAbsence);
            this.grpBoxAbsence.Controls.Add(this.dataGridViewAbsence);
            this.grpBoxAbsence.Location = new System.Drawing.Point(34, 48);
            this.grpBoxAbsence.Name = "grpBoxAbsence";
            this.grpBoxAbsence.Size = new System.Drawing.Size(436, 451);
            this.grpBoxAbsence.TabIndex = 4;
            this.grpBoxAbsence.TabStop = false;
            this.grpBoxAbsence.Text = "Absence management";
            // 
            // lblPersonConcerned
            // 
            this.lblPersonConcerned.AutoSize = true;
            this.lblPersonConcerned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonConcerned.Location = new System.Drawing.Point(18, 36);
            this.lblPersonConcerned.Name = "lblPersonConcerned";
            this.lblPersonConcerned.Size = new System.Drawing.Size(189, 24);
            this.lblPersonConcerned.TabIndex = 7;
            this.lblPersonConcerned.Text = "Personne concernée";
            // 
            // panelAbsence
            // 
            this.panelAbsence.Controls.Add(this.BtnAddAbsence);
            this.panelAbsence.Controls.Add(this.BtnRemoveAbsence);
            this.panelAbsence.Controls.Add(this.BtnModifyAbsence);
            this.panelAbsence.Location = new System.Drawing.Point(22, 380);
            this.panelAbsence.Name = "panelAbsence";
            this.panelAbsence.Size = new System.Drawing.Size(375, 65);
            this.panelAbsence.TabIndex = 6;
            // 
            // BtnAddAbsence
            // 
            this.BtnAddAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAddAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAbsence.Location = new System.Drawing.Point(27, 14);
            this.BtnAddAbsence.Name = "BtnAddAbsence";
            this.BtnAddAbsence.Size = new System.Drawing.Size(109, 42);
            this.BtnAddAbsence.TabIndex = 1;
            this.BtnAddAbsence.Text = "Add";
            this.BtnAddAbsence.UseVisualStyleBackColor = false;
            this.BtnAddAbsence.Click += new System.EventHandler(this.BtnAddAbsence_Click);
            // 
            // BtnRemoveAbsence
            // 
            this.BtnRemoveAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnRemoveAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveAbsence.Location = new System.Drawing.Point(257, 14);
            this.BtnRemoveAbsence.Name = "BtnRemoveAbsence";
            this.BtnRemoveAbsence.Size = new System.Drawing.Size(109, 42);
            this.BtnRemoveAbsence.TabIndex = 2;
            this.BtnRemoveAbsence.Text = "Remove";
            this.BtnRemoveAbsence.UseVisualStyleBackColor = false;
            this.BtnRemoveAbsence.Click += new System.EventHandler(this.BtnRemoveAbsence_Click);
            // 
            // BtnModifyAbsence
            // 
            this.BtnModifyAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnModifyAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyAbsence.Location = new System.Drawing.Point(142, 14);
            this.BtnModifyAbsence.Name = "BtnModifyAbsence";
            this.BtnModifyAbsence.Size = new System.Drawing.Size(109, 42);
            this.BtnModifyAbsence.TabIndex = 3;
            this.BtnModifyAbsence.Text = "Modify";
            this.BtnModifyAbsence.UseVisualStyleBackColor = false;
            this.BtnModifyAbsence.Click += new System.EventHandler(this.BtnModifyAbsence_Click);
            // 
            // dataGridViewAbsence
            // 
            this.dataGridViewAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsence.Location = new System.Drawing.Point(22, 79);
            this.dataGridViewAbsence.Name = "dataGridViewAbsence";
            this.dataGridViewAbsence.RowHeadersWidth = 51;
            this.dataGridViewAbsence.RowTemplate.Height = 24;
            this.dataGridViewAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAbsence.Size = new System.Drawing.Size(401, 286);
            this.dataGridViewAbsence.TabIndex = 0;
            // 
            // grpBoxAbsenceData
            // 
            this.grpBoxAbsenceData.Controls.Add(this.panelAbsenceData);
            this.grpBoxAbsenceData.Controls.Add(this.comboBoxReason);
            this.grpBoxAbsenceData.Controls.Add(this.dateTimePickerEnd);
            this.grpBoxAbsenceData.Controls.Add(this.dateTimePickerStart);
            this.grpBoxAbsenceData.Controls.Add(this.lblReason);
            this.grpBoxAbsenceData.Controls.Add(this.lblFirstDay);
            this.grpBoxAbsenceData.Controls.Add(this.lblLastDay);
            this.grpBoxAbsenceData.Location = new System.Drawing.Point(493, 48);
            this.grpBoxAbsenceData.Name = "grpBoxAbsenceData";
            this.grpBoxAbsenceData.Size = new System.Drawing.Size(371, 344);
            this.grpBoxAbsenceData.TabIndex = 5;
            this.grpBoxAbsenceData.TabStop = false;
            this.grpBoxAbsenceData.Text = "Data management";
            // 
            // panelAbsenceData
            // 
            this.panelAbsenceData.Controls.Add(this.BtnCancelAbsence);
            this.panelAbsenceData.Controls.Add(this.BtnSaveAbsence);
            this.panelAbsenceData.Location = new System.Drawing.Point(54, 210);
            this.panelAbsenceData.Name = "panelAbsenceData";
            this.panelAbsenceData.Size = new System.Drawing.Size(269, 63);
            this.panelAbsenceData.TabIndex = 15;
            // 
            // BtnCancelAbsence
            // 
            this.BtnCancelAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCancelAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelAbsence.Location = new System.Drawing.Point(139, 9);
            this.BtnCancelAbsence.Name = "BtnCancelAbsence";
            this.BtnCancelAbsence.Size = new System.Drawing.Size(109, 42);
            this.BtnCancelAbsence.TabIndex = 5;
            this.BtnCancelAbsence.Text = "Cancel";
            this.BtnCancelAbsence.UseVisualStyleBackColor = false;
            // 
            // BtnSaveAbsence
            // 
            this.BtnSaveAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnSaveAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveAbsence.Location = new System.Drawing.Point(24, 9);
            this.BtnSaveAbsence.Name = "BtnSaveAbsence";
            this.BtnSaveAbsence.Size = new System.Drawing.Size(109, 42);
            this.BtnSaveAbsence.TabIndex = 5;
            this.BtnSaveAbsence.Text = "Save";
            this.BtnSaveAbsence.UseVisualStyleBackColor = false;
            this.BtnSaveAbsence.Click += new System.EventHandler(this.BtnSaveAbsence_Click);
            // 
            // comboBoxReason
            // 
            this.comboBoxReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReason.FormattingEnabled = true;
            this.comboBoxReason.Location = new System.Drawing.Point(135, 156);
            this.comboBoxReason.Name = "comboBoxReason";
            this.comboBoxReason.Size = new System.Drawing.Size(212, 30);
            this.comboBoxReason.TabIndex = 12;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(135, 113);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(212, 24);
            this.dateTimePickerEnd.TabIndex = 11;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(135, 68);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(212, 24);
            this.dateTimePickerStart.TabIndex = 10;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(50, 159);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(75, 24);
            this.lblReason.TabIndex = 9;
            this.lblReason.Text = "Reason";
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstDay.Location = new System.Drawing.Point(45, 70);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(80, 24);
            this.lblFirstDay.TabIndex = 7;
            this.lblFirstDay.Text = "First day";
            // 
            // lblLastDay
            // 
            this.lblLastDay.AutoSize = true;
            this.lblLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastDay.Location = new System.Drawing.Point(47, 113);
            this.lblLastDay.Name = "lblLastDay";
            this.lblLastDay.Size = new System.Drawing.Size(78, 24);
            this.lblLastDay.TabIndex = 8;
            this.lblLastDay.Text = "Last day";
            // 
            // FrmManageAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 511);
            this.Controls.Add(this.grpBoxAbsenceData);
            this.Controls.Add(this.grpBoxAbsence);
            this.Controls.Add(this.lblTitleAbsence);
            this.Name = "FrmManageAbsence";
            this.Text = "Absences";
            this.grpBoxAbsence.ResumeLayout(false);
            this.grpBoxAbsence.PerformLayout();
            this.panelAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).EndInit();
            this.grpBoxAbsenceData.ResumeLayout(false);
            this.grpBoxAbsenceData.PerformLayout();
            this.panelAbsenceData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleAbsence;
        private System.Windows.Forms.GroupBox grpBoxAbsence;
        private System.Windows.Forms.DataGridView dataGridViewAbsence;
        private System.Windows.Forms.Label lblPersonConcerned;
        private System.Windows.Forms.Panel panelAbsence;
        private System.Windows.Forms.Button BtnAddAbsence;
        private System.Windows.Forms.Button BtnRemoveAbsence;
        private System.Windows.Forms.Button BtnModifyAbsence;
        private System.Windows.Forms.GroupBox grpBoxAbsenceData;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblFirstDay;
        private System.Windows.Forms.Label lblLastDay;
        private System.Windows.Forms.ComboBox comboBoxReason;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Panel panelAbsenceData;
        private System.Windows.Forms.Button BtnCancelAbsence;
        private System.Windows.Forms.Button BtnSaveAbsence;
    }
}