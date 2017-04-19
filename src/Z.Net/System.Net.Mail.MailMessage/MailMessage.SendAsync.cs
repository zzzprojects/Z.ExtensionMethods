// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Net.Mail;

public static partial class Extensions
{
    /// <summary>
    ///     A MailMessage extension method that sends this message asynchronous.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="userToken">The user token.</param>
    public static void SendAsync(this MailMessage @this, object userToken)
    {
        using (var smtpClient = new SmtpClient())
        {
            smtpClient.SendAsync(@this, userToken);
        }
    }
}