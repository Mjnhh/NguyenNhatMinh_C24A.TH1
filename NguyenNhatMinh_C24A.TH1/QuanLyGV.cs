using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNhatMinh_C24A.TH1
{
    public class QuanLyGV
    {
        private List<GiangVien> dsGV = new List<GiangVien>();

        public void NhapDS()
        {
            int n;
            do
            {
                Console.Write("Nhập số lượng giảng viên: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Lỗi: Số lượng phải là số nguyên dương! Vui lòng nhập lại.");
                }
                else
                {
                    break;
                }
            } while (true);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin giảng viên thứ {0}:", i + 1);

                int loai;
                do
                {
                    Console.Write("Chọn loại giảng viên (1 - Cơ hữu, 2 - Thỉnh giảng): ");
                    if (!int.TryParse(Console.ReadLine(), out loai) || (loai != 1 && loai != 2))
                    {
                        Console.WriteLine("Lỗi: Chỉ nhập 1 hoặc 2! Vui lòng nhập lại.");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                GiangVien gv;
                if (loai == 1)
                {
                    gv = new GiangVienCH();
                }
                else
                {
                    gv = new GiangVienTG();
                }

                gv.Nhap();
                dsGV.Add(gv);
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("\n===== DANH SÁCH GIẢNG VIÊN =====");
            foreach (GiangVien gv in dsGV)
            {
                Console.WriteLine($"Mã số: {gv.MaSo}");
                Console.WriteLine($"Họ tên: {gv.HoTen}");
                Console.WriteLine($"Năm sinh: {gv.NamSinh}");

                if (gv is GiangVienCH gvch)
                {
                    Console.WriteLine($"Hệ số lương: {gvch.Hesoluong}");
                }
                else if (gv is GiangVienTG gvtg)
                {
                    Console.WriteLine($"Số tiết dạy: {gvtg.Sotietday}");
                }

                Console.WriteLine($"Lương: {gv.tinhLuong():N0} VND");
                Console.WriteLine("-------------------------");
            }
        }

        public int TinhTongLuong()
        {
            return dsGV.Sum(gv => gv.tinhLuong());
        }
    }
}

