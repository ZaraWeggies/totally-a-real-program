using RealProgram.src.Entities;
    
namespace RealProgram.src
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person zara = new Person();
            Job softwareEngineer = new Job();
            Gender woman = new Gender();
            Gender man = new Gender();
            Gender nonbinary = new Gender();

            woman.Pronoun = "She/Her";
            man.Pronoun = "He/Him";
            nonbinary.Pronoun = "They/Them";

            softwareEngineer.Title = "Software Engineer";
            softwareEngineer.Salary = 900000;
            softwareEngineer.Location = "Remote";
            softwareEngineer.YearsExperience = 100;

            zara.Name = "Zara";
            zara.Age = 400;
            zara.Job = softwareEngineer;
            zara.Gender = woman;

            Console.WriteLine("Hello, World!");
        }
    }
}