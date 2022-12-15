using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using WpfUser.Data;

namespace WpfUser
{
    /// <summary>
    /// Interaction logic for UserInsertWindow.xaml
    /// </summary>
    public partial class UserInsertWindow : Window
    {
        private readonly AppDbContext _dbContext = new AppDbContext();
        public UserInsertWindow()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            ValidateTextInput(txtbxUserName.Text, "UserName");
            ValidateTextInput(pwbPassword.Password, "Password");
            ValidateTextInput(txtbxAddress.Text, "Address");
            ValidateTextInput(txtbxEmail.Text, "Email");
            ValidateTextInput(txtbxAge.Text, "Age");

            DateTime? selectedDate = datePicker.SelectedDate;
            ValidateDate(selectedDate!);

            //Insert data to user table
            var user = new User
            {
                UserName = txtbxUserName.Text,
                Password = pwbPassword.Password,
                DateOfBirth = selectedDate!.Value,
                Address = txtbxAddress.Text,
                Email = txtbxEmail.Text,
                Age = Int32.Parse(txtbxAge.Text),
                Gender = cbbGender.Text,
                Status = true
                // UserRole = new UserRole
                // {
                //     RoleId = roleId,
                //     UserId = lastUserId + 1
                // }
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        private void btnInsert_Click1(object sender, RoutedEventArgs e)
        {
            ValidateTextInput(txtbxUserName.Text, "UserName");
            ValidateTextInput(pwbPassword.Password, "Password");
            ValidateTextInput(txtbxAddress.Text, "Address");
            ValidateTextInput(txtbxEmail.Text, "Email");
            ValidateTextInput(txtbxAge.Text, "Age");

            DateTime? selectedDate = datePicker.SelectedDate;
            ValidateDate(selectedDate!);
            var transaction = _dbContext.Database.BeginTransaction();
            var roleId = _dbContext.Roles.FirstOrDefault(r =>
                r.Name.ToLower() == cbbRole.Text.ToLower())!.Id;
            if (roleId == 0)
            {
                MessageBox.Show("Error when get roleId from database");
                return;
            }

            var lastUserId = _dbContext.Users
                .OrderByDescending(u => u.Id)
                .FirstOrDefaultAsync().Id;

            var lastUserRoleId = _dbContext.UserRoles
                .OrderByDescending(ur => ur.Id)
                .FirstOrDefaultAsync().Id;

            var user = new User
            {
                UserName = txtbxUserName.Text,
                Password = pwbPassword.Password,
                DateOfBirth = selectedDate!.Value,
                Address = txtbxAddress.Text,
                Email = txtbxEmail.Text,
                Age = Int32.Parse(txtbxAge.Text),
                Gender = cbbGender.Text,
                Status = true,
                UserRoleId = lastUserRoleId + 1
                // UserRole = new UserRole
                // {
                //     RoleId = roleId,
                //     UserId = lastUserId + 1
                // }
            };

            var userRole = new UserRole
            {
                RoleId = roleId,
                UserId = lastUserId + 1
            };

            _dbContext.UserRoles.Add(userRole);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            transaction.Commit();
            this.Hide();
        }

        private void ValidateTextInput(string text, string name)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show(name + " can't be empty");
                return;
            }
        }

        private void ValidateDate(DateTime? selectedDate)
        {
            selectedDate = datePicker.SelectedDate;
            if (selectedDate is null)
            {
                MessageBox.Show("Date of birth can't be empty");
                return;
            }
        }

        
        private void NumericOnly(Object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextNumeric(e.Text);

        }
        private static bool IsTextNumeric(string str)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("[^0-9]");
            return reg.IsMatch(str);

        }
    }
}
