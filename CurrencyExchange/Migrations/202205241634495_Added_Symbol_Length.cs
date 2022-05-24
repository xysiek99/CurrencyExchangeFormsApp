namespace CurrencyExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Symbol_Length : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Currencies", "Symbol", c => c.String(nullable: false, maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Currencies", "Symbol", c => c.String(nullable: false));
        }
    }
}
