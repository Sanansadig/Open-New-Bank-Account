using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCard
{
    class NewCard : OldCard
    {
        private int b1;
        private int b2;
        private int b3;
        private int b4;
        private int b5;
        private int b6;
        private int b7;
        private int b8;
        private int b9;
        private int b10;
        private int b11;
        private int b12;
        private int b13;
        private int b14;
        private string fCardNumber;


        public NewCard(int c1, int c2, int c3, int c4, int c5, int c6, int c7, int c8, int c9, int c10, int c11, int c12, int c13, int c14, string cCardNumber)
        {
            b1 = c1;
            b2 = c2;
            b3 = c3;
            b4 = c4;
            b5 = c5;
            b6 = c6;
            b7 = c7;
            b8 = c8;
            b9 = c9;
            b10 = c10;
            b11 = c11;
            b12 = c12;
            b13 = c13;
            b14 = c14;
            fCardNumber = cCardNumber = b1 + "" + b2 + "" + b3 + "" + b4 + "" + b5 + "" + b6 + "" + b7 + "" + b8 + "" +
            b9 + "" + b10 + "" + b11 + "" + b12 + "" + b13 + "" + b14;
        }

        public string ACardNumber
        {
            get { return fCardNumber; }
        }


    }


}

