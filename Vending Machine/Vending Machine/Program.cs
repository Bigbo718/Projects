using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {

        static void Main(string[] args)
        {
            //height and weight for coins
            // Quarter = 24.26 & 5.6
            // Nickel = 21.21 & 5.0
            // Dime = 17.90 & 2.2

            //var Coin = new AcceptCoins();
            var selecteditem = new SelectProduct();
            var insertcoin = new AcceptCoins();

            try
            {
                while (true)
                {
                    double coinheight = Convert.ToDouble(Console.ReadLine());
                    if (coinheight == 0)
                    {
                        break;
                    }
                    else
                    {
                        double coinweight = Convert.ToDouble(Console.ReadLine());
                        insertcoin.InsertCoin(coinheight, coinweight);
                    }
                }
                Console.WriteLine("Please Select a Item: Cola, Candy, or Chips");
                var iteminput = Console.ReadLine().ToLower();
                selecteditem.Products((float)insertcoin.AddTotal(), iteminput);


            }
            catch (Exception)
            {

               insertcoin.ReturnCoins();
            }


        }
    }
}
