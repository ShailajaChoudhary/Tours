using MetTours.Expense;
using System.Reflection;
class Program
{
   static void Main(string[] args)
   {
      Type t = Type.GetType($"MetTours.Expense.{args[0]}Tours,MetTours");

      object obj = Activator.CreateInstance(t);

      MethodInfo m = t.GetMethod($"{args[1]}DayRent");

      DefaultTaxAttribute md = m.GetCustomAttribute<DefaultTaxAttribute>();

      double ans = (double)m.Invoke(obj, [2, 2]);
      float a1=md?.Tax ?? 0;

      Console.WriteLine(a1);
      Console.WriteLine(ans+(double)a1);
      
      
   }

}
