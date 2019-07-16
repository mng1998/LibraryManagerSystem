using System.Windows;
using System.Windows.Controls;
using QUANLYTHUVIEN.Views;

namespace QUANLYTHUVIEN
{
    /// <summary>
    /// Interaction logic for UserControlNguoiDung.xaml
    /// </summary>
    public partial class UserControlNguoiDung : UserControl
    {
        public UserControlNguoiDung()
        {
            InitializeComponent();
        }

        private void btTheDocGia_Click(object sender, RoutedEventArgs e)
        {
            DocGiaView dg = new DocGiaView();
            dg.ShowDialog();
        }

        private void btTraCuuDG_Click(object sender, RoutedEventArgs e)
        {
            TraCuuDocGiaView dg = new TraCuuDocGiaView();
            dg.ShowDialog();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            QuyDinhView qd = new QuyDinhView();
            qd.ShowDialog();
        }
    }
}
