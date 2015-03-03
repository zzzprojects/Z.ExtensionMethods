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