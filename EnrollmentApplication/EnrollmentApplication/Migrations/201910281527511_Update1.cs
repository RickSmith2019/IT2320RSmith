namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "InstructorName", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Courses", "Credits", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Credits", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
            DropColumn("dbo.Courses", "InstructorName");
        }
    }
}
