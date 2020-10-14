using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class UserInfo
    {
        public static int EnterAccountNumber(int listposition, List<int> accountnumber)
        {
            int account;
            int tries = 1;
            bool success = true;
            Console.WriteLine("Please enter your account using only digits: ");
            account = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (tries < 3 && success == true)
            {
                for (int i = 0; i < accountnumber.Count; i++) //i = mitä riviä käsitellään, i < accountnumber käy listän rivi kerrallaan läpi
                {
                    if (accountnumber[i] == account) //jos accountnumber, joka on sillä rivillä, mihin i viittaa, on sama kuin minkä syöttäjä syötti
                    {
                        listposition = i; //i:n tiedot tallentuvat muuttujaan listposition (sisältää id:n, pinkoodin ja tilillä olevan rahamäärän)
                        success = false; //lähtee while:n sisältä pois
                        break; //lähtee for:n sisältä pois
                    }
                }
                if (success == true)
                {
                    tries++;
                    Console.Clear();
                    Console.WriteLine("Wrong account number, please try again using digits: ");
                    account = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (tries == 3 && success == true) //käyttäjä syöttänyt accountnumberin 3 kertaa väärin
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have entered the wrong account number 3 times, your account has now been locked");
                return 999; //palautetaan virhekoodina, että tilinumeroa yritetty liian monta kertaa (metodista pitää palauttaa jotakin ja 999 ei ole käytössä muualla)
            }
            else
                return listposition; //palauttaa bankatm:n puolelle tiedon siitä, mitä riviä käsitellään
        }
        public static int EnterPin()
        {
            int pin1;
            Console.WriteLine("Please enter your pin using digits: ");
            pin1 = Convert.ToInt32(Console.ReadLine());
            return pin1;
        }

        public static void EnterNewPin(List<int> pincode, int listposition)
        {
            Console.WriteLine("Please enter your new pin code using only four digits: ");
            pincode[listposition] = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Your pin code is changed");
        }

        public static void TooManyWrongPins()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have entered the wrong pin code 3 times, your card has now been locked");
        }
    }
}
