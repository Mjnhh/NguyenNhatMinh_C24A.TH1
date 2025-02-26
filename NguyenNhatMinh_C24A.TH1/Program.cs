using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNhatMinh_C24A.TH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            QuanLyGV ql = new QuanLyGV();
            int choice;

            do
            {
                Console.WriteLine("\n===== QUẢN LÝ GIẢNG VIÊN =====");
                Console.WriteLine("1. Nhập danh sách giảng viên");
                Console.WriteLine("2. Hiển thị danh sách giảng viên");
                Console.WriteLine("3. Tính tổng lương phải trả");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng (1-4): ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập số từ 1 đến 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ql.NhapDS();
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine("\nTổng lương phải trả: {0:N0} VND", ql.TinhTongLuong());
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lỗi: Vui lòng chọn số từ 1 đến 4.");
                        break;
                }
            } while (choice != 4);
            Console.ReadLine();
        }
    }
}