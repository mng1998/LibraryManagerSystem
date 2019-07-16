namespace QUANLYTHUVIEN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_QLTV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DOCGIAs",
                c => new
                    {
                        DocGia_Id = c.String(nullable: false, maxLength: 10),
                        LoaidocGia_Id = c.String(maxLength: 10),
                        TenDocGia = c.String(maxLength: 50),
                        DiaChi = c.String(maxLength: 50),
                        Email = c.String(maxLength: 70),
                        SoDT = c.String(maxLength: 15),
                        NgaySinh = c.DateTime(nullable: false),
                        NgayLapThe = c.DateTime(nullable: false),
                        NgayHetHan = c.DateTime(nullable: false),
                        PHIEU_MUONSACH_PhieuMuon_Id = c.String(maxLength: 10),
                        PHIEU_MUONSACH_DocGia_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DocGia_Id)
                .ForeignKey("dbo.LOAIDOCGIAs", t => t.LoaidocGia_Id)
                .ForeignKey("dbo.PHIEU_MUONSACH", t => new { t.PHIEU_MUONSACH_PhieuMuon_Id, t.PHIEU_MUONSACH_DocGia_Id })
                .Index(t => t.LoaidocGia_Id)
                .Index(t => new { t.PHIEU_MUONSACH_PhieuMuon_Id, t.PHIEU_MUONSACH_DocGia_Id });
            
            CreateTable(
                "dbo.LOAIDOCGIAs",
                c => new
                    {
                        LoaiDocGia_Id = c.String(nullable: false, maxLength: 10),
                        TenLoaiDocGia = c.String(maxLength: 50),
                        GhiChu = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.LoaiDocGia_Id);
            
            CreateTable(
                "dbo.PHIEU_MUONSACH",
                c => new
                    {
                        PhieuMuon_Id = c.String(nullable: false, maxLength: 10),
                        DocGia_Id = c.String(nullable: false, maxLength: 128),
                        NgayMuon = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.PhieuMuon_Id, t.DocGia_Id });
            
            CreateTable(
                "dbo.CHITIET_PHIEUMUONSACH",
                c => new
                    {
                        Phieumuon_Id = c.String(nullable: false, maxLength: 10),
                        Chitietmuon_Id = c.String(nullable: false, maxLength: 1),
                        Sach_Id = c.String(nullable: false, maxLength: 128),
                        SoLuong = c.Int(nullable: false),
                        PHIEU_MUONSACH_PhieuMuon_Id = c.String(maxLength: 10),
                        PHIEU_MUONSACH_DocGia_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Phieumuon_Id, t.Chitietmuon_Id, t.Sach_Id })
                .ForeignKey("dbo.PHIEU_MUONSACH", t => new { t.PHIEU_MUONSACH_PhieuMuon_Id, t.PHIEU_MUONSACH_DocGia_Id })
                .Index(t => new { t.PHIEU_MUONSACH_PhieuMuon_Id, t.PHIEU_MUONSACH_DocGia_Id });
            
            CreateTable(
                "dbo.SACHes",
                c => new
                    {
                        Sach_Id = c.String(nullable: false, maxLength: 10),
                        TenSach = c.String(maxLength: 70),
                        LoaiSach_Id = c.String(maxLength: 10),
                        TacGia_Id = c.String(maxLength: 10),
                        NXB_Id = c.String(maxLength: 10),
                        Gia = c.Single(nullable: false),
                        NamXB = c.Int(nullable: false),
                        NgayNhap = c.DateTime(nullable: false),
                        CHITIET_PHIEUMUONSACH_Phieumuon_Id = c.String(maxLength: 10),
                        CHITIET_PHIEUMUONSACH_Chitietmuon_Id = c.String(maxLength: 1),
                        CHITIET_PHIEUMUONSACH_Sach_Id = c.String(maxLength: 128),
                        CHITIET_PHIEUTRASACH_PhieuPhat_Id = c.String(maxLength: 10),
                        CHITIET_PHIEUTRASACH_PhieuTra_Id = c.String(maxLength: 128),
                        CHITIET_PHIEUTRASACH_Sach_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Sach_Id)
                .ForeignKey("dbo.CHITIET_PHIEUMUONSACH", t => new { t.CHITIET_PHIEUMUONSACH_Phieumuon_Id, t.CHITIET_PHIEUMUONSACH_Chitietmuon_Id, t.CHITIET_PHIEUMUONSACH_Sach_Id })
                .ForeignKey("dbo.LOAISACHes", t => t.LoaiSach_Id)
                .ForeignKey("dbo.NXBs", t => t.NXB_Id)
                .ForeignKey("dbo.TACGIAs", t => t.TacGia_Id)
                .ForeignKey("dbo.CHITIET_PHIEUTRASACH", t => new { t.CHITIET_PHIEUTRASACH_PhieuPhat_Id, t.CHITIET_PHIEUTRASACH_PhieuTra_Id, t.CHITIET_PHIEUTRASACH_Sach_Id })
                .Index(t => t.LoaiSach_Id)
                .Index(t => t.TacGia_Id)
                .Index(t => t.NXB_Id)
                .Index(t => new { t.CHITIET_PHIEUMUONSACH_Phieumuon_Id, t.CHITIET_PHIEUMUONSACH_Chitietmuon_Id, t.CHITIET_PHIEUMUONSACH_Sach_Id })
                .Index(t => new { t.CHITIET_PHIEUTRASACH_PhieuPhat_Id, t.CHITIET_PHIEUTRASACH_PhieuTra_Id, t.CHITIET_PHIEUTRASACH_Sach_Id });
            
            CreateTable(
                "dbo.LOAISACHes",
                c => new
                    {
                        LoaiSach_Id = c.String(nullable: false, maxLength: 10),
                        TenLoaiSach = c.String(maxLength: 25),
                        GhiChu = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.LoaiSach_Id);
            
            CreateTable(
                "dbo.NXBs",
                c => new
                    {
                        NXB_Id = c.String(nullable: false, maxLength: 10),
                        TenNXB = c.String(maxLength: 50),
                        GhiChu = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.NXB_Id);
            
            CreateTable(
                "dbo.TACGIAs",
                c => new
                    {
                        TacGia_Id = c.String(nullable: false, maxLength: 10),
                        TenTacGia = c.String(maxLength: 50),
                        GhiChu = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.TacGia_Id);
            
            CreateTable(
                "dbo.PHIEU_TRASACH",
                c => new
                    {
                        PhieuTra_Id = c.String(nullable: false, maxLength: 10),
                        DocGia_Id = c.String(nullable: false, maxLength: 128),
                        NgayTra = c.DateTime(nullable: false),
                        TienPhatKiNay = c.Single(nullable: false),
                        PHIEU_MUONSACH_PhieuMuon_Id = c.String(maxLength: 10),
                        PHIEU_MUONSACH_DocGia_Id = c.String(maxLength: 128),
                        PHIEU_THUPHAT_PhieuPhat_Id = c.String(maxLength: 10),
                        PHIEU_THUPHAT_Phieutra_Id = c.String(maxLength: 128),
                        PHIEU_THUPHAT_DocGia_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PhieuTra_Id, t.DocGia_Id })
                .ForeignKey("dbo.PHIEU_MUONSACH", t => new { t.PHIEU_MUONSACH_PhieuMuon_Id, t.PHIEU_MUONSACH_DocGia_Id })
                .ForeignKey("dbo.PHIEU_THUPHAT", t => new { t.PHIEU_THUPHAT_PhieuPhat_Id, t.PHIEU_THUPHAT_Phieutra_Id, t.PHIEU_THUPHAT_DocGia_Id })
                .Index(t => new { t.PHIEU_MUONSACH_PhieuMuon_Id, t.PHIEU_MUONSACH_DocGia_Id })
                .Index(t => new { t.PHIEU_THUPHAT_PhieuPhat_Id, t.PHIEU_THUPHAT_Phieutra_Id, t.PHIEU_THUPHAT_DocGia_Id });
            
            CreateTable(
                "dbo.PHIEU_THUPHAT",
                c => new
                    {
                        PhieuPhat_Id = c.String(nullable: false, maxLength: 10),
                        Phieutra_Id = c.String(nullable: false, maxLength: 128),
                        DocGia_Id = c.String(nullable: false, maxLength: 128),
                        TongNo = c.Single(nullable: false),
                        SoTienThu = c.Single(nullable: false),
                        ConLai = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.PhieuPhat_Id, t.Phieutra_Id, t.DocGia_Id });
            
            CreateTable(
                "dbo.CHITIET_PHIEUTRASACH",
                c => new
                    {
                        PhieuPhat_Id = c.String(nullable: false, maxLength: 10),
                        PhieuTra_Id = c.String(nullable: false, maxLength: 128),
                        Sach_Id = c.String(nullable: false, maxLength: 128),
                        SoNgayQuaHan = c.Int(nullable: false),
                        TienPhat = c.Single(nullable: false),
                        PHIEU_TRASACH_PhieuTra_Id = c.String(maxLength: 10),
                        PHIEU_TRASACH_DocGia_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PhieuPhat_Id, t.PhieuTra_Id, t.Sach_Id })
                .ForeignKey("dbo.PHIEU_TRASACH", t => new { t.PHIEU_TRASACH_PhieuTra_Id, t.PHIEU_TRASACH_DocGia_Id })
                .Index(t => new { t.PHIEU_TRASACH_PhieuTra_Id, t.PHIEU_TRASACH_DocGia_Id });
            
            CreateTable(
                "dbo.THAMSOes",
                c => new
                    {
                        ThamSo_Id = c.String(nullable: false, maxLength: 5),
                        GiaTri = c.Int(nullable: false),
                        GhiChu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ThamSo_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SACHes", new[] { "CHITIET_PHIEUTRASACH_PhieuPhat_Id", "CHITIET_PHIEUTRASACH_PhieuTra_Id", "CHITIET_PHIEUTRASACH_Sach_Id" }, "dbo.CHITIET_PHIEUTRASACH");
            DropForeignKey("dbo.CHITIET_PHIEUTRASACH", new[] { "PHIEU_TRASACH_PhieuTra_Id", "PHIEU_TRASACH_DocGia_Id" }, "dbo.PHIEU_TRASACH");
            DropForeignKey("dbo.PHIEU_TRASACH", new[] { "PHIEU_THUPHAT_PhieuPhat_Id", "PHIEU_THUPHAT_Phieutra_Id", "PHIEU_THUPHAT_DocGia_Id" }, "dbo.PHIEU_THUPHAT");
            DropForeignKey("dbo.PHIEU_TRASACH", new[] { "PHIEU_MUONSACH_PhieuMuon_Id", "PHIEU_MUONSACH_DocGia_Id" }, "dbo.PHIEU_MUONSACH");
            DropForeignKey("dbo.DOCGIAs", new[] { "PHIEU_MUONSACH_PhieuMuon_Id", "PHIEU_MUONSACH_DocGia_Id" }, "dbo.PHIEU_MUONSACH");
            DropForeignKey("dbo.SACHes", "TacGia_Id", "dbo.TACGIAs");
            DropForeignKey("dbo.SACHes", "NXB_Id", "dbo.NXBs");
            DropForeignKey("dbo.SACHes", "LoaiSach_Id", "dbo.LOAISACHes");
            DropForeignKey("dbo.SACHes", new[] { "CHITIET_PHIEUMUONSACH_Phieumuon_Id", "CHITIET_PHIEUMUONSACH_Chitietmuon_Id", "CHITIET_PHIEUMUONSACH_Sach_Id" }, "dbo.CHITIET_PHIEUMUONSACH");
            DropForeignKey("dbo.CHITIET_PHIEUMUONSACH", new[] { "PHIEU_MUONSACH_PhieuMuon_Id", "PHIEU_MUONSACH_DocGia_Id" }, "dbo.PHIEU_MUONSACH");
            DropForeignKey("dbo.DOCGIAs", "LoaidocGia_Id", "dbo.LOAIDOCGIAs");
            DropIndex("dbo.CHITIET_PHIEUTRASACH", new[] { "PHIEU_TRASACH_PhieuTra_Id", "PHIEU_TRASACH_DocGia_Id" });
            DropIndex("dbo.PHIEU_TRASACH", new[] { "PHIEU_THUPHAT_PhieuPhat_Id", "PHIEU_THUPHAT_Phieutra_Id", "PHIEU_THUPHAT_DocGia_Id" });
            DropIndex("dbo.PHIEU_TRASACH", new[] { "PHIEU_MUONSACH_PhieuMuon_Id", "PHIEU_MUONSACH_DocGia_Id" });
            DropIndex("dbo.SACHes", new[] { "CHITIET_PHIEUTRASACH_PhieuPhat_Id", "CHITIET_PHIEUTRASACH_PhieuTra_Id", "CHITIET_PHIEUTRASACH_Sach_Id" });
            DropIndex("dbo.SACHes", new[] { "CHITIET_PHIEUMUONSACH_Phieumuon_Id", "CHITIET_PHIEUMUONSACH_Chitietmuon_Id", "CHITIET_PHIEUMUONSACH_Sach_Id" });
            DropIndex("dbo.SACHes", new[] { "NXB_Id" });
            DropIndex("dbo.SACHes", new[] { "TacGia_Id" });
            DropIndex("dbo.SACHes", new[] { "LoaiSach_Id" });
            DropIndex("dbo.CHITIET_PHIEUMUONSACH", new[] { "PHIEU_MUONSACH_PhieuMuon_Id", "PHIEU_MUONSACH_DocGia_Id" });
            DropIndex("dbo.DOCGIAs", new[] { "PHIEU_MUONSACH_PhieuMuon_Id", "PHIEU_MUONSACH_DocGia_Id" });
            DropIndex("dbo.DOCGIAs", new[] { "LoaidocGia_Id" });
            DropTable("dbo.THAMSOes");
            DropTable("dbo.CHITIET_PHIEUTRASACH");
            DropTable("dbo.PHIEU_THUPHAT");
            DropTable("dbo.PHIEU_TRASACH");
            DropTable("dbo.TACGIAs");
            DropTable("dbo.NXBs");
            DropTable("dbo.LOAISACHes");
            DropTable("dbo.SACHes");
            DropTable("dbo.CHITIET_PHIEUMUONSACH");
            DropTable("dbo.PHIEU_MUONSACH");
            DropTable("dbo.LOAIDOCGIAs");
            DropTable("dbo.DOCGIAs");
        }
    }
}
