namespace CurrencyExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_in_DateTime_property : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Currencies", "Updated", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Currencies", "Updated", c => c.DateTime(nullable: false));
        }
    }
}
