using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_activity__5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float bank_balance;
            Console.WriteLine("enter your bank balance");
            bank_balance=Convert.ToSingle(Console.ReadLine());
            if (bank_balance >= 150000)
            {
                float intrest_rate1;
                intrest_rate1 = bank_balance * 8 / 100;
                Console.WriteLine("your Annual intrest rate amount is : " + intrest_rate1);

                float anual_intrest_amount1;
                anual_intrest_amount1 = bank_balance + intrest_rate1;
                Console.WriteLine("Your Annual intrest amount is : " + anual_intrest_amount1);

            }
            else if (bank_balance >= 100000)
            {
                float intrest_rate2;
                intrest_rate2= bank_balance * 5 / 100;
                Console.WriteLine("your intrest rate amount is : "+intrest_rate2);

                float anual_intrest_amount2;
                anual_intrest_amount2 = bank_balance + intrest_rate2;
                Console.WriteLine("Your annual intrest amount is :"+anual_intrest_amount2);
            }
            else if (bank_balance>=50000)
            {
                float intrest_rate3;
                intrest_rate3= bank_balance * 4 / 100;
                Console.WriteLine("Your Intrest rate amount is : "+intrest_rate3);

                float anual_intrest_amount3;
                anual_intrest_amount3 = bank_balance + intrest_rate3;
                Console.WriteLine("You Intrest amount is :" + anual_intrest_amount3);
            }
            else
            {
                float intrest_rate4;
                intrest_rate4 = bank_balance * 4 / 100;
                Console.WriteLine("Your Intrest rate amount is : " + intrest_rate4);

                float anual_intrest_amount4;
                anual_intrest_amount4 = bank_balance + intrest_rate4;
                Console.WriteLine("You Intrest amount is :" + anual_intrest_amount4);
            }
















            Console.ReadKey();

        }
    }
}
