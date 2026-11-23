# Phần mềm Quản lý Kế toán Mua hàng (WinForms C# & SQL Server)

Hệ thống hỗ trợ doanh nghiệp quản lý quy trình kế toán mua hàng từ khâu lập phiếu nhập, duyệt chứng từ, theo dõi công nợ phải trả đến tổng hợp báo cáo nhập hàng.

## 1. Nghiệp vụ & Luồng xử lý chính
* **Phân quyền 2 vai trò (Admin & User):** Kiểm soát chặt chẽ quyền tạo, xem và phê duyệt dữ liệu.
* **Quy trình chứng từ khép kín:** Đăng nhập → User lập phiếu nhập (tự động tính VAT 10%) → Admin duyệt/từ chối phiếu (Pending / Approved / Rejected) → Ghi nhận công nợ → Thanh toán & Lập báo cáo.
* **Kiểm soát ràng buộc dữ liệu:** Chặn xóa nhà cung cấp đã phát sinh giao dịch nhập hàng; tự động tạo số chứng từ chi và cập nhật số dư nợ theo từng hóa đơn khi thanh toán.

## 2. Kiến trúc & Cơ sở dữ liệu
* **Mô hình 4 lớp:** UI – BLL – DAL – DTO.
* **Hệ quản trị CSDL:** SQL Server (9 bảng dữ liệu quản lý danh mục, phiếu nhập, thanh toán, công nợ và phân quyền).

## 3. Vai trò đảm nhiệm
* Thiết kế giao diện người dùng (UI) cho các phân hệ chức năng chính.
* Phân tích luồng nghiệp vụ, soạn thảo tài liệu đặc tả chức năng và hướng dẫn sử dụng hệ thống.

## 4. Giao diện minh họa
<img width="467" height="248" alt="image" src="https://github.com/user-attachments/assets/3c8e94b9-2cfc-43d4-b726-bbeaf1cd8e52" />
<img width="451" height="255" alt="image" src="https://github.com/user-attachments/assets/354bf6ba-8940-400d-9af3-82ec50d24174" />
