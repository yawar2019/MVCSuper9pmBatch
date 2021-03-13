namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "Address");
        }
    }
}
