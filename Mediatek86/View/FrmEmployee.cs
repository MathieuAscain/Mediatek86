using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Mediatek86.Control;
using Mediatek86.Model;
using System.ComponentModel;

namespace Mediatek86.View
{
    /// <summary>
    /// Form for the 
    /// </summary>
    public partial class FrmEmployee : Form
    {
        private readonly ControlMyApp controlMyApp;

        private bool modificationOngoing;
        readonly BindingSource bindingSourceEmployees = new BindingSource();
        readonly BindingSource bindingSourceDepartments = new BindingSource();

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
            dataGridViewEmployee.Columns["idEmployee"].Visible = false;
            dataGridViewEmployee.Columns["idDepartment"].Visible = false;
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

        /// <summary>
        /// Clear the fields of the textBoxes
        /// and reposition the comboBox to the first element of the list
        /// </summary>
        private void EmptyEmployeeSelection()
        {
            textBoxFamilyName.Text = "";
            textBoxFirstName.Text = "";
            textBoxPhone.Text = "";
            textBoxMail.Text = "";
            comboBoxDepartment.SelectedIndex = 0;
        }

        /// <summary>
        /// Modify the fields of the employee selected in the dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifyEmployee_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                modificationOngoing = true;
                grpBoxEmployee.Enabled = false;
                lblShowButtonClicked.Text = "Modify Employee data";
                Employee selectedEmployee = dataGridViewEmployee.SelectedRows[0].DataBoundItem as Employee;
                textBoxFamilyName.Text = selectedEmployee.FamilyName;
                textBoxFirstName.Text = selectedEmployee.FirstName;
                textBoxPhone.Text = selectedEmployee.Phone;
                textBoxMail.Text = selectedEmployee.Mail;
                comboBoxDepartment.SelectedIndex = comboBoxDepartment.FindStringExact(selectedEmployee.DepartmentName);
            }
            else
            {
                MessageBox.Show("A line should be selected.", "Information");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelEmployee_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Do you really want to cancel ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmptyEmployeeSelection();
                grpBoxEmployee.Enabled = true;
                modificationOngoing = false;
                lblShowButtonClicked.Text = "Add an employee";
            }
        }

 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddEmployee_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFamilyName.Text) || 
                String.IsNullOrEmpty(textBoxFirstName.Text) || 
                String.IsNullOrEmpty(textBoxPhone.Text) || 
                String.IsNullOrEmpty(textBoxMail.Text))
            {
                MessageBox.Show("All the fields shall be filled", "Information");
            }
            else
            {
                Int32 idEmployee = dataGridViewEmployee.Rows.Count - 1;
            
                bindingSourceEmployees.Add(new Employee(idEmployee,
                                                 textBoxFamilyName.Text,
                                                 textBoxFirstName.Text,
                                                 textBoxPhone.Text,
                                                 textBoxMail.Text,
                                                 comboBoxDepartment.SelectedIndex,
                                                 comboBoxDepartment.Text
                                                 ));
            }
        }

        private void BtnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                Employee employee = dataGridViewEmployee.SelectedRows[0].DataBoundItem as Employee;
                //Employee employee = (Employee)bindingSourceEmployees.List[bindingSourceEmployees.Position];
                if (MessageBox.Show("Do you really want to delete the line " + employee.FamilyName + " " + employee.FirstName + " ?", "Confirmation before removing the line", MessageBoxButtons.YesNo) == DialogResult.Yes) { }
                {
                    controlMyApp.RemoveEmployee(employee);
                    FillEmployeesList();
                }
            }
            else
            {
                MessageBox.Show("A lign should be selected.", "Information");
            }
        }

        private void BtnSaveEmployee_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFamilyName.Text) ||
                String.IsNullOrEmpty(textBoxFirstName.Text) ||
                String.IsNullOrEmpty(textBoxPhone.Text) ||
                String.IsNullOrEmpty(textBoxMail.Text))
            {
                MessageBox.Show("All the informations shall be filled", "Information");
            }
            else
            
            {

                //Department department = dataGridViewDepartment.SelectedRows[0].DataBoundItem as Department;

                //Department department = (Department)bindingSourceEmployees.List[bindingSourceDepartments.Position];
                int idEmployee = 0;
                if (modificationOngoing)
                {
                    idEmployee = (int)dataGridViewEmployee.SelectedRows[0].Cells["idEmployee"].Value;
                }
                Employee employee = new Employee(idEmployee,
                                                 textBoxFamilyName.Text,
                                                 textBoxFirstName.Text,
                                                 textBoxPhone.Text,
                                                 textBoxMail.Text,
                                                 comboBoxDepartment.SelectedIndex,
                                                 comboBoxDepartment.Text);

                if (modificationOngoing)
                {
                    controlMyApp.UpdateEmployee(employee);
                    modificationOngoing = false;
                    grpBoxEmployee.Enabled = true;
                    lblShowButtonClicked.Text = "Add an employee";
                }
                else
                {
                    controlMyApp.AddModifiedEmployee(employee);
                }
                FillEmployeesList();
                EmptyEmployeeSelection();
            }
        }
    }
}




