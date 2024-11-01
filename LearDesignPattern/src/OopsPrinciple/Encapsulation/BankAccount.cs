

namespace LeadDesignPattern.OopsPrinciple.Encapsulation{

public class BankAccount{

    private Decimal balance;

    public BankAccount(decimal balance){
        Deposit(balance);
    }

    public void Deposit(decimal amaount){
        balance = amaount;
        if(amaount <=0){
            throw new ArgumentException("Deposit amount should be positive");
        }
       this.balance+=amaount;
    }

public void Widthdraw(decimal amount){

    if(amount<=0){
        throw new ArgumentException("Withdrawl amount must be positive");
    }
     if(amount>balance){
        throw new InvalidOperationException("Insufficient funds");
     }
     this.balance-=amount;
}

}

}