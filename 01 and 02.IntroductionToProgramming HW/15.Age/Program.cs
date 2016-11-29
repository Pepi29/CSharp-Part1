using System;
using System.Globalization;

class AgeAfter10Years
{
    static void Main()
    {

        DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", CultureInfo.InvariantCulture);

        DateTime presentYear = DateTime.Now;
        TimeSpan TS = presentYear - dateOfBirth;

        DateTime Age = DateTime.MinValue.AddDays(TS.Days);

        Console.WriteLine(Age.Year - 1);
     
        int ageAfterTen = Age.Year + 9;
        Console.WriteLine(ageAfterTen);

    }
}