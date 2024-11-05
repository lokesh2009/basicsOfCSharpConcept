

using LeadDesignPattern.src.OopsPrinciple.Inheritance;

namespace LeadDesignPattern.OopsPrinciple.Inheritance{


    public class Plane : Vehicle{

     

        public override void Start()
        {
            System.Console.WriteLine("Plane starts...");

        }

        public override void Stop()
        {
         System.Console.WriteLine("Plane stops")   
        }

    }
    }
