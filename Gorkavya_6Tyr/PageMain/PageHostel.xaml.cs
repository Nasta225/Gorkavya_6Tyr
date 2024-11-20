using Gorkavya_6Tyr.ApplicationData;
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

namespace Gorkavya_6Tyr.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageHostel.xaml
    /// </summary>
    public partial class PageHostel : Page
    {
        public PageHostel()
        {
            InitializeComponent();
            DtGrid.ItemsSource = TyrEntities.GetContext().Tour.ToList();
        }

        private void ButDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButDobavit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
