namespace Altkom.BPSC.CSharp.DbServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomer : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Kontrahenci");
            RenameColumn(table: "dbo.Kontrahenci", name: "FirstName", newName: "Imie");
            RenameColumn(table: "dbo.Kontrahenci", name: "LastName", newName: "Nazwisko");
            AlterColumn("dbo.Kontrahenci", "Imie", c => c.String(maxLength: 40));
            AlterColumn("dbo.Kontrahenci", "Nazwisko", c => c.String(maxLength: 40));
            AlterColumn("dbo.Items", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Name", c => c.String());
            AlterColumn("dbo.Kontrahenci", "Nazwisko", c => c.String());
            AlterColumn("dbo.Kontrahenci", "Imie", c => c.String());
            RenameColumn(table: "dbo.Kontrahenci", name: "Nazwisko", newName: "LastName");
            RenameColumn(table: "dbo.Kontrahenci", name: "Imie", newName: "FirstName");
            RenameTable(name: "dbo.Kontrahenci", newName: "Customers");
        }
    }
}
