namespace MetTours.Expense;

public class PremiumTours
{
   [DefaultTax(12.9f)]
   public double CommonDayRent(int days, int noPersons) => 1200 * days * noPersons;
   public double WomenDayRent(int days, int noPersons) => 0.15 * CommonDayRent(days,noPersons);   
}