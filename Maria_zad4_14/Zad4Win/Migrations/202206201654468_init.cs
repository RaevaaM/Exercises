namespace Zad4Win.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Discription = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.DishTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "TypeId", "dbo.DishTypes");
            DropIndex("dbo.Dishes", new[] { "TypeId" });
            DropTable("dbo.DishTypes");
            DropTable("dbo.Dishes");
        }
    }
}
