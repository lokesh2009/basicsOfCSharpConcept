namespace LeadDesignPattern.src.OopsPrinciple.Abstraction
{

public class EmailService(){

    public void sendEmail(){
        System.Console.WriteLine("Sending email...");
    }

    public void Authenticate(){
        System.Console.WriteLine("Authenticate the user");

    }

    public void Connect(){

    System.Console.WriteLine("Connecting to email server...");
    }

    public void Disconnect(){
        System.Console.WriteLine("Disconnect with the email server...");
    }
}

}