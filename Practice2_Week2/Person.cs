using System;
namespace Practice2_Week2
{
    public class Person
    {

        public string name;
        public int age;
        public DateTime birthdate;


        public Person()
        {
            name = "Aldo";
            age = 12;
        }


        public void setName()
        {
            Console.WriteLine("Full Name: ");
            name = Console.ReadLine();
            Console.WriteLine(name);
        }

        public void setAge()
        {
            Console.WriteLine("Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name);
        }

        public int GetBirthDate(DateTime now)
        {
            Console.WriteLine("Your BirthDate is: ");
            age = now.Year - birthdate.Year;
            if(now.Month < birthdate.Month|| (now.Month == birthdate.Month && now.Day < birthdate.Day))
                age--;

              return age;
        }
    }
}
