namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "姓");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "姓", newName: "FirstMidName");
        }
    }
}
