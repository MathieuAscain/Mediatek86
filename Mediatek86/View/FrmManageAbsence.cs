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
        private readonly Employee employee;
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
      
        }

       
        public void Init(Employee employee)
        {
            FillAbsenceList(employee);
            FillComboBoxReason();
            AddNameToLabel(employee);
        }

        public void FillAbsenceList(Employee employee)
        {
            try
            {
                Console.WriteLine(employee.FirstName);
                List<Absence> theAbsences = _controlMyApp.GetTheAbsences(employee);
                bindingSourceAbsences.DataSource = theAbsences;
                dataGridViewAbsence.DataSource = bindingSourceAbsences;
                dataGridViewAbsence.RowHeadersVisible = false;
                dataGridViewAbsence.RowHeadersVisible = false;
                dataGridViewAbsence.Columns["Employee"].Visible = false;
                dataGridViewAbsence.Columns["FirstDay"].HeaderText = "First day";
                dataGridViewAbsence.Columns["LastDay"].HeaderText = "Last day";
                dataGridViewAbsence.Columns["IdReason"].Visible = false;
                //dataGridViewAbsence.Columns["IdReason"].HeaderText = "id Reason";
                //dataGridViewAbsence.Columns["DepartmentName"].HeaderText = "Department";
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

        private bool DateAreDifferent()
        {
            if(dateTimePickerEnd.Value.Date > dateTimePickerStart.Value.Date)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        private bool DateNotPreviouslySelected()
        {


            return true;
        }

        public void AddNameToLabel(Employee employee)
        {
            lblPersonConcerned.Text = employee.FamilyName + " " + employee.FirstName;
        }

        private void BtnAddAbsence_Click(object sender, EventArgs e)
        {
            if (DateAreDifferent() && DateNotPreviouslySelected())
            {
        
                bindingSourceAbsences.Add(new Absence(employee,
                                                 dateTimePickerStart.Value.Date,
                                                 dateTimePickerEnd.Value.Date,
                                                 comboBoxReason.SelectedIndex,
                                                 comboBoxReason.SelectedItem.ToString()
                                                 ));
            }
            else
            {
                MessageBox.Show("The second date should be after the first one", "Information");
            }
        }

        private void BtnModifyAbsence_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveAbsence_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAbsence_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAbsence_Click(object sender, EventArgs e)
        {

        }
    }
}
