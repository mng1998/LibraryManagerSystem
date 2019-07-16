using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QUANLYTHUVIEN
{
    public class LOAISACH
    {
        #region prop
        string loaiSach_Id;
        string tenLoaiSach, ghiChu;
        [Key]
        [MaxLength(10)]
        public string LoaiSach_Id { get => loaiSach_Id; set => loaiSach_Id = value; }
        [MaxLength(25)]
        public string TenLoaiSach { get => tenLoaiSach; set => tenLoaiSach = value; }
        [MaxLength(100)]
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        #endregion
        public ICollection<SACH> Sachs { get; set; }
    }
    public class NXB
    {
        #region prop
        string nXB_Id;
        string tenNXB, ghiChu;
        [Key]
        [MaxLength(10)]
        public string NXB_Id { get => nXB_Id; set => nXB_Id = value; }
        [MaxLength(50)]
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
        [MaxLength(100)]
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        #endregion
        public NXB()
        {
            nXB_Id = tenNXB = ghiChu = "";
        }
        public NXB(string nXB_Id, string tenNXB, string ghiChu)
        {
            this.NXB_Id = nXB_Id;
            this.TenNXB = tenNXB;
            this.GhiChu = ghiChu;
        }
        public ICollection<SACH> Sachs { get; set; }
    }    
    public class TACGIA
    {
        #region prop
        string tacGia_Id;
        string tenTacGia, ghiChu;       

        [Key]
        [MaxLength(10)]
        public string TacGia_Id { get => tacGia_Id; set => tacGia_Id = value; }
        [MaxLength(50)]
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        [MaxLength(100)]
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        #endregion
        public ICollection<SACH> Sachs { get; set; }
        public TACGIA()
        {
            tacGia_Id = tenTacGia = ghiChu = "";
        }
        public TACGIA(string tacGia_Id, string tenTacGia, string ghiChu)
        {
            this.TacGia_Id = tacGia_Id;
            this.TenTacGia = tenTacGia;
            this.GhiChu = ghiChu;
        }
    }
    public class LOAIDOCGIA
    {
        #region prop
        string loaiDocGia_Id;
        string tenLoaiDocGia, ghiChu;
        [Key]
        [MaxLength(10)]
        public string LoaiDocGia_Id { get => loaiDocGia_Id; set => loaiDocGia_Id = value; }
        [MaxLength(50)]
        public string TenLoaiDocGia { get => tenLoaiDocGia; set => tenLoaiDocGia = value; }
        [MaxLength(100)]
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        #endregion
        public ICollection<DOCGIA> DocGias { get; set; }
    }
    public class DOCGIA
    {
        #region prop
        string docGia_Id, loaidocGia_Id;
        string tenDocGia, diaChi, email, soDT;
        DateTime ngaySinh, ngayLapThe, ngayHetHan;        
        [Key]
        [MaxLength(10)]
        public string DocGia_Id { get => docGia_Id; set => docGia_Id = value; }
        [MaxLength(4)]
        public string LoaidocGia_Id { get => loaidocGia_Id; set => loaidocGia_Id = value; }
        [MaxLength(50)]
        public string TenDocGia { get => tenDocGia; set => tenDocGia = value; }
        [MaxLength(50)]
        public string DiaChi { get => diaChi; set => diaChi = value; }
        [MaxLength(70)]
        public string Email { get => email; set => email = value; }
        [MaxLength(15)]
        public string SoDT { get => soDT; set => soDT = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public DateTime NgayLapThe { get => ngayLapThe; set => ngayLapThe = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        #endregion
        public LOAIDOCGIA LOAIdOCGIA { get; set; }
        public PHIEU_MUONSACH PHIEU_MUONSACH { get; set; }
        public DOCGIA()
        {
            docGia_Id = tenDocGia = email = soDT = diaChi = loaidocGia_Id= "";
            ngaySinh = ngayHetHan = ngayLapThe = DateTime.Now;
            
        }
        public DOCGIA(string docGia_Id, string tenDocGia,  DateTime ngaySinh, string loaiDocGia_Id, string diaChi,
                      string soDT, string email, DateTime ngayLapPhieu, DateTime ngayHetHan )
        {
            this.DocGia_Id = docGia_Id;
            this.TenDocGia = tenDocGia;
            this.LoaidocGia_Id = loaiDocGia_Id;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
            this.NgayHetHan = ngayHetHan;
            this.NgayLapThe = ngayLapPhieu;
            this.NgaySinh = ngaySinh;
            this.Email = email;
        }
    }
    public class SACH
    {
        #region prop
        string sach_Id, tenSach, loaiSach_Id, tacGia_Id, nXB_Id;
        float gia;
        int namXB;
        DateTime ngayNhap;
        [Key]
        [MaxLength(10)]
        public string Sach_Id { get => sach_Id; set => sach_Id = value; }
        [MaxLength(70)]
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string LoaiSach_Id { get => loaiSach_Id; set => loaiSach_Id = value; }   
        public string TacGia_Id { get => tacGia_Id; set => tacGia_Id = value; }        
        public string NXB_Id { get => nXB_Id; set => nXB_Id = value; }
        public float Gia { get => gia; set => gia = value; }
        public int NamXB { get => namXB; set => namXB = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        #endregion
        public NXB NXB { get; set; }
        public TACGIA TACGIA { get; set; }
        public LOAISACH LOAISACH { get; set; }
        public CHITIET_PHIEUMUONSACH CHITIET_PHIEUMUONSACH { get; set; }
    }
    public class PHIEU_MUONSACH
    {
        #region prop
        string phieumuon_Id , docGia_Id;
        DateTime ngayMuon;
        [Key]
        [Column(Order = 1)]
        [MaxLength(10)]
        public string PhieuMuon_Id { get => phieumuon_Id; set => phieumuon_Id = value; }
        [Key]
        [Column(Order = 2)]
        public string DocGia_Id { get => docGia_Id; set => docGia_Id = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        #endregion
        public ICollection<DOCGIA> DOCGIAs { get; set; }
        public virtual List<CHITIET_PHIEUMUONSACH> CHITIET_PHIEUMUONSACHs { get; set; }
        public virtual List<PHIEU_TRASACH> PHIEU_TRASACHs { get; set; }
        
    }
    public class CHITIET_PHIEUMUONSACH
    {
        #region prop
        string phieumuon_Id, chitietmuon_Id, sach_Id;
        int soLuong;
        [Key]
        [MaxLength(10)]
        [Column(Order = 1)]
        public string Phieumuon_Id { get => phieumuon_Id; set => phieumuon_Id = value; }
        [Key]
        [MaxLength(1)]
        [Column(Order = 2)]
        public string Chitietmuon_Id { get => chitietmuon_Id; set => chitietmuon_Id = value; }
        [Key]
        [Column(Order = 3)]
        public string Sach_Id { get => sach_Id; set => sach_Id = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        #endregion
        public virtual PHIEU_MUONSACH PHIEU_MUONSACH { get; set; }
        public ICollection<SACH> Sachs { get; set; }
    }
    public class PHIEU_TRASACH
    {
        #region prop
        string phieutra_Id, docGia_Id;
        float tienPhatKiNay;
        DateTime ngayTra;        
        [Key]
        [MaxLength(10)]
        [Column(Order = 1)]
        public string PhieuTra_Id { get => phieutra_Id; set => phieutra_Id = value; }
        [Key]
        [Column(Order = 2)]
        public string DocGia_Id { get => docGia_Id; set => docGia_Id = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
        public float TienPhatKiNay { get => tienPhatKiNay; set => tienPhatKiNay = value; }
        #endregion
        public virtual PHIEU_THUPHAT PHIEU_THUPHAT { get; set; }
        public virtual PHIEU_MUONSACH PHIEU_MUONSACH { get; set; }
    }
    public class CHITIET_PHIEUTRASACH
    {
        #region prop
        string phieuTra_Id, phieuPhat_Id, sach_Id;
        int soNgayQuaHan;
        float tienPhat;
        [Key]
        [MaxLength(10)]
        [Column(Order = 1)]
        public string PhieuPhat_Id { get => phieuPhat_Id; set => phieuPhat_Id = value; }
        [Key]        
        [Column(Order = 2)]
        public string PhieuTra_Id { get => phieuTra_Id; set => phieuTra_Id = value; }
        [Key]
        [Column(Order = 3)]
        public string Sach_Id { get => sach_Id; set => sach_Id = value; }
        public int SoNgayQuaHan { get => soNgayQuaHan; set => soNgayQuaHan = value; }
        public float TienPhat { get => tienPhat; set => tienPhat = value; }
        #endregion
        public virtual PHIEU_TRASACH PHIEU_TRASACH { get; set; }
        public virtual ICollection<SACH> SACHs { get; set; }
        
    }
    public class PHIEU_THUPHAT
    {
        #region prop
        string phieuPhat_Id, phieutra_Id, docGia_Id;
        float tongNo, soTienThu, conLai;
      
        [Key]
        [MaxLength(10)]
        [Column(Order = 1)]
        public string PhieuPhat_Id { get => phieuPhat_Id; set => phieuPhat_Id = value; }       
        [Key]
        [Column(Order = 2)]
        public string Phieutra_Id { get => phieutra_Id; set => phieutra_Id = value; }
        [Key]
        [Column(Order = 3)]
        public string DocGia_Id { get => docGia_Id; set => docGia_Id = value; }        
        public float TongNo { get => tongNo; set => tongNo = value; }
        public float SoTienThu { get => soTienThu; set => soTienThu = value; }
        public float ConLai { get => conLai; set => conLai = value; }
        #endregion
        public virtual List<PHIEU_TRASACH> PHIEU_TRASACHs { get; set; }
    }
    public class THAMSO
    {
        string thamSo_Id;
        int giaTri;
        string ghiChu;
        [Key]
        [MaxLength(5)]
        public string ThamSo_Id { get => thamSo_Id; set => thamSo_Id = value; }
        public int GiaTri { get => giaTri; set => giaTri = value; }
        [MaxLength(50)]
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public THAMSO()
        {
            thamSo_Id = ghiChu = "";
            giaTri = 0;
        }
        public THAMSO(string thamSo_Id, int giaTri, string ghiChu)
        {
            this.ThamSo_Id = thamSo_Id;
            this.GiaTri = giaTri;
            this.GhiChu = ghiChu;
        }

    }
    public class QLTV_DBContext : DbContext
    {
        public QLTV_DBContext() : base("QLTV_ConnectionString")
        {

        }
        public DbSet<DOCGIA> DOCGIAs { get; set; }
        public DbSet<LOAIDOCGIA> LOAIDOCGIAs { get; set; }
        public DbSet<SACH> SACHs { get; set; }
        public DbSet<LOAISACH> LOAISACHs { get; set; }
        public DbSet<TACGIA> TACGIAs { get; set; }
        public DbSet<NXB> NHAXUATBANs { get; set; }
        public DbSet<CHITIET_PHIEUMUONSACH> PHIEUMUONSACHs { get; set; }
        public DbSet<PHIEU_TRASACH> TRASACHs { get; set; }
        public DbSet<CHITIET_PHIEUTRASACH> PHIEUTRASACHs { get; set; }
        public DbSet<PHIEU_THUPHAT> THUTIENPHATs { get; set; }
        public DbSet<THAMSO> THAMSOs { get; set; }
     
    }
}
