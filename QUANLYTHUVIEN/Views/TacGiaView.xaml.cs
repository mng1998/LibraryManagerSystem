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
    /// Interaction logic for TacGiaView.xaml
    /// </summary>
    public partial class TacGiaView : Window
    {
        public TacGiaView()
        {
            InitializeComponent();
            using (var db = new QLTV_DBContext())
            {
                TacGiaList.ItemsSource = db.TACGIAs.ToList();
            }
        }
       
        private void btThemTG_Click(object sender, RoutedEventArgs e)
        {
            if(CheckNull()==true)
            {
                return;
            }
            else
            {
                using (var db = new QLTV_DBContext())
                {
                    var tg = new TACGIA(txtMaTG.Text, txtTenTG.Text, txtGhiChu.Text);
                    db.TACGIAs.Add(tg);
                    db.SaveChanges();
                    TacGiaList.ItemsSource = db.TACGIAs.ToList();
                    TacGiaList.Items.Refresh();
                }
            }
        }
        private bool CheckNull()
        {
            if (String.IsNullOrEmpty(txtTenTG.Text) || String.IsNullOrEmpty(txtMaTG.Text) || String.IsNullOrEmpty(txtGhiChu.Text) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return false;
        }
        private void ResetTextBox()
        {
            txtMaTG.Text = string.Empty;
            txtTenTG.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            
        }        
        private void btCapNhatTG_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QLTV_DBContext())
            {
                var t = db.TACGIAs.Find(txtMaTG.Text);
                t.TacGia_Id = txtMaTG.Text;
                t.TenTacGia = txtTenTG.Text;
                t.GhiChu = txtGhiChu.Text;
                db.SaveChanges();
                TacGiaList.ItemsSource = db.TACGIAs.ToList();
                TacGiaList.Items.Refresh();
            }
        }
        private void TacGiaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TacGiaList.Items.Count > 0 && TacGiaList.SelectedIndex < TacGiaList.Items.Count - 1)
            {
                var ncc = (TACGIA)TacGiaList.SelectedItem;
                if (ncc != null)
                {
                    txtMaTG.Text = ncc.TacGia_Id;
                    txtTenTG.Text = ncc.TenTacGia;
                    txtGhiChu.Text = ncc.GhiChu;
                }
            }
        }
        private void TacGiaList_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()).ToString();
        }
        private void btXoaTG_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa tác giả này?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                using (var db = new QLTV_DBContext())
                {
                    var tg = db.TACGIAs.Find(txtMaTG.Text);
                    if (tg != null)
                    {
                        db.TACGIAs.Remove(tg);
                        db.SaveChanges();
                        TacGiaList.ItemsSource = db.TACGIAs.ToList();
                        TacGiaList.Items.Refresh();

                    }
                }
            }
            else
            { MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information); }
        }
    }
}
