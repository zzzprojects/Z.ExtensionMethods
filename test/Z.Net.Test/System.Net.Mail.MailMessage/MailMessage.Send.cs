// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Net.Test
{
    [TestClass]
    public class System_Net_Mail_MailMessage_Send
    {
        [TestMethod]
        public void Send()
        {
            // Type
            var @this = new MailMessage("noreply@zzzportal.com", "noreply@zzzportal.com", "Fizz", "Buzz");

            // Examples
            @this.Send(); // Send a mail
        }
    }
}