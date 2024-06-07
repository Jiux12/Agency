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

namespace EstateApp
{
    /// <summary>
    /// Логика взаимодействия для EstateList.xaml
    /// </summary>
    public partial class EstateList : Page
    {
        public EstateList()
        {
            InitializeComponent();
        }

        private void Button_EstateAdd_Click(object sender, RoutedEventArgs e)
        {
            MainNav.Instance.Landing.Content = new EstateAdd();
        }

        private void Button_EstateEdit_Click(object sender, RoutedEventArgs e)
        {
            MainNav.Instance.Landing.Content = new EstateEdit();
        }
    }
}
