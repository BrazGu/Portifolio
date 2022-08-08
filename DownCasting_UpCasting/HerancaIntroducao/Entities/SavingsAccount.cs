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
        //=====ATRIBUTOS========================



        //=====CONSTRUTOR=======================
        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        //=====CONSTRUTOR=======================



        //=====MÉTODO===========================
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //=====MÉTODO===========================
    }
}
