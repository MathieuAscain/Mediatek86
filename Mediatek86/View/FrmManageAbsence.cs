using System;
using System.Collections.Generic;
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
        private Employee _employee;
        private object mySender;
        private readonly BindingSource bindingSourceReasons = new BindingSource();
        private readonly BindingSource bindingSourceAbsences = new BindingSource();

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
            UnlockDataGridViewAndBlockModifications();
            FillAbsenceList(employee);
            FillComboBoxReason();
            AddNameToLabel(employee);
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

        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {

            LockDataGridViewAndAllowModifications();
            mySender = sender;
            dateTimePickerStart.Focus();

        }

        private void BtnModifyAbsence_Click(object sender, EventArgs e)
        {
            LockDataGridViewAndAllowModifications();
            SetAbsenceData();
            mySender = sender;
            dateTimePickerStart.Focus();
        }

        private void SetAbsenceData()
        {
            Absence absence = (Absence)dataGridViewAbsence.CurrentRow.DataBoundItem;
            dateTimePickerStart.Value = new DateTime(absence.FirstDay.Year,
                                                     absence.FirstDay.Month,
                                                     absence.FirstDay.Day);
            dateTimePickerEnd.Value = new DateTime(absence.LastDay.Year,
                                                     absence.LastDay.Month,
                                                     absence.LastDay.Day);
            comboBoxReason.SelectedIndex = absence.IdReason - 1;
        }

        private void BtnRemoveAbsence_Click(object sender, EventArgs e)
        {
            if (dataGridViewAbsence.SelectedRows.Count == 1)
            {
                Absence absence = dataGridViewAbsence.SelectedRows[0].DataBoundItem as Absence;
                if (MessageBox.Show("Do you really want to delete the line " + _employee.FamilyName + " " + _employee.FirstName + " ?", "Confirmation before removing the line", MessageBoxButtons.YesNo) == DialogResult.Yes) { }
                {
                    _controlMyApp.RemoveAbsenceFromEmployee(absence, _employee);
                    FillAbsenceList(_employee);
                }
            }
            else
            {
                MessageBox.Show("A lign should be selected.", "Information");
            }
        }

        private void BtnSaveAbsence_Click(object sender, EventArgs e)
        {
            if (FirstDayPredateLastDate(dateTimePickerStart.Value, dateTimePickerEnd.Value))
            {
                Button btn = (Button)mySender;
                switch (btn.Text)
                {
                    case "Add":
                        if (FirstDayWasNeverPicked(dateTimePickerStart.Value))
                        {
                            Console.WriteLine(comboBoxReason.SelectedIndex);
                            AddAbsence(_employee,
                                       dateTimePickerStart.Value,
                                       dateTimePickerEnd.Value,
                                       comboBoxReason.SelectedIndex + 1);
                        }
                        else
                        {
                            MessageBox.Show("There is already an absence at this date", "Information");
                        }
                        break;
                    case "Modify":
                        Console.WriteLine("combo box " + (comboBoxReason.SelectedIndex + 1));
                        UpdateAbsence(_employee,
                                       dateTimePickerStart.Value,
                                       dateTimePickerEnd.Value,
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
                           DateTime firstDay,
                           DateTime lastDay,
                           int idReason
                           )
        {
            _controlMyApp.UpdateAbsence(employee, firstDay, lastDay, idReason);
        }
    }
}
