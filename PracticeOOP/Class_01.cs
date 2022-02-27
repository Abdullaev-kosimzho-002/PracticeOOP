using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOP
{
    class Class_01
    {
        //Question 1.
        /*
        public string name = "Bolt";
        public string surname;

        public Class_01(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        */

        //Question 2.
        /*
        public string name = "Alla";
        public string email = "@alla.com";
        public int age = 108;

        public Class_01 (string name)
        {
            this.name = name;
        }
        public Class_01(string name, int age) : this(name)
        {
            this.age = age;
        }
        public Class_01(string name,string email, int age) : this("Zaha", 10)
        {
            this.email = "Zaha@gmail.com";
        }
        */



        //Question 5.
        /*
                int age = 25;
                string name = "Tom";

                public Class_01(int age, string name)
                {
                    this.age = age;
                    this.name = name;
                }

        */

        //Task Svoistva

        //Question 1.
        /*
        private int age = 15;

        public int Age
        {
            get { return age;}
            set { }
        }
        */


        //Task const and readonly

        //Question 2.

        /*
        public static const double KOEF = 4.5;
        public readonly double field = 7.8;

        public Class_01(int f)
        {
            this.field = KOEF * f;
        }
        */

        //Question 3.
        /*
        public const double KOEF = 4.5;
        public readonly double field;

        public Class_01(int f)
        {
            this.field = KOEF * f;
        }
        */






















































    }
}
