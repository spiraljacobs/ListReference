using System;
using System.Collections.Generic;

namespace ListReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPeopleRefernceType = new List<PersonReferenceType>() 
            {
                new PersonReferenceType(1, "Walter", "White"),
                new PersonReferenceType(2, "Gustavo", "Fring"),
                new PersonReferenceType(3, "Mike", "Ehrmantraut"),
                new PersonReferenceType(1, "Dude", "White")
            };
            Console.WriteLine("\n*************************************************************");
            Console.WriteLine("Reference Types Explored");
            Console.WriteLine("*************************************************************\n");

            Console.WriteLine("The first person in the list: " + listOfPeopleRefernceType[0].FirstName + " and the third person: " +
            listOfPeopleRefernceType[2].FirstName + " are the same? " + listOfPeopleRefernceType[0].Equals(listOfPeopleRefernceType[2]));
            
            Console.WriteLine("\nSet the first person in the list to equal the third person in the list.\n");
            listOfPeopleRefernceType[0] = listOfPeopleRefernceType[2];

            Console.WriteLine("The first person in the list: " + listOfPeopleRefernceType[0].FirstName + " and the third person: " +
            listOfPeopleRefernceType[2].FirstName + " are the same? " + listOfPeopleRefernceType[0].Equals(listOfPeopleRefernceType[2]));

            Console.WriteLine("\nLet's change the name of the first person in the list to 'Dude'.\n");
            listOfPeopleRefernceType[0].FirstName = "Dude";

            Console.WriteLine("The first person in the list: " + listOfPeopleRefernceType[0].FirstName + " and the third person: " +
            listOfPeopleRefernceType[2].FirstName + " are the same? " + listOfPeopleRefernceType[0].Equals(listOfPeopleRefernceType[2]));

            Console.WriteLine("The first person in the list: " + listOfPeopleRefernceType[0].FirstName + " and the fourth person: " +
            listOfPeopleRefernceType[3].FirstName + " are the same? " + listOfPeopleRefernceType[0].Equals(listOfPeopleRefernceType[3]));


            // values of the first and the last structs are the same.
            var listOfPeopleValue = new List<PersonValueType>() 
            {
                new PersonValueType()
                {
                   id = 1,
                   firstName = "Walter",
                   lastName = "White"
                },
                new PersonValueType()
                {
                    id = 2,
                    firstName = "Gustavo",
                    lastName = "Fring"
                },
                new PersonValueType()
                {
                    id = 3,
                    firstName = "Mike",
                    lastName = "Ehrmantrout"
                },
                new PersonValueType()
                {
                    id = 1,
                    firstName = "Walter",
                    lastName = "White"
                }
            };

            Console.WriteLine("\n*************************************************************");
            Console.WriteLine("Value Types in a list explored");
            Console.WriteLine("*************************************************************\n");

             Console.WriteLine("The first person in the list: " + listOfPeopleValue[0].firstName + " and the fourth person: " +
            listOfPeopleValue[3].firstName + " are the same? " + listOfPeopleValue[0].Equals(listOfPeopleValue[3]));


            Console.WriteLine("The first person in the list: " + listOfPeopleValue[0].firstName + " and the third person: " +
            listOfPeopleValue[2].firstName + " are the same? " + listOfPeopleValue[0].Equals(listOfPeopleValue[2]));

            Console.WriteLine("\nSet the first person in the list to equal the third person in the list.\n");
            listOfPeopleValue[0] = listOfPeopleValue[2];

            Console.WriteLine("The first person in the list: " + listOfPeopleValue[0].firstName + " and the third person: " +
            listOfPeopleValue[2].firstName + " are the same? " + listOfPeopleValue[0].Equals(listOfPeopleValue[2]));

            Console.WriteLine("\n*************************************************************");
            Console.WriteLine("More Value Types");
            Console.WriteLine("*************************************************************\n");

            var mike = new PersonValueType();
            mike.id = 1;
            mike.firstName = "Mike";
            mike.lastName = "Ehrmantraut";

            var mikeTheSecond = new PersonValueType();
            mikeTheSecond.id = 1;
            mikeTheSecond.firstName = "Mike";
            mikeTheSecond.lastName = "Ehrmantraut";

            Console.WriteLine("Are the two Mike's equal? " + mike.Equals(mikeTheSecond));
            mike.firstName = "Bill";
            Console.WriteLine("The Mike's first names are: " + mike.firstName + " & " + mikeTheSecond.firstName);
            Console.WriteLine("Are the two Mike's equal? " + mike.Equals(mikeTheSecond));
            mikeTheSecond.firstName = "Bill";
            Console.WriteLine("The Mike's first names are: " + mike.firstName + " & " + mikeTheSecond.firstName);
            Console.WriteLine("Are the two Mike's equal? " + mike.Equals(mikeTheSecond));



        }
    }
}
