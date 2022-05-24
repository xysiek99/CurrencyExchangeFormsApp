namespace CurrencyExchange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReqiuredField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Currencies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Currencies", "Symbol", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Currencies", "Symbol", c => c.String());
            AlterColumn("dbo.Currencies", "Name", c => c.String());
        }
    }
}
