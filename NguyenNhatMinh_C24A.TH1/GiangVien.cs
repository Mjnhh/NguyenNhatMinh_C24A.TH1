using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNhatMinh_C24A.TH1
{
    public abstract class GiangVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public GiangVien () { }
        public GiangVien(string maSo, string hoTen, int namSinh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NamSinh = namSinh;
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập mã số: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }
        public virtual int tinhLuong()
        {
            return 0;
        }
    }
}
