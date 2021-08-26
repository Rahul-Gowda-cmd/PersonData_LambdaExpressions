using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonData_LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            List<Person> listpersoninCity = new List<Person>();
            AddRecords(listpersoninCity);

            Retriving_ToptwoRecord_IsAge_lessthanSixty(listpersoninCity);
            Checkingfor_TeenagerPerson(listpersoninCity);

        }

        private static void AddRecords(List<Person> listpersoninCity)
        {
            listpersoninCity.Add(new Person("101", "Sam", "13 Main, city Newyork", 18));
            listpersoninCity.Add(new Person("102", "Rahul", "11 Main, city Newyork", 25));
            listpersoninCity.Add(new Person("103", "Ravi", "12 Main, city Newyork", 27));
            listpersoninCity.Add(new Person("104", "Raju", "14 Main, city Newyork", 41));
            listpersoninCity.Add(new Person("105", "Sam", "13, Main, city Newyork", 45));
            listpersoninCity.Add(new Person("106", "Abc", "16 Main, city Newyork", 54));
            listpersoninCity.Add(new Person("107", "xyz", "17 Main, city Newyork", 70));
            
        }
        //UC2
        private static void Retriving_ToptwoRecord_IsAge_lessthanSixty(List<Person> listpersoninCity)
        {
            foreach(Person person in listpersoninCity.FindAll(e => (e.Age <60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\t Age" + person.Age);
            }
        }

        //UC3
        private static void Checkingfor_TeenagerPerson(List<Person> listpersoninCity)
        {
            if(listpersoninCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine("Yes, we have some Teenagers in List");
            }
            else
            {
                Console.WriteLine("We dont have any Teenagers in List");
            }
        }
    }
}
