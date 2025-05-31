using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public static class MailService
{
    public static async Task SendMailAsync(string name, string email, string subject, string message)
    {
        // Static configuration
        string smtpServer = "smtp.gmail.com";
        int port = 587;
        string senderName = "Neelkanth Controls";
        string senderEmail = "aksheshpatel2019@gmail.com"; 
        string username = "aksheshpatel2019@gmail.com";    
        string password = "byjc qblt enqo ysii";     

        var mail = new MailMessage
        {
            From = new MailAddress(senderEmail, senderName),
            Subject = subject,
            Body = $"From: {name} <{email}>\n\n{message}",
            IsBodyHtml = false
        };

        mail.To.Add(senderEmail); // Sends to yourself

        using var smtp = new SmtpClient(smtpServer, port)
        {
            Credentials = new NetworkCredential(username, password),
            EnableSsl = true
        };

        await smtp.SendMailAsync(mail);
    }
}
