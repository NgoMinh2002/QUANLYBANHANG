--- tạo bảng đang nhập
 Create table [dbo].[Dangnhap](
[taikhoan] nvarchar(16) Primary key,
[matkhau] varchar(16) not null,
[loainguoidung] int null
)
-- tạo bảng nhân viên
Create table [dbo].[NhanVien](
[MaNV] char(10) Primary key,
[TenNV] nvarchar(40)  null,
[Gioitinh] nchar(3) null,
[Diachi] nvarchar(40) null,
[Dienthoai] char(15) null,
[Ngaysinh] date null,
)
-----tạo bảng khách hàng.

Create table [dbo].[Khachhang](
[MaKhach] char(10) Primary key,
[TenKhach] nvarchar(30) null,
[Diachi] nvarchar(40) null,
[Dienthoai] char(25) null
)
------ tạo bảng nhà cung cấp
Create table [dbo].[NhaCC](
[STT]  int IDENTITY (1,1),
[MaNCC] char(10)  primary key ,
[TenNCC] nvarchar(30) null
)
-- tạo loại hàng.
Create table [dbo].[Loaihang](
[STT]  int IDENTITY (1,1),
[Maloai] char(10) Primary key,
[Tenloai] nvarchar(30) null,
)
----tạo bảng hàng hóa
Create table [dbo].[Hanghoa](
[MaHang] char(10)  Primary key,
[TenHang] nvarchar(max) null,
[Maloai] char(10) CONSTRAINT fk6 Foreign key references Loaihang(Maloai) on Delete Cascade on Update Cascade,
[MaNCC] char(10)  CONSTRAINT fk1 Foreign key references NhaCC(MaNCC) on Delete Cascade on Update Cascade,
[Soluong] int,
[Dongianhap] int,
[Dongiaban]	float,
)
--- bảng Tồn kho
Create table [dbo].[Tonkho_DK](
[Makho] char(10) Primary key,
[Tenkho] nvarchar(30) null,
[Mahang] char(10) CONSTRAINT fk7 Foreign key references Hanghoa(MaHang) on Delete Cascade on Update Cascade,
[Soluongton] int,
)
---  bảng nhập xuất hàng hóa
Create table [dbo].[Nhap_xuat](
[Mahang] char(10) CONSTRAINT fk8 Foreign key references Hanghoa(MaHang) on Delete Cascade on Update Cascade,
[Makho] char(10) CONSTRAINT fk10 Foreign key references Tonkho_DK(Makho) ,
[Ngay_NX] date,
[Loai_NX] bit,
[Soluong_NX] int
)
--- bảng hóa đon
Create table [dbo].[Hoadon](
[MaHDB] char(30)  Primary key,
[NgayBan] date,
[MaNV] char(10) CONSTRAINT fk2 Foreign key references NhanVien(MaNV) on Delete Cascade on Update Cascade, 
[MaKhach] char(10) CONSTRAINT fk3 Foreign key references Khachhang(MaKhach) on Delete Cascade on Update Cascade,
[Tongtien] float
)
Create table[dbo].[HoaDon_CT](
[MaHDB] char(30)  CONSTRAINT fk4 Foreign key references Hoadon(MaHDB) on Delete Cascade on Update Cascade,
[MaHang] char(10) CONSTRAINT fk5 Foreign key references Hanghoa(MaHang) on Delete Cascade on Update Cascade,
[Soluong] int,
[Dongiaban] float,
[GiamGia] float,
[ThanhTien] float,
)
insert into  Dangnhap  values('admin','admin123',1) 
insert into  Dangnhap  values('user1','123',2)
insert into  Dangnhap  values('user2','123',2)

insert into Khachhang values('KH01',N'Hoàng Thị Mai',N'23 Nguyễn Ngọc Vũ - Hà Nội','(029)382-3922') ,       
('KH02',N'Hoàng Văn Sơn',N'Hải Dương','(032) 323-4232     '      ),
('KH03',N'Nguyễn hoàng sơn',N'Hải Dương','(039) 823-2392 '       )   ,
('KH04',N'Trần Thị Hoa',N'Hà Nội','(093) 234-3432 ' ),
('KH05',N'Lê Thị Kim Oanh',	N'Hải Phòng	','(094) 389-2343' )     ,   
('KH06',N'Ngô Văn Minh',N'Bắc Giang','(094) 394-3345'  ) 

----nhập dữ liệu khách hàng
insert into NhanVien values('NV01', N'Nguyễn Văn Tùng', N'Nam',N'Hải Dương','(023) 232-3232 ','2002-12-12')
insert into NhanVien values('NV02',N'Nguyễn Thị Mai Anh',N'Nữ '	,N'Hà Nội',	'(022) 323-2423' 	,'2002-01-02')
insert into NhanVien values('NV03',N'Trần Văn Hùng',N'Nam',N'Hải Dương'	,'(092) 328-2394'	,'2002-12-04')
insert into NhanVien values('NV04',N'Phạm Văn Thắng',N'Nam',N'Hải Phòng'	,'(093) 223-2122 ',	'2002-11-04')
insert into NhanVien values('NV05',N'Lê Kim Sơn'	,N'Nam',N'	Bắc Ninh'	,'(039) 243-2443 '	,'2002-01-02')
insert into NhanVien values('NV06',N'Hoàng Thu Tuyền'	,N'Nữ' ,N'	Hà Giang'	,'(039) 232-2452 ','	2002-03-04')
-----nhà cung cấp
insert into NhaCC values('NCC01','Sony'),
('NCC02','Samsung'),
('NCC03','Lenovo'),
('NCC04','XiaoMi'),
('NCC05','Dell')
--- loại hàng
insert into Loaihang values('LH01','Điện Thoại'),
('LH02'  ,	'Máy Tính'),
('LH03' ,	'Tủ lạnh'),
('LH04' ,	'Máy Giặt'),
('LH05' ,	'Gia Dụng Điện')
 ---- nhập dữ liệu kho hàng
 insert into Tonkho_DK values('K01',N'Kho hàng 1','HH01',25)
 insert into Tonkho_DK values('K02',N'Kho hàng 2','HH02',22)
 insert into Tonkho_DK values('K03',N'Kho hàng 3','HH03',20)
 insert into Tonkho_DK values('K04',N'Kho hàng 4','HH04',23)
 ----  nhập dữ liệu hàng hóa
 SELECT *FROM Tonkho_DK
insert into Hanghoa values('HH01'  ,  N'	Samsung Galaxy S23 5G	','LH01'    ,'NCC02'	,20,5400000,5850000)
insert into Hanghoa values('HH02',N'Samsung Galaxy S23 Ultra 5G',	'LH01 ',	'NCC02' ,6,2400000,2600000)
insert into Hanghoa values('HH03',N' 	Lenovo Ideapad 3 15IAU7 i3 1215U','LH02','NCC03 ',10,2300000,	24916660)
insert into Hanghoa values('HH04',N'Laptop Lenovo Ideapad 3 15IAU7 i3','LH02','NCC03',   	14,4400000	,4840000)
insert into Hanghoa values('HH05'   , N'Laptop Lenovo Ideapad 5 15IAL7 i5',	'LH02'   ,  'NCC03',     	5,32000000,	35200000)
insert into Hanghoa values('HH06'    ,N'  	Xiaomi Redmi Note 11 (4GB/128GB)'	,'LH01','NCC04',    	13,34000000,	37400000)
insert into Hanghoa values(	'HH07'      	,N'Xiaomi Not11',	'LH01'      ,'NCC04'     	,12,	28000000,30800000)
--- nhập dữ liệu nhập - xuất
insert into Nhap_xuat values('HH01','K01','05/05/2023','1',23)
insert into Nhap_xuat values('HH01','K01','05/05/2023','2',24)
insert into Nhap_xuat values('HH02','K02','10/07/2023','1',22)
insert into Nhap_xuat values('HH02','K02','10/07/2023','2',21)
insert into Nhap_xuat values('HH03','K03','12/06/2023','2',29)
insert into Nhap_xuat values('HH03','K03','12/06/2023','1',23)
