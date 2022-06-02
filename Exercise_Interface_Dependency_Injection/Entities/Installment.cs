using System.Globalization;

namespace Exercise_Interface_Dependency_Injection.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                + " - $"
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
