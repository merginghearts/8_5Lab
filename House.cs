using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5_Lab_Reality_Star
{
    class House_hunter : Application

    {
        public string job_title;
        public int current_annual_income;
        public int when_buying_months;
        public int bedrooms;
        public int bathrooms;

        public House_hunter(string job_title, int current_annual_income, int when_buying_months, int bedrooms, int bathrooms,
        string first_name, string last_name, string date_of_birth, string address, string city, string state, int zip, string phone_number, string email) :
        base(first_name, last_name, date_of_birth, address, city, state, zip, phone_number, email)
        {
            this.job_title = job_title;
            this.current_annual_income = current_annual_income;
            this.when_buying_months = when_buying_months;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;

        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You have been accepted to Dream House Hunters!");
        }


    }

}
