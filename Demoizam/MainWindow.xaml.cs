using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Windows.Media;

namespace Demoizam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object pswBox;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Window1();
        }

        private void OpenAutoriz_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as Window1).Password = pswBox;//Password.ToString();
            (DataContext as Window1).AuthorInApp();
        }

        private void GoustAutoriz_Click(object sender, RoutedEventArgs e)
        {
            Window2 goustWindow = new Window2();
            goustWindow.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        

    }
}