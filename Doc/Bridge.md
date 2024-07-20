Bridge Pattern: Là một mẫu thiết kế cấu trúc phân chia logic nghiệp vụ hoặc lớp lớn thành các hệ thống phân cấp lớp riêng biệt có thể được phát triển độc lập. ý tưởng chính là sử dụng cầu nối giữa tầng abstraction và tầng implementaion. Ví dụ: chúng ta có 1 đối tượng hình dạng (shape), có 2 class kế thừa là hình tròn và hình vuông (circle và square). Bây giờ chúng ta muốn kế thừa 2 class này để ra được các class có màu sắc là đỏ và xanh. Thì chúng ta phải tạo ra 4 class mới.

=> lỗi thường gặp với việc kế thừa: chúng ta đang cố gắng tạo ra các class kế thừa các class hình dạng (shape class là circle và square bên trên) theo 2 chiều, theo chiều hình dạng (form) và chiều màu sắc (color).

=> sử dụng Bridge Pattern giải quyết vấn đề này bằng cách chuyển từ kế thừa về cách kết hợp. Tạo ra 2 class riêng biệt là class shape ( hình dạng ) và class color ( màu sắc ) rồi tạo 1 class thứ 3 reference tới 2 class kia.

![BridgeExample](../Img/BridgeExample1.png) ![BridgeExample](../Img/BridgeExample2.png) ![BridgeExample](../Img/BridgeExample3.png) ![BridgeExample](../Img/BridgeExample4.png) ![BridgeExample](../Img/BridgeExample5.png)
