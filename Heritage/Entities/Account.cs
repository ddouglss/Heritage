namespace Heritage.Entities
{
    //Implementação Básica da Conta 
    class Account
    {
        public int Number { get; private set; } //Número
        public string Holder { get; private set; } //Titular
        public double Balance { get; protected set; } //Saldo

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //Retirar-Quantia

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        //Depositar-Quantia
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
