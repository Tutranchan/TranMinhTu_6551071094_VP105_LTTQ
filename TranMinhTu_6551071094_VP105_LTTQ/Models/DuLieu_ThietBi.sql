GO
CREATE DATABASE DuLieu_ThietBi;
GO
 
USE DuLieu_ThietBi;
GO
 
CREATE TABLE ThietBi
(
    MaThietBi     nvarchar(10) NOT NULL PRIMARY KEY,
    TenThietBi    ntext        NOT NULL,
    DonGia  nvarchar(12)  NOT NULL
);
GO
 
INSERT INTO ThietBi (MaThietBi, TenThietBi, DonGia) VALUES
(N'TB001', N'Máy tính xách tay Dell', N'15.000.000'),
(N'TB002', N'Máy in HP LazerJet',   N'5.500.000'),
(N'TB003', N'Màn hình Samsung',     N'3.800.000'),
(N'TB004', N'Bàn phím cơ Logitech',   N'1.200.000'),
(N'TB005', N'Chuột không dây',  N'450.000');
GO