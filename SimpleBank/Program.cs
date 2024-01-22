using SimpleBank.Entities;

Account acc = new Account(1001, "Alex", 0.0);
BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.0);

// Upcasting
Account acc1 = bacc;
Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

// Downcasting
BussinessAccount acc4 = (BussinessAccount)acc2;
//BussinessAccount acc4 = acc2 as BussinessAccount;
acc4.Loan(100);