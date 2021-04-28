using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mediatek86.Control;
using Mediatek86.Model;

namespace Mediatek86.View
{
    /// <summary>
    /// Form for the 
    /// </summary>
    public partial class FrmEmployee : Form
    {
        private readonly ControlMyApp controlMyApp;
        private readonly BindingSource bindingSourceEmployees = new BindingSource();
        private readonly BindingSource bindingSourceDepartments = new BindingSource();
        private object mySender;


        /// <summary>
        /// Initialization of the graphic interface
        /// Recovery of the controler
        /// </summary>
        /// <param name="controlMyApp">controler of the connexion</param>
        public FrmEmployee(ControlMyApp controlMyApp)
        {
            InitializeComponent();
            this.controlMyApp = controlMyApp;
            Init();
        }

        /// <summary>
        /// Initialization of the Employee frame : fill of the list and the comboBox
        /// </summary>
        public void Init()
        {
            grpBoxEmployeeData.Enabled = false;
            FillEmployeesList();
            FillDepartmentsList();
            
        }

        /// <summary>
        /// Fill the list of employees
        /// </summary>
        public void FillEmployeesList()
        {
            List<Employee> theEmployees = controlMyApp.GetTheEmployees();
            bindingSourceEmployees.DataSource = theEmployees;
            dataGridViewEmployee.DataSource = bindingSourceEmployees;
            dataGridViewEmployee.RowHeadersVisible = false;
            dataGridViewEmployee.Columns["IdEmployee"].Visible = false;
            dataGridViewEmployee.Columns["IdDepartment"].Visible = false;
            dataGridViewEmployee.Columns["FamilyName"].HeaderText = "Family name";
            dataGridViewEmployee.Columns["FirstName"].HeaderText = "First name";
            dataGridViewEmployee.Columns["DepartmentName"].HeaderText = "Department";
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// 
        /// </summary>
        public void FillDepartmentsList()
        {
            List<Department> theDepartments = controlMyApp.GetTheDepartments();
            bindingSourceDepartments.DataSource = theDepartments;
            comboBoxDepartment.DataSource = bindingSourceDepartments;
            if (comboBoxDepartment.Items.Count > 0)
            {
                comboBoxDepartment.SelectedIndex = 0;
            }
        }

        private void EmptyEmployeeSelection()
        {
            textBoxFamilyName.Text = "";
            textBoxFirstName.Text = "";
            textBoxPhone.Text = "";
            textBoxMail.Text = "";
            comboBoxDepartment.SelectedIndex = 0;
        }

        private bool TextBoxesAreNullOrEmpty()
        {
            if(String.IsNullOrEmpty(textBoxFamilyName.Text) ||
                String.IsNullOrEmpty(textBoxFirstName.Text) ||
                String.IsNullOrEmpty(textBoxPhone.Text) ||
                String.IsNullOrEmpty(textBoxMail.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LockDataGridViewAndAllowModifications()
        {
            grpBoxEmployeeData.Enabled = true;
            grpBoxEmployee.Enabled = false;
        }

        private void UnlockDataGridViewAndBlockModifications()
        {
            grpBoxEmployeeData.Enabled = false;
            grpBoxEmployee.Enabled = true;
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            LockDataGridViewAndAllowModifications();
            mySender = sender;
            textBoxFamilyName.Focus();
        }

        private void BtnModifyEmployee_Click(object sender, System.EventArgs e)
        {
            LockDataGridViewAndAllowModifications();
            mySender = sender;
            Employee employee = (Employee)dataGridViewEmployee.CurrentRow.DataBoundItem;
            FillTextBoxes(employee);
            textBoxFamilyName.Focus();
        }

        private void FillTextBoxes(Employee employee)
        {
            textBoxFamilyName.Text = employee.FamilyName;
            textBoxFirstName.Text = employee.FirstName;
            textBoxPhone.Text = employee.Phone;
            textBoxMail.Text = employee.Mail;
            comboBoxDepartment.SelectedIndex = comboBoxDepartment.FindStringExact(employee.DepartmentName);
        }
        
        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (TextBoxesAreNullOrEmpty())
            {
                MessageBox.Show("All the fields shall be filled", "Information");
            }
            else
            {
                Button btn = (Button)mySender;
                textBoxFamilyName.Focus();
                
                switch (btn.Text)
                {
                    case "Add":
                        AddEmployee();
                        UnlockDataGridViewAndBlockModifications();
                        EmptyEmployeeSelection();
                        break;
                    case "Modify":
                        UpdateEmployee();
                        UnlockDataGridViewAndBlockModifications();
                        EmptyEmployeeSelection();
                        break;
                    default:
                        break;
                }
            }
        }

        private void AddEmployee()
        {
            int newEmployeeID = ControlMyApp.GetMaxEmployeeID() + 1;
            controlMyApp.AddEmployee(newEmployeeID,
                                     textBoxFamilyName.Text,
                                     textBoxFirstName.Text,
                                     textBoxPhone.Text,
                                     textBoxMail.Text,
                                     comboBoxDepartment.SelectedIndex + 1,
                                     comboBoxDepartment.Text);

            FillEmployeesList();
        }

        private void UpdateEmployee()
        {
            Employee employee = (Employee)dataGridViewEmployee.CurrentRow.DataBoundItem;

            controlMyApp.UpdateEmployee(employee,
                                        textBoxFamilyName.Text,
                                        textBoxFirstName.Text,
                                        textBoxPhone.Text,
                                        textBoxMail.Text,
                                        comboBoxDepartment.SelectedIndex + 1
                                        );
        }

        private void BtnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                Employee employee = dataGridViewEmployee.SelectedRows[0].DataBoundItem as Employee;
                if (MessageBox.Show("Do you really want to delete the line " + employee.FamilyName + " " + employee.FirstName + " ?", "Confirmation before removing the line", MessageBoxButtons.YesNo) == DialogResult.Yes) { }
                {
                    controlMyApp.RemoveEmployeeFromAbsence(employee);
                    controlMyApp.RemoveEmployeeFromEmployee(employee);
                    FillEmployeesList();
                }
            }
            else
            {
                MessageBox.Show("A lign should be selected.", "Information");
            }
        }

        private void BtnCancelEmployee_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmptyEmployeeSelection();
                UnlockDataGridViewAndBlockModifications();
                lblShowButtonClicked.Text = "Adding";
            }
        }

        private void BtnAccessAbsence_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                Employee employee = (Employee)bindingSourceEmployees.List[bindingSourceEmployees.Position];
                controlMyApp.OpenAbsence(employee);
            }
            else
            {
                MessageBox.Show("A line should be selected.", "Information");
            } 
        }    
    }
}




