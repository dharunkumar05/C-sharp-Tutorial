using System;

class Bank
{
    private int balance;

    public int Balance
    {
        get
        {
            return balance;
        }
        private set
        { 
            balance = value;
        }
    }
        public void deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        
    }
        public void withdraw(int amount)
    {
        if (amount>0 && amount <= Balance)
        {
            Balance-=amount;
        }

    }
}

class Encapsulation
{
    public static void Main()
    {
        Bank b = new Bank();
        Console.WriteLine(b.Balance);
        b.deposit(1000);
        Console.WriteLine(b.Balance);
        b.withdraw(500);
        b.withdraw(200);
        Console.WriteLine(b.Balance);
    }
}