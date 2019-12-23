using System;
using System.Collections.Generic;
using System.Text;

namespace BancoExemplo.Enums {
    class BusinessAccount : Account {
        public double LoanLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) {
            LoanLimit = loanLimit;
        }

        public BusinessAccount() { }

        public void Loan(double amount) {
            if(amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }

}
