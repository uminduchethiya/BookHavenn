using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation.Admin
{
    public partial class AddnewUser : Form
    {
        private readonly IUserService _userService;
        public AddnewUser()
        {
            InitializeComponent();
            _userService = new UserService(new UserManageRepository()); // Fixed Repository Reference
            LoadUserRoles();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadUserRoles()
        {
            List<KeyValuePair<int, string>> roles = _userService.GetUserRoles();
            cmbuserrole.DataSource = new BindingSource(roles, null);
            cmbuserrole.DisplayMember = "Value";
            cmbuserrole.ValueMember = "Key";
        }



        private void btnadd_Click_1(object sender, EventArgs e)
        {
            UserModel newUser = new UserModel
            {
                FirstName = txtfirstname.Text,
                LastName = txtname.Text,
                Email = txtemail.Text,
                Address = txtaddress.Text,
                Phone = txtphone.Text,
                RoleID = (int)cmbuserrole.SelectedValue,
                Idnumber = txtidnum.Text,
                Gender = cmbgender.SelectedItem?.ToString(),
                Dob = dobpicker.Value
            };

            _userService.AddUser(newUser);
            MessageBox.Show("User added successfully!");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfirstname.Text = string.Empty;
            txtname.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtidnum.Text = string.Empty;
            cmbuserrole.SelectedIndex = -1;
            cmbgender.SelectedIndex = -1;
            dobpicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement(_userService); // Pass _userService
            this.Hide();  // Optionally hide the current form
            userManagementForm.Show(); // Opens the form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();  // To show the AdminDashboard form
            this.Hide();  // Optionally hide the current form
        }
    }

}
