using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //add elements to cart
            PaymentEngine.InitializeProducts();
            //process payments for items in cart
            PaymentEngine.ProcessPayments();
            Console.ReadLine();

        }

       
    }
   
}
