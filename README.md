# CSDLPT_QuanLyVatTu
Cơ sở dữ liệu phân tán - Quản Lí Vật Tư

ĐỀ TÀI MÔN  CƠ SỞ DỮ LIỆU PHÂN TÁN KHÓA 2016
Đề 2 . QUẢN LÝ NHẬP/XUẤT VẬT TƯ
Viết chương trình việc quản lý nhập/xuất vật tư của cửa hàng. 
Cho cơ sở dữ liệu QLVT, trong đó có các Table sau :
a.  Table ChiNhanh:
Field Name	Type	Constraint
MACN	nChar(10)	Primary key
ChiNhanh	nvarchar(100)	Unique
DIACHI	nvarchar(100)	
SoDT	nVarchar(15)	

b.  Table Nhanvien
Field Name	Type	Constraint
MANV	INT	Primary key
HO	nvarchar(40)	
TEN	nvarchar(10)	
DIACHI	nvarchar(100)	
NGAYSINH	DateTime	
LUONG	float	>=4000000
MACN	nChar(10)	FK

c.  Table Kho:
Field Name	Type	Constraint
MAKHO	nChar(4)	Primary Key 
TENKHO	nvarchar(30)	Unique
DIACHI	nvarchar(100)	
MACN	nChar(10)	FK
 
d. Table Vattu:
Field Name	Type	Constraint
MAVT	nChar(4)	Primary Key 
TENVT	nvarchar(30)	Unique
DVT	nvarchar(15)	

e. Table DatHang:
Field Name	Type	Constraint
MasoDDH	nChar(8)	Primary Key
NGAY	Date	Default : ngày hiện tại GetDate()
NhaCC	Nvarchar(100)	Tên công ty, nhà cung cấp hàng
MANV	int	Foreign key
MAKHO	nChar(4)	

f. Table CTDDH: chi tiết đơn hàng
Field Name	Type	Properties
MasoDDH	nChar(8)	Foreign key
MAVT	nChar(4)	Foreign key
SOLUONG	int	>0
DONGIA	float	>0
Khóa chính: MasoDDH +MAVT

g. Table PhieuNhap:
Field Name	Type	Constraint
MAPN	nChar(8)	Primary Key
NGAY	Date	Default: Getdate()
MasoDDH	nchar (8)	Foreign key, Unique
MANV	Int	Foreign key
MAKHO	nChar(4)	

h. Table CTPN: chi tiết phiếu nhập hàng
Field Name	Type	Properties
MAPN	nChar(8)	Foreign key
MAVT	nChar(4)	Foreign key
SOLUONG	int	>0
DONGIA	float	>=0
Khóa chính: MAPN +MAVT

i. Table PhieuXuat:
Field Name	Type	Constraint
MAPX	nChar(8)	Primary Key
NGAY	Date	Dafault: Getdate()
HOTENKH	nvarchar (100)	Họ tên khách hàng
MANV	Int	Foreign key
MAKHO	nChar(4)	

j. Table CTPX: chi tiết phiếu xuất
Field Name	Type	Properties
MAPX	nChar(8)	Foreign key
MAVT	nChar(4)	Foreign key
SOLUONG	int	>0
DONGIA	float	>=0
Khóa chính: MAPX +MAVT

Yêu cầu: 
Giả sử  công ty có  2 chi  nhánh: chi nhánh 1  (CN1), chi nhánh 2  (CN2) .
Phân tán cơ sở dữ liệu QLVT  ra làm 2 mảnh với điều kiện sau: 
-	QLVT được đặt trên server1: chứa thông tin của các phiếu phát sinh thuộc chi nhánh 1.
-	QLVT được đặt trên server2: chứa thông  tin của các phiếu phát sinh thuộc chi nhánh 2.
Viết chương trình tạo các Form và Report sau:

1. Lập các Form sau:
1.1. Nhập danh sách nhân viên : có các chức năng: Thêm, Xóa, Ghi, Undo, Reload, Chuyển chi nhánh , Thoát. Nhân viên thuộc chi nhánh nào thì chi nhánh đó nhập. Trên từng chi nhánh ta chỉ thấy được danh sách nhân viên thuộc chi nhánh đó.
1.2. Nhập danh mục vật tư: Thêm, Xóa, Ghi, Undo, Reload , Thoát. 
1.3. Nhập danh mục kho: Thêm, Xóa, Ghi, Undo, Reload , Thoát. Kho thuộc chi nhánh nào thì chi nhánh đó nhập. Trên từng chi nhánh ta chỉ thấy được danh sách Kho thuộc chi nhánh đó.
1.4. Đơn đặt hàng: trình bày form dưới dạng SubForm. Nhân viên thuộc chi nhánh nào thì lập đơn đặt hàng của chi nhánh đó. Trên từng chi nhánh ta chỉ thấy được danh sách các đơn đặt hàng của chi nhánh đó.
1.5.Phiếu nhập/xuất vật tư: trình bày form dưới dạng SubForm. Nhân viên thuộc chi nhánh nào thì nhập dữ liệu nhập/xuất của chi nhánh đó. Trên từng chi nhánh ta chỉ thấy được danh sách các phiếu nhập/xuất của chi nhánh đó.
Phiếu nhập hàng chỉ lập khi có đơn đặt hàng, và không cho nhập quá số lượng đã đặt.  
 
2. Phân quyền: Chương trình có 3 nhóm : Công ty , ChiNhanh, User
-  Nếu login thuộc nhóm CongTy thì login đó có thể đăng nhập vào bất kỳ chi nhánh nào để xem số liệu bằng cách chọn tên chi nhánh, và chỉ có các chức năng sau:
 + Chỉ có thể xem dữ liệu của phân mảnh tương ứng.
 	 + Xem được các báo cáo.
	 + Tạo login thuộc nhóm Congty
-  Nếu login thuộc nhóm ChiNhanh thì chỉ cho phép toàn quyền làm việc trên chi nhánh đó , không được log vào chi nhánh khác ; Tạo login thuộc nhóm ChiNhanh, User .
- Nếu login thuộc nhóm User thì chỉ được quyền cập nhật dữ liệu, không được tạo tài khoản mới cho hệ thống.
Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn gì. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh. 

3. Lập các báo biểu:
3.1. In danh sách nhân viên: Tùy thuộc vào quyền hạn của login mà ta cho phép chọn công ty – chi nhánh để in theo thứ tự tăng dần tên + họ
 Nếu login thuộc nhóm Công ty thì ta cho chọn tên chi nhánh và tìm dữ liệu trên phân mảnh tương ứng để in. 
 Nếu login thuộc nhóm ChiNhánh thì ta cho lấy dữ liệu trên phân mảnh tương ứng để in.
3.2. In danh mục vật tư: theo thứ tự tên vật tư tăng dần của cả công ty
3.3. In Bảng kê chi tiết số lượng – trị giá hàng nhập hoặc xuất theo từng tháng trong 1 khoảng thời gian do người sử dụng chọn. 
Dữ liệu in ra sẽ thuộc chi nhánh tương ứng với nhân viên khi login vào. Nếu login vào thuộc nhóm Công ty thì dữ liệu sẽ là dữ liệu tổng hợp của cả 2 chi nhánh. Kết xuất: 
Tháng/năm       Tên vật tư        Tổng số lượng            Tổng trị giá

3.4. In Danh sách các đơn đặt hàng chưa có phiếu nhập. Kết xuất:
      Mã số ĐĐH  Ngày lập     Nhà cung cấp  Họ tên nhân viên  
           Tên vật tư     Số lượng đặt     Đơn giá
           
3.5. Báo cáo tình hình hoạt động của 1 nhân viên: báo cáo được nhóm theo từng tháng
 
3.6. Lập Report tên ‘TONG HOP NHAP XUAT’ để:
- Tổng hợp số tiền Nhập và Xuất trong từng ngày
- Mỗi ngày chỉ thể hiện một dòng
- Tổng hợp trong khoảng thời gian nào
- Mỗi ngày phải cho biết tỷ lệ % so với tổng số.
- Cuối cùng phải cho biết tổng số tiền trong khoảng thời gian mà ta chỉ ra.
Mẫu in có dạng:
BẢNG TỔNG HỢP NHẬP XUẤT
TỪ dd/mm/yy ĐẾN dd/mm/yy
NGÀY	NHẬP	TỶ LỆ	XUẤT	TỶ LỆ
dd/mm/yyyy	#,##0.0	0.00%	#,##0.0	0.00%
dd/mm/yyyy	#,##0.0	0.00%	#,##0.0	0.00%
….				
CỘNG	#,##0.0		#,##0.0	
 Ghi chú: 
- Sinh viên tự kiểm tra các ràng buộc có thể có khi viết chương trình.
 - Thực hiện các lệnh truy vấn dưới dạng Stored Procedure.



