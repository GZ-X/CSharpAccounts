using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public enum Currency
    {
        RMB,
        USD,
        EUR
    }

    public class Money
    {
        public double value;
        public Currency currency;

        public Money(double value)
        {
            this.value = value;
            this.currency = Currency.RMB;
        }

        public Money(double value, Currency currency)
        {
            this.value = value;
            this.currency = currency;
        }

        public static Money operator+ (Money amount1, Money amount2)
        {
            var value1 = ToRMB(amount1.value, amount1.currency);
            var value2 = ToRMB(amount2.value, amount2.currency);
            return new Money (value1 + value2,Currency.RMB);
        }

        public static Money operator- (Money amount1, Money amount2)
        {
            var value1 = ToRMB(amount1.value, amount1.currency);
            var value2 = ToRMB(amount2.value, amount2.currency);
            return new Money(value1 - value2, Currency.RMB);
        }

        public static double ToRMB(double value, Currency currency)
        {
            switch (currency)
            {
                case Currency.RMB:
                    return value;
                case Currency.USD:
                    return value * 7;
                case Currency.EUR:
                    return value * 8;
                default:
                    return value;
            }     
        }
    }
}
