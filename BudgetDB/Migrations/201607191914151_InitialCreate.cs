namespace BudgetDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalBudget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BudgetSetDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Outcomes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BudgetId = c.Int(nullable: false),
                        FoodSpendings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransportSpendings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HouseSpendings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BillSpendings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LeasureSpendings = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SpendingsSum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Budgets", t => t.BudgetId, cascadeDelete: true)
                .Index(t => t.BudgetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Outcomes", "BudgetId", "dbo.Budgets");
            DropIndex("dbo.Outcomes", new[] { "BudgetId" });
            DropTable("dbo.Outcomes");
            DropTable("dbo.Budgets");
        }
    }
}
