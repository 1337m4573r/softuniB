//A bank account has a holder name (first name, middle name and last name), available amount
//of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single
//bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Georgi";
        string middleName = "Ivanov";
        string lastName = "Dimitrov";
        decimal balanceEur = 1013.45M;
        string bankName = "DSK Bank";
        string iban = "BG20STSA93000021276680";
        long card1Number = 4539914379099371;
        long card2Number = 5312920913665650;
        long card3Number = 6011711562796215;

        Console.WriteLine("name: " + firstName + " " + middleName + " " + lastName +
                          "\nbalance: " + balanceEur + " euro in " + bankName +
                          "\nIBAN: " + iban + "\nCC#1: " + card1Number +
                          "\nCC#2: " + card2Number + "\nCC#3: " + card3Number);

    }
}

