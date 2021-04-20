
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
            this.dataGridViewAbsence = new System.Windows.Forms.DataGridView();
            this.btnAddAbsence = new System.Windows.Forms.Button();
            this.btnRemoveAbsence = new System.Windows.Forms.Button();
            this.btnModifyAbsence = new System.Windows.Forms.Button();
            this.panelAbsence = new System.Windows.Forms.Panel();
            this.lblPersonConcerned = new System.Windows.Forms.Label();
            this.grpBoxAbsenceData = new System.Windows.Forms.GroupBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblLastDay = new System.Windows.Forms.Label();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancelAbsence = new System.Windows.Forms.Button();
            this.btnSaveAbsence = new System.Windows.Forms.Button();
            this.panelAbsenceData = new System.Windows.Forms.Panel();
            this.grpBoxAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).BeginInit();
            this.panelAbsence.SuspendLayout();
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
            // dataGridViewAbsence
            // 
            this.dataGridViewAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsence.Location = new System.Drawing.Point(22, 79);
            this.dataGridViewAbsence.Name = "dataGridViewAbsence";
            this.dataGridViewAbsence.RowHeadersWidth = 51;
            this.dataGridViewAbsence.RowTemplate.Height = 24;
            this.dataGridViewAbsence.Size = new System.Drawing.Size(401, 286);
            this.dataGridViewAbsence.TabIndex = 0;
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAbsence.Location = new System.Drawing.Point(27, 14);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(109, 42);
            this.btnAddAbsence.TabIndex = 1;
            this.btnAddAbsence.Text = "Add";
            this.btnAddAbsence.UseVisualStyleBackColor = false;
            // 
            // btnRemoveAbsence
            // 
            this.btnRemoveAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemoveAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAbsence.Location = new System.Drawing.Point(257, 14);
            this.btnRemoveAbsence.Name = "btnRemoveAbsence";
            this.btnRemoveAbsence.Size = new System.Drawing.Size(109, 42);
            this.btnRemoveAbsence.TabIndex = 2;
            this.btnRemoveAbsence.Text = "Remove";
            this.btnRemoveAbsence.UseVisualStyleBackColor = false;
            // 
            // btnModifyAbsence
            // 
            this.btnModifyAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModifyAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyAbsence.Location = new System.Drawing.Point(142, 14);
            this.btnModifyAbsence.Name = "btnModifyAbsence";
            this.btnModifyAbsence.Size = new System.Drawing.Size(109, 42);
            this.btnModifyAbsence.TabIndex = 3;
            this.btnModifyAbsence.Text = "Modify";
            this.btnModifyAbsence.UseVisualStyleBackColor = false;
            // 
            // panelAbsence
            // 
            this.panelAbsence.Controls.Add(this.btnAddAbsence);
            this.panelAbsence.Controls.Add(this.btnRemoveAbsence);
            this.panelAbsence.Controls.Add(this.btnModifyAbsence);
            this.panelAbsence.Location = new System.Drawing.Point(22, 380);
            this.panelAbsence.Name = "panelAbsence";
            this.panelAbsence.Size = new System.Drawing.Size(375, 65);
            this.panelAbsence.TabIndex = 6;
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
            // grpBoxAbsenceData
            // 
            this.grpBoxAbsenceData.Controls.Add(this.panelAbsenceData);
            this.grpBoxAbsenceData.Controls.Add(this.comboBox1);
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
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(50, 159);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(75, 24);
            this.lblReason.TabIndex = 9;
            this.lblReason.Text = "Reason";
            this.lblReason.Click += new System.EventHandler(this.lblPhone_Click);
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
            this.lblLastDay.Click += new System.EventHandler(this.lblFirstName_Click);
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
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(135, 68);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(212, 24);
            this.dateTimePickerStart.TabIndex = 10;
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 30);
            this.comboBox1.TabIndex = 12;
            // 
            // btnCancelAbsence
            // 
            this.btnCancelAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAbsence.Location = new System.Drawing.Point(139, 9);
            this.btnCancelAbsence.Name = "btnCancelAbsence";
            this.btnCancelAbsence.Size = new System.Drawing.Size(109, 42);
            this.btnCancelAbsence.TabIndex = 5;
            this.btnCancelAbsence.Text = "Cancel";
            this.btnCancelAbsence.UseVisualStyleBackColor = false;
            // 
            // btnSaveAbsence
            // 
            this.btnSaveAbsence.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAbsence.Location = new System.Drawing.Point(24, 9);
            this.btnSaveAbsence.Name = "btnSaveAbsence";
            this.btnSaveAbsence.Size = new System.Drawing.Size(109, 42);
            this.btnSaveAbsence.TabIndex = 5;
            this.btnSaveAbsence.Text = "Save";
            this.btnSaveAbsence.UseVisualStyleBackColor = false;
            // 
            // panelAbsenceData
            // 
            this.panelAbsenceData.Controls.Add(this.btnCancelAbsence);
            this.panelAbsenceData.Controls.Add(this.btnSaveAbsence);
            this.panelAbsenceData.Location = new System.Drawing.Point(54, 210);
            this.panelAbsenceData.Name = "panelAbsenceData";
            this.panelAbsenceData.Size = new System.Drawing.Size(269, 63);
            this.panelAbsenceData.TabIndex = 15;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsence)).EndInit();
            this.panelAbsence.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAddAbsence;
        private System.Windows.Forms.Button btnRemoveAbsence;
        private System.Windows.Forms.Button btnModifyAbsence;
        private System.Windows.Forms.GroupBox grpBoxAbsenceData;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblFirstDay;
        private System.Windows.Forms.Label lblLastDay;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Panel panelAbsenceData;
        private System.Windows.Forms.Button btnCancelAbsence;
        private System.Windows.Forms.Button btnSaveAbsence;
    }
}