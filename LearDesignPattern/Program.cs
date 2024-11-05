// Encapsulation

using LeadDesignPattern.OopsPrinciple.Encapsulation;
using LeadDesignPattern.OopsPrinciple.Inheritance;
using LeadDesignPattern.src.OopsPrinciple.Abstraction;
using LeadDesignPattern.src.OopsPrinciple.Encapsulation;
using LeadDesignPattern.src.OopsPrinciple.Inheritance;


BankAccount bankAccount = new BankAccount(100);
//System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

bankAccount.Widthdraw(100);


// Abstraction

EmailService emailService = new EmailService();
emailService.sendEmail();

var car = new Car();
car.Start();
car.Brand="Ford";
car.Stop();

List<Object> list= new List<object>();
list.Add(new Car{Brand="KIA",Modal="XZ+",Year="2024",numberOfWheels=4,NumberofDoors=4});
list.Add(new Bike{Brand="Yamaha",Modal="yzPlus",Year="2020"} );

// Difference between composition and Inheritance


