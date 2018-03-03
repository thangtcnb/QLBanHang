--use QuanLyBanHang;
--sselect * from QuanLyBanHang.sys.database_files


alter database Quanlybanhang set offline;
go

alter database quanlybanhang 
modify file 
(
	name = 'Quanlybanhang', filename='E:\QLBanHang\data\QuanLyBanHang.mdf'
)
go

alter database quanlybanhang 
modify file 
(
	name = 'Quanlybanhang_Log', filename='E:\QLBanHang\data\QuanLyBanHang_log.ldf'
)
go

alter database Quanlybanhang set online;
go
--C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\QuanLyBanHang.mdf
--C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\QuanLyBanHang_log.ldf