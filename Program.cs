// See https://aka.ms/new-console-template for more information
using ConsoleAppTwo;
List<Employee> employees = new List<Employee>()
{
    new Employee(){Id=1,Name="Vijay",Designation="Developer",Doj=new DateTime(day:23,month:11,year:2023)},
    new Employee(){Id=2,Name="Riya",Designation="Manager",Doj=new DateTime(day:22,month:10,year:2023)},
    new Employee(){Id=3,Name="Simi",Designation="Tester",Doj=new DateTime(day:21,month:01,year:2023)},
    new Employee(){Id=4,Name="Vinay",Designation="Developer",Doj=new DateTime(day:11,month:09,year:2023)},
    new Employee(){Id=5,Name="Raj",Designation="Manager",Doj=new DateTime(day:25,month:05,year:2023)},
    new Employee(){Id=6,Name="Nitesh",Designation="Developer",Doj=new DateTime(day:22,month:12,year:2023)}
};

Console.WriteLine("Id  \t Name   \t   Designation \t   Date of joining ");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id + "\t\n");
    Console.Write(emp.Name + "\t\n");
    Console.Write(emp.Designation + "\t\t");
    Console.Write(emp.Doj.ToLongDateString());
}


