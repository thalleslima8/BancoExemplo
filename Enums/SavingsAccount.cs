using System;
using System.Collections.Generic;
using System.Text;

namespace BancoExemplo.Enums {
    class SavingsAccount : Account {
        public double InterestRate { get; private set; }

        public SavingsAccount() {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void updateBalance() {
            Balance += Balance * InterestRate;
        }
    }
}
