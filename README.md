# 📦 Hệ Thống Quản Lý Nguyên Liệu, Sản Phẩm và Hợp Đồng Xuất Khẩu

---

## 📖 Tổng quan
**Hệ thống Quản lý Xuất Nhập Khẩu** là giải pháp phần mềm được xây dựng để tin học hóa toàn bộ quy trình sản xuất và kinh doanh tại công ty xuất khẩu. Hệ thống đóng vai trò trung tâm trong việc kết nối dữ liệu giữa các phòng ban (Cung ứng, Kế toán, Kinh doanh) và các phân xưởng sản xuất. Ứng dụng quản lý chặt chẽ vòng đời hàng hóa: từ khâu nhập mua nguyên liệu, điều phối sản xuất theo định mức, cho đến khi xuất thành phẩm để thanh lý các hợp đồng xuất khẩu quốc tế.<br>
**Link tải ứng dụng:**
***

## 🚀 Các tính năng chính
* [cite_start]**Quản lý Hợp đồng Xuất khẩu**: Lưu trữ chi tiết các hợp đồng ký kết với khách hàng, bao gồm thời gian giao hàng, địa điểm, phương thức thanh toán và danh sách sản phẩm đặt hàng[cite: 273, 274].
* [cite_start]**Định mức Cơ cấu Sản phẩm (BOM)**: Thiết lập bảng cơ cấu sản phẩm – nguyên liệu, cho biết chính xác số lượng từng loại nguyên vật liệu cần thiết để tạo ra một đơn vị thành phẩm[cite: 277].
* **Quản lý Kho Nguyên liệu**: Theo dõi quy trình nhập nguyên liệu từ khách hàng (kèm thuế GTGT) và xuất nguyên liệu trực tiếp cho từng phân xưởng sản xuất theo ca làm việc[cite: 283, 286, 287].
* [cite_start]**Quản lý Thành phẩm**: Ghi nhận sản phẩm hoàn thành từ phân xưởng và quản lý việc xuất sản phẩm cho các hợp đồng, ưu tiên các hợp đồng sắp đến hạn giao hàng[cite: 292, 294, 295].
* **Hệ thống Báo cáo & Thống kê**:
    * [cite_start]Thống kê tình hình tồn kho sản phẩm chưa xuất[cite: 298].
    * Cảnh báo tiến độ hợp đồng (hợp đồng đã hoàn thành, hợp đồng còn thiếu sản phẩm)[cite: 299].
    * [cite_start]Lập kế hoạch thu mua nguyên liệu dựa trên nhu cầu thực tế của các hợp đồng[cite: 301].

***

## 🛠️ Công nghệ sử dụng
* **Kiến trúc**: 3-Tier Architecture (GUI - BLL - DAL).
* **Ngôn ngữ lập trình**: C# (.NET).
* **Giao diện**: Windows Forms (WinForms).
* **Cơ sở dữ liệu**: SQL Server.
* **Truy vấn dữ liệu**: ADO.NET / Entity Framework Core.

***

## ⚙️ Hướng dẫn cài đặt

### Yêu cầu hệ thống
* [.NET SDK](https://dotnet.microsoft.com/download) phù hợp (phiên bản 6.0/8.0 hoặc .NET Framework).
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB hoặc Express).
* Visual Studio 2019/2022.

### Các bước cài đặt
1.  **Clone dự án**
    ```bash
    git clone [https://github.com/Fong62/QLXuatNhapKhau.git](https://github.com/Fong62/QLXuatNhapKhau.git)
    cd QLXuatNhapKhau
    ```

2.  **Cấu hình Cơ sở dữ liệu**
    * Chạy file script SQL đính kèm để tạo cấu trúc bảng và các Stored Procedures.
    * Mở tệp cấu hình trong project `DAL`, cập nhật chuỗi kết nối `ConnectionString` để kết nối tới SQL Server của bạn.

3.  **Chạy ứng dụng**
    * Mở file `QLXuatNhapKhau.sln` bằng Visual Studio.
    * Chọn `QLXuatNhapKhauGUI` làm dự án khởi động (Startup Project).
    * Nhấn `F5` để biên dịch và chạy.

***

## 🔐 Hướng dẫn Đăng nhập (Tài khoản mẫu)

Hệ thống hỗ trợ phân quyền nghiệp vụ theo các phòng ban chuyên trách:

#### 1. Quản trị viên & Quản lý (Admin/Manager)
* **Tài khoản:** `admin`
* **Mật khẩu:** `123`
* **Nhân sự**: Lê Nguyễn Minh Hoàng (Chức vụ: Quản lý - Trưởng phòng)
* **Quyền hạn:** Quản lý toàn bộ danh mục đối tác, vật tư; giám sát hoạt động của các phòng ban và xem báo cáo tổng hợp.

#### 2. Tài khoản Phòng Cung ứng
* **Tài khoản:** `HUY`
* **Mật khẩu:** `123`
* **Nhân sự**: Nguyễn Trần Gia Huy (Bộ phận: Phòng cung ứng)
* **Quyền hạn:** Thực hiện nghiệp vụ mua nguyên liệu, lập phiếu nhập/xuất kho vật tư và điều phối sản xuất tại các phân xưởng.
  
#### 3. Tài khoản Phòng Kế toán
* **Tài khoản:** `PHONG`
* **Mật khẩu:** `123`
* **Nhân sự**: Nguyễn Hoàng Phong (Bộ phận: Phòng kế toán)
* **Quyền hạn:** Quản lý các hợp đồng xuất khẩu, theo dõi trị giá hợp đồng, thuế GTGT và lập phiếu xuất thành phẩm cho khách hàng.

#### 4. Tài khoản Khách hàng
* **Tài khoản:** `NGỌC`
* **Mật khẩu:** `123`
* **Nhân sự**: Nguyễn Quang Ngọc (Khách hàng)
* **Quyền hạn:** Theo dõi tình trạng các hợp đồng đã ký kết, xem lịch sử giao nhận hàng và thông báo công nợ cá nhân.

## 📂 Cấu trúc thư mục
```text
QLXuatNhapKhau
├── QLXuatNhapKhauGUI     # Giao diện người dùng (Presentation Layer)
├── BLL                   # Xử lý nghiệp vụ (Business Logic Layer)
├── DAL                   # Truy cập dữ liệu (Data Access Layer)
│   ├── DBConnect.cs      # Kết nối và thực thi lệnh SQL
├── .gitignore            # Loại bỏ các file build tạm thời
└── QLXuatNhapKhau.sln    # Solution quản lý toàn bộ dự án
```

## 📞 Liên hệ
**Nguyễn Hoàng Phong**
* **Email:** nguyenhoangphongsupham@gmail.com
* **LinkedIn:** [Nguyễn Hoàng Phong](https://www.linkedin.com/in/nguy%E1%BB%85n-ho%C3%A0ng-phong-a95135354/)
* **GitHub:** [Fong62](https://github.com/Fong62)
