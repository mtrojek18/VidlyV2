namespace VidlyV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviestoTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) Values('The Hangover',NULL,NULL,1,1)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) Values('Die Hard',NULL,NULL,2,2)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) Values('The Terminator',NULL,NULL,5,2)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) Values('Toy Story',NULL,NULL,0,3)");
            Sql("Insert into Movies (Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) Values('Titanic',NULL,NULL,7,4)");
        }
        
        public override void Down()
        {
        }
    }
}
