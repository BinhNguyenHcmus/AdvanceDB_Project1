--USE MASTER
--DROP DATABASE DB_QLCH_ADB1_14

CREATE DATABASE DB_QLCH_ADB1_14
GO
USE DB_QLCH_ADB1_14

CREATE TABLE KHACHHANG
(
	MAKH CHAR(8),
	HO NVARCHAR(30),
	TEN NVARCHAR(20),
	NGSINH DATE,
	SONHA VARCHAR(20),
	DUONG NVARCHAR(50),
	PHUONG NVARCHAR(30),
	QUAN NVARCHAR(20),
	TPHO NVARCHAR(20),
	DIENTHOAI CHAR(10),
	CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH)
)

CREATE TABLE HOADON
(
    MAHD CHAR(8),
    MAKH CHAR(8),
    NGAYLAP DATE,
    TONGTIEN INT,
    CONSTRAINT PK_HOADON PRIMARY KEY (MAHD)
)

CREATE TABLE CT_HOADON
(
    MAHD CHAR(8),
    MASP CHAR(8),
    SOLUONG SMALLINT,
    GIABAN INT,
    GIAGIAM INT,
    THANHTIEN INT,
    CONSTRAINT PK_CTHD PRIMARY KEY (MAHD,MASP)
)

CREATE TABLE SANPHAM
(
    MASP CHAR(8),
    TENSP VARCHAR(1000),
    SOLUONGTON INT,
    MOTA VARCHAR(8000),
    GIA INT,
    CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP)
)

ALTER TABLE HOADON
ADD
CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)

ALTER TABLE CT_HOADON
ADD 
CONSTRAINT FK_CTHD_SAN_PHAM FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
CONSTRAINT FK_CTHD_HOA_DON FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)