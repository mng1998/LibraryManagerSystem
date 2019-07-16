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

namespace QUANLYTHUVIEN.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : Window
    {
        public MenuView()
        {
            InitializeComponent();
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 0:
                    ActiveItem.Children.Clear();
                    break;
                case 1:
                    ActiveItem.Children.Clear();
                    ActiveItem.Children.Add(new UserControlNguoiDung());
                    break;
                case 2:
                    ActiveItem.Children.Clear();
                    ActiveItem.Children.Add(new UserControlSach());
                    break;
                case 3:
                    ActiveItem.Children.Clear();
                    ActiveItem.Children.Add(new UserControlMuonTraSach());
                    break;
                case 4:
                    ActiveItem.Children.Clear();
                    break;
                case 5:
                    ActiveItem.Children.Clear();
                    break;
                default:
                    break;
            }

        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MoveCursorMenu(int index)
        {
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btLogOut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btChangePassword_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
