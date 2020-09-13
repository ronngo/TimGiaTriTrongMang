using System;

namespace TimGiaTriTrongMang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo mảng chứa danh sách sinh viên
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };

            // Khai báo biến lưu tên tìm kiếm và  gán với giá trị nhập vào
            Console.WriteLine("Enter a name’s student : ");
            string input_name = Console.ReadLine();

            // Duyệt mảng sinh viên đã khai báo ở trên, tìm phần tử có giá trị bằng với tên đã nhập vào.
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if ( students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list" + input_name + " is : " + (i + 1));
                    isExist = true;
                    break;
                }    
            }  
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
            }    
        }
    }
}
