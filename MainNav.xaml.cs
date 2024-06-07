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
    /// Логика взаимодействия для MainNav.xaml
    /// </summary>
    public partial class MainNav : Window
    {
        public static MainNav Instance { get; private set; }

        public MainNav()
        {
            InitializeComponent(); 
            Instance = this;
            Landing.Content = new EstateList();
        }

        private void Button_EstateList_Click(object sender, RoutedEventArgs e)
        {
            Landing.Content = new EstateList();
            NavName.Text = "Недвижимость";
        }

        private void Button_DemandList_Click(object sender, RoutedEventArgs e)
        {
            Landing.Content = new DemandList();
            NavName.Text = "Потребность";
        }
    }
}
