namespace LeadDesignPattern.src.OopsPrinciple.Abstraction
{

public class EmailService(){

    public void sendEmail(){
        Connect();
        Authenticate();
        System.Console.WriteLine("Sending email...");
        Disconnect();
    }

    private void Authenticate(){
        System.Console.WriteLine("Authenticate the user");

    }

    private void Connect(){

    System.Console.WriteLine("Connecting to email server...");
    }

    private void Disconnect(){
        System.Console.WriteLine("Disconnect with the email server...");
    }
}

}