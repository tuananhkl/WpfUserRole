using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using WpfUser.Data;
using WpfUser.ViewModels;

namespace WpfUser.Views
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        private readonly AppDbContext _dbContext = new AppDbContext();
        public static DataGrid dataGrid;

        public UserView()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            var users = _dbContext.Users
                .Include(u => u.UserRole)
                .ThenInclude(ur => ur.Role)
                .ToList();

            var usersDto = new List<UserViewModel>();

            foreach (var user in users)
            {
                var userDto = new UserViewModel
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    DateOfBirth = user.DateOfBirth,
                    Address = user.Address,
                    Email = user.Email,
                    Age = user.Age,
                    Gender = user.Gender,
                };

                userDto.Status = user.Status ? "Active" : "Disable";

                userDto.Role = user.UserRole.Role.Name;

                usersDto.Add(userDto);
            }


            MyDataGrid.ItemsSource = usersDto;

            dataGrid = MyDataGrid;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            UserInsertWindow userInsertWindow = new UserInsertWindow();
            userInsertWindow.Show();
        }
    }
}
