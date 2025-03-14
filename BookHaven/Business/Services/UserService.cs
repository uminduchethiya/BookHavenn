using BookHaven.Business.Interfaces;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace BookHaven.Business.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserManageRepository _userRepo;

        public UserService(IUserManageRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public void AddUser(UserModel user)
        {
            user.RegistrationNumber = GenerateRegistrationNumber();
            string generatedPassword = GeneratePassword();
            user.Password = HashPassword(generatedPassword);
            user.IsDeleted = false;
            user.CreatedAt = DateTime.Now;

            _userRepo.AddUser(user);

            // Send email with generated password
            SendEmail(user.Email, generatedPassword);
        }

        public List<KeyValuePair<int, string>> GetUserRoles()
        {
            return _userRepo.GetUserRoles();
        }

        private string GenerateRegistrationNumber()
        {
            return "REG" + DateTime.Now.Ticks.ToString().Substring(10);
        }

        private string GeneratePassword()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SendEmail(string recipientEmail, string generatedPassword)
        {
            try
            {
                string senderEmail = "uminduchethiya@gmail.com"; // Change to your email
                string senderPassword = "bcgjguscujhvknor"; // Change to your email password
                string smtpServer = "smtp.gmail.com"; // Change to your SMTP server
                int smtpPort = 587; // Change to the correct SMTP port

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Your BookHaven Account Password";
                    mail.Body = $"Dear User,\n\nYour account has been created successfully.\nYour login password is: {generatedPassword}\n\nPlease change your password after logging in.\n\nBest Regards,\nBookHaven Team";
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }

        public List<UserModel> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }
        public void UpdateUser(UserModel user)
        {
            _userRepo.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            try
            {
                // Assuming the repository handles the actual database operation
                _userRepo.DeleteUser(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting user: {ex.Message}");
            }
        }

    }
}
