namespace VidlyV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumbAvailV2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies set NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
        }
    }
}
