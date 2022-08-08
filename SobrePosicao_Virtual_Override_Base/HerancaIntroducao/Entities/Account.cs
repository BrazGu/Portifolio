namespace HerancaIntroducao.Entities
{
    class Account
    {
        //======ATRIBUTOS====================
        //private, neste caso, - podemos acessar de qualquer lugar, mas altera-se apenas NESTA classe
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        //proteced - podemos alterá-lo na subclasse
        //======ATRIBUTOS====================



        //=====CONSTRUTORES==================
        public Account()//contrutor padrao
        {

        }

        public Account(int number, string holder, double balance)
        {//com atributos/argumentos
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //=====CONSTRUTORES==================



        //=====MÉTODOS=======================
        public virtual void WithDraw(double amount) //VIRTUAL - permite que o método seja sobrescrito nas subaclasses
        {//SAQUE
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {//DEPÓSITO
            Balance += amount;
        }
        //=====MÉTODOS=======================
    }
}
