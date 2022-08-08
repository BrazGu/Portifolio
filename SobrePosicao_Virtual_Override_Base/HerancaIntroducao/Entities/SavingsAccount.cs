using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaIntroducao.Entities
{
    class SavingsAccount : Account //herdar TUDO da classe account
    {
        //=====ATRIBUTO=========================
        public double InterestRate { get; set; }
        //=====ATRIBUTO=========================



        //=====CONSTRUTORES=====================
        public SavingsAccount()
        {}
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        //=====CONSTRUTORES=====================



        //=====MÉTODOS==========================
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        
        public override void WithDraw(double amount) //BASE - permite utilizar a mesma regra da Account, e posteriormente alterar o valor
        {//SAQUE                                     //BASE - acessa a superclasse
            base.WithDraw(amount);
            Balance -= 2.0;
        }
        //=====MÉTODOS==========================
    }
}
