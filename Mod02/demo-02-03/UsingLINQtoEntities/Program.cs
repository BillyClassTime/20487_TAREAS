using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UsingLINQtoEntity.Database;
using UsingLINQtoEntity.Models;

namespace UsingLINQtoEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                DbInitializer.Initialize(context);

                var cursos = from c in context.Courses select c;
                foreach (var curso in cursos)
                {
                    System.Console.WriteLine($"Curso name: {curso.Name}");
                    foreach (var student in curso.Students)
                          {
                            System.Console.WriteLine($"Student name: {student.Name}");
                          }          
                }
            }
        }
    }
}
