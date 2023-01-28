using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonlab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true); 
            Person person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);

            string GinasInfo = person2.DisplayPersonInfo();
            Console.WriteLine(GinasInfo);

            string MikesInfo = person3.ToString();
            Console.WriteLine(MikesInfo);

            person1.ChangefavoriteColor();
            Console.WriteLine(person1.DisplayPersonInfo());

            person4.GetAgeInTenYears();
            Console.WriteLine("Mary's age in ten years is:" + person4.Age);

            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);

            Console.WriteLine(relation1.ToString());
            Console.WriteLine(relation2.ToString());

            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            int sum = 0;

            foreach (Person person in people)
            {
                sum += person.Age;
            }

            double average = sum / (double) people.Count;

            Console.WriteLine("Average age: " + average);

            Console.WriteLine(MikesInfo);
            Console.WriteLine(person3.ToString());
            Console.WriteLine(MikesInfo);
        }
    }
}
