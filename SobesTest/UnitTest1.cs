using NUnit.Framework;
using Sobes;
using System;

namespace SobesTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTeacher()
        {
            //arrange 
            var surName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Parse("1960.12.12");
            var faculty = Guid.NewGuid().ToString();
            var position = Guid.NewGuid().ToString();
            var experience = 20;

            //act
            var teach = new Teacher(surName, birthDate, faculty, position, experience);

            //assert
            Assert.AreEqual(surName, teach.SurName);
            Assert.AreEqual(birthDate, teach.BrithDate);
            Assert.AreEqual(faculty, teach.Faculty);
            Assert.AreEqual(position, teach.Position);
            Assert.AreEqual(experience, teach.Experience);
        }

        [Test]
        public void TestManager()
        {
            //arrange 
            var surName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Parse("1960.12.12");
            var faculty = Guid.NewGuid().ToString();
            var position = Guid.NewGuid().ToString();


            //act
            var manag = new Manager(surName, birthDate, faculty, position);

            //assert
            Assert.AreEqual(surName, manag.SurName);
            Assert.AreEqual(birthDate, manag.BrithDate);
            Assert.AreEqual(faculty, manag.Faculty);
            Assert.AreEqual(position, manag.Position);

        }

        [Test]
        public void TestStudent()
        {
            //arrange 
            var surName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Parse("1960.12.12");
            var faculty = Guid.NewGuid().ToString();
            var course = 4;

            //act
            var stud = new Student(surName, birthDate, faculty, course);

            //assert
            Assert.AreEqual(surName, stud.SurName);
            Assert.AreEqual(birthDate, stud.BrithDate);
            Assert.AreEqual(faculty, stud.Faculty);
            Assert.AreEqual(course, stud.Course);

        }

        [Test]
        public void TestAdministrator()
        {
            //arrange 
            var surName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Parse("1960.12.12");
            var faculty = Guid.NewGuid().ToString();

            //act
            var admin = new Administrator(surName, birthDate, faculty);

            //assert
            Assert.AreEqual(surName, admin.SurName);
            Assert.AreEqual(birthDate, admin.BrithDate);
            Assert.AreEqual(faculty, admin.Faculty);

        }
    }
}