

Bước 1:         Publisher                                                   

===>
        | Input:    tên publisher, giá trị, kiểu
        | Output:   dictionary các header: kiểu dữ liệu, thời gian gửi ...



Bước 2: Đẩy Message vào Persitance      

        | Input: Message với kiểu dữ liệu là object và các header
        | Xử lý: 
        |       + Message sẽ được serializer thành các string
        |       + Đẩy dữ liệu vào Database
        |
        | Output: Medium Message

Bước 3: Đẩy Medium Message vào Queue

        | Đẩy MediumMessage vào trong Queue



Mục tiêu: xây dựng một middleware xử lý message trước khi lưu vào persistant và Queue

Đầu vào là 1 message (Message context) đầu ra là một Message (Message context)

Khó khăn: 
        + cầu merge được Medium message và Message. 
        + Cải cải tiến Message thành Message context
