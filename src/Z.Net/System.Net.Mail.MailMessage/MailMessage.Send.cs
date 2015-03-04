// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Net.Mail;

public static partial class Extensions
{
    /// <summary>
    ///     A MailMessage extension method that send this message.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    public static void Send(this MailMessage @this)
    {
        using (var smtpClient = new SmtpClient())
        {
            smtpClient.Send(@this);
        }
    }
}