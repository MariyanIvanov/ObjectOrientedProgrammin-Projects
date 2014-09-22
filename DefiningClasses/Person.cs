using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DefiningClasses
{
   public class Person
    {
        public string name;
        public string email;
        public int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is empty!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int Age
        {

            get
            {
                return this.age;
            }
            set
            {
                if (age < 0 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be in the range [1...100]");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Not a valid email adress!");
                }
                else
                {
                    this.email = value;
                }

            }
        }

        public Person( string name, int age, string email)
        {

            this.Name = name;
            this.Age -= age;
            this.Email = email;

        }
        public Person(string name, int age) : this(name,age, null) { }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                return string.Format("Name's person is {0}.\nHis age is{1}", this.Name, this.Age);
            }
            else
            {
                return string.Format("Name's person is{0}.\nHis age is{1}.\nHis email address is {2}.", this.Name, this.Age, this.Email);
            }


        }
    }
   

   }


