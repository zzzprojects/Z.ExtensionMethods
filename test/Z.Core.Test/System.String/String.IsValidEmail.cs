// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsValidEmail
    {
        [TestMethod]
        public void IsValidEmail()
        {
            // Valid Emails
            {
                // Arrange
                var validEmails = new[]
                {
                    "email@example.com",
                    "firstname.lastname@example.com",
                    "email@subdomain.example.com",
                    "firstname+lastname@example.com",
                    "email@123.123.123.123",
                    "email@[123.123.123.123]",
                    "1234567890@example.com",
                    "email@example-one.com",
                    "_______@example.com",
                    "email@example.name",
                    "email@example.museum",
                    "email@example.co.jp",
                    "firstname-lastname@example.com"
                };

                // Act
                foreach (var validEmail in validEmails)
                {
                    // Act
                    var result = validEmail.IsValidEmail();

                    // Assert
                    Assert.IsTrue(result);
                }
            }

            // Invalid Emails
            {
                // Arrange
                var invalidEmails = new[]
                {
                    "plainaddress",
                    "#@%^%#$@#$@#.com",
                    "@example.com",
                    "Joe Smith <email@example.com>",
                    "email.example.com",
                    "email@example@example.com",
                    ".email@example.com",
                    "email.@example.com",
                    "email..email@example.com",
                    "email@example.com (Joe Smith)",
                    "email@example",
                    "email@-example.com",
                    //"email@example.web", // Should not be valid, not a top level domain, how should we handle this outside regex? Lookup dictionary of all valid top level domains?
                    "email@example..com",
                    "Abc..123@example.com"
                };

                // Act
                foreach (var validEmail in invalidEmails)
                {
                    // Act
                    var result = validEmail.IsValidEmail();

                    // Assert
                    Assert.IsFalse(result);
                }
            }
        }
    }
}