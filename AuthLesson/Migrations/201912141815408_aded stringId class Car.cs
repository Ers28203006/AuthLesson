namespace AuthLesson.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adedstringIdclassCar : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Cars");
            AlterColumn("dbo.Cars", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Cars", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Cars");
            AlterColumn("dbo.Cars", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Cars", "Id");
        }
    }
}
