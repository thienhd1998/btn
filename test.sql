--====================
--Author: <Hoàng Đình Phôn>
--Create Date : 09/11/2018
--descrip

create database QLSV
go
use QLSV
go
create table DoiTuongUuTien
(
	Ma int identity(1,1) primary key,
	Ten nvarchar(50),
	GhiChu nvarchar(500)
)
go
alter proc sp_DoiTuongUuTien_Insert
	@Ten nvarchar(50),
	@GhiChu nvarchar(500)
as
begin
	insert into DoiTuongUuTien(Ten,GhiChu)
	values(@Ten,@GhiChu)
	
	print @@identity  
end
go
sp_DoiTuongUuTien_Insert N'Đối Tượng 3',N'Thêm đối tượng lần 3'
go
create proc sp_DoiTuongUuTien_Update
	@Ten nvarchar(50),
	@GhiChu nvarchar(500),
	@Ma int
as
begin
	Update DoiTuongUuTien
	set Ten = @Ten,
		GhiChu = @GhiChu
	where Ma = @Ma
end
go
sp_DoiTuongUuTien_Update N'Nguyễn Văn A',N'Đối tượng 1',1
go
create proc sp_DoiTuongUuTien_Delete
	@Ma int
as
begin
	delete from DoiTuongUuTien
	where Ma = @Ma
end
go
sp_DoiTuongUuTien_Delete 3
go
alter proc sp_DoiTuongUuTien_Select
as
begin
	
	select Ma as [Mã],Ten as [Đây là tên],GhiChu as[Ghi chú]
	from DoiTuongUuTien
	order by Ma
end
go
sp_DoiTuongUuTien_Select
go
create table HSSV
(
	
)
--cho 1 bảng hóa đơn gồm mã hóa đơn ngày bán,số phiếu mã khách 
-- chi tiết hóa đơn gồm mã chi tiết,mã hóa đơn mã vật tư số lượng đơn giá
-- liệt kê tất cả các mặt hàng được bán trong khoảng thời gian từ ngày đến ngày
-- tìm tất cả các vật tư có số lượng xuất ra là nhiều nhất
-- đếm các hóa đơn bán hàng cho khách hàng sắp xếp theo giảm dần theo số lượng hóa đơn
-- giả sử có danh sách khách hàng liệt kê các khách hàng trong khoảng thời gian từ ngày đến ngày k có các hoạt động giao dịch
-- lập bảng thống kê các vật tư đã xuất trong khoảng từ ngày đến ngày sắp xếp theo chiều giảm dần về số lượng
-- tìm các hóa đơn có tổng doanh thu của hóa đơn là lớn nhất

create database HD
go
use HD
go
create table Hoadon
(
	mahd int identity (1,1) primary key,
	ngayban date,
	sophieu int,
	makhach int,
)
go
create table hoadon_chitiet
(
	Machitiet int identity(1,1) primary key,
	mahd int references hoadon(mahd),
	mavattu int,
	soluong int,
	dongia int
)
go
create table khachhang
(
	makhach int identity primary key,
	tenkhach nvarchar(90),
	ghichu nvarchar(550)
)
go
create table vattu
(
	mavattu int identity primary key,
	tenvattu nvarchar(50)
)
go
create proc sp_Baocao_TKHD_TheoThoiGian
@tungay date,
@denngay date
as
begin
	select mahd,ngayban,sophieu,makhach
	from hoadon
	where ngayban between @tungay and @denngay
end
go

create proc sp_ThongkeKH_Khongmuahang

@tungay date,
@denngay date
as
begin
	select makhach,tenkhach,ghichu
	from khachhang
	where makhach not in
	(
		select mahd,ngayban,sophieu,makhach
		from hoadon
		where ngayban between @tungay and @denngay
		)
end
go

alter proc sp_BaocaothongkevattuNN
as
begin
	select  t.mavattu,tenvattu,SUM(soluong)as sl
	from vattu t,hoadon_chitiet
	where t.mavattu = hoadon_chitiet.mavattu
	group by t.mavattu,tenvattu
	having SUM(soluong) = (select MAX(so_luong_tong) from
								(	select mavattu,SUM(soluong) as so_luong_tong
									from hoadon_chitiet
									group by mavattu
								) a)
	order by sl
end	
go
sp_BaocaothongkevattuNN
