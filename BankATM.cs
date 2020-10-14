using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace ATM
{
    class BankATM
    {
        public void OurATM()
        {
            int pin1; //asetetaan muuttuja
            int exit = 0;
            int listposition = 0;

            List<int> pincode = new List<int>(); //luo listan pincode, joka sisältää numeerisen pinkoodin
            List<double> balance2 = new List<double>(); //luo listan balance2, joka sisältää numeerisen saldon
            List<int> accountnumber = new List<int>();
            var strPath = @"User.csv"; //tallentaa "User.csv" tiedoston sijainnin strPath nimiseen muuttujaan

            CSV.ReadingCSV(pincode, balance2, accountnumber, listposition, strPath); //hakee metodin ReadingCSV luokasta CSV ja kutsuu parametreja  

            int tries = 0; //alustetaan laskuri, joka lähtee nollasta
            while (tries < 3) //laskuri, joka laskee pin-koodin laittokerrat 
            {
                listposition = UserInfo.EnterAccountNumber(listposition, accountnumber); //palautetaan listposition metodista ulos
                if (listposition == 999) //tarkastaa, onko palauttanut virhekoodin. Jos on, ohjelma loppuu
                    break;

                pin1 = UserInfo.EnterPin();

                if (pincode[listposition] == pin1)
                {
                    Console.Clear();
                    Console.WriteLine("Pin verification successful\n");
                    tries = 4; //ohjaa pois laskurin loopista, mikäli pin on oikein

                    do
                    {
                        int choice = Menu.MenuOptions();

                        switch (choice)
                        {
                            case 1: //katso saldo
                                Console.WriteLine($"The balance on your account is {balance2[listposition]}€\n");
                                break;
                            case 2: //nosta rahaa
                                Console.Clear();
                                Console.WriteLine("Enter the amount to withdraw using digits and/or comma: ");
                                {
                                    double amount;
                                    bool arvo;
                                    MoneyTransactions.WithdrawMoney(out amount, out arvo);

                                    if (arvo == true) //ehto, joka tarkistaa että syötetty arvo on positiivinen
                                    {
                                        MoneyTransactions.EnterOnlyPositiveNumbers();
                                        break;
                                    }
                                    else
                                    {
                                        if (balance2[listposition] >= amount) 
                                        {
                                            int receipt = MoneyTransactions.Receipt(balance2, amount, listposition);

                                            if (receipt == 1)
                                                MoneyTransactions.AmountToWithdraw(balance2, amount, listposition);

                                            else
                                                Console.WriteLine("Please take your money");
                                        }
                                        else
                                            MoneyTransactions.NotEnoughBalance();
                                    }
                                }
                                exit = 1; //ohjaa switch-loopista pois
                                break;
                            case 3: //rahan tallennus
                                MoneyTransactions.DepositMoney(balance2, listposition);
                                break;
                            case 4: //pin-koodin vaihto
                                Console.WriteLine("Please enter your previous pin code using only four digits: ");
                                int prepin = int.Parse(Console.ReadLine()); //käyttäjän syöttämä vanha pinkoodi tallentuu prepin muuttujaan
                                Console.Clear();

                                if (prepin == pincode[listposition])
                                    UserInfo.EnterNewPin(pincode, listposition);
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter your correct pin using only four digits");
                                    break;
                                }
                                break;
                            case 5: //valikon lopetus
                                Console.WriteLine("Please remove your card!");
                                exit = 1;
                                break;
                            default: //virheilmoitus
                                Console.WriteLine("Wrong choice, please try again");
                                break;
                        }
                    }
                    while (exit == 0);
                }
                else if (++tries < 3) //mikäli pin-koodi syötetään väärin antaa virheilmoituksen
                {
                    Console.Clear();
                    Console.WriteLine("Wrong pin code, please try again using only four digits!");
                }
                else
                {
                    UserInfo.TooManyWrongPins();
                    break;
                }
                CSV.WritingCSV(pincode, balance2, accountnumber, listposition, strPath);
            }
        }
    }
}