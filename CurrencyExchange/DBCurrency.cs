namespace CurrencyExchange
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBCurrency : DbContext
    {
        public DBCurrency()
            : base("name=DBCurrency")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Currency> Currencies { get; set; }
    }
}