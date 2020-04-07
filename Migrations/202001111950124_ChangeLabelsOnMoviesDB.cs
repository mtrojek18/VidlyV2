namespace VidlyV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeLabelsOnMoviesDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
