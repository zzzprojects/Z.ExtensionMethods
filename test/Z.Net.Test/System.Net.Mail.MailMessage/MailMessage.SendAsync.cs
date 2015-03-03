using System.Net.Mail;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Net.Test
{
    [TestClass]
    public class System_Net_Mail_MailMessage_SendAsync
    {
        [TestMethod]
        public void SendAsync()
        {
            var token = new object();

            // Type
            var @this = new MailMessage("noreply@zzzportal.com", "noreply@zzzportal.com", "Fizz", "Buzz");

            // Examples
            @this.SendAsync(token); // Send a mail async
        }
    }
}