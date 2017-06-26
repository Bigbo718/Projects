using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class AcceptCoins
    {
        private readonly List<float> _totalamt = new List<float>();
        private double _receivedcoinheight { get; set; }
        private double _receivedcoinweight { get; set; }
        private float _insertedcoin { get; set; }

        public AcceptCoins()
        {
            Console.WriteLine("Insert Coins");
        }


        public void InsertCoin(double CoinHeight, double CoinWeight)
        {
            //Height in milliliter and Weight in grams
            _receivedcoinheight = CoinHeight;
            _receivedcoinweight = CoinWeight;

            if (CoinHeight == 24.26 && CoinWeight == 5.6)
            {
                _insertedcoin = .25f;
            }
            else if (CoinHeight == 21.21 && CoinWeight == 5.0)
            {
                _insertedcoin = .5f;
            }
            else if (CoinHeight == 17.90 && CoinWeight == 2.2)
            {
                _insertedcoin = .10f;
            }
            else
            {
                _insertedcoin = .0f;
                Console.WriteLine("INSERT COIN");
            }
            _totalamt.Add(_insertedcoin);
            Console.WriteLine("Inserted Amout {0}", _totalamt.Sum());
        }
        public double AddTotal()
        {
            double InsertedTotal = _totalamt.Sum();
            return InsertedTotal;
                
        }
        public void ReturnCoins()
        {
            _totalamt.Clear();
            Console.WriteLine("INSERT COINS");
        }


    }
}
