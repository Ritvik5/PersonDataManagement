﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonDataMang
    {
        public static void Display(Person person)
        {
            Console.WriteLine($"Person with SSN: {person.SSN} ,Name: {person.Name} ,Address: {person.Address} ,Age: {person.Age}.");
        }
        public static void AddRecords(List<Person> personList)
        {
            personList.Add(new Person(1, "Pot", "Mumbai", 25));
            personList.Add(new Person(2, "Bot", "Mumbai", 55));
            personList.Add(new Person(3, "Rae", "Pune", 17));
            personList.Add(new Person(4, "Tom", "Delhi", 18));
            personList.Add(new Person(5, "Ross", "Rampur", 75));
            personList.Add(new Person(6, "Racheal", "Manali", 15));
            personList.Add(new Person(7, "Joey", "Dehradun", 35));
            personList.Add(new Person(8, "John", "Mumbai", 65));
            personList.Add(new Person(9, "Snow", "Kanpur", 14));
            personList.Add(new Person(10, "Jack", "Lucknow", 15));
        }
        
        public static void DisplayAllRecords(List<Person> personList)
        {
            foreach(Person person in personList)
            {
                Display(person);
            }
        }

        public static void RetreiveTop2Records(List<Person> personList)
        {
            foreach(Person person in personList.FindAll(x => x.Age < 60).Take(2))
            {
                Display(person);
            }
        }

        public static void RetreiveBetweenRange(List<Person> personList)
        {
            foreach(Person person in personList.FindAll(x => x.Age >=13 && x.Age <= 18))
            {
                Display(person);
            }
        }

        public static void AverageAge(List<Person> personList)
        {
            var averageAge = personList.Average(x => x.Age);
            Console.WriteLine("The average age is : "+averageAge);
        }
    }
}
