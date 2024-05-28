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
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            DGridUsers.ItemsSource = de41_TItov_v2Entities.GetContext().Users.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddUsersPage((sender as Button).DataContext as Users));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddUsersPage(null));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var usersForRemoving = DGridUsers.SelectedItems.Cast<Users>().ToList();

            if(MessageBox.Show($"Вы уверены удалить данные строки? {usersForRemoving.Count()} - количесство на удаление","Внимание",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    de41_TItov_v2Entities.GetContext().Users.RemoveRange(usersForRemoving);
                    de41_TItov_v2Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    DGridUsers.ItemsSource = de41_TItov_v2Entities.GetContext().Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                de41_TItov_v2Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(entry =>  entry.Reload());
                DGridUsers.ItemsSource = de41_TItov_v2Entities.GetContext().Users.ToList();
            }
        }
    }
}
