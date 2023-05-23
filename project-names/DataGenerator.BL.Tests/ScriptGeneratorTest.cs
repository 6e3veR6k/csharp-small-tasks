using DataGenerator.BL.Interfaces;
using DataGenerator.Data.Models;
using NUnit.Framework;


namespace DataGenerator.BL.Tests
{
    [TestFixture]
    internal class ScriptGeneratorTest
    {
        private IScriptGenerator scriptGenerator;

        [SetUp]
        public void Init()
        {
            scriptGenerator = null;
        }

        [Test]
        public void GenerateUser_FirstNameRequired()
        {
            UserEntity user = scriptGenerator.GenerateUser();
            string firstName = user.FirstName;

            Assert.That(firstName, Is.Not.Empty);
        }


        [Test]
        public void GenerateUser_LastNameRequired()
        {
            UserEntity user = scriptGenerator.GenerateUser();
            string lastName = user.LastName;

            Assert.That(lastName, Is.Not.Empty);
        }


        [Test]
        public void GenerateUser_EmailRequired()
        {
            UserEntity user = scriptGenerator.GenerateUser();
            string email = user.Email;

            Assert.That(email, Is.Not.Empty);
        }


        [Test]
        public void GenerateUser_RegistrationDateInPeriod()
        {
            UserEntity user = scriptGenerator.GenerateUser();
            DateTime registrationDate = user.RegisteredDate;

            Assert.That(registrationDate, Is.InRange(new DateTime(2010, 1, 1), new DateTime(2020, 12, 31)));
        }


        [Test]
        public void GenerateUser_GetValueLine()
        {
            UserEntity user = new UserEntity()
            {
                FirstName = "Dmytro",
                LastName = "Bezvershuk",
                MiddleName = "Alexandrovich",
                Login = "bezvershuk_do",
                Email = "Dmytro.Bezvershuk@gmail.com",
                Password = "zxcv12233",
                RegisteredDate = new DateTime(2003, 8, 1)
            };

            const string EXPECTED_VALUE = "VALUES ('Dmytro', 'Bezvershuk', 'Alexandrovich', 'Dmytro.Bezvershuk@gmail.com', 'bezvershuk_do', 'zxcv12233', '20030801')";
            string result = scriptGenerator.GetValueString(user);

            Assert.That(result, Is.EqualTo(EXPECTED_VALUE));
        }


        [Test]
        public void GenerateUser_GetInsertLine()
        {
            const string EXPECTED_VALUE = "INSERT INTO dbo.BlogUser (FirstName, LastName, MiddleName, Email, Login, Password, RegisteredDate)";

            string result = scriptGenerator.GetInsertLine();

            Assert.That(result, Is.EqualTo(EXPECTED_VALUE));
        }
    }
}
