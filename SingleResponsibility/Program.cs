// See https://aka.ms/new-console-template for more information

// A class should have one and only one reason to change, meaning that a class should have only one job.
UserService userService = new UserService(new EmailService());

userService.Register("testhotmail.com", "testuser");