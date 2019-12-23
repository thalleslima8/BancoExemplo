using System;
using System.Collections.Generic;
using System.Text;

namespace BancoExemplo.Enums {
    class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }

        public Account() {
        }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount) {
            if (Balance > amount) {
                Balance = Balance - amount;
            } else {
                Console.WriteLine("Saldo Insuficiente");
            }
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
