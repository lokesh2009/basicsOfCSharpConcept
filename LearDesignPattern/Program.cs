// Encapsulation

using LeadDesignPattern.OopsPrinciple.Encapsulation;
using LeadDesignPattern.src.OopsPrinciple.Encapsulation;


BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

bankAccount.Widthdraw(100);