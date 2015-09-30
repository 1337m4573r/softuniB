//This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.
//You can test your solution on https://judge.softuni.bg/Contests/4/CSharp-Basics-Exam-11-April-2014-Morning .
//Lelia Vanche is a very keen freelance developer.
//She is well known for her outstanding skills, but she is also known
//for being pretty moody, which often affects her productivity.
//She also has a passion for bicycles and 10% of the normal work days she goes mountain-biking instead of working.
//You are asked to calculate whether Lelia Vanche can finish a project on time.
//You will be given the number of hours required to finish the project, the days that Lelia Vanche has available for
//working (mind that she goes to biking in 10% of this time) and her average productivity during the given period.
//Assume that a normal work day for Lelia Vanche has 12 hours.
//Note that only the whole hours are taken (e.g. 6.98 hours is rounded down to 6 hours).
//Input
//Input data should be read from the console. 
//- The number h (the required work hours to finish the project) is on the first input line.
//- The number d (the days available to finish the project) is on the second input line.
//- The number p (the productivity in percent) is on the third input line.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data must be printed on the console.
//- On the first output line you should print ‘Yes’ or ‘No’ if Lelya Vanche can complete the project.
//- On the second output line you should print the difference, between the project hours and the work hours.
//Constraints
//- The number h will be an integer between 0 and 2 147 483 647, inclusive.
//- The number d will be an integer between 0 and 89 478 485, inclusive.
//- The number p will be an integer between 0 and 100, inclusive.
//- Allowed working time for your program: 0.1 seconds.
//- Allowed memory: 16 MB.

using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int workHours = (int)((108L * (long)d * (long)p) / 1000L);
        int difference = workHours - h;
        if (difference >= 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine(difference);
    }
}

