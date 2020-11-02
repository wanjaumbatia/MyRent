namespace MyRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Counties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Counties");
        }
    }
}
