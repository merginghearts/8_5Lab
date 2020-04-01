using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5_Lab_Reality_Star
{
    class Above_deck: Application
    { 
        public int Years_experience;
        public string Nationality;

        public Above_deck(int Years_experience, string Nationality, string first_name, string last_name, string date_of_birth, string address, string city, string state, int zip, string phone_number, string email) :
        base(first_name, last_name, date_of_birth, address, city, state, zip, phone_number, email)
        {
            this.Years_experience = Years_experience;
            this.Nationality = Nationality;

        }
         public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You have been accepted to Above Deck!");
        }
    }
}
