using DependencyInjectionExample;
using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        ClassRoom classRoom = new(new Teacher());
        var result = classRoom;

        result.GetTeacherInfo();
    }
}