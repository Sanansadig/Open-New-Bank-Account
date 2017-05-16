using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCard
{
    class SecureCode
    {
        int x1;
        int x2;
        int x3;
        private string scode;

        public SecureCode(int s1, int s2, int s3, string finalCode)
        {
            x1 = s1;
            x2 = s2;
            x3 = s3;
            scode = finalCode = x1 + "" + x2 + "" + x3;
        }

        public string Scode
        {
            get { return this.scode; }
            set { this.scode = value; }
        }


    }
}
