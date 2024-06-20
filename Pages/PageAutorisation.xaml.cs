using SportStore.Data;
using SportStore.Services;
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

namespace SportStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAutorisation.xaml
    /// </summary>
    public partial class PageAutorisation : Page
    {
        SportShopEntities1 db = new SportShopEntities1();
        ManageStructur userI = new ManageStructur();
        public PageAutorisation()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnInputUser_Click(object sender, RoutedEventArgs e)
        {
            var User = db.Users.FirstOrDefault(x => x.Password
            == PassTBox.Password && x.Login == LoginTBox.Text);
            if(String.IsNullOrEmpty(PassTBox.Password) || String.IsNullOrEmpty(LoginTBox.Text))
            {
                MessageBox.Show("Введите даннные");             
            }            
            else if (User == null) 
            {
                MessageBox.Show("Неправильно введен логин или пароль");
            }
            else
            {
                string Passing = userI.FullNamePassing = User.FullName;
                switch (User.Role)
                {
                    case "Администратор":
                        PageAdmin pageAdmin = new PageAdmin(Passing);
                        NavigationService.Navigate(pageAdmin);
                        break;
                    case "Менеджер":
                        PageManager pageManager = new PageManager(Passing);
                        NavigationService.Navigate(pageManager);
                        break;
                    case "Клиент":
                        PageСlient pageClient = new PageСlient(Passing);
                        NavigationService.Navigate(pageClient);
                        break;
                }
            }           
        }
        private void BtnCheckProduct_Click(object sender, RoutedEventArgs e)
        {
            PageGuest pageGuest = new PageGuest();
            NavigationService.Navigate(pageGuest);
        }
    }
}
