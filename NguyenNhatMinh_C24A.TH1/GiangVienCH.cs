using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNhatMinh_C24A.TH1
{
    public class GiangVienCH : GiangVien
    {
        public float Hesoluong { get; set; }

        public GiangVienCH() { }

        public GiangVienCH(string maSo, string hoTen, int namSinh, float hesoluong)
            : base(maSo, hoTen, namSinh)
        {
            Hesoluong = hesoluong;
        }

        public override void Nhap()
        {
            base.Nhap();
            float hesoluong;
            do
            {
                Console.Write("Nhập hệ số lương: ");
                if (!float.TryParse(Console.ReadLine(), out hesoluong) || hesoluong <= 0)
                {
                    Console.WriteLine("Lỗi: Hệ số lương phải là số dương! Vui lòng nhập lại.");
                }
                else
                {
                    Hesoluong = hesoluong;
                    break;
                }
            } while (true);
        }
        public override int tinhLuong()
        {
            return (int)(Hesoluong * 2340000);
        }
    }

}
