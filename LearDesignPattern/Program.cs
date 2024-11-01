// Encapsulation

using LeadDesignPattern.OopsPrinciple.Encapsulation;
using LeadDesignPattern.src.OopsPrinciple.Abstraction;
using LeadDesignPattern.src.OopsPrinciple.Encapsulation;


BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

bankAccount.Widthdraw(100);


// Abstraction

EmailService emailService = new EmailService();
emailService.Connect();
emailService.Authenticate();
emailService.sendEmail();
emailService.Disconnect();