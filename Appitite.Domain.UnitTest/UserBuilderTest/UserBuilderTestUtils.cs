using Apptite.Domain.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Appitite.Domain.UnitTest.UserBuilderTest
{
    public class UserBuilderTestUtils
    {



        public static UserBuilder getCorrectUser()
        {
            return new UserBuilder()
                .WithName("Cloud")
                .WithSurname("Strife")
                .SetLogin("Xsoldier")
                .SetPassword("Aeriths2", "Aeriths2")
                .SetEmail("cloud@Avalanche.com");
        }
    }
}
