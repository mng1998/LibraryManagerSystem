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
    /// Interaction logic for SachMoiView.xaml
    /// </summary>
    public partial class SachMoiView : Window
    {
        public SachMoiView()
        {
            InitializeComponent();
            using (var db = new QLTV_DBContext())
            {
                SachList.ItemsSource = db.SACHs.ToList();
                //combobox Thể Loại
                cbNXB.ItemsSource = db.NHAXUATBANs.ToList();
                cbNXB.SelectedValuePath = "NXB_Id";
                cbNXB.DisplayMemberPath = "TenNXB";
                //combobox tác giả
                cbTacGia.ItemsSource = db.TACGIAs.ToList();
                cbTacGia.SelectedValuePath = "TacGia_Id";
                cbTacGia.DisplayMemberPath = "TenTacGia";
                //combobox Thể Loại sách
                cbTheLoai.ItemsSource = db.LOAISACHs.ToList();
                cbTheLoai.SelectedValuePath = "LoaiSach_Id";
                cbTheLoai.DisplayMemberPath = "TenLoaiSach";
            }
        }

        private void cbTacGia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbNXB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        

        private void cbTheLoai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtNamXB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
