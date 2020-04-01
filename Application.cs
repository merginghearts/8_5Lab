using System;
using System.Collections.Generic;
using System.Text;



namespace _8_5_Lab_Reality_Star
{
    class Application
    {
        public string first_name;
        public string last_name;
        public string date_of_birth;
        public string address;
        public string city;
        public string state;
        public int zip;
        public string phone_number;
        public string email;
        public bool isapp_Sub;
        protected bool isapp_Accept;

        public Application(string first_name, string last_name, string date_of_birth, string address, string city, string state, int zip, string phone_number, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.date_of_birth = date_of_birth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone_number = phone_number;
            this.email = email;
            isapp_Sub = false;
            isapp_Accept = false;


        }
            public void Submit()
            {
            isapp_Sub = true;

            Console.WriteLine("Application has been submitted.");
            }


            public virtual void Accept()
            {
            isapp_Accept = true;
            Console.WriteLine("Application Accepted.");
            }   

    }
}
