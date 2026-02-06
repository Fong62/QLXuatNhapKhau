📦 Website Quản Lý Xuất Nhập Khẩu
📖 Tổng quan

Website Quản Lý Xuất Nhập Khẩu là một ứng dụng được xây dựng nhằm hỗ trợ doanh nghiệp trong việc quản lý toàn bộ quy trình xuất – nhập hàng hóa, từ quản lý danh mục hàng hóa, kho bãi, đối tác đến theo dõi các phiếu nhập – xuất và báo cáo tồn kho.

Hệ thống giúp số hóa nghiệp vụ xuất nhập khẩu, giảm thiểu sai sót thủ công, nâng cao hiệu quả quản lý và hỗ trợ ra quyết định nhanh chóng dựa trên dữ liệu tập trung.

🚀 Các tính năng chính

Quản lý hàng hóa: Thêm, sửa, xóa và tra cứu thông tin mặt hàng xuất – nhập.

Quản lý kho: Theo dõi số lượng tồn kho theo thời gian thực.

Quản lý phiếu nhập – xuất: Lập và quản lý phiếu nhập kho, phiếu xuất kho.

Quản lý đối tác: Lưu trữ thông tin khách hàng và nhà cung cấp.

Báo cáo – thống kê: Thống kê nhập, xuất và tồn kho theo thời gian.

Phân quyền người dùng: Quản lý quyền truy cập theo vai trò (Admin / Nhân viên).

🛠️ Công nghệ sử dụng

Ngôn ngữ: C#

Nền tảng: .NET

Mô hình kiến trúc: 3-tier Architecture

Cơ sở dữ liệu: SQL Server

Giao diện: Windows Forms / WPF (tùy cấu hình project)

🧱 Kiến trúc hệ thống

Hệ thống được xây dựng theo mô hình 3 lớp (3-tier):

GUI (Presentation Layer): Giao diện người dùng

BLL (Business Logic Layer): Xử lý nghiệp vụ xuất nhập khẩu

DAL (Data Access Layer): Tương tác với cơ sở dữ liệu

Mô hình này giúp hệ thống dễ bảo trì, mở rộng và nâng cấp trong tương lai.

⚙️ Hướng dẫn cài đặt
Yêu cầu hệ thống

Windows 10 trở lên

Visual Studio 2019 / 2022

.NET Framework / .NET SDK tương thích

SQL Server (Express hoặc LocalDB)

Các bước cài đặt

Clone dự án

git clone https://github.com/Fong62/QLXuatNhapKhau.git
cd QLXuatNhapKhau


Mở project

Mở file QLXuatNhapKhau.sln bằng Visual Studio

Đặt project giao diện làm Startup Project

Cấu hình cơ sở dữ liệu

Mở file cấu hình trong thư mục DAL

Cập nhật Connection String phù hợp với SQL Server trên máy

Chạy ứng dụng

Build solution

Nhấn Run (F5) để khởi động chương trình

🔐 Phân quyền người dùng (mô tả)

Admin:

Quản lý toàn bộ dữ liệu

Quản lý hàng hóa, kho, đối tác

Xem báo cáo thống kê

Nhân viên:

Lập phiếu nhập – xuất

Cập nhật thông tin hàng hóa

Theo dõi tồn kho

(Có thể mở rộng phân quyền chi tiết hơn trong tương lai)

📂 Cấu trúc thư mục
QLXuatNhapKhau
├── BLL                 # Xử lý nghiệp vụ xuất nhập khẩu
├── DAL                 # Truy cập & xử lý dữ liệu
├── QLXuatNhapKhauGUI   # Giao diện người dùng
├── QLXuatNhapKhau.sln  # Solution chính
└── .gitignore

🚧 Hướng phát triển

Quản lý hợp đồng xuất – nhập khẩu

Tính thuế, phí và chi phí logistics

Xuất báo cáo Excel / PDF

Phát triển phiên bản Web (ASP.NET Core)

Tích hợp API phục vụ mobile app

📞 Liên hệ

Nguyễn Hoàng Phong

GitHub: Fong62

Email: nguyenhoangphongsupham@gmail.com
