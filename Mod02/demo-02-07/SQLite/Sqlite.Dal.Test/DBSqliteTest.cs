using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sqlite.Dal.Database;
using Microsoft.EntityFrameworkCore;
using Sqlite.Dal.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using Sqlite.Dal.Repository;

namespace Sqlite.Dal.Test
{
    [TestClass]
    public class DBSqliteTest
    {
        private StudentRepository _studentRepository;
        private TeacherRepository _teacherRepository;

        private DbContextOptions<SchoolContext> _options =
                    new DbContextOptionsBuilder<SchoolContext>()
                        .UseSqlite(@"Data Source = D:\20_610\20487\Tareas\Mod02\demo-02-07\SQLite\Database\SqliteSchool.db")
                        .Options;

        public DBSqliteTest()
        {
            _studentRepository = new StudentRepository(_options);
            _teacherRepository = new TeacherRepository(_options);
        }

        [TestMethod]
        public void AddStudentTest()
        {
            Student student = new Student { Name = "Kari Hensien" };
            student = _studentRepository.Add(student);

            using (var context = new SchoolContext(_options))
            {
                var result = context.Students.FirstOrDefault((s) => s.PersonId == student.PersonId);
                Assert.IsNotNull(result);
            }
        }
    }
}
