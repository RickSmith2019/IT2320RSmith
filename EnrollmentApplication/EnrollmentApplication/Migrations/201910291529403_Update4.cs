namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Zipcode", c => c.String());
            AlterColumn("dbo.Students", "State", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Zipcode", c => c.String(nullable: false));
        }
    }
}
