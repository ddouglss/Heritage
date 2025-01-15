namespace Heritage.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; } //Limite de empréstimo

        public BusinessAccount() { }
        //Implementação da Herança
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;

        }

        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
