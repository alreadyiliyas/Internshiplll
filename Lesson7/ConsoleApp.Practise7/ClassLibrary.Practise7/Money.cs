using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise7
{
    public class Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public Money ConvertToCurrency(decimal exchangeRate, string targetCurrency)
        {
            if (Currency == targetCurrency)
            {
                return this; // Нет необходимости конвертировать, если валюты совпадают.
            }

            if (exchangeRate <= 0)
            {
                throw new ArgumentException("Неверный курс обмена.");
            }

            decimal convertedAmount = Amount / exchangeRate;
            return new Money(convertedAmount, targetCurrency);
        }

        public static Money operator +(Money money1, Money money2)
        {
            if (money1.Currency != money2.Currency)
            {
                throw new InvalidOperationException("Нельзя складывать деньги в разных валютах.");
            }

            return new Money(money1.Amount + money2.Amount, money1.Currency);
        }

        public static Money operator -(Money money1, Money money2)
        {
            if (money1.Currency != money2.Currency)
            {
                throw new InvalidOperationException("Нельзя вычитать деньги в разных валютах.");
            }

            return new Money(money1.Amount - money2.Amount, money1.Currency);
        }

        public static bool operator ==(Money money1, Money money2)
        {
            if (ReferenceEquals(money1, money2))
            {
                return true;
            }

            if (ReferenceEquals(money1, null) || ReferenceEquals(money2, null))
            {
                return false;
            }

            return money1.Amount == money2.Amount && money1.Currency == money2.Currency;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }
    }
}
