using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftServeHW4
{
    public class Person
    {
        private string Name;
        private int BirthYear;
        public int Id;
        public Person(string modelName, int modelDate, int modelId)
        {
            Name = modelName;
            BirthYear = modelDate;
            Id = modelId;
        }


        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Person obj1 = new Person("Severyn", 2001, 0);
            Person obj2 = new Person("Roman", 2007, 1);
            Person obj3 = new Person("Olya", 2000, 2);
            Person obj4 = new Person("Max", 2015, 3);
            Person obj5 = new Person("Roman", 1980, 4);
            Person obj6 = new Person("Dasha", 1976, 5);
            persons.Add(obj1);
            persons.Add(obj2);
            persons.Add(obj3);
            persons.Add(obj4);
            persons.Add(obj5);
            persons.Add(obj6);
            do
            {
                Console.WriteLine("What do u wanna to do?0 print data, 1 GetAge, 2 Input,3 GetEqual, 4 GetYoung, 5 Change Name, 6 exit");
                var newAction = Convert.ToInt32(Console.ReadLine());
                switch ((Choice)newAction)
                {
                    case Choice.PrintAll:
                        OutPut(persons);
                        break;
                    case Choice.Age:
                        Age(persons);
                        break;
                    case Choice.Input:
                        Input(persons);
                        break;
                    case Choice.Equal:
                        EqualByName(persons);
                        break;
                    case Choice.Young:
                        Young(persons);
                        break;
                    case Choice.ChangeName:
                        ChangeName(persons);
                        break;
                    case Choice.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Try again, uknown operation!");
                        break;

                }
            } while (true);

        }
        public override string ToString()
        {
            return ($"Id: {Id} Name: {Name} BirthYear {BirthYear} ");
        }

        static void Age(List<Person> persons)
        {
            var users = persons;
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine($"Name: {persons[i].Name} Year: {DateTime.Now.Year - (persons[i].BirthYear)}");
            }
        }
        static void EqualByName(List<Person> persons)
        {
            Console.WriteLine("Enter name to see equall");
            int count = 0;
            var searchName = Console.ReadLine();
            foreach (var person in persons)
            {
                if (person.Name == searchName)
                {
                    count += 1;
                    Console.WriteLine( person.ToString());
                }
            }
            if (count < 0)
            {
                Console.WriteLine("No such name!");
            }
        }
        static void Young(List<Person> persons)
        {
            Console.WriteLine("ChangingName to young");
            for (int i = 0; i < persons.Count; i++)
            {
                if ((DateTime.Now.Year - (persons[i].BirthYear)) < 16)
                {
                    persons[i].Name = "Very Young";
                }
            }
        }


        static void ChangeName(List<Person> persons)
        {
            Console.WriteLine("Choose id who you want change");
            var chooseNum = int.Parse(Console.ReadLine());
            var existingUser = persons.FirstOrDefault(t => t.Id == chooseNum);
            if (existingUser == null)
            {
                Console.WriteLine("No such user!");
            }
            else
            {
                Console.WriteLine("Please enter new name: ");
                string newName = Console.ReadLine();
                persons[chooseNum].Name = newName;
            }
        }
        static void Input(List<Person> persons)
        {
            var maxId = persons.Any() ? persons.Max(user => user.Id) : 0;
            persons[persons.Count-1].Id = maxId+1;
            Console.WriteLine("Enter name:");
            var addName = Console.ReadLine();
            persons[persons.Count-1].Name = addName;
            Console.WriteLine("Enter year of birth: ");
            var addAge = int.Parse(Console.ReadLine());
            persons[persons.Count-1].BirthYear = addAge;
        }
        static void OutPut(List<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }

    }
}



