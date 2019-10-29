namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "Grade", c => c.String(nullable: false));
            AlterColumn("dbo.Enrollments", "AssignedCampus", c => c.String(nullable: false));
            AlterColumn("dbo.Enrollments", "EnrollmentSemster", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Address1", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Address2", c => c.String(nullable: true));
            AlterColumn("dbo.Students", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Zipcode", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "State", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "State", c => c.String());
            AlterColumn("dbo.Students", "Zipcode", c => c.String());
            AlterColumn("dbo.Students", "City", c => c.String());
            AlterColumn("dbo.Students", "Address2", c => c.String());
            AlterColumn("dbo.Students", "Address1", c => c.String());
            AlterColumn("dbo.Enrollments", "EnrollmentSemster", c => c.String());
            AlterColumn("dbo.Enrollments", "AssignedCampus", c => c.String());
            AlterColumn("dbo.Enrollments", "Grade", c => c.String());
        }
    }
}
