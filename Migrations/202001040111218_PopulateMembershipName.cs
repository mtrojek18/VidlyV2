namespace VidlyV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = 'Pay' where Id = 1");
            Sql("Update MembershipTypes set Name = 'Pay as you Go' where Id = 2");
            Sql("Update MembershipTypes set Name = 'Monthly' where Id = 3");
            Sql("Update MembershipTypes set Name = 'Monthly' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
