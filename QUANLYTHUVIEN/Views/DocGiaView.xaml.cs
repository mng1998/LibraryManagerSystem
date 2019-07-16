using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for DocGiaView.xaml
    /// </summary>
    public partial class DocGiaView : Window
    {
        public DocGiaView()
        {
            InitializeComponent();
            using (var db = new QLTV_DBContext())
            {
                DocGiaList.ItemsSource = db.DOCGIAs.ToList();

                //combobox số phiếu nhập
                cbLoaiDG.ItemsSource = db.LOAIDOCGIAs.ToList();
                cbLoaiDG.SelectedValuePath = "LoaiDocGia_Id";
                cbLoaiDG.DisplayMemberPath = "TenLoaiDocGia";
            }
        }

        private void txtPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ResetTextBox();
        }
        
        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new QLTV_DBContext())
            {
                if (CheckNull() == true)
                { return; }
                else
                {
                    var dg = new DOCGIA(txtMaDocGia.Text,
                                        txtTenDocGia.Text,
                                        DateTime.Parse(dpNgaySinh.Text),
                                        cbLoaiDG.SelectedValue.ToString(),
                                        txtDiaChi.Text,
                                        txtPhone.Text,
                                        txtEmail.Text,
                                        DateTime.Parse(dpNgayLapPhieu.Text),
                                        DateTime.Parse(dpNgayHetHan.Text));
                    db.DOCGIAs.Add(dg);
                    db.SaveChanges();
                    DocGiaList.ItemsSource = db.DOCGIAs.ToList();
                    DocGiaList.Items.Refresh();
                }
            }
        }

        private bool CheckNull()
        {
            if (String.IsNullOrEmpty(txtMaDocGia.Text) || String.IsNullOrEmpty(txtTenDocGia.Text) || 
                String.IsNullOrEmpty(txtDiaChi.Text)|| String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtEmail.Text) ||
                (cbLoaiDG.SelectedItem == null) || dpNgayHetHan.SelectedDate == null || dpNgayLapPhieu.SelectedDate == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return false;
        }
        private void ResetTextBox()
        {
            txtMaDocGia.Text = string.Empty;
            txtTenDocGia.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cbLoaiDG.Text = string.Empty;
            dpNgayHetHan.Text = string.Empty;
            dpNgayLapPhieu.Text = string.Empty;
            dpNgaySinh.Text = string.Empty;
        }

        private void txtEmail_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(e.Handled = new Regex(@"\S+@\S+\.S\S+").IsMatch(e.Text))
            {
                return;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}
