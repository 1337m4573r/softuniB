//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string nameFirst = "Amanda";
        string nameLast = "Jonson";
        byte age = 27;
        char gender = 'f';
        ulong numberPID = 8306112507;
        ushort numberUE = 3571;
        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: 2756{5}", nameFirst, nameLast, age, gender, numberPID, numberUE);
    }
}

