namespace MetTours.Expense;

public class EconomyTours
{
   public double CommonDayRent(int days, int noPersons) => 500 * days * noPersons;
   public double EmployeeDayRent(int days, int noPersons) => 0.25 * CommonDayRent(days,noPersons);
}
