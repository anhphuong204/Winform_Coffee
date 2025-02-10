I. Viết bằng Winform C#, SQL Server
II. Mô tả
1	Start	Người dùng bắt đầu bằng cách khởi chạy ứng dụng hoặc truy cập vào hệ thống quản lý.
2	Đăng nhập	- Nhập tên đăng nhập và mật khẩu: Người dùng được yêu cầu nhập thông tin tên đăng nhập và mật khẩu của họ vào các trường tương ứng trên giao diện đăng nhập.
- Hệ thống kiểm tra thông tin tên đăng nhập và mật khẩu đã được nhập
+ Nếu thông tin đăng nhập chính xác, hệ thống cho phép người dùng tiếp tục và chuyển sang bước tiếp theo, đó là phân quyền.
+ Nếu thông tin đăng nhập không chính xác, hệ thống sẽ hiển thị thông báo lỗi yêu cầu người dùng nhập lại thông tin. Người dùng sau đó sẽ quay lại để thử lại đăng nhập.

3	Phân quyền	Xác định quyền hạn của người dùng: Sau khi đăng nhập thành công, hệ thống sẽ xác định quyền hạn của người dùng dựa trên tài khoản đã đăng nhập. Quyền hạn có thể là Admin hoặc Nhân viên, và quyền này sẽ quyết định các chức năng mà người dùng có thể truy cập trong hệ thống.
- Nếu là Admin: Sẽ được chuyển đến các chức năng quản lý nâng cao như quản lý nhân viên, hóa đơn, sản phẩm, bàn, và tài khoản.
- Nếu là Nhân viên: Sẽ chỉ có quyền truy cập vào các chức năng giới hạn như quản lý bán hàng và quản lý hóa đơn và tài khoản.

4	Quản lý với quyền Quản trị viên	Quản trị viên có quyền lựa chọn từ một loạt các chức năng quản lý trong hệ thống. Các chức năng này bao gồm quản lý nhân viên, quản lý hóa đơn, quản lý sản phẩm, quản lý bàn, và quản lý tài khoản.
5	Quản lý với quyền Nhân viên	Nhân viên có thể lựa chọn giữa các chức năng quản lý Bán hàng, quản lí hóa đơn và quản lý tài khoản.

III. Giao diện:
1. Đăng nhập: 
![image](https://github.com/user-attachments/assets/1e337d7e-78f1-40c9-b7fd-781bafdbbb18)

3. Trang chủ với quyền admin:
  ![image](https://github.com/user-attachments/assets/9da86f74-cc33-465b-a32d-c2c322c5936b)

4. Trang chủ với quyền nhân viên:
 ![image](https://github.com/user-attachments/assets/1242302c-8d66-4632-831e-9d49940cd390)

5. Quên mật khẩu:
![image](https://github.com/user-attachments/assets/bbc65557-eb70-42bb-bb5f-79a3e5d1b1d7)

6. Quản lý Nhân viên(Quyền Admin)
![image](https://github.com/user-attachments/assets/2d1b9e12-7ac7-48f9-8a45-1719ed246453)

7. Quản lý Sản phẩm:
![image](https://github.com/user-attachments/assets/47e5022b-12db-428e-9717-66c5a9a92aef)

8. Quản lý Bàn:
![image](https://github.com/user-attachments/assets/fe496190-4009-4bbc-9d69-4c2a636bb33c)

9. Quản lý Hóa đơn:
![image](https://github.com/user-attachments/assets/f8c29c01-a07d-467b-9641-2ab7bf385616)

10. Quản lí Phiếu Nhập:
![image](https://github.com/user-attachments/assets/b39ed30b-0a2c-495d-801c-7236c119b7f3)

11. Quản lí Chi Tiết Phiếu Nhập:
![image](https://github.com/user-attachments/assets/b8d93f1b-ce88-4f87-a861-44eaac0207b4)

12. Giao diện Quản lý Phiếu xuất:
![image](https://github.com/user-attachments/assets/97a01c6d-32b6-4491-8569-81df13a84cee)

13. Quản lí Chi Tiết Phiếu Xuất:
![image](https://github.com/user-attachments/assets/09e37e43-8088-4c80-a197-fa2406d96002)

13.Quản lý bán hàng:
![image](https://github.com/user-attachments/assets/15cf6029-e905-4d72-a295-292c7f2960b1)
