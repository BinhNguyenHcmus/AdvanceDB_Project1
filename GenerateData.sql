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

-- SAN PHAM CO GIA TU 100000 DEN 1000000
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

SELECT ISNULL(TONGTIEN, 0 ) FROM HOADON
