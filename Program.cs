using System;

namespace _8_5_Lab_Reality_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            House_hunter House_hunter = new House_hunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "02/04/1975", "111 Brove Way", "Los Angeles", "CA", 90001,
                "888-233-1234", "omar.smith@hotmail.com");

            Paradise_island piContestant = new Paradise_island("Female", "Carl", 2, "Patti", "Johnson", "05/4/1994", "211 Love Rd", "Los Angeles", "CA", 90001, "988-444-1234",
                "patti.johnson@gmail.com");

            Above_deck adContestant = new Above_deck(20, "American", "Captain", "Lee", "7/12/1964", "211 Bravo Road", "Los Angeles", "CA", 90001, "711-333-1234", "captain@gmail.com"); 

        
            House_hunter.Submit();
            House_hunter.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();
        }


    }
}
