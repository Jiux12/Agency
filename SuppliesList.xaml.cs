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

namespace EstateApp
{
    /// <summary>
    /// Логика взаимодействия для SuppliesList.xaml
    /// </summary>
    public partial class SuppliesList : Page
    {
        public SuppliesList()
        {
            InitializeComponent();
        }

        private void Button_SuppliesAdd_Click(object sender, RoutedEventArgs e)
        {
            MainNav.Instance.Landing.Content = new SuppliesAdd();
        }

        private void Button_SuppliesEdit_Click(object sender, RoutedEventArgs e)
        {
            MainNav.Instance.Landing.Content = new SuppliesEdit();
        }
    }
}
