using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Apptite.Domain;
using Apptite.Domain.Builder;

namespace Appitite.Domain.UnitTest.UserBuilderTest
{
    [TestClass]
    public class UserBuilderTests
    {



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameWithOneCaracterForBuildUser()
        {
            new UserBuilder()
               .WithName("a");
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameWithMorethen20CaracterForBuildUser()
        {
            new UserBuilder()
                 .WithName("123456789012345678901");
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WithSurnameWithOneCaracterForBuildUser()
        {
            new UserBuilder()
                 .WithSurname("a");
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WithSurnameWithMorethen20CaracterForBuildUser()
        {
            new UserBuilder()
                 .WithSurname("123456789012345678901");
            Assert.Fail();

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLoginWith3CaracterForBuildUser()
        {
            new UserBuilder()
               .SetLogin("aaa");
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLoginWithMorethen20CaracterForBuildUser()
        {
            new UserBuilder()
                 .SetLogin("123456789012345678901");
            Assert.Fail();

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetPasswordWeakForBuildUser()
        {
            new UserBuilder()
                 .SetPassword("123", "123");
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetPasswordNotSameForBuildUser()
        {
            new UserBuilder()
                 .SetPassword("1234", "1235");
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetEmailInvalidForBuildUser()
        {
            new UserBuilder()
                 .SetEmail("asd1234@1234");
            Assert.Fail();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetEmailNotDomainForBuildUser()
        {
            new UserBuilder()
                .SetEmail("asf123.com");
            Assert.Fail();
        }





        [TestMethod]
        public void ImplictConverterCorrectTestForBuildUser()
        {
            User teste = UserBuilderTestUtils.getCorrectUser();
            Assert.IsTrue(teste.GetType() == typeof(User));

        }


    }
}
