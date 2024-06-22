using System;
using System.Runtime.CompilerServices;
namespace CSharp6;

public class CreditCard
{
    private string cardNumber;
    public string CardNumber
    {
        get { return cardNumber; }
        set
        {
            if (value.Length == 16) 
                cardNumber = value;
            else 
                throw new Exception("Incorrect card number!");
        }
    }
    private string cvc;
    public string Cvc
    {
        get { return cvc; }
        set
        {
            if (value.Length == 3) 
                cvc = value;
            else 
                throw new Exception("Incorrect cvv!");
        }
    }
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value)) 
                name = value;
            else 
                throw new Exception("Error! Name is empty.");
        }
    }
    private DateTime data;
    public DateTime Data
    {
        get { return data; }
        set
        {
            if (value > DateTime.Now) 
                data = value;
            else 
                throw new Exception("Incorrect data!");
        }
    }

    public CreditCard(string cardNumber, string cvc, string name, DateTime date)
    {
        this.CardNumber = cardNumber; 
        this.Cvc = cvc;
        this.Name = name;
        this.Data = date;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        //1
        //Console.WriteLine("Enter a string of digits: ");
        //string input = Console.ReadLine();

        //try
        //{
        //    int number = Convert.ToInt32(input);
        //    Console.WriteLine("Integer number: " + number);
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Input string was not in a correct format.");
        //}
        //catch (OverflowException)
        //{
        //    Console.WriteLine("The input number is outside the range of an int.");
        //}
        //finally
        //{
        //    Console.WriteLine("End of the program.");
        //}

        //2
    }
}
