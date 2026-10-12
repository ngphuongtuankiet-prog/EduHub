# Nhiem vu 1 - User Stories EduHub

## US-07 - Sinh vien huy dang ky su kien

**Vai tro:** Sinh vien

La sinh vien, toi muon huy dang ky su kien khi khong the tham gia, de nhuong cho cho sinh vien khac.

**Tieu chi nghiem thu:**

- AC1: Given phieu dang ky o trang thai Pending hoac Confirmed, When sinh vien chon huy dang ky, Then he thong chuyen phieu sang trang thai Cancelled.
- AC2: Given phieu dang ky da Cancelled, When sinh vien tiep tuc yeu cau huy, Then he thong tu choi va thong bao phieu da bi huy.

## US-08 - Sinh vien xem lich su dang ky

**Vai tro:** Sinh vien

La sinh vien, toi muon xem lich su dang ky su kien de theo doi cac su kien da dang ky.

**Tieu chi nghiem thu:**

- AC1: Given sinh vien da co phieu dang ky, When mo lich su dang ky, Then he thong hien thi cac su kien va trang thai tuong ung.
- AC2: Given sinh vien chua tung dang ky su kien, When mo lich su, Then he thong thong bao chua co du lieu.

## US-09 - Ban CLB gioi han so luong nguoi tham gia

**Vai tro:** Ban CLB

La thanh vien Ban CLB, toi muon dat so luong nguoi tham gia toi da cho su kien de kiem soat suc chua.

**Tieu chi nghiem thu:**

- AC1: Given Ban CLB dang tao su kien, When nhap suc chua la so nguyen lon hon 0, Then he thong chap nhan gia tri.
- AC2: Given suc chua bang 0 hoac so am, When luu su kien, Then he thong tu choi va hien thi thong bao loi.

## US-10 - Ban CLB xem danh sach dang ky

**Vai tro:** Ban CLB

La thanh vien Ban CLB, toi muon xem danh sach sinh vien dang ky su kien de chuan bi cong tac to chuc.

**Tieu chi nghiem thu:**

- AC1: Given su kien da co sinh vien dang ky, When mo danh sach dang ky, Then he thong hien thi thong tin sinh vien va trang thai phieu.
- AC2: Given su kien chua co ai dang ky, When mo danh sach, Then he thong thong bao danh sach trong.

## US-11 - Admin khoa tai khoan vi pham

**Vai tro:** Admin

La Admin, toi muon khoa tai khoan vi pham quy dinh de dam bao an toan he thong.

**Tieu chi nghiem thu:**

- AC1: Given tai khoan dang hoat dong, When Admin khoa tai khoan, Then he thong chuyen tai khoan sang trang thai bi khoa.
- AC2: Given tai khoan da bi khoa, When nguoi dung dang nhap, Then he thong tu choi truy cap va hien thi thong bao phu hop.

## US-12 - Admin xem thong ke he thong

**Vai tro:** Admin

La Admin, toi muon xem thong ke cau lac bo, su kien va luot dang ky de danh gia tinh hinh hoat dong.

**Tieu chi nghiem thu:**

- AC1: Given he thong da co du lieu, When Admin mo trang thong ke, Then he thong hien thi tong so CLB, su kien va luot dang ky.
- AC2: Given he thong chua co du lieu, When Admin mo trang thong ke, Then cac chi so hien thi bang 0 va khong phat sinh loi.
