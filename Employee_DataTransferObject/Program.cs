using System;

namespace Employee_DataTransferObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employee = new Employee();

            //Note the Employee class contains properties including Id, FirstName, LastName, 
            //Department, Basic, DA, HRA, and NetSalary. 
            //However, the presentation layer might only need the Id, FirstName, LastName, 
            //and Department Name of the employees from the GetAllEmployees() method. 

            //If this method returns a List<Employee> then anyone would be able to see 
            //the salary details of an employee. You don’t want that. 

            EmployeeDTO employeeDTO = new EmployeeDTO();

            //We can create a converter class that contains two methods: 
            //one to convert an instance of the Employee model class to an instance of EmployeeDTO and 
            //(vice versa) one to convert an instance of EmployeeDTO to an instance of the Employee model class. 
            //But also we can take advantage of AutoMapper, a popular object-to-object mapping library to map 
            //these two dissimilar types
        }
    }
}
