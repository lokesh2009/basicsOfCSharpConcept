using LeadDesignPattern.src.OopsPrinciple.Inheritance;

namespace LeadDesignPattern.OopsPrinciple.Inheritance{


    public class Bike :Vehicle{

        int numberofWheels {get;set;}

        public override void Start()
        {
              System.Console.WriteLine("Bike Start..");
        }

        public override void Stop()
        {
            System.Console.WriteLine("Bike starts vroom vroom");
        }

    }

}
