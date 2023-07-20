using RealProgram.src.Entities;
    
namespace RealProgram.src
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create some sample genders
            Gender woman = new Gender() { Pronoun = "She/Her" };
            Gender man = new Gender() { Pronoun = "He/Him" };
            Gender nonbinary = new Gender() { Pronoun = "They/Them" };

            //Create some jobs
            Job softwareEngineer = new Job()
            {
                Title = "Software Engineer",
                Salary = 900000,
                Location = "Remote",
                YearsExperience = 8
            };

            Job teacher = new Job()
            {
                Title = "Teacher",
                Salary = 30000,
                Location = "Tupper Lake, NY",
                YearsExperience = 1
            };

            Job unemployed = new Job()
            {
                Title = "Unemployed",
                Salary = 0,
                Location = "None",
                YearsExperience = 0
            };

            Job dentist = new Job()
            {
                Title = "Dentist",
                Salary = 230000,
                Location = "New York, NY",
                YearsExperience = 4
            };

            //Create a list of people and add some people to it
            List<Person> people = new List<Person>();

            people.Add(new Person()
            {
                Name = "Zara",
                Age = 400,
                Job = softwareEngineer,
                Gender = woman
            });

            people.Add(new Person()
            {
                Name = "Joseph",
                Age = 25,
                Job = dentist,
                Gender = man
            });

            people.Add(new Person()
            {
                Name = "Kevin",
                Age = 21,
                Job = unemployed,
                Gender = man
            });

            people.Add(new Person()
            {
                Name = "Kim",
                Age = 35,
                Job = teacher,
                Gender = nonbinary
            });

            //Print out the people
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name + " is a " + person.Age + "-year-old person whose pronouns are '" + 
                    person.Gender.Pronoun + "'. Their current job title is '" + person.Job.Title +"' and they make $" + 
                    person.Job.Salary.ToString() + "/year.");
            }
        }
    }
}