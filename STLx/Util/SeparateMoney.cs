using System;
using System.Collections.Generic;

namespace STL_Auto.Util
{
    public class SeparateMoney
    {
        public Dictionary<string, Int32> Separate(decimal moneyAmount)
        {
            var money = new Dictionary<string, Int32>();
            var amount = Convert.ToInt32(moneyAmount);

            money.Add("500+", (int)amount/500);
            amount %= 500;

            money.Add("100+", (int)amount/100);
            amount %= 100;

            money.Add("50+", (int)amount/50);
            amount %= 50;

            money.Add("10+", (int)amount/10);
            amount %= 10;

            money.Add("5+", (int)amount/5);
            amount %= 5;

            money.Add("1+", (int)amount/1);

            return money;
        }
    }
}
