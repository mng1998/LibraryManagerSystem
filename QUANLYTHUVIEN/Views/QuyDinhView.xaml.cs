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
    /// Interaction logic for QuyDinhView.xaml
    /// </summary>
    public partial class QuyDinhView : Window
    {
        public QuyDinhView()
        {
            InitializeComponent();
            using (var db = new QLTV_DBContext())
            {
                QuyDinhList.ItemsSource = db.THAMSOs.ToList();
            }
        }

        private void btThem_Click(object sender, RoutedEventArgs e)
        {
            if(CheckNull()==true)
            {
                return;
            }
            else
            {
                using (var db = new QLTV_DBContext())
                {
                    var qd = new THAMSO(txtNoiDungQD_ID.Text, int.Parse(txtGiaTri.Text), txtGhichu.Text);
                    db.THAMSOs.Add(qd);
                    db.SaveChanges();
                    QuyDinhList.ItemsSource = db.THAMSOs.ToList();
                    QuyDinhList.Items.Refresh();
                }
            }
            
        }
        private bool CheckNull()
        {
            if (String.IsNullOrEmpty(txtNoiDungQD_ID.Text) || String.IsNullOrEmpty(txtGiaTri.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return false;
        }

        private void btThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
