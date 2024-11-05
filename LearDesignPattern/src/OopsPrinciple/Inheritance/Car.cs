namespace LeadDesignPattern.src.OopsPrinciple.Inheritance
{

public class Car:Vehicle{

    public int NumberofDoors{get;set;}

    public int numberOfWheels{get;set;}
    public String Brand{get;set;}
    public string Model{get;set;}
    public string Year{set;get;}

    public override void Start(){

        System.Console.WriteLine("Car Start..");
    }

    public override void Stop(){

        System.Console.WriteLine(" Car Stop ");
    } 


        

    
}

}