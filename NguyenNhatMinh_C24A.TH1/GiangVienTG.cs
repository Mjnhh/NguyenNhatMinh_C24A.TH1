using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNhatMinh_C24A.TH1
{
    public class GiangVienTG : GiangVien
    {
        public int Sotietday { get; set; }

        public GiangVienTG() { }

        public GiangVienTG(string maso, string hoten, int namsinh, int sotietday)
            : base(maso, hoten, namsinh)
        {
            Sotietday = sotietday;
        }

        public override void Nhap()
        {
            base.Nhap();
            int sotiet;
            Console.Write("Nhập số tiết dạy: ");
            while (!int.TryParse(Console.ReadLine(), out sotiet) || sotiet < 0)
            {
                Console.Write("Lỗi! Nhập lại số tiết dạy: ");
            }
            Sotietday = sotiet;
        }

            
        public override int tinhLuong()
        {
            return Sotietday * 120000;
        }
    }
}
