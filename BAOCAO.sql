
CREATE DATABASE BAOCAONHOM5
GO
USE BAOCAONHOM5

CREATE TABLE KhachHang
(	MaKH varchar(20),
	TenKH nvarchar(100) not null,
	SDT char(10),
	primary key(MaKH)
)
GO

CREATE TABLE NhanVien
(	MaNV varchar(20),
	TenNV nvarchar(100) not null,
	SDT	CHAR(10) not null,
	DiaChi NVARCHAR(100) not null,
	primary key(MaNV)
)
GO

CREATE TABLE SanPham
(	MaSP varchar(20),
	TenSP nvarchar(100) not null,
	DonGia int not null,
	primary key (MaSP)
)
GO

CREATE TABLE NguyenVatLieu 
(	MaNVL varchar(20), 
	TenNVL nvarchar(100) not null,
	SoLuong int not null,
	DonVi nvarchar(20) not null, 
	KhoiLuongTinh int not null,
	DoViTinh varchar(20) not null,
	primary key(MaNVL)
)
GO

CREATE TABLE NhapNVL
(	MaPhieu varchar(20), 
	NgayNhap date not null, 
	TongTienHang int not null, 
	TongThanhToan int not null,
	CongNo int,
	MaNV varchar(20) not null,
	primary key (MaPhieu),
	foreign key (MaNV) references NhanVien

)
GO

CREATE TABLE ChiTietNhapNVL
(	MaPhieu varchar(20) not null, 
	TenNVL nvarchar(100) not null,
	SoLuongNhap int not null, 
	DonGia int not null,
	DVT nvarchar(20),
	ThanhTien int not null, 
	ChietKhau int, 
	MaNVL varchar(20) not null,
	foreign key (MaPhieu) references NhapNVL,
	foreign key (MaNVL) references NguyenVatLieu
)
GO

CREATE TABLE CongThuc
(	MaCT varchar(20) not null, 
	MaSP varchar(20) not null, 
	MaNVL varchar(20) not null,
	LuongNVL int not null,
	DonViTinh varchar(20) not null,
	foreign key (MaSP) references SanPham,
	foreign key (MaNVL) references NguyenVatLieu
)

CREATE TABLE HoaDon 
(	MaHD varchar(20), 
	NgayBan date not null, 
	GhiChu nvarchar(100), 
	TongTien int not null, 
	ChietKhau int,
	MaNV varchar(20) not null, 
	MaKH varchar(20) not null,
	primary key(MaHD),
	foreign key (MaNV) references NhanVien,
	foreign key (MaKH) references KhachHang
)
GO

CREATE TABLE ChiTietHoaDon 
(	MaHD varchar(20) not null, 
	TenSP nvarchar(50) not null,
	SoLuong int not null, 
	DonGia int not null, 
	ThanhTien int not null,
	MaSP varchar(20) not null,
	foreign key (MaHD) references HoaDon,
	foreign key (MaSP) references SanPham
)
GO


 -- THÊM DỮ LIỆU VÀO BẢNG KHACHHANG

 INSERT INTO KHACHHANG 
 VALUES 
	 ('0000000001',N'Trương Quang Hòa','0976308098'),
	 ('0000000002',N'Lê Anh Huy','0966654330'),
	 ('0000000003',N'Hồ Trần Nhật Khánh','0164843800'),
	 ('0000000004',N'Lê Minh Trí','0935700123'),
	 ('0000000005',N'Phan Công Diễn','0935604934')


--THÊM DỮ LIỆU VÀO BẢNG NHANVIEN
 
INSERT INTO NHANVIEN
VALUES
	('NV001',N'Nguyễn Trí Hùng','0905886802',N'HUỲNH HÙNG, THÔN 4, XÃ HÒA PHONG, KRÔNG BÔNG, ĐĂK LĂK'),
	('NV002',N'Dương Ngọc Long','0120877631',N'01 THOẠI NGỌC HẦU, TAM KỲ, QUẢNG NAM'),
	('NV003',N'Trương Nhật Minh','0165421777',N'TỔ 37B KHU VỰC 4, SỐ NHÀ 20/6A CHI LĂNG, QUY NHƠN, BÌNH ĐỊNH'),
	('NV004',N'Lê Nguyễn Hoàng Văn','0969590517',N'SỐ 31 ĐƯỜNG HÒA MINH 4, LIÊN CHIỂU, ĐÀ NẴNG'),
	('NV005',N'Nguyễn Văn Hoàng Long','0914660398',N'TỔ 45 ĐA PHƯỚC II, HÒA KHÁNH BẮC, LIÊN CHIỂU, ĐÀ NẴNG'),
	('NV006',N'Trần Phước Đạt','0914163750',N'11 THÚC TỀ, THANH KHÊ, TP. ĐÀ NẴNG'),
	('NV007',N'Phạm Duy Khánh','0164663603',N'08/38 TRẦN BÌNH TRỌNG - P. ĐÔNG SƠN - TP THANH HÓA')

--THÊM DỮ LIỆU VÀO BẢNG SANPHAM

INSERT INTO SANPHAM
VALUES
	('SP0001',N'Café trứng',35000),
	('SP0002',N'Matcha đá xay',40000),
	('SP0003',N'Trà sữa olong',25000),
	('SP0004',N'Sinh tố xoài',30000),
	('SP0005',N'Soda việt quất',20000),
	('SP0006',N'Trà đào cam sả',25000),
	('SP0007',N'Ép cam',20000)

--THÊM DỮ LIỆU VÀO BẢNG NGUYÊN VẬT LIỆU

INSERT INTO NGUYENVATLIEU
VALUES
	('NL0001',N'Kem sữa béo',10,N'Hộp',5000,'GAM'),
	('NL0002',N'Trà đen Lộc Phát',10,N'Bịch',5000,'GAM'),
	('NL0003',N'Cam xanh',10,'KG',10000,'GAM'),
	('NL0004',N'Xoài',10,'KG',10000,'GAM'),
	('NL0005',N'Soda',5,N'Thùng',24,'LON'),
	('NL0006',N'Cafe',50,N'KG',50000,'GAM'),
	('NL0007',N'Siro việt quất',10,N'Chai',2000,'ML'),
	('NL0008',N'Bột matcha',10,N'Bịch',5000,'GAM')

--THÊM DỮ LIỆU VÀO BẢNG NHAPNVL

INSERT INTO NHAPNVL
VALUES
	('P00001','2021/12/27',1950000,1000000,950000,'NV001'),
	('P00002','2022/01/31',200000,200000,'','NV005'),
	('P00003','2022/06/16',750000,750000,'','NV001'),
	('P00004','2002/11/15',500000,500000,'','NV002')

-- THÊM DỮ LIỆU VÀO BẢNG CHITIETNHAPNVL
INSERT INTO CHITIETNHAPNVL
VALUES
	('P00003',N'Bột matcha',5,150000,N'Bịch',750000,0,'NL0008'),
	('P00004',N'Kem sữa béo',10,50000,N'Bịch',500000,0,'NL0001'),
	('P00001',N'Trà đen Lộc Phát',10,120000,N'Bịch',1200000,0,'NL0002'),
	('P00001',N'Bột matcha',5,150000,N'Bịch',750000,0,'NL0008'),
	('P00002',N'Xoài',10,20000,'KG',200000,0,'NL0004')
		
--THÊM DỮ LIỆU VÀO BẢNG CONGTHUC
INSERT INTO CONGTHUC
VALUES
	('CT0001','SP0003','NL0002',50,'GAM'),
	('CT0001','SP0003','NL0001',300,'GAM'),
	('CT0002','SP0005','NL0005',1,'LON'),
	('CT0002','SP0005','NL0007',50,'ML'),
	('CT0003','SP0007','NL0003',200,'ML')

--THÊM DỮ LIỆU VÀO BẢNG HOADON
INSERT INTO HOADON
VALUES
	('HD0001','2022-10-1',N'ít đá','50000','','NV001','0000000001'),
	('HD0002','2022-10-2',N'nhiều đá','75000','','NV003','0000000002'),
	('HD0003','2022-10-3',N'nhiều xoài','60000','','NV004','0000000003'),
	('HD0004','2022-10-5','','110000','','NV005','0000000004'),
	('HD0005','2022-10-6','','25000','','NV002','0000000005')

--THÊM DỮ LIỆU VÀO BẢNG CHITIETHOADON
INSERT INTO CHITIETHOADON
VALUES
	('HD0001',N'Trà sữa olong',2,25000,50000,'SP0003'),
	('HD0002',N'Trà sữa olong',3,75000,75000,'SP0003'),
	('HD0003',N'Sinh tố xoài',2,30000,60000,'SP0004'),
	('HD0004',N'Sinh tố xoài',2,30000,60000,'SP0004'),
	('HD0004',N'Trà sữa olong',2,25000,50000,'SP0003'),
	('HD0005',N'Trà sữa olong',1,25000,25000,'SP0003')

--TẠO 1 NON-CLUSTERED INDEX TRÊN CỘT MAHD CỦA BẢNG CHITIETHOADON
	
	CREATE NONCLUSTERED INDEX  NINDEX ON CHITIETHOADON (MAHD)

/* THỰC HIỆN VIỆC MÃ HÓA CỘT SDT TRONG BẢNG KHACHHANG */

--1. Tạo cột để lưu trữ dữ liệu mã hóa
ALTER TABLE KHACHHANG ADD
[MAHOA]  VARBINARY (MAX)
GO

--2. Cập nhật dữ liệu đã được mã hóa vào cột vừa tạo
UPDATE KHACHHANG SET [MAHOA] =ENCRYPTBYPASSPHRASE('DIEN THOAI', CONVERT (VARCHAR(100), SDT))


--3. Xóa bỏ cột SDT ban đầu 
ALTER TABLE KHACHHANG DROP COLUMN SDT
SELECT MAKH, TENKH, CONVERT (CHAR, CONVERT (CHAR, CONVERT(VARCHAR(100), DECRYPTBYPASSPHRASE('DIEN THOAI',[MAHOA])))) AS SDT FROM KHACHHANG
select * from Khachhang	

--proc xóa kh
create proc xoakh @makh varchar(20)
as
begin
	delete from khachhang where makh = @makh
end
--proc xóa nv
create proc xoanv @manv varchar(20)
as
begin
	delete from nhanvien where manv = @manv
end
--proc xoa nvl
create proc xoanvl @manvl varchar(20)
as
begin
	delete from nguyenvatlieu where manvl = @manvl
end
--proc xóa nnvl
create proc xoannvl @maphieu varchar(20)
as
begin
	delete from nhapnvl where maphieu = @maphieu
end
--proc xóa ctnnvl
create proc xoactnnvl @maphieu varchar(20), @manvl varchar(20)
as
begin
	delete from chitietnhapnvl where maphieu = @maphieu and manvl = @manvl
end
--proc xóa hoadon
create proc xoahd @mahd varchar(20)
as
begin
	delete from hoadon where mahd = @mahd
end
--proc xóa cthd
create proc xoacthd @mahd varchar(20), @masp varchar(20)
as
begin
	delete from chitiethoadon where mahd = @mahd and masp = @masp
end
----------proc xóa cthd khi xóa hoadon
create proc xoacthd_hd @mahd varchar(20)
as
begin
	delete from chitiethoadon where mahd=@mahd
end
-----------------proc xóa ctnnvl khi xóa nhapnvl
create proc xoactnnvl_nnvl @maphieu varchar(20)
as
begin
	delete from chitietnhapnvl where maphieu=@maphieu
end

--proc themct
create proc themct @MaCT varchar(20),@MaSP  varchar(20),@MaNVL varchar(20),@LuongNVL int, @DonViTinh varchar(20)
as
begin
	insert into CongThuc values(@mact,@MaSP,@MaNVL,@LuongNVL,@DonViTinh)
end

--proc themkh
go
create proc themkh @TenKH nvarchar(100),@SDT char(10)
as
begin
	declare @makh varchar(20)
	select @makh = max(Makh)+1 from khachhang
	set @makh = replicate(0,10-len(@makh))+ @makh
	insert into khachhang values(@makh,@tenkh,@SDT)
end

----proc themnv
go
create proc themnv @TenNV varchar(20),@SDT char(10),@DiaChi nvarchar(100) 
as
begin
	declare @manv varchar(20)
	select @manv = max(Manv) from nhanvien
	set @manv = right(@manv,3)+1
	set @manv= 'NV'+replicate(0,5-len(@manv))+ @manv
	insert into nhanvien values(@manv,@tennv,@sdt,@diachi)
end

------thêm nvl
create proc themnvl @tennvl nvarchar(100), @soluong int, @donvi nvarchar(20),@khoiluongtinh int,@donvitinh varchar(20)
as
begin
	declare @manvl varchar(20)
	select @manvl = max(Manvl) from nguyenvatlieu
	set @manvl = right(@manvl,4)+1
	set @manvl= 'NL'+replicate(0,6-len(@manvl))+ @manvl
	insert into nguyenvatlieu values(@manvl,@tennvl,@soluong,@donvi,@khoiluongtinh,@donvitinh)
end

----------------Thêm sản phẩm
create proc themsp @tensp nvarchar(100), @dongia decimal
as
begin
	declare @masp varchar(20)
	select @masp = max(Masp) from sanpham
	set @masp = right(@masp,4)+1
	set @masp= 'SP'+replicate(0,6-len(@masp))+ @masp
	insert into sanpham values(@masp,@tensp,@dongia)
end

---------------Thêm đơn hàng
create  proc themhoadon @ngayban date, @ghichu nvarchar(100),@tongtien int,@chietkhau int, @manv varchar(20),@makh varchar(20)
as
begin
	declare @mahd varchar(20)
	select @mahd = max(Mahd) from hoadon
	set @mahd = right(@mahd,4)+1
	set @mahd= 'HD'+replicate(0,4-len(@mahd))+ @mahd
	insert into hoadon values(@mahd,@ngayban, @ghichu, @tongtien, @chietkhau, @manv, @makh)
end
select * from hoadon
------thêm cthd
create proc themcthd @mahd varchar(20),@tensp nvarchar(50),@soluong int, @dongia decimal, @thanhtien decimal, @masp varchar(20)
as
begin
	insert into chitiethoadon values(@mahd,@tensp, @soluong, @dongia, @thanhtien, @masp)
end

----------thêm nhapnvl

create proc themnnvl @ngaynhap date, @tongtienhang decimal, @tongthanhtoan decimal, @congno decimal, @manv varchar(20)
as
begin
	declare @maphieu varchar(20)
	select @maphieu = max(Maphieu) from nhapnvl
	set @maphieu = right(@maphieu,5)+1
	set @maphieu = 'P'+replicate(0,6-len(@maphieu))+ @maphieu
	insert into nhapnvl values(@maphieu,@ngaynhap, @tongtienhang,@tongthanhtoan, @congno, @manv)
end

-------------thêm ctnnvl
select * from chitietNhapnvl 
create proc themctnnvl @maphieu varchar(20),@tennvl nvarchar(50),@soluongnhap int, @dongia decimal,@dvt nvarchar(20), @thanhtien decimal, @chietkhau int, @manvl varchar(20)
as
begin
	insert into chitietnhapnvl values( @maphieu, @tennvl, @soluongnhap, @dongia, @dvt, @thanhtien, @chietkhau, @manvl)
end

---sửa ct
create proc suact @mact varchar(20),@masp varchar(20),@manvl varchar(20),@luongnvl int, @donvitinh varchar(20)
as
begin
	update congthuc set  masp =@masp, manvl = @manvl, luongnvl= @luongnvl, donvitinh= @donvitinh where mact =@mact
end

--sửa nv
create proc suanv @manv varchar(20),@tennv nvarchar(100),@sdt char(10),@diachi nvarchar(100)
as
begin
	update nhanvien set  tennv =@tennv, sdt = @sdt, diachi= @diachi where manv = @manv
end

--sửa kh
create proc suakh @makh varchar(20),@tenkh nvarchar(100),@sdt char(10)
as
begin
	update khachhang set  tenkh =@tenkh, sdt = @sdt where makh = @makh
end

--sửa nvl
create proc suanvl @manvl varchar(20),@tennvl nvarchar(100),@soluong int, @donvi nvarchar(20),@khoiluongtinh int, @donvitinh varchar(20)
as
begin
	update nguyenvatlieu set  tennvl =@tennvl, soluong = @soluong, donvi = @donvi, khoiluongtinh = @khoiluongtinh, donvitinh = @donvitinh where manvl = @manvl
end

--sửa nhập nvl
create proc suannvl @maphieu varchar(20), @ngaynhap date, @tongtienhang decimal, @tongthanhtoan decimal,@congno decimal,@manv varchar(20)
as
begin
	update nhapnvl set  ngaynhap = @ngaynhap,tongtienhang= @tongtienhang, tongthanhtoan = @tongthanhtoan ,congno = @congno, manv =@manv where maphieu=@maphieu
end

--sửa ctnnvl
create proc suactnnvl @maphieu varchar(20),@tennvl nvarchar(20),@soluongnhap int, @dongia decimal,@dvt nvarchar(20),@thanhtien decimal,@chietkhau int, @manvl varchar(20)
as
begin
	update chitietnhapnvl set tennvl = @tennvl ,soluongnhap = @soluongnhap, @dongia = @dongia,dvt = @dvt ,thanhtien = @thanhtien,chietkhau = @chietkhau where maphieu =@maphieu and manvl =@manvl
end

--sửa hóa đơn
create proc suahd @mahd varchar(20),@ngayban date, @ghichu nvarchar(100), @chietkhau int, @manv varchar(20), @makh varchar(20)
as
begin
	update hoadon set ngayban = @ngayban , ghichu= @ghichu , chietkhau = @chietkhau, manv = @manv , makh = @makh where mahd= @mahd
end

--sửa cthd
create proc suacthd @mahd varchar(20),@tensp nvarchar(50),@soluong int, @dongia decimal, @thanhtien decimal, @masp varchar(20)
as
begin
	update chitiethoadon set tensp = @tensp, soluong = @soluong, dongia = @dongia, thanhtien = @thanhtien where mahd =@mahd and masp= @masp
end

--sửa sản phẩm
create proc suasp @masp varchar(20),@tensp nvarchar(100), @dongia decimal
as
begin
	update sanpham set  tensp =@tensp, dongia = @dongia where masp = @masp
end

------------------tính tổng tiền
create proc tongtien @mahd varchar(20)
as
begin
	declare @tongtien decimal
	select @tongtien = sum(soluong*dongia) from chitiethoadon where mahd = @mahd
end





