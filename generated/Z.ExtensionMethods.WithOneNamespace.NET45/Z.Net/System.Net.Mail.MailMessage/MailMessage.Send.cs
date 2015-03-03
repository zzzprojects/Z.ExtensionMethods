namespace Z.ExtensionMethods
{

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

}