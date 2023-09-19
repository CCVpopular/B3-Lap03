using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap03_03
{
    internal class SinhVien
    {
        public string MSSV;
        public string Ten;
        public string Khoa;
        public float DTB;

        public SinhVien() { }  
        public SinhVien(string mSSV, string ten, string khoa, float dTB)
        {
            MSSV = mSSV;
            Ten = ten;
            Khoa = khoa;
            DTB = dTB;
        }
    }
}
