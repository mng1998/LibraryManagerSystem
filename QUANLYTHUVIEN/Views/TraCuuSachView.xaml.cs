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
    /// Interaction logic for TraCuuSachView.xaml
    /// </summary>
    public partial class TraCuuSachView : Window
    {
        public TraCuuSachView()
        {
            InitializeComponent();
            //combobox số phiếu nhập
            using (var db = new QLTV_DBContext())
            {
                SachList.ItemsSource = db.SACHs.ToList();
                //combobox Thể Loại
                cbTheLoai.ItemsSource = db.LOAISACHs.ToList();
                cbTheLoai.SelectedValuePath = "LoaiSach_Id";
                cbTheLoai.DisplayMemberPath = "TenLoaiSach";
                //combobox Tác Giả
                cbTacGia.ItemsSource = db.TACGIAs.ToList();
                cbTacGia.SelectedValuePath = "TacGia_Id";
                cbTacGia.DisplayMemberPath = "TenTacGia";
                //combobox Nhà Xuất Bản
                cbNXB.ItemsSource = db.NHAXUATBANs.ToList();
                cbNXB.SelectedValuePath = "NXB_Id";
                cbNXB.DisplayMemberPath = "TenNXB";
            }
        }
       
        private void cbTacGia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new QLTV_DBContext())
            {
                var query = from p in db.SACHs
                            join q in db.TACGIAs on p.TacGia_Id equals q.TacGia_Id
                            where p.TacGia_Id == cbTacGia.SelectedValue.ToString()
                            select new { p.Sach_Id, p.TenSach, p.LoaiSach_Id, q.TenTacGia, p.NamXB, p.Gia };
                SachList.ItemsSource = query.ToList();
            }
        }

        private void cbNXB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new QLTV_DBContext())
            {
                var query = from p in db.NHAXUATBANs
                            join q in db.SACHs on p.NXB_Id equals q.NXB_Id
                            where p.NXB_Id == cbNXB.SelectedValue.ToString()
                            select new { q.Sach_Id, q.TenSach, q.LoaiSach_Id, p.TenNXB, q.Gia };
                SachList.ItemsSource = query.ToList();
            }
        }

        private void cbTheLoai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new QLTV_DBContext())
            {
                var query = from p in db.SACHs
                            join q in db.LOAISACHs on p.LoaiSach_Id equals q.LoaiSach_Id
                            where p.LoaiSach_Id == cbTheLoai.SelectedValue.ToString()
                            select new { p.Sach_Id, p.TenSach, q.TenLoaiSach, p.NamXB, p.Gia };
                SachList.ItemsSource = query.ToList();
            }
        }
    }
}
