#### Đề tài: Quản lý điểm sinh viên hệ tín chỉ
#### Môn học: Cơ sở dữ liệu phân tán
#### Ngôn ngữ sử dụng: C#, DevExpress(lưu ý: khi cài devexpress thì cần tải phù hợp với phiên bản visual studio đang sử dụng để không bị xung đột)
#### Phần mềm tích hợp phát triển ứng dụng (IDE): Visual Studio 2019
#### Cơ sở dữ liệu: MS SQL SERVER 2019
#### Giáo viên hướng dẫn: Lưu Nguyễn Kỳ Thư

#### Những công việc cần làm trong đồ án này là:
~~~
Yêu cầu: Giả sử  trường có 2 khoa: công nghệ thông tin (CNTT),  và viễn thông (VT)
1.	Phân tán cơ sở dữ liệu QLDSV_HTC ra làm 3 mảnh với điều kiện sau: 
-	QLDSV được đặt trên server1: chứa thông tin của các sinh viên thuộc khoa công nghệ thông tin
-	QLDSV được đặt trên server2:  chứa thông tin của các sinh viên thuộc khoa viễn thông.
-	QLDSV được đặt trên server3:  chứa thông tin đóng học phí của các sinh viên của trường
Lưu ý: 
-	Lớp tín chỉ do khoa nào quản lý thì chỉ cho sinh viên khoa đó đăng ký. 
-	Một giảng viên có thể dạy các lớp tín chỉ thuộc cả 2 khoa

Viết chương trình thực hiện các công việc sau trên từng khoa:
a. Nhập liệu: gồm các công việc sau
- Nhập danh mục lớp: Form có các chức năng sau Thêm, Xóa, Ghi, Phục hồi, Thoát; Lớp thuộc khoa nào thì khoa đó nhập. Trên từng khoa ta chỉ thấy được danh sách lớp thuộc khoa đó.
- Nhập danh sách sinh viên: dưới dạng SubForm. Yêu cầu: giống như lớp
- Nhập môn học: trên form Nhập môn học có các nút lệnh : Thêm, Xóa,  Ghi, Phục hồi, Thoát
- Mở Lớp tín chỉ: có các chức năng Thêm, Xóa, Ghi, Phục hồi thông tin của lớp tín chỉ
- Đăng ký lớp tín chỉ: user nhập vào mã sinh viên của mình, chương trình tự động in ra các thông tin của sinh viên (họ, tên, mã lớp).  Kế tiếp, user nhập vào Niên khóa, Học kỳ, chương trình sẽ tự động lọc ra các lớp tín chỉ đã mở trong niên khóa, học kỳ đó để sinh viên đăng ký (chưa hủy). Dữ liệu in ra gồm : MAMH, TENMH, nhóm, Hoten GV giảng,  số sv đã đăng ký; (giao tác)
- Nhập điểm:  Điểm thuộc khoa nào thì khoa đó nhập hoặc PGV nhập. User nhập vào Niên khóa, Học kỳ, môn học, nhóm; click nút lệnh Bắt đầu thì chương trình tự động lọc ra các sinh viên có đăng ký trên lớp tín chỉ đó theo dạng sau, sau đó user chỉ nhập điểm vào. 
Điểm hết môn = Điểm CC * 0.1 + Điểm GK*0.3+ ĐCK * 0.6 
 
 
Mã SV	Họ tên SV	Điểm chuyên cần	Điểm giữa kỳ	Điểm cuối kỳ	Điểm hết môn
(read only)	(read only)				(tự động tính, read only)
					
    Sau khi nhập điểm thi xong, click nút lệnh ‘Ghi điểm’ thì mới ghi hết điểm về CSDL. 
-	Đóng học phí: login thuộc nhóm PkeToan mới được quyền vào module này. (Form này trình bày theo dạng SubForm). Khi user chọn 1 dòng trên lưới, thì sẽ tự động lọc ra chi tiết đóng học phí của niên khóa, học kỳ đó.
User nhập vào mã SV, chương trình tự động load lên họ tên, mã lớp và 1 bảng chứa tòan bộ thông tin đóng học phí của sinh viên ( theo thứ tự Niên khóa, học kỳ):

Niên khóa	Học kỳ	Học phí	Số tiền đã đóng	Số tiền cần đóng
 			(tự động tính, read only)	(tự động tính, read only)
Trên form này, User thêm vào thông tin niên khóa, học kỳ, học phí cả học kỳ, sau đó click nút Ghi để ghi dữ liệu vào DB; chi tiết đóng học phí sẽ có dạng sau:
Ngày đóng	Số tiền đóng
	

2. Phân quyền: Chương trình có các nhóm : PGV (phòng giáo vụ), KHOA, SV, PKT (phòng kế toán)
-  Nếu login thuộc nhóm PGV thì login đó có thể chọn bất kỳ khoa nào để toàn quyền làm việc bằng cách chọn tên khoa,  và tìm dữ liệu trên phân mảnh tương ứng. Login nhóm này được tạo tài khoản cho nhóm PGV, Khoa.  
-  Nếu login thuộc nhóm Khoa thì ta chỉ cho phép toàn quyền làm việc trên khoa đã đăng nhập   và tìm dữ liệu trên phân mảnh tương ứng để in. Login này được tạo tài khoản cho nhóm Khoa.
- Nhóm SV : được đăng ký lớp tín chỉ, xem Phiếu điểm của chính mình. Tất cả sinh viên đều dùng chung 1 login đăng nhập.
- Nếu login thuộc nhóm PKT thì chỉ được quyền cập nhật dữ liệu đóng học phí của sinh viên, chỉ được tạo tài khoản mới thuộc cùng nhóm. Xem các báo cáo có liên quan đến học phí.
Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn tương ứng. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh. 
3. In ấn : gồm các chức năng sau:
-	Danh sách lớp tín chỉ: user nhập vào Niên khóa, học kỳ, chương trình in ra các lớp tín chỉ đã mở (chưa hủy) trong Niên khóa, học kỳ thuộc khoa mà user đang chọn. Mẫu in: ( in theo thứ tự tên môn học, nhóm)
KHOA XXXXXXXXXXXX
Niên khóa: ####-####   Học kỳ: #

STT	Tên môn học	Nhóm	Họ tên GV giảng	Số SV tối thiểu	Số SV đã đăng ký
					
Số lượng lớp đã mở: ###
-	Danh sách sinh viên đăng ký lớp tín chỉ:  user nhập vào Niên khóa, học kỳ, môn học, nhóm, chương trình in ra danh sách theo thứ tự tăng dần tên+họ với mẫu sau:
DANH SÁCH SINH VIÊN ĐĂNG KÝ LỚP TÍN CHỈ
KHOA XXXXXXXXXXXX
Niên khóa: ####-####   Học kỳ: #
Môn học: XXXXXXXXXXX – Nhóm: #

STT	Mã SV	Họ	Tên	Phái	Mã lớp
					
Số sinh viên đã đăng ký: ###
- Bảng điểm môn học của 1 lớp tín chỉ: user nhập vào Niên khóa, học kỳ, môn học, nhóm, chương trình in ra bảng điểm theo thứ tự tăng dần tên+họ với mẫu sau:
BẢNG ĐIỂM HẾT MÔN
KHOA XXXXXXXXXXXX
Niên khóa: ####-####   Học kỳ: #
Môn học: XXXXXXXXXXX – Nhóm: #

STT	Mã SV	Họ	Tên	Điểm chuyên cần	Điểm giữa kỳ	Điểm cuối kỳ	Điểm hết môn
							
Số sinh viên: ###
- Phiếu Điểm:  để in phiếu điểm cho một sinh viên dựa vào mã sinh viên do ta nhập hay chọn từ trong một danh sách.
Phiếu điểm gồm có các cột: STT, TÊN MÔN HỌC, ĐIỂM.
- Thứ tự  in điểm là theo tên môn học
- Điểm là điểm Max của các lần thi (nếu có).
- In danh sách đóng học phí của lớp: User nhập vào mã lớp, niên khóa, học kỳ, chương trình sẽ in ra thông tin đóng học phí của sinh viên của niên khóa, học kỳ đó với mẫu sau: (Sinh viên nào chưa đóng cũng in ra)
DANH SÁCH SINH VIÊN ĐÓNG HỌC PHÍ
MÃ LỚP: XXXXXXXXXXXX
KHOA: XXXXXXXXXXXXX
STT	Họ và tên	Học phí	Số tiền đã đóng
			
Tổng số sinh viên: ###
Tổng số tiền đã đóng: #,###,##0 ( tiền chữ) 
 
- Bảng điểm tổng kết: Bảng điểm tổng kết của 1 lớp dựa vào mã lớp nhập vào. Điểm thi là điểm lớn nhất của các lần thi. (Cross-Tab)   
BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA
LỚP: XXXXXXXXXXXXX – KHÓA HỌC: 
KHOA: XXXXXXXXXXX
MASV-Họ tên	Môn học 1	Môn học 2	Môn học 3	Môn học 4	Môn học n
					

Ghi chú: Sinh viên tự kiểm tra các ràng buộc có thể có khi viết chương trình
 Lưu ý: Thực hiện việc truy vấn trên SQL Server.
   	- Chỉ làm việc với các sinh viên còn đang học.
~~~
