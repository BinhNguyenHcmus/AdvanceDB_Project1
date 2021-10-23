USE DB_QLCH_ADB1_14
GO

-- Cho danh sách các hoá đơn lập trong năm 2020
SELECT *
FROM HOADON
WHERE YEAR(NGAYLAP)=2020

-- Cho danh sách các khách hàng ở TPHCM
SELECT *
FROM KHACHHANG
WHERE TPHO=N'TPHCM'

-- Cho danh sách các sản phẩm có giá trong một khoảng từ….đến
CREATE FUNCTION fn_PRODUCTSFILTERBYPRICE(@TOP INT, @BOTTOM INT)
RETURNS int
AS 
BEGIN 
	RETURN(SELECT * FROM SANPHAM WHERE GIA <= @TOP AND GIA >= @BOTTOM)
END
GO
PRINT dbo.fn_PRODUCTSFILTERBYPRICE(10, 100)
GO
-- Cho danh sách các sản phẩm có số lượng tồn < 100
SELECT * FROM SANPHAM WHERE SOLUONGTON < 100


-- Cho danh sách các sản phẩm bán chạy nhất (số lượng bán nhiều nhất)

-- Cho danh sách các sản phẩm có doanh thu cao nhất