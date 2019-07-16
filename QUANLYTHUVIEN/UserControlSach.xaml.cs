using QUANLYTHUVIEN.Views;
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

namespace QUANLYTHUVIEN
{
    /// <summary>
    /// Interaction logic for UserControlSach.xaml
    /// </summary>
    public partial class UserControlSach : UserControl
    {
        public UserControlSach()
        {
            InitializeComponent();
        }

        private void btThemSach_Click(object sender, RoutedEventArgs e)
        {
            SachMoiView s = new SachMoiView();
            s.ShowDialog();
        }
    }
}
