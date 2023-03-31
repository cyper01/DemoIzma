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
using System.Windows.Shapes;

namespace Demoizam
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();


        }
    }
    public class Autorization : Window3
    {
        public Autorization() { }
    }
    ///    private User _user;
    ///private string _login;
    ///private string _password;

    ///public string Login
    ///{
       /// get => _login;

       // set
       // {
         ///   _login = value;
            ///OnPropertyChanged(nameof(Login));
        //}//
  //  }
    ///public string Password
    //{
      ///  get => _password;

 ///       set
    ///    {
       ///     _password = value;
          ///  OnPropertyChanged(nameof(Password));
      //  }
  //  }

  //  public async Task<bool> Authorization(string login, string password)
   // {
    //    try
     ///   {
      //      var result = await DbStorage.Db.User.FirstOrDefaultAsync(user => user.Login == login && user.Password == password);
       //     _user = result;
       //     if (result != null)
         //   {
         //       return true;
          //  }
          ///  return false;
       /// }
      ///  catch (Exception exception)
      //  {
      ///      MessageBox.Show(exception.Message, "Исключения!", MessageBoxButton.OK, MessageBoxImage.Stop);
         ///   return false;
       /// }
 ///   }
////public async void AuthorInApp()
    //{

      ///  if (await Authorization(Login, Password))
      ///  {
         ///   foreach (var item in App.Current.Windows)
         ///   {
           ///     if (item is WindowTableProduct)
           //     {
               ///     (item as Window)?.Hide();
             ///   }
         ///   }
         ///   return;
     //   }
      ////  MessageBox.Show("Неверный логин или пароль", "Авторизация!", MessageBoxButton.OK, MessageBoxImage.Error)///;///
   // }
    ///

}