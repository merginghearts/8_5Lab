using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5_Lab_Reality_Star
{
    class Paradise_island : Application
    {
        public string Gender;
        public string Name_of_Sig_Other;
        public int Years_Dating;

        public Paradise_island(string Gender, string Name_of_Sig_Other, int Years_Dating, string first_name, string last_name, string date_of_birth, string address, string city, string state, int zip, string phone_number, string email) :
        base(first_name, last_name, date_of_birth, address, city, state, zip, phone_number, email)
        {
            this.Gender = Gender;
            this.Name_of_Sig_Other = Name_of_Sig_Other;
            this.Years_Dating = Years_Dating;

        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You have been accepted to Paradise Island!");
        }
    }
}
