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
    /// Interaction logic for DocGiaUpdateDeleteView.xaml
    /// </summary>
    public partial class DocGiaUpdateDeleteView : Window
    {
        public DocGiaUpdateDeleteView()
        {
            InitializeComponent();
        }

        private void txtPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void txtMaDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                
                using (var db = new QLTV_DBContext())
                {
                    var t = db.DOCGIAs.Find(txtMaDocGia.Text);
                    txtTenDocGia.Text = t.TenDocGia;
                    txtDiaChi.Text = t.DiaChi;
                    cbLoaiDG.Text = t.LOAIdOCGIA.TenLoaiDocGia;
                    dpNgayHetHan.Text = t.NgayHetHan.ToString();
                    dpNgayLapPhieu.Text = t.NgayLapThe.ToString();
                    dpNgaySinh.Text = t.NgaySinh.ToString();
                    txtEmail.Text = t.Email;
                    txtPhone.Text= t.SoDT;
                }
               

            }


        }
    }
}
