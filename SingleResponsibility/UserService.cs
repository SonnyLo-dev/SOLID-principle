using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class UserService
{

	private EmailService emailService;

	public UserService(EmailService emailService)
	{
		this.emailService = emailService;
	}

	public void Register(string email, string username)
	{
		if (!emailService.ValidateEmail(email))
		{
			Console.WriteLine("Email is not valid.");
			return;
		}

		Console.WriteLine($"User with username: {username} and email: {email} is registered.");
	}

}
