namespace CurrencyExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Float_to_Double : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Currencies", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Currencies", "Price", c => c.Single(nullable: false));
        }
    }
}
