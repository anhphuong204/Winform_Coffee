I. Viết bằng WinForms C#, SQL Server  

## II. Mô tả  

1. **Start**  
   Người dùng bắt đầu bằng cách khởi chạy ứng dụng hoặc truy cập vào hệ thống quản lý.  

2. **Đăng nhập**  
   - Nhập tên đăng nhập và mật khẩu: Người dùng được yêu cầu nhập thông tin tên đăng nhập và mật khẩu của họ vào các trường tương ứng trên giao diện đăng nhập.  
   - Hệ thống kiểm tra thông tin tên đăng nhập và mật khẩu:  
     - Nếu thông tin đăng nhập chính xác, hệ thống cho phép người dùng tiếp tục và chuyển sang bước tiếp theo, đó là phân quyền.  
     - Nếu thông tin đăng nhập không chính xác, hệ thống sẽ hiển thị thông báo lỗi yêu cầu người dùng nhập lại thông tin.  

3. **Phân quyền**  
   - Xác định quyền hạn của người dùng: Sau khi đăng nhập thành công, hệ thống sẽ xác định quyền hạn của người dùng dựa trên tài khoản đã đăng nhập.  
   - Nếu là **Admin**: Được truy cập các chức năng quản lý nhân viên, hóa đơn, sản phẩm, bàn, tài khoản.  
   - Nếu là **Nhân viên**: Chỉ có quyền truy cập vào quản lý bán hàng, hóa đơn và tài khoản.  

4. **Quản lý với quyền Quản trị viên**  
   - Admin có thể quản lý nhân viên, hóa đơn, sản phẩm, bàn, tài khoản.  

5. **Quản lý với quyền Nhân viên**  
   - Nhân viên có thể quản lý bán hàng, hóa đơn và tài khoản.  

## III. Giao diện  

### 1. Đăng nhập  
<img src="https://github.com/user-attachments/assets/1e337d7e-78f1-40c9-b7fd-781bafdbbb18" width="300">  

### 2. Trang chủ với quyền Admin  
<img src="https://github.com/user-attachments/assets/9da86f74-cc33-465b-a32d-c2c322c5936b" width="300">  

### 3. Trang chủ với quyền Nhân viên  
<img src="https://github.com/user-attachments/assets/1242302c-8d66-4632-831e-9d49940cd390" width="500">  

### 4. Quên mật khẩu  
<img src="https://github.com/user-attachments/assets/bbc65557-eb70-42bb-bb5f-79a3e5d1b1d7" width="300">  

### 5. Quản lý Nhân viên (Quyền Admin)  
<img src="https://github.com/user-attachments/assets/2d1b9e12-7ac7-48f9-8a45-1719ed246453" width="300">  

### 6. Quản lý Sản phẩm  
<img src="https://github.com/user-attachments/assets/47e5022b-12db-428e-9717-66c5a9a92aef" width="300">  

### 7. Quản lý Bàn  
<img src="https://github.com/user-attachments/assets/fe496190-4009-4bbc-9d69-4c2a636bb33c" width="300">  

### 8. Quản lý Hóa đơn  
<img src="https://github.com/user-attachments/assets/f8c29c01-a07d-467b-9641-2ab7bf385616" width="300">  

### 9. Quản lý Phiếu Nhập  
<img src="https://github.com/user-attachments/assets/b39ed30b-0a2c-495d-801c-7236c119b7f3" width="300">  

### 10. Quản lý Chi Tiết Phiếu Nhập  
<img src="https://github.com/user-attachments/assets/b8d93f1b-ce88-4f87-a861-44eaac0207b4" width="300">  

### 11. Giao diện Quản lý Phiếu Xuất  
<img src="https://github.com/user-attachments/assets/97a01c6d-32b6-4491-8569-81df13a84cee" width="300">  

### 12. Quản lý Chi Tiết Phiếu Xuất  
<img src="https://github.com/user-attachments/assets/09e37e43-8088-4c80-a197-fa2406d96002" width="300">  

### 13. Quản lý Bán hàng  
<img src="https://github.com/user-attachments/assets/15cf6029-e905-4d72-a295-292c7f2960b1" width="300">  
