using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212416_Lab4
{
    internal class SinhVien
    {
        public string MSSV {  get; set; }
        public string HoTen {  get; set; }
        public bool Phai {  get; set; }
        public DateTime NgaySinh {  get; set; }
        public string Lop {  get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Hinh { get; set; }

        
        public SinhVien()
        {
            
        }
        public SinhVien(string mSSV, string hoTen, bool phai, DateTime ngaySinh, string lop, string email, string phone, string hinh)
        {
            this.MSSV = mSSV;
            this.HoTen = hoTen;
            this.Phai = phai;
            this.NgaySinh = ngaySinh;
            this.Lop = lop;
            this.Email = email;
            this.Phone = phone;
            this.Hinh = hinh;
        }
    }
}
