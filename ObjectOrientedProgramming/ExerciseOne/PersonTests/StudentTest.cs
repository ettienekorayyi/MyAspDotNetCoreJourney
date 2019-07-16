using NUnit.Framework;
using Classes;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [TestCase("Stephen", 22)]
        public void GetStudentDetails_WhenCalled_ShouldReturnNameAndAge(string name, int age)
        {
            var expectedName = "Stephen";
            var expectedAge = 22;
            var mockStudent = new Student(name,age);

            Assert.AreEqual(expectedName,mockStudent.GetName());
            Assert.AreEqual(expectedAge,mockStudent.GetAge());
        }
    }
}