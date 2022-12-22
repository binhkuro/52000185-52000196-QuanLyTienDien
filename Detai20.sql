-- Đề tài số 20 - Phần mềm tính tiền điện
use master
go
-- Tạo cơ sở dữ liệu tính tiền điện
if exists(select * from sysdatabases where name = 'TinhTienDien')
    drop database TinhTienDien
go
create database TinhTienDien
go
-- Sử dụng cơ sở dữ liệu tính tiền điện để tạo bảng và thực hiện các thao tác phía dưới:
use TinhTienDien
go
-- Tạo bảng khách hàng
if exists(select * from sysobjects where name = 'KhachHang')
    drop table KhachHang
go
create table KhachHang
(
	MaKH char(10) not null primary key,
	DiaChi nvarchar(50) not null,
	SoDienThoai char(10) not null
)
go

-- Tạo bảng khu vực
if exists(select * from sysobjects where name = 'KhuVuc')
    drop table KhuVuc
go
create table KhuVuc
(
	MaKhuVuc char(10) not null primary key,
	TenKhuVuc nvarchar(50) not null,
	QuanHuyen nvarchar(50) not null
)
go

-- Tạo bảng điện kế
if exists(select * from sysobjects where name = 'DienKe')
    drop table DienKe
go
create table DienKe
(
	MaDienKe char(10) not null primary key,
	HieuDienThe int,
	MaKH char(10) not null,
	MaKhuVuc char(10) not null,
	NuocSanXuat nvarchar(50) not null,
	GhiChu nvarchar(50)
	Constraint DienKe_MaKH_FK foreign key (MaKH) references KhachHang(MaKH),
	Constraint DienKe_MaKhuVuc_FK foreign key (MaKhuVuc) references KhuVuc(MaKhuVuc)
)
go

-- Tạo bảng hóa đơn
if exists (select * from sysobjects where name = 'HoaDon')
	drop table HoaDon
go
create table HoaDon
(
	SoHoaDon char(10) primary key,
	ThanhTien decimal not null,
	Thang int not null,
	MaDienKe char(10),
	Constraint HoaDon_MaDienKe_FK foreign key (MaDienKe) references DienKe(MaDienKe)
)
go

-- Tạo bảng đơn giá
if exists (select * from sysobjects where name = 'DonGia')
	drop table DonGia
go
create table DonGia
(
	MaDonGia char(10) primary key,
	TuKW int,
	DenKW int,
	SoTien money not null,
	GhiChu nvarchar(50)
)
go

-- Tạo bảng chi tiết hóa đơn
if exists (select * from sysobjects where name = 'ChiTietHoaDon')
	drop table ChiTietHoaDon
go
create table ChiTietHoaDon
(
	SoHoaDon char(10) not null,
	MaDonGia char(10) not null,
	SoLuongKW int not null
)
go

alter table ChiTietHoaDon add constraint CTHD_PK primary key (SoHoaDon, MaDonGia)
alter table ChiTietHoaDon add constraint CTHD_MaDonGia_FK foreign key (MaDonGia) references DonGia(MaDonGia)
alter table ChiTietHoaDon add constraint CTHD_SoHoaDon_FK foreign key (SoHoaDon) references HoaDon(SoHoaDon)

-- Thêm dữ liệu cho bảng khách hàng:
insert into KhachHang values('KH01', N'156, Lý Thường Kiệt, phường 14, quận 10, TP HCM', '0967321459')
insert into KhachHang values('KH02', N'321, Dương Bá Trạc, phường 2, quận 8, TP HCM', '0342657852')
insert into KhachHang values('KH03', N'460, Nguyễn Đình Chiểu, phường 6, quận 3, TP HCM', '0289367814')
insert into KhachHang values('KH04', N'527, Trần Hưng Đạo, phường 11, quận 1, TP HCM', '0721890145')
insert into KhachHang values('KH05', N'289, Lê Đại Hành, phường 7, quận 11, TP HCM', '0833941658')
select * from KhachHang

-- Thêm dữ liệu cho bảng khu vực:
insert into KhuVuc values('KV01', N'Khu vực 1', N'Quận 1')
insert into KhuVuc values('KV02', N'Khu vực 2', N'Quận 2')
insert into KhuVuc values('KV03', N'Khu vực 3', N'Quận 3')
insert into KhuVuc values('KV04', N'Khu vực 4', N'Quận 4')
insert into KhuVuc values('KV05', N'Khu vực 5', N'Quận 5')
insert into KhuVuc values('KV06', N'Khu vực 6', N'Quận 6')
insert into KhuVuc values('KV07', N'Khu vực 7', N'Quận 7')
insert into KhuVuc values('KV08', N'Khu vực 8', N'Quận 8')
insert into KhuVuc values('KV09', N'Khu vực 9', N'Quận 9')
insert into KhuVuc values('KV10', N'Khu vực 10', N'Quận 10')
insert into KhuVuc values('KV11', N'Khu vực 11', N'Quận 11')
select * from KhuVuc

-- Thêm dữ liệu cho bảng điện kế: 
insert into DienKe values('DK01', 220, 'KH02', 'KV08', N'Nhật Bản', N'Sử dụng lâu dài')
insert into DienKe values('DK02', 480, 'KH05', 'KV11', N'Trung Quốc', N'Made in China')
insert into DienKe values('DK03', 720, 'KH01', 'KV10', N'Đài Loan', N'Chất lượng chuẩn Châu Âu')
insert into DienKe values('DK04', 110, 'KH03', 'KV03', N'Hàn Quốc', N'Điện kế của mọi nhà')
insert into DienKe values('DK05', 360, 'KH04', 'KV01', N'Singapore', N'Đạt tiêu chuẩn 5 sao Châu Á')
select * from DienKe

-- Thêm dữ liệu cho bảng hóa đơn
insert into HoaDon values ('HD01', 500000, 8, 'DK01')
insert into HoaDon values ('HD02', 700000, 8, 'DK02')
insert into HoaDon values ('HD03', 300000, 8, 'DK03')
insert into HoaDon values ('HD04', 1000000, 8, 'DK04')
insert into HoaDon values ('HD05', 1500000, 8, 'DK05')
select * from HoaDon

-- Thêm dữ liệu cho bảng đơn giá:
insert into DonGia values ('DG01', 0, 50, 1678, N'')
insert into DonGia values ('DG02', 51, 100, 1734, N'')
insert into DonGia values ('DG03', 101, 200, 2014, N'')
insert into DonGia values ('DG04', 201, 250, 2536, N'')
insert into DonGia values ('DG05', 301, 400, 2834, N'')
insert into DonGia values ('DG06', 401, null, 2927, N'')
select * from DonGia

-- Thêm dữ liệu cho bảng chi tiết hóa đơn:
insert into ChiTietHoaDon values ('HD01', 'DG01', 50)
insert into ChiTietHoaDon values ('HD01', 'DG02', 20)
insert into ChiTietHoaDon values ('HD02', 'DG01', 35)
insert into ChiTietHoaDon values ('HD03', 'DG01', 50)
insert into ChiTietHoaDon values ('HD03', 'DG02', 50)
insert into ChiTietHoaDon values ('HD03', 'DG03', 2)
select * from ChiTietHoaDon