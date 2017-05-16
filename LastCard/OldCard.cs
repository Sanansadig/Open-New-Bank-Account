using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCard
{
    class OldCard
    {
        private string name = "Jalil";
        private string surname = "Jalilzadeh";
        private double cardNumber = 14456544989087;
        private int secureNumber = 345;
        private double amount = 20000;
        private int month = 9;
        private int year = 2014;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }
        public double CardNumber
        {
            get { return this.cardNumber; }
            set { this.cardNumber = value; }
        }
        public int SecureNumber
        {
            get { return this.secureNumber; }
            set { this.secureNumber = value; }


        }
        public int Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
    }

}
