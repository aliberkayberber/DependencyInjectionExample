using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class Teacher : ITeacher
    {
        public string FirstName = "Sertan";
        public string LastName = "Bozkuş";

        
        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}"); 
        }
    }
}
