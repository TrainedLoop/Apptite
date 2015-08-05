using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Apptite.Domain;
using Apptite.Domain.Builder;

namespace Appitite.Domain.UnitTest
{
    [TestClass]
    public class UserBuilderTest
    {
        [TestMethod]
        public void CorrectTestForBuildUser()
        {
            User user = new UserBuilder()
                .WithName("Arnold")
                .WithSurname("Nigga")
                .SetLogin("Nigganold")
                .SetPassword("nigger321", "nigger321")
                .SetEmail("Nigga@niggadomain.com");

            Assert.IsTrue(user.GetType() == typeof(User));               

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameWithOneCaracterForBuildUser()
        {
            User user = new UserBuilder()
                .WithName("a")
                .WithSurname("Nigga")
                .SetLogin("Nigganold")
                .SetPassword("nigger321", "nigger321")
                .SetEmail("Nigga@niggadomain.com");

            Assert.Fail();

        }
    }
}
