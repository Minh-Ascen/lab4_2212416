using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212416_Lab4
{
    internal class DanhSachSV
    {
        public ArrayList DSSV;
        public DanhSachSV()
        {
            DSSV = new ArrayList();
        }
        public SinhVien this[int index]
        {
            get { return DSSV[index] as SinhVien; }
            set { DSSV[index] = value; }
        }
        public void Them(SinhVien sv)
        {
            DSSV.Add(sv);
        }
        public override string ToString()
        {
            string s = "Danh sach sinh vien: ";
            foreach(object sv in DSSV)
            {
                s += sv as SinhVien + ";";
            }
            return s;
        }
    }
}
