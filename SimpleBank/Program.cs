﻿using SimpleBank.Entities;

Account acc1 = new Account(1001, "Alex", 500.00);
Account acc2 = new SavingsAccount(1002, "Helena", 500.00, 0.01);

acc1.Withdraw(10);
acc2.Withdraw(10);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);