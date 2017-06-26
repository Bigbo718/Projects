using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class SelectProduct
    {
        private List<string> ProductList = new List<string>() { "cola", "candy", "candy", "chips", "chips" };
        private const float _costofchips = .50f;
        private const float _costofcola = 1.00f;
        private const float _costofcandy = .65f;
        private float itemtotal;

        public double Products(float totalamt, string item)
        {
            if (item == "cola")
            {
                itemtotal = _costofcola - totalamt;

                if (itemtotal == 0.00f || itemtotal <= 0.00f)
                {
                    try
                    {
                        ProductList.Remove(item);
                        Console.WriteLine("THANK YOU");
                        Console.WriteLine("CHANGE: {0}", totalamt - _costofcola);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("SOLD OUT");
                    }
                    
                }
                else if (itemtotal >= 0.01f)
                {
                    Console.WriteLine("Price: ${0}", _costofcola);
                    Console.WriteLine("Insert Coin ");
                }
            }
            if (item == "candy")
            {
                itemtotal = _costofcandy - totalamt;

                if (itemtotal == 0.00f || itemtotal <= 0.00f)
                {
                    try
                    {
                        ProductList.Remove(item);
                        Console.WriteLine("THANK YOU");
                        Console.WriteLine("CHANGE: {0}", totalamt - _costofcandy);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("SOLD OUT");
                    }
                }
                else if (itemtotal >= 0.01)
                {
                    Console.WriteLine("Price: ${0}", _costofcandy);
                    Console.WriteLine("Insert Coin ");
                }

            }


            return itemtotal;
        }

    }
}
