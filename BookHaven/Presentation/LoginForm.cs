using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories;
using BookHaven.Presentation.Admin;
using BookHaven.Presentation.Staff;
using BookHaven.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(new UserRepository());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            IAuthService authService = new AuthService(new UserRepository());
            string email = txtemail.Text.Trim();
            string password = txtpassword.Text.Trim();

            UserModel authenticatedUser = authService.AuthenticateUser(email, password);

            if (authenticatedUser != null)
            {
                if (authenticatedUser.IsDeleted)
                {
                    MessageBox.Show("Your account is deactivated!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Store user in session
                SessionManager.LoggedInUser = authenticatedUser;

                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Email format validation method
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
