using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19SA1276_Encapsulation
{
    class data
    {
        public string plat, model, manufaktur;
        public int speed;
        public tahun tahunproduksi;
        private int bensin = 2;

        public int getbensin
        {
            get
        {
           return bensin;
        }
            set
            {
                bensin = 2;
            }
        }

     
        public string gas(string a)
        {
            string b = "";
            switch (a)
            {
                case "pelan": b = "lembut"; break;
                case "sedang": b = "cepat"; break;
                case "kuat": b = "kencang"; break;
            }
            return b;

        }
        public string rem(string a)
        {
            string b = "";
            switch (a)
            {
                case "pelan": b = "lembut"; break;
                case "sedang": b = "cepat"; break;
                case "kuat": b = "kencang"; break;
            }
            return b;

        }
    }
}
