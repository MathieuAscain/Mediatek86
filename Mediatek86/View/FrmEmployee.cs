
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Mediatek86.Control;
using Mediatek86.Model;

/// <summary>
/// View in the MVC conception for the Employee Form
/// </summary>
namespace Mediatek86.View
{
    /// <summary>
    /// Windows Form to manage all employees from the company
    /// </summary>
    public partial class FrmEmployee : Form
    {
        private readonly ControlMyApp controlMyApp;
        private readonly BindingSource bindingSourceEmployees = new BindingSource();
        private readonly BindingSource bindingSourceDepartments = new BindingSource();
        private object myOptionSelected;
        private readonly ArrayList senderList = new ArrayList();


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

        private void Init()
        {
            grpBoxEmployeeData.Enabled = false;

            BtnAddEmployee.BackColor = Color.Aquamarine;
            BtnModifyEmployee.BackColor = Color.Aquamarine;
            BtnRemoveEmployee.BackColor = Color.Aquamarine;
            BtnAccessAbsence.BackColor = Color.Aquamarine;
            BtnSaveEmployee.BackColor = Color.Aquamarine;
            BtnCancelEmployee.BackColor = Color.Aquamarine;

            FillEmployeesList();
            FillDepartmentsList();
            lblShowButtonClicked.Text = "Blocked/Use left buttons";
        }

        private void FillEmployeesList()
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

        private void FillDepartmentsList()
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

        private void FillTextBoxes(Employee employee)
        {
            textBoxFamilyName.Text = employee.FamilyName;
            textBoxFirstName.Text = employee.FirstName;
            textBoxPhone.Text = employee.Phone;
            textBoxMail.Text = employee.Mail;
            comboBoxDepartment.SelectedIndex = comboBoxDepartment.FindStringExact(employee.DepartmentName);
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

        private void ResetOriginalColor()
        {
            foreach(Object sender in senderList)
            {
                Button button = (Button)sender;
                button.BackColor = Color.Aquamarine;
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            senderList.Add(sender);
            LockDataGridViewAndAllowModifications();
            lblShowButtonClicked.Text = "Adding";
            BtnAddEmployee.BackColor = Color.Green;
            myOptionSelected = sender;
            textBoxFamilyName.Focus();
        }

        private void BtnModifyEmployee_Click(object sender, System.EventArgs e)
        {
            senderList.Add(sender);
            if (dataGridViewEmployee.SelectedRows.Count == 1)
            {
                BtnModifyEmployee.BackColor = Color.Green;
                LockDataGridViewAndAllowModifications();
                lblShowButtonClicked.Text = "Modification";
                myOptionSelected = sender;
                Employee employee = (Employee)dataGridViewEmployee.CurrentRow.DataBoundItem;
                FillTextBoxes(employee);
                textBoxFamilyName.Focus();
            }
            else if (dataGridViewEmployee.SelectedRows.Count > 1)
            {
                BtnModifyEmployee.BackColor = Color.Orange;
                MessageBox.Show("Only a line should be selected", "Information");
                BtnModifyEmployee.BackColor = Color.Aquamarine;
            }
        }

        private void BtnRemoveEmployee_Click(object sender, EventArgs e)
        {
            senderList.Add(sender);
            if (dataGridViewEmployee.SelectedRows.Count == 1)
            {
                BtnRemoveEmployee.BackColor = Color.Green;
                Employee employee = dataGridViewEmployee.SelectedRows[0].DataBoundItem as Employee;
                if (MessageBox.Show("Do you really want to delete the line " + employee.FamilyName + " " + employee.FirstName + " ?", "Confirmation before removing the line", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controlMyApp.RemoveEmployeeFromAbsence(employee);
                    controlMyApp.RemoveEmployeeFromEmployee(employee);
                    FillEmployeesList();
                }
            }
            else if (dataGridViewEmployee.SelectedRows.Count > 1)
            {
                BtnRemoveEmployee.BackColor = Color.Orange;
                MessageBox.Show("Only a line should be selected.", "Information");
            }
            ResetOriginalColor();
        }
        
        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {
            senderList.Add(sender);
            if (TextBoxesAreNullOrEmpty())
            {
                BtnSaveEmployee.BackColor = Color.Orange;
                MessageBox.Show("All the fields shall be filled", "Information");
            }
            else
            {
               
                Button btn = (Button)myOptionSelected;
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
                        FillEmployeesList();
                        EmptyEmployeeSelection();
                        break;
                    default:
                        break;
                }
            }
            ResetOriginalColor();
        }

        private void BtnCancelEmployee_Click(object sender, System.EventArgs e)
        {
            senderList.Add(sender);
            BtnCancelEmployee.BackColor = Color.Green;
            if (MessageBox.Show("Do you really want to cancel ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmptyEmployeeSelection();
                UnlockDataGridViewAndBlockModifications();
                lblShowButtonClicked.Text = "Pick a left button";
                ResetOriginalColor();
            }
        }

        private void BtnAccessAbsence_Click(object sender, EventArgs e)
        { 
            if (dataGridViewEmployee.SelectedRows.Count == 1)
            {
                Employee employee = (Employee)bindingSourceEmployees.List[bindingSourceEmployees.Position];
                controlMyApp.OpenAbsence(employee);
            }
            else if(dataGridViewEmployee.SelectedRows.Count > 1)
            {
                BtnAccessAbsence.BackColor = Color.Orange;
                MessageBox.Show("Only a line should be selected.", "Information");
                
            }
        }    
    }
}




