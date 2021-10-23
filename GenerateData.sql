USE DB_QLCH_ADB1_14

-- import data from csv
-- remember to change path 
BULK INSERT CT_HOADON
FROM '\\Mac\AllFiles\Users\Study\temp\cthd.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '0x0a',   --Use to shift the control to next row
    TABLOCK
)

BULK INSERT SANPHAM
FROM '\\Mac\Home\Downloads\sanpham.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '0x0a',   --Use to shift the control to next row
    TABLOCK
)

BULK INSERT HOADON
FROM '\\Mac\Home\Downloads\hoadon.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '0x0a',   --Use to shift the control to next row
    TABLOCK
)

BULK INSERT KHACHHANG
FROM '\\Mac\Home\Downloads\data.csv'
WITH
(
    FIRSTROW = 2, -- as 1st one is header
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)

--alter data from foreign key just need to run only
UPDATE CT_HOADON 
SET GIABAN = (SELECT GIA FROM SANPHAM SP WHERE SP.MASP = CT_HOADON.MASP)

UPDATE CT_HOADON 
SET THANHTIEN = SOLUONG*(GIABAN - GIAGIAM)

UPDATE HOADON
SET TONGTIEN = (SELECT SUM(THANHTIEN)
				FROM CT_HOADON CT
				WHERE HOADON.MAHD = CT.MAHD
				GROUP BY MAHD)
--query 
--CHO DANH SÁCH CÁC HOÁ ĐƠN LẬP TRONG NĂM 2020
SELECT MAHD, NGAYLAP, TONGTIEN
FROM HOADON 
WHERE YEAR(NGAYLAP) = 2020
--CHO DANH SÁCH CÁC KHÁCH HÀNG Ở TPHCM
SELECT MAKH, HO +' '+ TEN as HOTEN, NGSINH, TPHO
FROM KHACHHANG
WHERE TPHO = N'TPHCM'
--CHO DANH SÁCH CÁC SẢN PHẨM CÓ GIÁ TRONG MỘT KHOẢNG TỪ___ ĐẾN ____(lay vd tu 1000 den 100000)
SELECT MASP, TENSP, GIA 
FROM SANPHAM 
WHERE GIA BETWEEN 100000 AND 1000000
--CHO DANH SÁCH CÁC SẢN PHẨM CÓ SỐ LƯỢNG TỒN <100
SELECT MASP, TENSP, SOLUONGTON
FROM SANPHAM 
WHERE SOLUONGTON < 100
--CHO DANH SÁCH CÁC SẢN PHẨM BÁN CHẠY NHẤT(SỐ LƯỢNG BÁN NHIỀU NHẤT)
SELECT TOP 10 SP.MASP, SP.TENSP, SUM(CT.SOLUONG) AS SOLUONGBAN 
FROM SANPHAM SP JOIN CT_HOADON CT ON SP.MASP = CT.MASP
GROUP BY SP.MASP, SP.TENSP
ORDER BY SUM(CT.SOLUONG) DESC

--CHO DANH SÁCH CÁC SẢN PHẨM CÓ DOANH THU CAO NHẤT 
SELECT TOP 10 SP.MASP, SP.TENSP, SUM(CT.THANHTIEN) AS DOANHTHU
FROM SANPHAM SP JOIN CT_HOADON CT ON SP.MASP = CT.MASP
GROUP BY SP.MASP, SP.TENSP
ORDER BY SUM(CT.THANHTIEN) DESC