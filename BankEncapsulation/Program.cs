using BankEncapsulation;
//***EncapsulationExercise***//


BankAccount userAccount = new BankAccount();

Console.WriteLine("hello! Thanks for choosing Bank of Lost Dreams");
Console.WriteLine("How much do you want to deposit?");

var amountToDeposit = double.Parse(Console.ReadLine());
userAccount.Deposit(amountToDeposit);

Console.WriteLine(userAccount.GetBalance());
Console.WriteLine("How much would you like to withdraw?");

var amountToWithdraw = double.Parse(Console.ReadLine());
userAccount.Withdraw(amountToWithdraw);

Console.WriteLine(userAccount.GetBalance());











