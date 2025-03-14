using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookHaven.Presentation.Admin
{
    public partial class UserManagement : Form
    {
        private readonly IUserService _userService;
        public UserManagement(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
            LoadUsers();
        }



        private void LoadUsers()
        {
            try
            {
                // Fetch users from the service

                var users = _userService.GetAllUsers().Where(u => u.IsDeleted == false).ToList();
                // Bind the data to the DataGridView
                datagridviewuser.DataSource = users;

                // Hide specific columns
                datagridviewuser.Columns["RegistrationNumber"].Visible = false;
                datagridviewuser.Columns["Email"].Visible = false;
                datagridviewuser.Columns["Password"].Visible = false;
                datagridviewuser.Columns["RoleID"].Visible = false;
                datagridviewuser.Columns["IsDeleted"].Visible = false;
                datagridviewuser.Columns["CreatedAt"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching users: " + ex.Message);
            }
        }


        private void datagridviewuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row clicked is valid and it's not the header row (RowIndex >= 0)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = datagridviewuser.Rows[e.RowIndex];

                // Populate text fields from the selected row
                txtfirstname.Text = selectedRow.Cells["FirstName"].Value?.ToString() ?? string.Empty;
                txtlastname.Text = selectedRow.Cells["LastName"].Value?.ToString() ?? string.Empty;
                txtphone.Text = selectedRow.Cells["Phone"].Value?.ToString() ?? string.Empty;
                txtidnum.Text = selectedRow.Cells["Idnumber"].Value?.ToString() ?? string.Empty;
                txtaddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? string.Empty;

                // Set the gender combo box selection
                string gender = selectedRow.Cells["Gender"].Value?.ToString();
                if (gender != null && cmbgender.Items.Contains(gender))
                {
                    cmbgender.SelectedItem = gender;
                }

                // Handle potential null or invalid date for Date of Birth (Dob)
                DateTime dob;
                if (DateTime.TryParse(selectedRow.Cells["Dob"].Value?.ToString(), out dob))
                {
                    dobpicker.Value = dob;
                }
                else
                {
                    // Set to a default date if invalid
                    dobpicker.Value = DateTime.Now;
                }
            }
        }


        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                // Ensure a user is selected
                if (datagridviewuser.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = datagridviewuser.SelectedRows[0];

                    // Retrieve user ID
                    int userId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    // Create an updated user object
                    UserModel updatedUser = new UserModel
                    {
                        Id = userId,
                        FirstName = txtfirstname.Text,
                        LastName = txtlastname.Text,
                        Phone = txtphone.Text,
                        Address = txtaddress.Text,
                        Idnumber = txtidnum.Text,
                        Gender = cmbgender.SelectedItem.ToString(),
                        Dob = dobpicker.Value
                    };

                    // Call the service to update user details
                    _userService.UpdateUser(updatedUser);

                    // Refresh the DataGridView
                    LoadUsers();

                    MessageBox.Show("User updated successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a user to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddnewUser addNewUsersForm = new AddnewUser();
            addNewUsersForm.Show();  // To show the new form
            this.Hide();  // Optionally hide the current form
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the user has selected a row
                if (datagridviewuser.SelectedRows.Count > 0)
                {
                    // Get the selected user ID (assuming the first column is the ID)
                    int selectedUserId = Convert.ToInt32(datagridviewuser.SelectedRows[0].Cells["Id"].Value);

                    // Confirm deletion with the user
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Call the service method to mark the user as deleted (soft delete)
                        _userService.DeleteUser(selectedUserId);

                        // Refresh the DataGridView to reflect the changes
                        LoadUsers();
                        MessageBox.Show("User marked as deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message);
            }

        }

        private void backpic_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }
}
