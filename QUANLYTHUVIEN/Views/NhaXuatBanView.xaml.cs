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
    /// Interaction logic for NhaXuatBanView.xaml
    /// </summary>
    public partial class NhaXuatBanView : Window
    {
        public NhaXuatBanView()
        {
            InitializeComponent();
            using (var db = new QLTV_DBContext())
            {
                NXBList.ItemsSource = db.NHAXUATBANs.ToList();
            }
        }

        private bool CheckNull()
        {
            if (String.IsNullOrEmpty(txtMaNXB.Text) || String.IsNullOrEmpty(txtTenNXB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return false;
        }
        private void ResetTextBox()
        {
            txtMaNXB.Text = string.Empty;
            txtTenNXB.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }

        private void btThemNXB_Click(object sender, RoutedEventArgs e)
        {
            if(CheckNull() == true)
            {
                return;
            }
            else
            {
                using (var db = new QLTV_DBContext())
                {
                    var nxb = new NXB(txtMaNXB.Text, txtTenNXB.Text, txtGhiChu.Text);
                    db.NHAXUATBANs.Add(nxb);
                    db.SaveChanges();
                    NXBList.ItemsSource = db.NHAXUATBANs.ToList();
                    NXBList.Items.Refresh();
                }
            }
        }

        private void btXoaNXB_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin này?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                using (var db = new QLTV_DBContext())
                {
                    var nxb = db.NHAXUATBANs.Find(txtMaNXB.Text);
                    if (nxb != null)
                    {
                        db.NHAXUATBANs.Remove(nxb);
                        db.SaveChanges();
                        NXBList.ItemsSource = db.NHAXUATBANs.ToList();
                        NXBList.Items.Refresh();

                    }
                }
            }
            else
            { MessageBox.Show("Bạn chưa chọn thông tin NXB nào!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information); }
        }

        private void btCapNhatNXB_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QLTV_DBContext())
            {
                var t = db.NHAXUATBANs.Find(txtMaNXB.Text);
                t.NXB_Id = txtMaNXB.Text;
                t.TenNXB = txtTenNXB.Text;
                t.GhiChu = txtGhiChu.Text;
                db.SaveChanges();
                NXBList.ItemsSource = db.NHAXUATBANs.ToList();
                NXBList.Items.Refresh();
            }
        }

        private void NXBList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NXBList.Items.Count > 0 && NXBList.SelectedIndex < NXBList.Items.Count - 1)
            {
                var ncc = (NXB)NXBList.SelectedItem;
                if (ncc != null)
                {
                    txtMaNXB.Text = ncc.NXB_Id;
                    txtTenNXB.Text = ncc.TenNXB;
                    txtGhiChu.Text = ncc.GhiChu;
                }
            }
        }
    }
}
