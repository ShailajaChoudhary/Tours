namespace MetTours.Expense;


[AttributeUsage(AttributeTargets.Method)]
public class DefaultTaxAttribute : Attribute
{
   public float Tax { get; set; }

   public DefaultTaxAttribute(float tax)
   {
      Tax = tax;
   }
}

