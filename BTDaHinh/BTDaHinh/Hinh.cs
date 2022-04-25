using System;
using System.Collections.Generic;
using System.Text;

namespace BTDaHinh
{
    class Hinh
    {
        public int socanh
        {
            get;
            set;
        }
        public int sodinh
        {
            get;
            set;
        }
        public HinhHoc(int Canh, int Dinh)
        {
            socanh = Canh;
            sodinh = Dinh;
            
        }
    }
}
