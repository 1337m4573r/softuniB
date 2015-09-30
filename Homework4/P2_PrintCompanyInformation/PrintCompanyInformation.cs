//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company
//and its manager and prints it back on the console.

#undef debug
using System;

class PrintCompanyInformation
{
    static void Main()
    {
#if debug
        string name = "Software University";
        string address = "26 V. Kanchev, Sofia";
        string phoneNumber = "+359 899 55 55 92";
        string faxNumber = "";
        string website = "http://softuni.bg";
        string managerFirstName = "Svetlin";
        string managerLastName = "Nakov";
        int managerAge = 25;
        string managerPhoneNumber = "+359 2 981 981";
#else
        string name = Console.ReadLine();
        string address = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string website = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhoneNumber = Console.ReadLine();
#endif
        if (phoneNumber == "")
        {
            phoneNumber = "(no tel)";
        }
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        if (managerPhoneNumber == "")
        {
            managerPhoneNumber = "(no tel)";
        }

        Console.WriteLine("{0}\n" +
            "Address: {1}\n" +
            "Tel. {2}\n" +
            "Fax: {3}\n" +
            "Web site: {4}\n" +
            "Manager: {5} {6} (age:{7}, tel. {8})",
            name, address, phoneNumber, faxNumber, website,
            managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}

