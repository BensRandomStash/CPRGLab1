using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonlab
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        }

        public string DisplayPersonInfo()
        {
            string info;

            info = id + ": " + (firstName + " " + lastName) + "'s favorite color is: " + favoriteColor;

            return info;
        }

        public void ChangefavoriteColor()
        {
            favoriteColor = "White";
        }

        public int GetAgeInTenYears()
        {
            int ageInTenYears = age + 10;

            return ageInTenYears;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "ID:\t" + id + "\n";
            formatted += "First Name:\t" + firstName + "\n";
            formatted += "Last Name:\t" + lastName + "\n";
            formatted += "Age:\t" + age + "\n";
            formatted += "Favorite Color:\t" + favoriteColor + "\n";
            formatted += "Is working?:\t" + isWorking + "\n";

            return formatted;
        }
    }
}