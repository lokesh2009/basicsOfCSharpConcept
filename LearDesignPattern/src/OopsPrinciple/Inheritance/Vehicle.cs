namespace LeadDesignPattern.src.OopsPrinciple.Inheritance{

    public class Vehicle{

        public String Brand{get;set;}
        public String Modal{get;set;}

        public String Year{get;set;}

// Virtual methods in CSharp can be ovverride
     public virtual void Start(){

     System.Console.WriteLine("Start the engine....");
     }

     public virtual void Stop(){
        System.Console.WriteLine("press the key and Stop the enginee...");
     }

    }
}