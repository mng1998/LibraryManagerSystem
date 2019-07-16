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
    /// Interaction logic for TraCuuDocGia.xaml
    /// </summary>
    public partial class TraCuuDocGiaView : Window
    {
        public TraCuuDocGiaView()
        {
            InitializeComponent();
            using (var db = new QLTV_DBContext())
            {
                DocGiaList.ItemsSource = db.DOCGIAs.ToList();
                //combobox Thể Loại
                cbLoaiDG.ItemsSource = db.LOAIDOCGIAs.ToList();
                cbLoaiDG.SelectedValuePath = "LoaiDocGia_Id";
                cbLoaiDG.DisplayMemberPath = "TenLoaiDocGia";
            }
        }

        private void txtTenDG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using (var db = new QLTV_DBContext())
                {
                    var query = from p in db.DOCGIAs
                                where p.TenDocGia.Contains(txtTenDG.Text)
                                select p;
                    DocGiaList.ItemsSource = query.ToList();
                }
            }
        }

        private void txtMaDG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using (var db = new QLTV_DBContext())
                {
                    var query = from p in db.DOCGIAs
                                where p.DocGia_Id == txtMaDG.Text
                                select p;
                    DocGiaList.ItemsSource = query.ToList();
                }
            }
        }

        private void cbLoaiDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new QLTV_DBContext())
            {
                var query = from p in db.DOCGIAs
                            join q in db.LOAIDOCGIAs on p.LoaidocGia_Id equals q.LoaiDocGia_Id
                            where p.LoaidocGia_Id == cbLoaiDG.SelectedValue.ToString()
                            select p;
                DocGiaList.ItemsSource = query.ToList();
            }
        }
    }
}
