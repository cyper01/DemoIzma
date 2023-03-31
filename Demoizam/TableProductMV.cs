using System;
using System.Windows;

namespace Demoizam
{
    public partial class WindowTableProduct : Window
    {
        public WindowTableProduct()
        {
            InitializeComponent();
            this.DataContext = new TableProductMV();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as TableProductMV).DeleteData();
        }
    }
}