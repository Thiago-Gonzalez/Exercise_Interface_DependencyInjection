// See https://aka.ms/new-console-template for more information
using System.Globalization;
using Exercise_Interface_Dependency_Injection.Entities;
using Exercise_Interface_Dependency_Injection.Services;

Console.WriteLine("Enter contract data: ");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: $");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, contractValue);
ContractService contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, months);

Console.WriteLine("Installments: ");
foreach (var installment in contract.Installments)
{
    Console.WriteLine(installment);
}