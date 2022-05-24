using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CurrencyExchange
{
    public class Currency : DBObject
    {
        [Required] public string Name { get; set; }
        [Required] [MaxLength(3)] [MinLength(3)] public string Symbol { get; set; }
        [Required] public double Price { get; set; }
        public DateTime? Updated { get; set; } // ? - umozliwia Null'e

        public void AddToDB()
        {
            DBCurrency dbCurrency = new DBCurrency(); // baza do ktorej bedzie dodany
            var currencyData = dbCurrency.Currencies.ToList();
            bool currInBase = false;

            Currency newCurr = new Currency();

            newCurr.Name = this.Name;
            newCurr.Symbol = this.Symbol.ToUpper();
            newCurr.Price = this.Price;
            newCurr.Updated = DateTime.Now;

            foreach (Currency existingCurr in currencyData)
            {
                if (existingCurr.Symbol == newCurr.Symbol)
                {
                    currInBase = true;
                }
            }

            if (currInBase)
            {
                MessageBox.Show("Currency already added to Database");
            }
            else
            {
                dbCurrency.Currencies.Add(newCurr);
                dbCurrency.SaveChanges();
                MessageBox.Show("Currency added succesfully");
            }
        }
    }
}
