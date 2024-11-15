using System;

/// <summary>
/// This is the user service class but it violates the single responsibility principle.
/// Instead of just registering the user, it also validates the email.
/// </summary>
public class UserServiceViolation
{
	public UserServiceViolation() 
    { 
        Console.WriteLine("UserServiceViolation instance created.");
    }

    public void Register(string email, string username)
    {
        if (ValidateEmail(email))
        {
            Console.WriteLine("Email is not valid.");
            return;
        }

        Console.WriteLine($"User with username: {username} and email: {email} is registered.");
    }

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
