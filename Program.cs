using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        int SodaMaxStock = 100;
        int SodaRestock = 40;
        int ChipsMaxStock = 40;
        int ChipsRestock = 20;
        int CandyMaxStock = 60;
        int CandyRestock = 40;

        Console.WriteLine("Welcome to the restocking tool. ");

        // Sodas //

        Console.WriteLine("How many Sodas have been sold today? " + SodaMaxStock + " are in stock");
        int SodasPurchased = int.Parse(Console.ReadLine());

        if (SodaMaxStock - SodasPurchased < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
            SodasPurchased = 0;
        }
        else
        {
            Console.WriteLine("There are " + (SodaMaxStock - SodasPurchased) + " sodas left.");
        };

        // Chips //

        Console.WriteLine("How many Chips have been sold today? " + ChipsMaxStock + " are in stock");
        int ChipsPurchased = int.Parse(Console.ReadLine());

        if (ChipsMaxStock - ChipsPurchased < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
            ChipsPurchased = 0;
        }
        else
        {
            Console.WriteLine("There are " + (ChipsMaxStock - ChipsPurchased) + " chips left.");
        };

        // Candy //

        Console.WriteLine("How much Candy has been sold today? " + CandyMaxStock + " are in stock");
        int CandyPurchased = int.Parse(Console.ReadLine());

        if (CandyMaxStock - CandyPurchased < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted");
            CandyPurchased = 0;
        }
        else
        {
            Console.WriteLine("There are " + (CandyMaxStock - CandyPurchased) + " candy left.");
        }

 /* Restocking Lines */

        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

        //Soda Restocking//

        if (SodaMaxStock - SodasPurchased <= SodaRestock)
        {
            Console.WriteLine("Sodas need to be restocked");
        };

        //Chips Restocking//

        if (ChipsMaxStock - ChipsPurchased <= ChipsRestock)
            {
                Console.WriteLine("Chips need to be restocked");
            };

        //Candy Restocking//

        if (CandyMaxStock - CandyPurchased <= CandyRestock)
            {
                Console.WriteLine("Candy need to be restocked");
            };

     
    }
}