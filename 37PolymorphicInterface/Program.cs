namespace _37PolymorphicInterface;

/*
Polymorphic Interface:
When we need Different classes to impliment the same set of methods and properties.
This Ensures consistency and allows and allows for flexible implimentations.a

Reasons for using Polymorphic Interface:
Different classes can Implement the same interface in various ways allowing for diverse 
behavior while maintaining a common contract.a

When to use it:
Use interfaces when you have multiple classes that should provide the same functionality
but might implement it differently.
for ex: Payment systems in banks
*/

public interface IPaymentProcessor
{
    void ProcessPayment(float amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(float amount)
    {
        System.Console.WriteLine($"Processing Credit Card payment of the amount: {amount} ");

    }
}

public class PaypalProcessor : IPaymentProcessor
{
    public void ProcessPayment(float amount)
    {
        System.Console.WriteLine($"Processing Paypal Payment of the amount: {amount}");
    }
}
/* 
Const:
In C#, a const keyword is used to declare constant fields and constant local. 
The value of the constant field is the same throughout the program or 
in other words, once the constant field is assigned the value of this field is not be changed. 
In C#, constant fields and locals are not variables, 
a constant is a number, string, null reference, boolean values.

ReadOnly:
In C#, you can use a readonly keyword to declare a readonly variable. 
This readonly keyword shows that you can assign the variable 
only when you declare a variable or in a constructor of the same class in which it is declared.
*/
public class PaymentService
{
    //here we created a readonly IPaymentProcessor instance named _processor
    public readonly IPaymentProcessor _processor;
    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }
    public void ProcessOrderPayment(float amount)
    {
        _processor.ProcessPayment(amount);
    }
} 

class Program
{
    static void Main(string[] args)
    {
        IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
        PaymentService paymentService = new PaymentService(creditCardProcessor);
        paymentService.ProcessOrderPayment(100.0f);
        

        IPaymentProcessor paypalProcessor = new PaypalProcessor();
        paymentService = new PaymentService(paypalProcessor);
        paymentService.ProcessOrderPayment(200.00f);       

    }

}       
