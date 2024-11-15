using System;

/// <summary>
/// This is the email service. Sole responsibility is to send emails and validate emails.
/// </summary>
public class EmailService
{
    public bool ValidateEmail(string email)
    {
        return email.Contains("@");
    }

    public bool EmailSend(string email, string message)
    {
        Console.WriteLine($"Email sent to {email} with message: {message}");
        return true;
    }
}
