using System;
using System.IO;
using System.Globalization;
using Course2.Entities;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rodri\OneDrive\Desktop\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                        Console.WriteLine(emp);                    
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("Error in file path: " + e.Message);
            }


        }
    }
}        
        