using System;
using System.Collections.Generic;

namespace ListReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPeople = new List<Person>() 
            {
                new Person(1, "Walter", "White"),
                new Person(2, "Gustavo", "Fring"),
                new Person(3, "Mike", "Ehrmantraut"),
                new Person(1, "Dude", "White")
            };

            Console.WriteLine("The first person in the list: " + listOfPeople[0].FirstName + " and the third person: " +
            listOfPeople[2].FirstName + " are the same? " + listOfPeople[0].Equals(listOfPeople[2]));
            
            Console.WriteLine("\nSet the first person in the list to equal the third person in the list.\n");
            listOfPeople[0] = listOfPeople[2];

            Console.WriteLine("The first person in the list: " + listOfPeople[0].FirstName + " and the third person: " +
            listOfPeople[2].FirstName + " are the same? " + listOfPeople[0].Equals(listOfPeople[2]));

            Console.WriteLine("\nLet's change the name of the first person in the list to 'Dude'.\n");
            listOfPeople[0].FirstName = "Dude";

            Console.WriteLine("The first person in the list: " + listOfPeople[0].FirstName + " and the third person: " +
            listOfPeople[2].FirstName + " are the same? " + listOfPeople[0].Equals(listOfPeople[2]));

            Console.WriteLine("The first person in the list: " + listOfPeople[0].FirstName + " and the fourth person: " +
            listOfPeople[3].FirstName + " are the same? " + listOfPeople[0].Equals(listOfPeople[3]));

            var listOfPeopleValue = new List<PersonValue>() 
            {
                new PersonValue
                {
                   id = 1,
                   firstName = "Walter",
                   lastName = "White"
                },
                new PersonValue
                {
                    id = 2,
                    firstName = "Gustavo",
                    lastName = "Fring"
                },
                new PersonValue 
                {
                    id = 3,
                    firstName = "Mike",
                    lastName = "Ehrmantrout"
                },
                new PersonValue
                {
                    id = 1,
                    firstName = "Walter",
                    lastName = "White"
                }
            };

            Console.WriteLine("*************************************************************");

            Console.WriteLine("The first person in the list: " + listOfPeopleValue[0].firstName + " and the third person: " +
            listOfPeopleValue[2].firstName + " are the same? " + listOfPeopleValue[0].Equals(listOfPeople[2]));

                        Console.WriteLine("\nSet the first person in the list to equal the third person in the list.\n");
            listOfPeopleValue[0] = listOfPeopleValue[2];

                        Console.WriteLine("The first person in the list: " + listOfPeopleValue[0].firstName + " and the third person: " +
            listOfPeopleValue[2].firstName + " are the same? " + listOfPeopleValue[0].Equals(listOfPeople[2]));
        }
    }
}
