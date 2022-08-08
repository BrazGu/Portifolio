namespace HerancaIntroducao.Entities
{
    //BusinessAccount - subclasse do Account - herança, está herdando todos os atributos e métodos e, acrescentando mais coisas.
    class BusinessAccount : Account
    {
        //=====ATRIBUTOS==========================
        public double LoanLimit { get; set; }
        //=====ATRIBUTOS==========================



        //=====CONSTRUTORES=======================
        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) //Construtor com herança da outra classe
        {
            LoanLimit = loanLimit;
        }
        //=====CONSTRUTORES=======================



        //=====MÉTODOS============================
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
        //=====MÉTODOS============================
    }
}
