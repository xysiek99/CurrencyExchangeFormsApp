using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    public class Currency:DBObject
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double Price { get; set; }
        public DateTime? Updated { get; set; } // ? - umozliwia Null'e

        public void AddToDB()
        {
            DBCurrency dbCurrency = new DBCurrency(); // baza do ktorej bedzie dodany
            Currency newCurr = new Currency();

            newCurr.Name = this.Name;
            newCurr.Symbol = this.Symbol;
            newCurr.Price = this.Price;
            newCurr.Updated = DateTime.Now;

            dbCurrency.Currencies.Add(newCurr);
            dbCurrency.SaveChanges();
        }
    }
}
