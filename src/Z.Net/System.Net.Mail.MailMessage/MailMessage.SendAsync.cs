// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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