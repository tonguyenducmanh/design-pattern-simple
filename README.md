# solution implement các design pattern thường gặp

Tham khảo hướng dẫn từ

https://nguyenphuc22.github.io/Design-Patterns/intro.html

# 1. Giới thiệu Design Pattern

## Định nghĩa Design Pattern

Design Pattern là một mô hình thiết kế được sử dụng để giải quyết một vấn đề cụ thể trong lập trình. Nó cung cấp một giải pháp đã được kiểm nghiệm và tối ưu hóa, giúp các lập trình viên tiết kiệm thời gian và công sức khi phát triển phần mềm

## Lịch sử ra đời và phát triển

Design Pattern được khai sinh vào những năm 1970 với sự phát triển của lập trình hướng đối tượng (OOP). Kể từ đó, nó đã trở thành một phần quan trọng trong quá trình phát triển phần mềm.

Năm 1994, ba lập trình viên Erich Gamma, Richard Helm, Ralph Johnson và John Vlissides đã xuất bản cuốn sách "Design Patterns: Elements Of Resuable Object - Oriented Software". Cuốn sách này đã trở thành một trong những tài liệu tham khảo quan trọng nhất về Design Pattern.

Trong những năm gần đây, Design Pattern tiếp tục được phát triển và mở rộng. Ngày càng có nhiều Design Pattern mới được giới thiệu, phù hợp với các yêu cầu mới của lâp trình.

## Ý nghĩa và lợi ích của Design Pattern

Design Pattern mang lại nhiều ý nghĩa và lợi ích cho lập trình, bao gồm:

- **Giúp giải quyết vấn đề một cách hiệu quả và tối ưu:** Design Pattern cung cấp các giải pháp đã được kiểm nghiệm và tối ưu hóa, giúp các lập trình viên giải quyết các vấn đề một cách nhanh chóng và hiêu quả.
- **Tăng tính tái sử dụng của code:** Design Pattern giúp các lập trình viên tái sử dụng code đã có, từ đó giảm thiểu thời gian và công ức phát triển phần mềm.
- **Tăng tính bảo trì và bảo dưỡng của phần mềm:** Design Pattern giúp phần mềm dễ dàng bảo trì và bảo dưỡng hơn.
- **Tăng tính dể hiểu và dễ đọc của code:** Design Pattern giúp code dễ hiểu và dễ đọc hơn, giúp việc công tác giữa các lập trình viên trở nên dễ dàng hơn.

Design Pattern là một kỹ thuật nâng cao của OOP, nó cực kì quan trọng trong lập trình. Nó mang lại nhiều ý nghĩa và lợi ích cho lập trình, giúp các lập trình viên phát triển phần mềm hiệu quả hơn.

# 2. Phân loại Design Pattern

## Creational Design Patterns

Creational Design Patterns liên quan tới việc khởi tạo đối tượng. Nhóm pattern này cung cấp các cơ chế tạo đối tượng một cách linh hoạt và phù hợp với bối cảnh sử dụng. Một số pattern phổ biến:

- Singleton, Factory Method, Abstract Factory, Builder, Prototype

Sử dụng Creational Patterns giúp tạo ra các đối tượng một cách linh hoạt, dễ dàng thay đổi và tối ưu hóa bộ nhớ.

## Structural Design Patterns

Structural Patterns liên quan tới cấu trúc và mối quan hệ giữa các lớp, đối tượng. Nhóm này giúp xây dựng cấu trúc phần mềm dễ thay đổi và bảo trì. Một số pattern:

- Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy

Sử dụng Structural Patterns giúp xây dựng hệ thống linh hoạt, dễ mở rộng và tối ưu hóa bộ nhớ.

## Behavioral Design Patterns

Behavioral Patterns liên quan tới hành vi giao tiếp giữa các đối tượng. Nhóm này giúp định nghĩa rõ ràng mối quan hệ giữa các object. Một số pattern:

- Chain of Responsibility, Command, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method, Visitor

Sử dụng Behavioral Patterns giúp tạo hệ thống linh hoạt, dễ thay đổi và tối ưu hóa hiệu suất.

# 3. Sử dụng Design Pattern

## Nguyên tắc và phương pháp áp dụng Design Pattern

### Nguyên Tắc

Để áp dụng Design Pattern hiệu quả, các lập trinh viên cần nắm được các nguyên tắc và phương pháp sau đây:

- **Nguyên tắc đầu tiên là phải hiểu rõ vấn đề cần giải quyết:** Trước khi áp dụng Design Pattern, các lập trinh viên cần hiểu rõ vấn đề cần giải quyết là gì. Từ đó, họ có thể lựa chọn được Design Pattern phù hợp nhất.

- **Nguyên tắc thứ hai là phải hiểu rõ Design Pattern:** Các lập trình viên cần hiểu rõ bản chất và cách hoạt động của Design Pattern. Từ đó, họ có thể áp dụng Design Pattern một cách chính xác và hiệu quả.

- **Nguyên tắc thứ ba là phải linh hoạt trong việc áp dụng Design Pattern:** Không phải lúc nào cũng có thể áp dụng Design Pattern một cách cứng nhắc. Các lập trình viên cần linh hoạt trong việc áp dụng Design Pattern để phù hợp với nhu cầu cụ thể của dự án.

### Phương pháp

- **Phương pháp trực tiếp:** Phương pháp này áp dụng Design Pattern một cách trực tiếp, không cần thay đổi cấu trúc của code.

- **Phương pháp gián tiếp:** Phương pháp này sử dụng các thư viện hoặc framework để áp dụng Design Pattern.

## Lợi ích của việc sử dụng Design Pattern trong phát triển phần mềm

- **Giúp giải quyết vấn đề một cách hiệu quả và tối ưu:** Design Pattern cung cấp các giải pháp đã được kiểm nghiệm và tối ưu hoá, giúp các lập trình viên giải quyết các vấn đề một cách nhanh chóng và hiệu quả hơn.
- **Tăng tính tái sử dụng của code:** Design Pattern giúp các lập trình viên tái sử dụng code đã có, từ đó giảm thiểu thời gian và công sức phát triển phần mềm.
- **Tăng tính linh hoạt và mở rộng của phần mềm:** Design Pattern giúp phần mềm linh hoạt và dễ dàng mở rộng khi có nhu cầu thay đổi.
- **Tăng tính bảo trì và bảo dưỡng của phần mềm:** Design Pattern giúp phền mềm dễ dàng bảo trì và bảo dưỡng hơn.
- **Tăng tính dễ hiểu và dễ đọc của code:** Design Pattern giúp code dễ hiểu và dễ đọc hơn, giúp việc công tá giữa các lập trình viên trở nên dễ dàng.

## Lưu ý khi áp dụng Design Pattern

Khi áp dụng Design Pattern, các lập trình viên cần lưu ý những điểm sau:

- **Không nên áp dụng Design Pattern một cách cứng nhắc:** Design Pattern là một giải pháp tổng thể, không phải là một giải pháp hoàn hảo. Các lập trình viên cần linh hoạt trong việc áp dụng Design Pattern để phù hợp với nhu cầu cụ thể của dự án.
- **Không nên làm dụng Design Pattern:** Design pattern không phải là một giải pháp cho mọi vấn đề. Các lập trình viên chỉ nên áp dụng Design Pattern khi nó thực sự cần thiết.
- **Cần có thời gian để học hỏi và nghiên cứu Design Pattern:** Design Pattern là một kỹ thuật phức tạp, cần có thời gian để học hỏi và nghiên cứu. Các lập trình viên không nên vội vàng áp dụng Design Pattern mà không hiểu rõ bản chất và cách hoạt động của nó.
