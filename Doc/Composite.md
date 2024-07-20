Composite pattern:

Tên gọi khác là Object tree, mục đích chính của Composite Pattern là đơn giản hóa quá trình làm việc với các cấu trúc phức tạp bằng cách cho phép client tương tác với các đối tượng đơn lẻ và tổ hợp "theo cùng một cách (cùng method)". Điều này giúp giảm thiểu sự phức tạp khi quản lý và tương tác với cấu trúc cây, làm cho mã nguồn dễ bảo trì và mở rộng hơn. Chỉ áp dụng với những đối tượng đủ đơn giản và có thể tổ chức hình cây

![composite](../Img/composite.png)

Ví dụ như sau: Trong việc lưu trữ trong máy tính có hai dạng chính: Folder và File. Một Folder thì có thể chứa nhiều Folder và File. Có thể một trong Folder chỉ chứa File hoặc cả File và Folder con. Giờ cần đếm xem có bao nhiêu File chứa từ "Book" ?
