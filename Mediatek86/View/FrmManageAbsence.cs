﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Mediatek86.Control;
using Mediatek86.Model;

namespace Mediatek86.View
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmManageAbsence : Form
    {
        private readonly ControlMyApp _controlMyApp;
        private readonly Employee _employee;
        private readonly BindingSource bindingSourceReasons = new BindingSource();
        private readonly BindingSource bindingSourceAbsences = new BindingSource();
        private object myOptionSelected;
        private readonly ArrayList senderList = new ArrayList();
        private DateTime previousDaySelected;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="controlMyApp"></param>
        public FrmManageAbsence(ControlMyApp controlMyApp, Employee employee)
        {
            InitializeComponent();
            _controlMyApp = controlMyApp;
            Init(employee);
            _employee = employee;
        }

        public void Init(Employee employee)
        {
            SetUpButtonColours();
            SetUpDateTimePickerFormat();
            UnlockDataGridViewAndBlockModifications();
            FillAbsenceList(employee);
            FillComboBoxReason();
            AddNameToLabel(employee);
        }

        public void SetUpButtonColours()
        {
            BtnAddAbsence.BackColor = Color.Aquamarine;
            BtnModifyAbsence.BackColor = Color.Aquamarine;
            BtnRemoveAbsence.BackColor = Color.Aquamarine;
            BtnSaveAbsence.BackColor = Color.Aquamarine;
            BtnCancelAbsence.BackColor = Color.Aquamarine;
        }

        public void SetUpDateTimePickerFormat()
        {
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        public void FillAbsenceList(Employee employee)
        {
            try
            {
                List<Absence> theAbsences = _controlMyApp.GetTheAbsences(employee);
                bindingSourceAbsences.DataSource = theAbsences;
                dataGridViewAbsence.DataSource = bindingSourceAbsences;
                dataGridViewAbsence.RowHeadersVisible = false;
                dataGridViewAbsence.RowHeadersVisible = false;
                dataGridViewAbsence.Columns["Employee"].Visible = false;
                dataGridViewAbsence.Columns["FirstDay"].HeaderText = "First day";
                dataGridViewAbsence.Columns["LastDay"].HeaderText = "Last day";
                dataGridViewAbsence.Columns["IdReason"].Visible = false;
                dataGridViewAbsence.Columns["Hour"].Visible = false;
                dataGridViewAbsence.Columns["Minute"].Visible = false;
                dataGridViewAbsence.Columns["Second"].Visible = false;
                dataGridViewAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void FillComboBoxReason()
        {
            List<Reason> theReasons = _controlMyApp.GetTheReasons();
            bindingSourceReasons.DataSource = theReasons;
            comboBoxReason.DataSource = bindingSourceReasons;
            if (comboBoxReason.Items.Count > 0)
            {
                comboBoxReason.SelectedIndex = 0;
            }
        }

        private void LockDataGridViewAndAllowModifications()
        {
            grpBoxAbsence.Enabled = false;
            grpBoxAbsenceData.Enabled = true;
        }

        private void UnlockDataGridViewAndBlockModifications()
        {
            grpBoxAbsence.Enabled = true;
            grpBoxAbsenceData.Enabled = false;
        }

        public void AddNameToLabel(Employee employee)
        {
            lblPersonConcerned.Text = employee.FamilyName + " " + employee.FirstName;
        }

        public void ResetAbsenceSelection()
        {
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
            comboBoxReason.SelectedIndex = 0;
        }

        private void UpdateDataGridViewAbsences()
        {
            List<Absence> theNewAbsences = _controlMyApp.GetTheAbsences(_employee);
            bindingSourceAbsences.DataSource = theNewAbsences;
            dataGridViewAbsence.DataSource = bindingSourceAbsences;
        }

        private bool FirstDayPredateLastDate(DateTime firstDay, DateTime lastDay)
        {
            return _controlMyApp.FirstDayPredateLastDate(firstDay, lastDay);
        }

        private bool FirstDayWasNeverPicked(DateTime firstDay)
        {
            return _controlMyApp.FirstDayWasNeverPicked(firstDay, dataGridViewAbsence);
        }


        private void AddAbsence(Employee employee,
                           DateTime firstDay,
                           DateTime lastDay,
                           int idReason
                           )
        {
            _controlMyApp.AddAbsence(employee, firstDay, lastDay, idReason);
        }

        public void UpdateAbsence(Employee employee,
                                  DateTime previousDaySelected,
                                  DateTime firstDay,
                                  DateTime lastDay,
                                  int idReason
                                  
                           )
        {
            _controlMyApp.UpdateAbsence(employee, 
                                        previousDaySelected, 
                                        firstDay, 
                                        lastDay, 
                                        idReason
                                        );
        }

        private void SetAbsenceData()
        {
            Absence absence = (Absence)dataGridViewAbsence.CurrentRow.DataBoundItem;
            dateTimePickerStart.Value = new DateTime(absence.FirstDay.Year,
                                                     absence.FirstDay.Month,
                                                     absence.FirstDay.Day,
                                                     absence.FirstDay.Hour,
                                                     absence.FirstDay.Minute,
                                                     0
                                                    );
            dateTimePickerEnd.Value = new DateTime(absence.LastDay.Year,
                                                   absence.LastDay.Month,
                                                   absence.LastDay.Day,
                                                   absence.LastDay.Hour,
                                                   absence.LastDay.Minute,
                                                   0
                                                   );
            comboBoxReason.SelectedIndex = absence.IdReason - 1;
        }

        private void EmptyAbsenceSelection()
        {
            dateTimePickerStart.Value = DateTime.Today;
            dateTimePickerEnd.Value = DateTime.Today;
            comboBoxReason.SelectedIndex = 0;
        }

        private void ResetOriginalColor()
        {
            foreach (Object sender in senderList)
            {
                Button button = (Button)sender;
                button.BackColor = Color.Aquamarine;
            }
        }

        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {
            BtnAddAbsence.BackColor = Color.Green;
            senderList.Add(sender);
            myOptionSelected = sender;
            LockDataGridViewAndAllowModifications();
            dateTimePickerStart.Focus();
        }

        private void BtnModifyAbsence_Click(object sender, EventArgs e)
        {
            senderList.Add(sender);
            if(dataGridViewAbsence.SelectedRows.Count == 1)
            {
                BtnModifyAbsence.BackColor = Color.Green;
                LockDataGridViewAndAllowModifications();
                SetAbsenceData();
                myOptionSelected = sender;
                previousDaySelected = (DateTime)dateTimePickerStart.Value;
                dateTimePickerStart.Focus();
            }
            else if(dataGridViewAbsence.SelectedRows.Count > 1)
            {
                BtnModifyAbsence.BackColor = Color.Orange;
                MessageBox.Show("Only one absence should be selected.", "Information");
                BtnModifyAbsence.BackColor = Color.Aquamarine;
            }
        }

        private void BtnRemoveAbsence_Click(object sender, EventArgs e)
        {
            senderList.Add(sender);
            if (dataGridViewAbsence.SelectedRows.Count == 1)
            {
                Absence absence = dataGridViewAbsence.SelectedRows[0].DataBoundItem as Absence;
                if (MessageBox.Show("Do you really want to delete the line " + _employee.FamilyName + " " + _employee.FirstName + " ?", "Confirmation before removing the line", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _controlMyApp.RemoveAbsenceFromEmployee(absence, _employee);
                    FillAbsenceList(_employee);
                    ResetOriginalColor();
                }
            }
            else if(dataGridViewAbsence.SelectedRows.Count > 1) 
            {
                BtnRemoveAbsence.BackColor = Color.Orange;
                MessageBox.Show("Only one absence should be selected.", "Information");
                BtnRemoveAbsence.BackColor = Color.Aquamarine;
            }
        }

        private void BtnSaveAbsence_Click(object sender, EventArgs e)
        {
            senderList.Add(sender);
            if (FirstDayPredateLastDate(dateTimePickerStart.Value, dateTimePickerEnd.Value))
            {
                Button btn = (Button)myOptionSelected;
                switch (btn.Text)
                {
                    case "Add":
                        DateTime dateToBeConfirmed = new DateTime(
                                                          dateTimePickerStart.Value.Year,
                                                          dateTimePickerStart.Value.Month,
                                                          dateTimePickerStart.Value.Day,
                                                          dateTimePickerStart.Value.Hour,
                                                          dateTimePickerStart.Value.Minute,
                                                          0
                                                          );               


                        if (FirstDayWasNeverPicked(dateToBeConfirmed))
                        {
                                AddAbsence(_employee,
                                       dateTimePickerStart.Value,
                                       dateTimePickerEnd.Value,
                                       comboBoxReason.SelectedIndex + 1
                                      );
                          
                        }
                        else
                        {
                            MessageBox.Show("There is already an absence at this date", "Information");
                        }
                        break;
                    case "Modify":
                        DateTime firstDay = (DateTime)dateTimePickerStart.Value;
                        DateTime lastDay = (DateTime)dateTimePickerEnd.Value;
                        UpdateAbsence(_employee,
                                       previousDaySelected,
                                       firstDay,
                                       lastDay,
                                       comboBoxReason.SelectedIndex + 1);

                        break;
                    default:
                        break;
                }

                UnlockDataGridViewAndBlockModifications();
                UpdateDataGridViewAbsences();
                ResetAbsenceSelection();
            }
            else
            {
                MessageBox.Show("The second date should end after the first date", "Information");
            }
            ResetOriginalColor();
        }

        private void BtnCancelAbsence_Click(object sender, EventArgs e)
        {
            senderList.Add(sender);
            BtnCancelAbsence.BackColor = Color.Green;
            if (MessageBox.Show("Do you really want to cancel ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmptyAbsenceSelection();
                UnlockDataGridViewAndBlockModifications();
                ResetOriginalColor();
            }
        }
    }
}
