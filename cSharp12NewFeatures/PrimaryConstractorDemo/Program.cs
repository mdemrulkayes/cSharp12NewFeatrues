//The most common uses for a primary constructor parameter are:

//As an argument to a base() constructor invocation.
//To initialize a member field or property.
//Referencing the constructor parameter in an instance member.

using PrimaryConstructorDemo;

var savingsAcc = new SavingsAccount("1457845894", "Emrul Kayes", 100);
savingsAcc.Deposit();
Console.ReadLine();