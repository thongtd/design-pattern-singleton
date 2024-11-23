# Mục đích của Singleton
Singleton là một mẫu thuộc lớp creation pattern nhằm mục đích tạo ra duy nhất một thể hiện (instance) cho một classs trên toàn bộ ứng dụng.
# Triển khai Singleton

Việc triển khai Singleton có 2 bước cơ bản như sau:

Tạo một private contructor, để đảm bảo chúng ta không thể sử dụng toán tử new để khởi tạo class này.

Tạo một method static nó hoạt động như một contructor. Method này sẽ gọi contructor ở bước 1 để tạo một object cho instance này và lưu chúng vào một biến static, và khi có hàm gọi đến method này nó sẽ trả về object đã được lưu ở biến static trước đó.

[https://thongit.substack.com/p/design-pattern-mau-singleton](https://thongit.substack.com/p/design-pattern-mau-singleton)
