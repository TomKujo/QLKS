CREATE DATABASE QLKS
GO
USE QLKS
GO
CREATE TABLE Phong
(
	MaPhong SMALLINT PRIMARY KEY,
	TinhTrang NVARCHAR(50) NOT NULL,
	Hang NVARCHAR(50) NOT NULL,
	SoGiuong TINYINT NOT NULL,
	Gia INT NOT NULL,
	DatTruoc NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE KhachHang
(
	MaKH SMALLINT PRIMARY KEY,
	TenKH NVARCHAR(100) NOT NULL,
	SDT BIGINT UNIQUE NOT NULL,
	QuocTich NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	NgaySinh DATE NOT NULL,
	CCCD BIGINT UNIQUE NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	ThoiGianNhanPhong DATETIME NOT NULL,
	ThoiGianTraPhong DATETIME NOT NULL,
	MaPhong SMALLINT NOT NULL FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON DELETE CASCADE
)
GO
CREATE TABLE NhanVien
(
	MaNV SMALLINT PRIMARY KEY,
	TenNV NVARCHAR(100) NOT NULL,
	SDT BIGINT UNIQUE NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	TK NVARCHAR(50) UNIQUE NOT NULL,
	MK NVARCHAR(50) UNIQUE NOT NULL
)
INSERT INTO Phong VALUES
(1, N'Không trống', N'Phổ thông', 1, 200000, N'Chưa đặt trước'),
(2, N'Không trống', N'Thương gia', 2, 500000, N'Đã đặt trước'),
(3, N'Trống', N'Phổ thông', 3, 600000, N'Chưa đặt trước'),
(4, N'Trống', N'Thương gia', 4, 1000000, N'Đã đặt trước'),
(5, N'Trống', N'Phổ thông', 5, 1000000, N'Chưa đặt trước'),
(6, N'Trống', N'Thương gia', 1, 250000, N'Đã đặt trước'),
(7, N'Trống', N'Phổ thông', 2, 400000, N'Chưa đặt trước'),
(8, N'Trống', N'Thương gia', 3, 750000, N'Đã đặt trước'),
(9, N'Trống', N'Phổ thông', 4, 800000, N'Chưa đặt trước'),
(10, N'Trống', N'Thương gia', 5, 1250000, N'Đã đặt trước')
SELECT * FROM Phong
INSERT INTO KhachHang VALUES
(1, N'Nguyễn Văn A', 1000000000, N'Việt Nam', 'Nam', '2000-01-01', 100000000000, '1 A, A, A', '2020-01-01 00:00:00', '2020-01-02 00:00:00', 1),
(2, N'Nguyễn Văn B', 1000000001, N'Trung Quốc', N'Nữ', '2001-02-02', 100000000001, '2 B, B, B', '2021-02-02 01:01:01', '2021-02-03 01:01:01', 2)
SELECT * FROM KhachHang
INSERT INTO NhanVien VALUES
(1, N'Nguyễn Văn C', 1000000002, 'Nam', 'NguyenVanC', 'NguyenVanC'),
(2, N'Nguyễn Văn D', 1000000003, N'Nữ', 'NguyenVanD', 'NguyenVanD'),
(3, N'Nguyễn Văn E', 1000000004, 'Nam', 'NguyenVanE', 'NguyenVanE'),
(4, N'Nguyễn Văn F', 1000000005, N'Nữ', 'NguyenVanF', 'NguyenVanF'),
(5, N'Nguyễn Văn G', 1000000006, 'Nam', 'NguyenVanG', 'NguyenVanG'),
(6, N'Nguyễn Văn H', 1000000007, N'Nữ', 'NguyenVanH', 'NguyenVanH'),
(7, N'Nguyễn Văn I', 1000000008, 'Nam', 'NguyenVanI', 'NguyenVanI'),
(8, N'Nguyễn Văn J', 1000000009, N'Nữ', 'NguyenVanJ', 'NguyenVanJ'),
(9, N'Nguyễn Văn K', 1000000010, 'Nam', 'NguyenVanK', 'NguyenVanK'),
(10, N'Nguyễn Văn L', 1000000011, N'Nữ', 'NguyenVanL', 'NguyenVanL')
SELECT * FROM NhanVien