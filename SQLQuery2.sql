create database KhuVuiChoi
go
use KhuVuiChoi
go

-- Phòng ban
-- Nhân viên 
-- Khu vui chơi
-- Trò chơi
-- Dịch vụ
-- Vé
-- Hóa đơn

create table ACCOUNT
(
	username nchar(30) primary key,
	pass nchar(30) not null
)
create table PHONGBAN
(
	MaPB nchar(10) primary key,
	TenPB nvarchar(50),
	MaTP nchar(10),
	NgayNC date,
	DiaDiem nvarchar(50)
)
create table KHUTROCHOI
(
	MaKhu nchar(10) primary key,
	TenKhu nvarchar(50),
	GiaTreEm int,
	GiaNguoiLon int,
	GioMoCua time,
	GioDongCua time
)
create table TROCHOI
(
	MaTro nchar(10) primary key,
	TenTro nvarchar(50),
	MaKhu nchar(10) references KHUTROCHOI(MaKhu)
)
create table DICHVU
(
	MaDV nchar(10) primary key,
	TenDV nvarchar(50),
	GiaDV int,
	MaKhu nchar(10) references KHUTROCHOI(MaKhu)
	
)
create table NHANVIEN
(
	STT int identity,
	MaNV nchar(10) primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3) check (GioiTinh in (N'Nam',N'Nữ')),
	QueQuan nvarchar(50),
	ChucVu nvarchar(50),
	Luong int,
	MaPB nchar(10) references PHONGBAN(MaPB),
	MaKhu nchar(10) references KHUTROCHOI(MaKhu),
	MaTro nchar(10) references TROCHOI(MaTro)
)
create table VE
(
	MaVe nchar(10) primary key,
	NgayBan datetime,
	SLTE int,
	SLNL int,
	TongThu int,
	MaNV nchar(10) references NHANVIEN(MaNV),
	MaKhu nchar(10) references KHUTROCHOI(MaKhu)
)
create table HOADON
(
	MaHD nchar(10) primary key,
	TenKH nvarchar(50),
	NgaySD datetime,
	MaDV nchar(10) references DICHVU(MaDV)
)
create table HOADON_DICHVU
(	
	MaHD nchar(10) references HOADON(MaHD),
	MaDV nchar(10) references DICHVU(MaDV),
	SoLuong int,
	ThanhTien int,
	primary key (MaHD,MaDV)
)
alter table PHONGBAN add
constraint TP_NV foreign key (MaTP) references NHANVIEN(MaNV)
alter table HOADON add NgaySD date
alter table HOADON add ThanhTien int

alter table HOADON drop constraint FK__HOADON__MaDV__239E4DCF
insert into PHONGBAN
values ('PB01',N'Giám đốc',NULL,NULL,N'phòng A812 tầng 8 tòa nhà A'),
('PB02',N'Hành chính nhân sự',NULL,NULL,N'phòng A310 tầng 3 tòa nhà A'),
('PB03',N'Kinh doanh',NULL,NULL,N'phòng A419 tầng 4 tòa nhà A'),
('PB04',N'Kỹ thuật',NULL,NULL,N'phòng A212 tầng 2 tòa nhà A'),
('PB05',N'Y tế',NULL,NULL,N'phòng B101 tầng 1 toàn nhà B'),
('PB06',N'Kế toán',NULL,NULL,N'phòng B504 tầng 5 tòa nhà B'),
('PB07',N'Điều hành',NULL,NULL,N'phòng A701 tầng 7 tòa nhà A'),
('PB08',N'Bảo vệ & Tạp vụ',NULL,NULL,N'phòng B110 tầng 1 tòa nhà B')

insert into KHUTROCHOI
values ('K01',N'Công viên nước Blue-Star',130000,200000,'06:00','18:00'),
('K02',N'Công viên mặt trời Sun Club',70000,100000,'06:00','18:00'),
('K03',N'Khu vui chơi trong nhà Vina House',50000,70000,'06:00','21:00')

select * from ACCOUNT where usename = 'admin' and password = N'' OR 1 = 1 --

insert into NHANVIEN
values ('NV01',N'Nguyễn Thị Phương Chi','12/22/1989',N'Nữ',N'Hà Nội',N'Giám đốc điều hành',25000000,'PB07',NULL,NULL),
('NV02',N'Tạ Quang Chí','12/19/1969',N'Nam',N'Hà Nội',N'Tổng giám đốc',1000000000,'PB01',NULL,NULL),
('NV03',N'Nguyễn Sỹ Chiến','12/05/1989',N'Nam',N'Hà Nội',N'Trợ lý giám đốc',15000000,'PB01',NULL,NULL),
('NV04',N'Nguyễn Văn Dũng','12/19/1989',N'Nam',N'Hà Nội',N'Trưởng phòng HCNS',20000000,'PB02',NULL,NULL),
('NV05',N'Nguyễn Nam Dương','11/15/1990',N'Nam',N'Hải Dương',N'Nhân viên',7000000,'PB02',NULL,NULL),
('NV06',N'Trần Tiến Đạt','10/12/1991',N'Nam',N'Ninh Bình',N'Nhân viên',7000000,'PB02',NULL,NULL),
('NV07',N'Nguyễn Hương Giang','07/06/1991',N'Nữ',N'Hà Nội',N'Nhân viên',6500000,'PB02',NULL,NULL),
('NV08',N'Nguyễn Trung Hiếu','06/28/1990',N'Nam',N'Hà Nội',N'Nhân viên',7500000,'PB02',NULL,NULL),
('NV09',N'Phạm Trung Hiếu','06/08/1988',N'Nam',N'Thái Bình',N'Trưởng phòng kinh doanh',25000000,'PB03',NULL,NULL),
('NV10',N'Nguyễn Văn Hoàn','04/16/1992',N'Nam',N'Hưng Yên',N'Nhân viên',7000000,'PB03',NULL,NULL)

go
insert into TROCHOI
values ('T01',N'Cầu trượt nước','K01'),
('T02',N'Đường ống tối tăm','K01'),
('T03',N'Bể bơi sóng','K01'),
('T04',N'Nhảy cầu','K01'),
('T05',N'Dòng chảy hiền hòa','K01'),
('T06',N'Bể bơi trẻ em','K01'),
('T07',N'Tàu lượn siêu tốc','K02'),
('T08',N'Đu quay bạch tuộc','K02'),
('T09',N'Đu quay xoắn','K02'),
('T10',N'Đu quay dây văng','K02'),
('T11',N'Xe đụng','K02'),
('T12',N'Tàu hỏa','K02'),
('T13',N'Nhà bóng','K03'),
('T14',N'Nhà phao','K03'),
('T15',N'Nhà liên hoàn ','K03'),
('T16',N'Cầu trượt','K03'),
('T17',N'Bắn bóng','K03'),
('T18',N'Nghịch cát','K03'),
('T19',N'Nhà ma','K03'),
('T20',N'Bắn cá','K03')

insert into DICHVU
values ('DV01',N'Cho thuê đồ tắm','30000','K01'),
('DV02',N'Cho thuê kính bơi','20000','K01'),
('DV03',N'Đồ ăn nhanh','15000','K01'),
('DV04',N'Đồ ăn nhanh','15000','K02'),
('DV05',N'Chụp ảnh lưu niệm','50000','K01'),
('DV06',N'Chụp ảnh lưu niệm','50000','K02'),
('DV07',N'Bán xèng','3000','K03'),
('DV08',N'Game center','30000','K02'),
('DV09',N'Tạp hóa lưu niệm','30000',NULL),
('DV10',N'Buffet ','250000',NULL)
go

create proc LoadAccount(@useName nvarchar(50))
as
begin
	select * from ACCOUNT where usename = @useName
end
go

LoadAccount 'admin'
go

alter proc LoadNV
as
begin
	select MaNV as[Mã NV],HoTen as[Họ và Tên],NgaySinh as[Ngày Sinh],GioiTinh as[Giới Tính],QueQuan as[Quê Quán],ChucVu as[Chức vụ],Luong as[Lương],MaPB as[Mã PB],MaKhu as[Mã Khu],MaTro as[Mã Trò] from NHANVIEN	
end
go
LoadNV

go


alter proc Login(@useName nvarchar(50),@passWord nvarchar(50))
as
begin
	select * from ACCOUNT where usename = @useName and password = @passWord
end
go
Login 'admin','123'
go
create proc LoadService
as
begin 
	select MaDV as [Mã DV],TenDV as [Tên DV],GiaDV as[Giá DV],MaKhu as[Mã Khu]
	from DICHVU
end