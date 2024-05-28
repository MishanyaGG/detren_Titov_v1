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

namespace WoldProject
{
    /// <summary>
    /// Логика взаимодействия для AddUsersPage.xaml
    /// </summary>
    public partial class AddUsersPage : Page
    {
        private Users _currentUsers = new Users();
        public AddUsersPage(Users selectedUser)
        {
            InitializeComponent();

            if (selectedUser != null)
                _currentUsers = selectedUser;

            DataContext = _currentUsers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errros = new StringBuilder();

            if (string.IsNullOrEmpty(_currentUsers.first_name))
                errros.AppendLine("Укажите Имя");
            if (string.IsNullOrEmpty(_currentUsers.last_name))
                errros.AppendLine("Укажите Фамилию");
            if (string.IsNullOrEmpty(_currentUsers.patronimyc))
                errros.AppendLine("Укажите Отчество");
            if (string.IsNullOrEmpty(_currentUsers.login))
                errros.AppendLine("Укажите Логин");
            if (string.IsNullOrEmpty(_currentUsers.passwod))
                errros.AppendLine("Укажите Пароль");
            if (string.IsNullOrEmpty(_currentUsers.role))
                errros.AppendLine("Укажите Роль");
            if (string.IsNullOrEmpty(_currentUsers.status))
                errros.AppendLine("Укажите Статус");

            if(errros.Length > 0)
            {
                MessageBox.Show(errros.ToString());
                return;
            }

            if (_currentUsers.id == 0)
                de41_TItov_v2Entities.GetContext().Users.Add(_currentUsers);
            try
            {
                de41_TItov_v2Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();

            } catch(Exception ex) 
            { 
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
